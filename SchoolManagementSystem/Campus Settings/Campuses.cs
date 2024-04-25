using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Campuses : Sample2
    {
        int edit = 0, CampusID;
        
        Regex rgMail = new Regex("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
        Regex rgPhone = new Regex("^[0-9]*$");

        private void Campuses_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbCampusManagement cm = new SchoolManagementSystem.dbCampusManagement();
            MainClass.ShowWindow(cm, this, MDI.ActiveForm);
        }

        public Campuses()
        {
            InitializeComponent();
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
        private void txtCampusName_TextChanged(object sender, EventArgs e)
        {
            if (txtCampusName.Text == "") { errCampusName.Visible = true; } else { errCampusName.Visible = false; }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "") { errAddress.Visible = true; } else { errAddress.Visible = false; }
        }

        private void txtPhone1_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone1.Text == "") { errPhone1.Visible = true; } else { errCampusName.Visible = false; }
           
        }

        private void txtPhone1_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone1.TextLength != 10)
            {
                txtPhone1.Focus();
                MainClass.ShowMsg("A Phone number must have 10 digits!", "Error", "Error");
                txtPhone1.SelectAll();
            }
            if (txtPhone1.Text != "")
            {
                if (!rgPhone.Match(txtPhone1.Text).Success)
                {
                    txtPhone1.Focus();
                    MainClass.ShowMsg("Invalid!\n\nType in this format 3001234567", "Error", "Error");
                    txtPhone1.SelectAll();
                }
            }
        }

        private void txtPhone2_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone2.Text != "")
            {
                if (txtPhone2.TextLength != 10)
                {
                    txtPhone2.Focus();
                    MainClass.ShowMsg("A Phone number must have 10 digits!", "Error", "Error");
                    txtPhone2.SelectAll();
                }
                if (!rgPhone.Match(txtPhone2.Text).Success)
                {
                    txtPhone2.Focus();
                    MainClass.ShowMsg("Invalid!\n\nType in this format 3001234567", "Error", "Error");
                    txtPhone2.SelectAll();
                }
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text != "")
            {
                if (!rgMail.Match(txtEmail.Text).Success)
                {
                    txtEmail.Focus();
                    MainClass.ShowMsg("Invalid!\n\nType in this format abc@example.com", "Error", "Error");
                    txtEmail.SelectAll();
                }
            }
        }

        private void ddStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCampusName.Text == "") { errCampusName.Visible = true; } else { errCampusName.Visible = false; }
            if (txtAddress.Text == "") { errAddress.Visible = true; } else { errAddress.Visible = false; }
            if (txtPhone1.Text == "") { errPhone1.Visible = true; } else { errPhone1.Visible = false; }
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
            if (errCampusName.Visible || errAddress.Visible || errPhone1.Visible || errStatus.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stoped..", "Error");
            }
            else
            {
                if (edit == 0)//code for save operation
                {
                        byte Stat = Convert.ToByte(ddStatus.SelectedIndex == 0 ? 1 : 0);
                        clsInsertion.AddCampuses(txtCampusName.Text, txtAddress.Text, txtPhone1.Text, txtPhone2.Text, txtEmail.Text, Stat);
                        MainClass.DisableReset(pnlDetails);
                        LoadData();
                    
                }
                else if (edit == 1)//code for update operation
                {
                        byte Stat = Convert.ToByte(ddStatus.SelectedIndex == 0 ? 1 : 0);
                    clsUpdation.UpdateCampuses(CampusID, txtCampusName.Text, txtAddress.Text, txtPhone1.Text, txtPhone2.Text, txtEmail.Text, Stat);
                        MainClass.DisableReset(pnlDetails);
                        LoadData();
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtCampusName.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.Delete(CampusID, "stp_DeleteCampuses", "@campID");
                    LoadData();
                    MainClass.DisableReset(pnlDetails);
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
            clsSelection.SelectCampuses(dataGridView1, gvCampID, gvCampus, gvAddress, gvPhone1, gvPhone2, gvEmail, gvStatus);
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        private void SearchData()
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectCampuses(dataGridView1, gvCampID, gvCampus, gvAddress, gvPhone1, gvPhone2, gvEmail, gvStatus,txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                clsSelection.SelectCampuses(dataGridView1, gvCampID, gvCampus, gvAddress, gvPhone1, gvPhone2, gvEmail, gvStatus);
                MainClass.SNO(dataGridView1, "gvSNO");
            }
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1 && e.ColumnIndex!=-1)
            {
                edit = 1;
                MainClass.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                CampusID = Convert.ToInt32(row.Cells["gvCampID"].Value.ToString());
                txtCampusName.Text = row.Cells["gvCampus"].Value.ToString();
                txtAddress.Text = row.Cells["gvAddress"].Value.ToString();
                txtPhone1.Text = row.Cells["gvPhone1"].Value.ToString();
                txtPhone2.Text = row.Cells["gvPhone2"].Value.ToString();
                txtEmail.Text = row.Cells["gvEmail"].Value.ToString();
                ddStatus.SelectedItem = row.Cells["gvStatus"].Value.ToString();
            }
        }

    }
}
