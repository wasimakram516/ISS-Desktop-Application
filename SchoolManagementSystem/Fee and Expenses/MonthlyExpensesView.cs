using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ISS
{
    public partial class MonthlyExpensesView : Sample2
    {
        public MonthlyExpensesView()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            MonthlyExpenses ob = new MonthlyExpenses();
            MainClass.ShowWindow(ob, this, MDI.ActiveForm);
        }

        int edit = 0;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        private int check1;
        private int check2;
        Int64 ExpenseID = 0;


        private void MonthlyExpensesView_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtDate.Value.Date > DateTime.Now.Date) { errDate.Visible = true; } else { errDate.Visible = false; }
        }

        private void ddExpenseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddExpenseType.SelectedIndex == -1) { errExpenseType.Visible = true; } else { errExpenseType.Visible = false; }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (txtDescription.Text == "") { errDescription.Visible = true; } else { errDescription.Visible = false; }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text == "") { errAmount.Visible = true; }
            else
            {
                errAmount.Visible = false;

                if (!rg.Match(txtAmount.Text).Success)
                {
                    txtAmount.Focus();
                    txtAmount.Text = "";
                }
            }
        }

        private void txtReceiptNo_TextChanged(object sender, EventArgs e)
        {
            if (txtReceiptNo.Text != "")
            {
                if (!rg.Match(txtReceiptNo.Text).Success)
                {
                    txtReceiptNo.Focus();
                    txtReceiptNo.Text = "";
                }
            }
        }


        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.EnableReset(pnlDetails);
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(pnlDetails);
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (dtDate.Value.Date > DateTime.Now.Date) { errDate.Visible = true; } else { errDate.Visible = false; }
            if (ddExpenseType.SelectedIndex == -1) { errExpenseType.Visible = true; } else { errExpenseType.Visible = false; }
            if (txtDescription.Text == "") { errDescription.Visible = true; } else { errDescription.Visible = false; }
            if (txtAmount.Text == "") { errAmount.Visible = true; } else { errAmount.Visible = false; }
            if (errDate.Visible)
            {
                MainClass.ShowMsg("Invalid Date!", "Error", "Error");
            }

            if (errExpenseType.Visible || errDescription.Visible || errAmount.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }

            else
            {
                if (edit == 1)
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        check1 = clsUpdation.UpdateExpenses(ExpenseID, dtDate.Value.Month, dtDate.Value.Year, dtDate.Value, ddExpenseType.Text,
                                txtDescription.Text, Convert.ToSingle(txtAmount.Text), txtReceiptName.Text, txtReceiptNo.Text);

                        if (check1 > 0)
                        {
                            MainClass.ShowMsg("Expense Details updated successfully!", "Success", "Success");
                            LoadData();
                            MainClass.DisableReset(pnlDetails);
                        }

                        else
                        {
                            MainClass.ShowMsg("Unable to update.\nContact your system administrator for more details.", "Error", "Error");
                        }
                    }
                    else
                    {
                        MainClass.ShowMsg("PLease, enter at least 1 expenditure detail to continue..", "Error", "Error");
                    }
                }

                else
                {
                    MainClass.ShowMsg("Press the edit button to update the record.", "Information", "Success");
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + ddExpenseType.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.Delete(ExpenseID, "stp_DeleteExpenses", "@ExpenseID");
                    MainClass.DisableReset(pnlDetails);
                    LoadData();
                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            MainClass.ShowMsg("Please, Press the Load button to continue...", "Information", "Success");
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                clsSelection.SelectExpenses(dataGridView1, gvExpenseID, gvDate, gvExpenseType, gvDescription, gvAmount, gvReceiptName, gvReceiptNo, dtMonthYear.Value.Month, dtMonthYear.Value.Year, MainClass.CAMPUSID, txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            clsSelection.SelectExpenses(dataGridView1, gvExpenseID, gvDate, gvExpenseType, gvDescription, gvAmount, gvReceiptName, gvReceiptNo, dtMonthYear.Value.Month, dtMonthYear.Value.Year, MainClass.CAMPUSID);
            MainClass.SNO(dataGridView1, "gvSNO");
            float total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToSingle(row.Cells["gvAmount"].Value);
            }
            lblTotal.Text = "Rs. " + total.ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ExpenseID = Convert.ToInt64(row.Cells["gvExpenseID"].Value);
                dtDate.Value = Convert.ToDateTime(row.Cells["gvDate"].Value.ToString());
                ddExpenseType.SelectedItem = row.Cells["gvExpenseType"].Value.ToString();
                txtDescription.Text = row.Cells["gvDescription"].Value.ToString();
                txtAmount.Text = row.Cells["gvAmount"].Value.ToString();
                txtReceiptName.Text = row.Cells["gvReceiptName"].Value.ToString();
                txtReceiptNo.Text = row.Cells["gvReceiptNo"].Value.ToString();

            }
        }
    }
}
