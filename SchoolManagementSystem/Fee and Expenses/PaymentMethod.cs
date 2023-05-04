using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISS
{
    public partial class PaymentMethod : Sample2
    {
        
        int edit = 0;
        int BankID;

        public PaymentMethod()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbFeeManagement stm = new ISS.dbFeeManagement();
            MainClass.ShowWindow(stm, this, MDI.ActiveForm);
        }

        private void PaymentMethod_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
        }

        private void txtBank_TextChanged(object sender, EventArgs e)
        {
            if (txtBank.Text == "") { errBank.Visible = true; } else { errBank.Visible = false; }
        }

        private void txtBranch_TextChanged(object sender, EventArgs e)
        {
            if (txtBranch.Text == "") { errbranch.Visible = true; } else { errbranch.Visible = false; }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "") { errAddress.Visible = true; } else { errAddress.Visible = false; }
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            if (txtAccount.Text == "") { errAccount.Visible = true; } else { errAccount.Visible = false; }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.EnableReset(pnlDetails);
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(pnlDetails);
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBank.Text == "") { errBank.Visible = true; } else { errBank.Visible = false; }
            if (txtBranch.Text == "") { errbranch.Visible = true; } else { errbranch.Visible = false; }
            if (txtAddress.Text == "") { errAddress.Visible = true; } else { errAddress.Visible = false; }
            if (txtAccount.Text == "") { errAccount.Visible = true; } else { errAccount.Visible = false; }
            if (errBank.Visible || errbranch.Visible || errAddress.Visible || errAccount.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {

                if (edit == 0)//code for save operation
                {
                    clsInsertion.AddPaymentMethods(txtBank.Text, txtBranch.Text, txtAddress.Text, txtAccount.Text);
                    LoadData();
                }
                else if (edit == 1)//code for update operation
                {
                    clsUpdation.UpdatePaymentMethods(BankID, txtBank.Text, txtBranch.Text, txtAddress.Text, txtAccount.Text);
                    LoadData();
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtBank.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                        clsDeletion.Delete(BankID, "stp_DeletePaymentMethods", "@BankID");
                        LoadData();
                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void LoadData()
        {
            clsSelection.SelectPaymentMethods(dataGridView1, gvBankID, gvBank, gvBranch, gvAddress, gvAccount);
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        private void SearchData()
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectPaymentMethods(dataGridView1, gvBankID, gvBank, gvBranch, gvAddress, gvAccount,txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                edit = 1;
                MainClass.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                BankID = Convert.ToInt32(row.Cells["gvBankID"].Value.ToString());
                txtBank.Text = row.Cells["gvBank"].Value.ToString();
                txtBranch.Text = row.Cells["gvBranch"].Value.ToString();
                txtAddress.Text = row.Cells["gvAddress"].Value.ToString();
                txtAccount.Text = row.Cells["gvAccount"].Value.ToString();
            }
        }
    }
}
