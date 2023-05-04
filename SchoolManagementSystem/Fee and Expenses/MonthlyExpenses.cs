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
    public partial class MonthlyExpenses : Sample2
    {
        public MonthlyExpenses()
        {
            InitializeComponent();
        }
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        private int check;

        private void MonthlyExpenses_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbExpenditures obj = new ISS.dbExpenditures();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtDate.Value.Date > DateTime.Now.Date) { errDate.Visible = true; } else { errDate.Visible = false; }
        }

        private void ddExamType_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnAddToList_Click(object sender, EventArgs e)
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
                dataGridView1.Rows.Add(1, dtDate.Value, ddExpenseType.Text, txtDescription.Text, txtAmount.Text, txtReceiptName.Text, txtReceiptNo.Text);
                MainClass.SNO(dataGridView1, "gvSNO");
                ddExpenseType.SelectedIndex = -1;
                txtDescription.Text = "";
                txtAmount.Text = "";
                txtReceiptName.Text = "";
                txtReceiptNo.Text = "";
                ddExpenseType.Focus();
            }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.EnableReset(pnlDetails);
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (dtDate.Value.Date > DateTime.Now.Date) { errDate.Visible = true; } else { errDate.Visible = false; }

            if (errDate.Visible)
            {
                MainClass.ShowMsg("Invalid Date!", "Error", "Error");
            }

            else
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        check = clsInsertion.AddExpenses(MainClass.CAMPUSID, Convert.ToDateTime(row.Cells["gvDate"].Value).Month, Convert.ToDateTime(row.Cells["gvDate"].Value).Year,
                            Convert.ToDateTime(row.Cells["gvDate"].Value), row.Cells["gvExpenseType"].Value.ToString(), row.Cells["gvDescription"].Value.ToString(),
                            Convert.ToSingle(row.Cells["gvAmount"].Value), row.Cells["gvReceiptName"].Value.ToString(), row.Cells["gvReceiptNo"].Value.ToString());
                    }

                    if (check > 0)
                    {
                        MainClass.ShowMsg(dataGridView1.Rows.Count + " Expense Details added successfully!", "Success", "Success");
                        dataGridView1.Rows.Clear();
                        MainClass.DisableReset(pnlDetails);
                    }

                    else
                    {
                        MainClass.ShowMsg("Unable to add.\nContact your system administrator for more details.", "Error", "Error");
                    }
                }
                else
                {
                    MainClass.ShowMsg("PLease, enter at least 1 expenditure detail to continue..", "Error", "Error");
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            MainClass.ShowMsg("Press View Button and then load records to delete any details.", "Information", "Success");
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            MonthlyExpensesView obj = new ISS.MonthlyExpensesView();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MainClass.ShowMsg("Press View Button and then load records to search any details.", "Information", "Success");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int ck = e.ColumnIndex;
                if (e.ColumnIndex == 7)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    dataGridView1.Rows.Remove(row);
                    MainClass.SNO(dataGridView1, "gvSNO");
                }
            }
        }
    }
}
