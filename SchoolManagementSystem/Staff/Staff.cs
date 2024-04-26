using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Staff : Sample2
    {
        Image img;
        int edit = 0, staffID;
        
        Regex rgMail = new Regex("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
        Regex rgPhone = new Regex("^[0-9]*$");
        Regex rgNumber = new Regex("^[0-9]*$");
        Regex rgCNIC = new Regex("^(\\d{5}-\\d{7}-\\d)$");
        public Staff()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbStaffManagement stm = new SchoolManagementSystem.dbStaffManagement();
            MainClass.ShowWindow(stm, this, MDI.ActiveForm);
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
            MainClass.GetDropdownList("stp_SelectCampuses", ddCampus, "Name", "CampID");
        }

        private void ddCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddCampus.SelectedIndex < 1) { errCampus.Visible = true; } else { errCampus.Visible = false; }
        }

        private void txtPriority_TextChanged(object sender, EventArgs e)
        {
            if (txtPriority.Text == "") { errPriority.Visible = true; } else { errPriority.Visible = false; }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "") { errName.Visible = true; } else { errName.Visible = false; }

        }

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtCNIC.Text == "") { errCNIC.Visible = true; } else { errCNIC.Visible = false; }

        }


        private void txtCNIC_Validating(object sender, CancelEventArgs e)
        {
            if (txtCNIC.Text != "")
            {
                if (!rgCNIC.Match(txtCNIC.Text).Success)
                {
                    txtCNIC.SelectAll();
                    txtCNIC.Focus();
                    MainClass.ShowMsg("Invalid Format!\n\nWrite in this format 12345-1234567-1", "Error", "Errror");
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") { errUserName.Visible = true; } else { errUserName.Visible = false; }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") { errPassword.Visible = true; } else { errPassword.Visible = false; }

        }

        private void txtConfrmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfrmPassword.Text == "") { errCnfrmPass.Visible = true; } else { errCnfrmPass.Visible = false; }

        }

        private void txtPhone1_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone1.Text == "") { errPhone1.Visible = true; } else { errPhone1.Visible = false; }

        }

        private void txtPhone2_TextChanged(object sender, EventArgs e)
        {


        }

        private void ddRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddRole.SelectedIndex == -1) { errrole.Visible = true; } else { errrole.Visible = false; }

        }

        private void ddStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }

        }

        private void txtConfrmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text != txtConfrmPassword.Text) { MainClass.ShowMsg("Password & Confirm Password don't match!", "Don't match", "Error"); }

        }

        private void txtSalery_TextChanged(object sender, EventArgs e)
        {
            if (txtSalery.Text == "") { errSalery.Visible = true; } else { errSalery.Visible = false; }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string FileExtension = System.IO.Path.GetExtension(openFileDialog1.FileName);
                if (FileExtension.ToLower() != ".jpg" && FileExtension.ToLower() != ".jpeg")
                {
                    MainClass.ShowMsg("Only .jpg and .jpeg images are allowed!", "Error", "Error");
                }
                else
                {
                    img = new Bitmap(openFileDialog1.FileName);
                    pictureBox1.Image = img;
                    txtImage.Text = openFileDialog1.FileName;
                }

            }
        }


        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.EnableReset(pnlDetails);
            MainClass.GetDropdownList("stp_SelectCampuses", ddCampus, "Name", "CampID");
            txtName.Focus();
            txtImage.Enabled = false;
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(pnlDetails);
            txtImage.Enabled = false;
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ddCampus.SelectedIndex < 1) { errCampus.Visible = true; } else { errCampus.Visible = false; }
            if (txtPriority.Text == "") { errPriority.Visible = true; } else { errPriority.Visible = false; }
            if (txtName.Text == "") { errName.Visible = true; } else { errName.Visible = false; }
            if (txtCNIC.Text == "") { errCNIC.Visible = true; } else { errCNIC.Visible = false; }
            if (txtUsername.Text == "") { errUserName.Visible = true; } else { errUserName.Visible = false; }
            if (txtPassword.Text == "") { errPassword.Visible = true; } else { errPassword.Visible = false; }
            if (txtConfrmPassword.Text == "") { errCnfrmPass.Visible = true; } else { errCnfrmPass.Visible = false; }
            if (txtPhone1.Text == "") { errPhone1.Visible = true; } else { errPhone1.Visible = false; }
            if (ddRole.SelectedIndex == -1) { errrole.Visible = true; } else { errrole.Visible = false; }
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
            if (txtSalery.Text == "") { errSalery.Visible = true; } else { errSalery.Visible = false; }

            if (txtPassword.Text != txtConfrmPassword.Text) { MainClass.ShowMsg("Password & Confirm Password don't match!", "Don't match", "Error"); }

            if (errCampus.Visible|| errPriority.Visible || errSalery.Visible || errName.Visible || errCNIC.Visible || errUserName.Visible || errPassword.Visible || errCnfrmPass.Visible || errPhone1.Visible || errrole.Visible || errStatus.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stoped..", "Error");
            }
            else
            {

                byte Stat = Convert.ToByte(ddStatus.SelectedIndex == 0 ? 1 : 0);
                byte gender = Convert.ToByte(ddGender.SelectedIndex == 0 ? 1 : 0);

                if (edit == 0)//code for save operation
                {
                    if (txtImage.Text == "")
                    {
                        clsInsertion.AddStaffWithoutImage(Convert.ToInt32(ddCampus.SelectedValue),Convert.ToInt32( txtPriority.Text), txtCNIC.Text, txtName.Text, txtUsername.Text, txtPassword.Text, txtPhone1.Text, txtPhone2.Text, Convert.ToString(ddRole.SelectedItem), ddScale.SelectedItem.ToString(), gender, Stat, dtJoinDate.Value, dtLeftDate.Value, Convert.ToSingle(txtSalery.Text));
                        MainClass.DisableReset(pnlDetails);
                        LoadData();

                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream();
                        img.Save(ms, ImageFormat.Jpeg);
                        byte[] arr = ms.ToArray();
                        clsInsertion.AddStaff(Convert.ToInt32(ddCampus.SelectedValue), Convert.ToInt32(txtPriority.Text), txtCNIC.Text, txtName.Text, txtUsername.Text, txtPassword.Text, txtPhone1.Text, txtPhone2.Text, Convert.ToString(ddRole.SelectedItem), ddScale.SelectedItem.ToString(), gender, Stat, dtJoinDate.Value, dtLeftDate.Value, Convert.ToSingle(txtSalery.Text), arr);
                        MainClass.DisableReset(pnlDetails);
                        LoadData();
                    }
                }
                else if (edit == 1)//code for update operation
                {
                    if (txtImage.Text == "")
                    {
                        clsUpdation.UpdateStaffWithoutImage(staffID, MainClass.CAMPUSID,Convert.ToInt32(txtPriority.Text), txtCNIC.Text, txtName.Text, txtUsername.Text, txtPassword.Text, txtPhone1.Text, txtPhone2.Text, Convert.ToString(ddRole.SelectedItem), ddScale.SelectedItem.ToString(), gender, Stat, dtJoinDate.Value, dtLeftDate.Value, Convert.ToSingle(txtSalery.Text));
                        MainClass.DisableReset(pnlDetails);
                        LoadData();
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream();
                        img.Save(ms, ImageFormat.Jpeg);
                        byte[] arr = ms.ToArray();

                        clsUpdation.UpdateStaff(staffID, MainClass.CAMPUSID, Convert.ToInt32(txtPriority.Text), txtCNIC.Text, txtName.Text, txtUsername.Text, txtPassword.Text, txtPhone1.Text, txtPhone2.Text, Convert.ToString(ddRole.SelectedItem), ddScale.SelectedItem.ToString(), gender, Stat, dtJoinDate.Value, dtLeftDate.Value, Convert.ToSingle(txtSalery.Text), arr);
                        MainClass.DisableReset(pnlDetails);
                        LoadData();
                    }
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtName.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                        clsDeletion.Delete(staffID, "stp_DeleteStaff", "@StaffID");
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
            clsSelection.SelectStaff(dataGridView1,gvPriority, gvStaffID, gvName, gvCNIC, gvCampID, gvCampus, gvUsername, gvPassword, gvPhone1, gvPhone2, gvRole, gvScale, gvGender, gvStatus, gvJoinDate, gvLeftDate, gvsalery);
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        private void SearchData()
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectStaff(dataGridView1,gvPriority, gvStaffID, gvName, gvCNIC, gvCampID, gvCampus, gvUsername, gvPassword, gvPhone1, gvPhone2, gvRole, gvScale, gvGender, gvStatus, gvJoinDate, gvLeftDate, gvsalery,txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                LoadData();
            }
        }

        private void txtPhone1_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone1.Text != "")
            {
                if (txtPhone1.TextLength != 10)
                {
                    txtPhone1.SelectAll();
                    txtPhone1.Focus();
                    MainClass.ShowMsg("A Phone number must have 10 digits!", "Error", "Error");
                }
                if (!rgPhone.Match(txtPhone1.Text).Success)
                {
                    txtPhone1.SelectAll();
                    txtPhone1.Focus();
                    MainClass.ShowMsg("Invalid!\n\nType in this format 3001234567", "Error", "Error");

                }
            }
        }

        private void txtPhone2_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone2.Text != "")
            {
                if (txtPhone2.TextLength != 10)
                {
                    txtPhone2.SelectAll();
                    txtPhone2.Focus();
                    MainClass.ShowMsg("A Phone number must have 10 digits!", "Error", "Error");
                }
                if (!rgPhone.Match(txtPhone2.Text).Success)
                {
                    txtPhone2.SelectAll();
                    txtPhone2.Focus();
                    MainClass.ShowMsg("Invalid!\n\nType in this format 3001234567", "Error", "Error");
                }
            }
        }

        private void pnlDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPriority_Validating(object sender, CancelEventArgs e)
        {
            if (txtPriority.Text != "")
            {
                if (!rgPhone.Match(txtPriority.Text).Success)
                {
                    txtPriority.SelectAll();
                    txtPriority.Focus();
                    MainClass.ShowMsg("Invalid!\n\nWrite a number.", "Error", "Error");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                edit = 1;
                MainClass.Disable(pnlDetails);
                pictureBox1.Image = null;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtPriority.Text= row.Cells["gvPriority"].Value.ToString();
                staffID = Convert.ToInt32(row.Cells["gvStaffID"].Value.ToString());
                ddCampus.SelectedValue = Convert.ToInt32(row.Cells["gvCampID"].Value.ToString());
                txtName.Text = row.Cells["gvName"].Value.ToString();
                txtCNIC.Text = row.Cells["gvCNIC"].Value.ToString();
                txtUsername.Text = row.Cells["gvUsername"].Value.ToString();
                txtPassword.Text = row.Cells["gvPassword"].Value.ToString();
                txtConfrmPassword.Text = row.Cells["gvPassword"].Value.ToString();
                txtPhone1.Text = row.Cells["gvPhone1"].Value.ToString();
                txtPhone2.Text = row.Cells["gvPhone2"].Value.ToString();
                ddRole.SelectedItem = row.Cells["gvRole"].Value.ToString();
                ddScale.SelectedItem = row.Cells["gvScale"].Value.ToString();
                ddGender.SelectedItem = row.Cells["gvGender"].Value.ToString();
                ddStatus.SelectedItem = row.Cells["gvStatus"].Value.ToString();
                dtJoinDate.Value = Convert.ToDateTime(row.Cells["gvJoinDate"].Value.ToString());
                if (ddStatus.SelectedIndex == 0)
                {
                    dtLeftDate.Value = DateTime.Now;
                }
                else
                {
                    dtLeftDate.Value = Convert.ToDateTime(row.Cells["gvLeftDate"].Value.ToString());
                }
                txtSalery.Text = row.Cells["gvsalery"].Value.ToString();
                
                //var i = (from x in obj.tblStaffs where x.StaffID == staffID select x.Image).First();
                //if (i != null)
                //{
                //    byte[] arr =i.ToArray();
                //    MemoryStream ms = new MemoryStream(arr);
                //    img = Image.FromStream(ms);
                //    pictureBox1.Image = img;
                //}

                try
                {
                    SqlCommand com = new SqlCommand("stp_SelectImageFromStaff", MainClass.con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@StaffID", staffID);
                    MainClass.con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            byte[] arr = (byte[])(dr["Image"]);
                            if (arr==null)
                            {
                                pictureBox1.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(arr);
                                img = Image.FromStream(ms);
                                pictureBox1.Image = img;
                            }
                            
                        }
                    }

                    MainClass.con.Close();
                }
                catch (Exception x)
                {
                    MainClass.con.Close();
                    //MainClass.ShowMsg(x.Message, "Error", "Error");
                    pictureBox1.Image = null;
                }
            }
        }
    }
}
