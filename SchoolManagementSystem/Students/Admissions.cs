using CrystalDecisions.CrystalReports.Engine;
using ISS.Properties;
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
using System.Transactions;
using System.Windows.Forms;

namespace ISS
{
    public partial class Admissions : Sample2
    {

        Image img;
        int edit = 0;
        Int64 RegNo;
        
        Regex rgMail = new Regex("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
        //Regex rgPhone = new Regex("^(\\d{4}-\\d{7})$");             0300-1234567
        Regex rgPhone = new Regex("^[0-9]*$");                  //    3001234567
        Regex rgCNIC = new Regex("^(\\d{5}-\\d{7}-\\d)$");
        ReportDocument rd;
        private int CheckLeftStudent;

        public Admissions()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbStudemtManagement stm = new ISS.dbStudemtManagement();
            MainClass.ShowWindow(stm, this, MDI.ActiveForm);
        }


        private void Admissions_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            MainClass.DisableReset(pnlDetails);
            LoadList();
        }


        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "") { errStudentName.Visible = true; } else { errStudentName.Visible = false; }
        }

        private void ddGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddGender.SelectedIndex == -1) { errGender.Visible = true; } else { errGender.Visible = false; }
        }

        private void txtFatherName_TextChanged(object sender, EventArgs e)
        {
            if (txtFatherName.Text == "") { errFatherName.Visible = true; } else { errFatherName.Visible = false; }
        }

        private void txtMotherName_TextChanged(object sender, EventArgs e)
        {
            //if (txtMotherName.Text == "") { errMotherName.Visible = true; } else { errMotherName.Visible = false; }
        }

        private void txtStudentCNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentCNIC.Text == "") { errStudentCNIC.Visible = true; } else { errStudentCNIC.Visible = false; }
        }

        private void txtFatherCNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtFatherCNIC.Text == "") { errFatherCNIC.Visible = true; } else { errFatherCNIC.Visible = false; }
        }

        private void txtFatherProfession_TextChanged(object sender, EventArgs e)
        {
            if (txtFatherProfession.Text == "") { errFatherProfession.Visible = true; } else { errFatherProfession.Visible = false; }
        }

        private void ddRelegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddRelegion.SelectedIndex == -1) { errRelegion.Visible = true; } else { errRelegion.Visible = false; }
        }


        private void dtDOB_ValueChanged(object sender, EventArgs e)
        {
            if (dtDOB.Value >= DateTime.Today) { errDOB.Visible = true; } else { errDOB.Visible = false; }
        }

        

        private void txtPlaceOfBirth_TextChanged(object sender, EventArgs e)
        {
            if (txtPlaceOfBirth.Text == "") { errPlaceOfBirth.Visible = true; } else { errPlaceOfBirth.Visible = false; }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dtSession.Value.Year < DateTime.Today.Year) { errSession.Visible = true; } else { errSession.Visible = false; }
        }

        private void ddLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == -1 || ddLevel.SelectedIndex == 0) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddLevel.SelectedIndex > 0)
            {
                MainClass.GetDropdownListWithOneParameters("stp_SelectClassesWRTLevels", ddClass, "Class", "ClassID", "@LevelID", Convert.ToInt32(ddLevel.SelectedValue));
            }
            else
            {
                ddClass.DataSource = null;
            }
        }

        private void ddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex == -1 || ddClass.SelectedIndex == 0) { errClass.Visible = true; } else { errClass.Visible = false; }
        }

        private void ddSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
        }

        private void txtPhone1_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone1.Text == "") { errPhone1.Visible = true; } else { errPhone1.Visible = false; }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "") { errAddress.Visible = true; } else { errAddress.Visible = false; }
        }

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "") { errRegNo.Visible = true; } else { errRegNo.Visible = false; }
        }

        private void btnBrowsePic_Click(object sender, EventArgs e)
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
                }

            }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.EnableReset(pnlDetails);
            LoadList();
            img = Resources.Student_2;
            pictureBox1.Image = img;
            txtRegNo.Focus();
            txtAge.Enabled = false;
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(pnlDetails);
            txtAge.Enabled = false;
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "") { errStudentName.Visible = true; } else { errStudentName.Visible = false; }
            if (ddGender.SelectedIndex == -1) { errGender.Visible = true; } else { errGender.Visible = false; }
            if (txtFatherName.Text == "") { errFatherName.Visible = true; } else { errFatherName.Visible = false; }
            //if (txtMotherName.Text == "") { errMotherName.Visible = true; } else { errMotherName.Visible = false; }
            if (txtFatherProfession.Text == "") { errFatherProfession.Visible = true; } else { errFatherProfession.Visible = false; }
            if (ddRelegion.SelectedIndex == -1) { errRelegion.Visible = true; } else { errRelegion.Visible = false; }
            if (dtDOB.Value >= DateTime.Today) { errDOB.Visible = true; } else { errDOB.Visible = false; }
            if (txtStudentCNIC.Text == "") { errStudentCNIC.Visible = true; } else { errStudentCNIC.Visible = false; }
            if (txtFatherCNIC.Text == "") { errFatherCNIC.Visible = true; } else { errFatherCNIC.Visible = false; }
            if (txtPlaceOfBirth.Text == "") { errPlaceOfBirth.Visible = true; } else { errPlaceOfBirth.Visible = false; }
            if (dtSession.Value.Year < DateTime.Today.Year) { errSession.Visible = true; } else { errSession.Visible = false; }
            if (ddLevel.SelectedIndex == -1 || ddLevel.SelectedIndex == 0) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == -1 || ddClass.SelectedIndex == 0) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
            if (txtPhone1.Text == "") { errPhone1.Visible = true; } else { errPhone1.Visible = false; }
            if (txtRegNo.Text == "") { errRegNo.Visible = true; } else { errRegNo.Visible = false; }
            if (txtAddress.Text == "") { errAddress.Visible = true; } else { errAddress.Visible = false; }
            if (dtAdmissionDate.Value.Date > DateTime.Today.Date) { errAdmissionDate.Visible = true; } else { errAdmissionDate.Visible = false; }

            if (errAdmissionDate.Visible)
            {
                MainClass.ShowMsg("Invalid Date of Admission!", "Stoped..", "Error");
            }
            else if (errSession.Visible)
            {
                MainClass.ShowMsg("Invalid Session!", "Stoped..", "Error");
            }
            else if (errDOB.Visible)
            {
                MainClass.ShowMsg("Invalid Date of Birth!", "Stoped..", "Error");
            }
            else if (errStudentName.Visible || errFatherName.Visible || errGender.Visible || errFatherProfession.Visible
                || errRelegion.Visible || errPlaceOfBirth.Visible || errClass.Visible || errSection.Visible
                || errPhone1.Visible || errAddress.Visible || errStudentCNIC.Visible || errFatherCNIC.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stoped..", "Error");
            }
            else
            {

                int clsID, secID;
                byte gender = Convert.ToByte(ddGender.SelectedIndex == 0 ? 1 : 0);

                QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
                var myData = QG.CreateQrCode(txtStudentName.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
                var QRCode = new QRCoder.QRCode(myData);
                var QRCodeImage= QRCode.GetGraphic(50);
                picQRCode.Image = QRCodeImage;

                if (edit == 0)//code for save operation
                {
                    if (ddClass.SelectedIndex > 0) { clsID = Convert.ToInt32(ddClass.SelectedValue); } else { clsID = 0; }
                    if (ddSection.SelectedIndex > 0) { secID = Convert.ToInt32(ddSection.SelectedValue); } else { secID = 0; }

                    //tostore student's picture

                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, ImageFormat.Jpeg);
                    byte[] arr = ms.ToArray();

                    //to store QRCode of student name

                    MemoryStream QR = new MemoryStream();
                    QRCodeImage.Save(QR, ImageFormat.Jpeg);
                    byte[] QRC = QR.ToArray();

                    clsInsertion.AddAdmissions(Convert.ToInt64(txtRegNo.Text), txtStudentName.Text, gender, txtFatherName.Text, txtMotherName.Text, txtFatherProfession.Text, txtMotherProfession.Text,
                   ddRelegion.SelectedItem.ToString(), dtDOB.Value, "Pakistani", txtPlaceOfBirth.Text, MainClass.CAMPUSID, clsID, secID, dtSession.Value, dtAdmissionDate.Value, txtPhone1.Text,
                   txtPhone2.Text, txtWhatsApp.Text, txtAddress.Text, txtPreviousSchoolName.Text, arr, 1,txtReference.Text,txtFatherCNIC.Text,txtStudentCNIC.Text,txtCaste.Text,QRC);
                    MainClass.DisableReset(pnlDetails);
                    LoadData();
                }
                else if (edit == 1)//code for update operation
                {
                    int count = 0;
                    DialogResult dr = MessageBox.Show("Are you sure you want to Re-Admit " + txtStudentName.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (ddClass.SelectedIndex > 0) { clsID = Convert.ToInt32(ddClass.SelectedValue); } else { clsID = 0; }
                        if (ddSection.SelectedIndex > 0) { secID = Convert.ToInt32(ddSection.SelectedValue); } else { secID = 0; }

                        //tostore student's picture

                        MemoryStream ms = new MemoryStream();
                        img.Save(ms, ImageFormat.Jpeg);
                        byte[] arr = ms.ToArray();

                        //to store QRCode of student name

                        MemoryStream QR = new MemoryStream();
                        QRCodeImage.Save(QR, ImageFormat.Jpeg);
                        byte[] QRC = QR.ToArray();

                        using (TransactionScope sc = new TransactionScope())
                        {
                            CheckLeftStudent = clsSelection.CheckLeftStudent(Convert.ToInt64(txtRegNo.Text));

                            try
                            {
                                if (CheckLeftStudent == 0) // if you just want to update any record of currently reading students
                                {
                                    clsUpdation.UpdateAdmissions(RegNo, Convert.ToInt64(txtRegNo.Text), txtStudentName.Text, gender, txtFatherName.Text, txtMotherName.Text, txtFatherProfession.Text, txtMotherProfession.Text,
                                  ddRelegion.SelectedItem.ToString(), dtDOB.Value, "Pakistani", txtPlaceOfBirth.Text, MainClass.CAMPUSID, clsID, secID, dtSession.Value, txtPhone1.Text,
                                  txtPhone2.Text, txtWhatsApp.Text, txtAddress.Text, txtPreviousSchoolName.Text, arr, dtAdmissionDate.Value, 1,txtReference.Text, txtFatherCNIC.Text, txtStudentCNIC.Text, txtCaste.Text,QRC);

                                    sc.Complete();
                                    count++;

                                }
                                else // if u want to re-admist any student
                                {
                                    clsUpdation.UpdateAdmissions(RegNo, Convert.ToInt64(txtRegNo.Text), txtStudentName.Text, gender, txtFatherName.Text, txtMotherName.Text, txtFatherProfession.Text, txtMotherProfession.Text,
                                   ddRelegion.SelectedItem.ToString(), dtDOB.Value, "Pakistani", txtPlaceOfBirth.Text, MainClass.CAMPUSID, clsID, secID, dtSession.Value, txtPhone1.Text,
                                   txtPhone2.Text, txtWhatsApp.Text, txtAddress.Text, txtPreviousSchoolName.Text, arr, dtAdmissionDate.Value, 1,txtReference.Text, txtFatherCNIC.Text, txtStudentCNIC.Text, txtCaste.Text,QRC);

                                    clsUpdation.UpdateLeftStudentStatus(Convert.ToInt64(txtRegNo.Text));
                                    sc.Complete();
                                    count++;
                                }
                            }
                            catch (Exception x)
                            {
                                MainClass.ShowMsg(x.Message, "Error", "Error");
                            }
                        }

                        if (count > 0)
                        {
                            MainClass.ShowMsg(txtStudentName.Text + " Re-Admitted successfully!", "Success", "Success");
                            MainClass.DisableReset(pnlDetails);
                            LoadData();
                        }

                    }
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtStudentName.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.Delete(RegNo, "stp_DeleteAdmissions", "@RegNo");
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


        private void LoadList()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectSectionsWRTCampus", ddSection, "Name", "SectionID", "@CampusID", MainClass.CAMPUSID);
        }

        private void LoadData()
        {
            clsSelection.SelectAdmissions(dataGridView1, gvRegNo, gvStuName, gvGender, gvFatherName, gvMotherName, gvFatherProf, gvMotherProf, gvRelegion, gvStatus, gvDOB,gvAge,
                gvNationality, gvPOB, gvCampusID, gvCampus, gvSession, gvLevelID, gvLevel, gvClassID, gvClass, gvSectionID, gvSection, gvAdmissionDate, gvPhone1, gvPhone2,
                gvWhatsapp, gvAddress, gvPreSchool,gvReference,gvCNICStudent,gvCNICFather,gvCaste, dtSession.Value.Year);
            MainClass.SNO(dataGridView1, "gvSNO");
        }



        private void SearchData()
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectAdmissions(dataGridView1, gvRegNo, gvStuName, gvGender, gvFatherName, gvMotherName, gvFatherProf, gvMotherProf, gvRelegion, gvStatus, gvDOB,gvAge,
               gvNationality, gvPOB, gvCampusID, gvCampus, gvSession, gvLevelID, gvLevel, gvClassID, gvClass, gvSectionID, gvSection, gvAdmissionDate, gvPhone1, gvPhone2,
               gvWhatsapp, gvAddress, gvPreSchool,gvReference, gvCNICStudent, gvCNICFather, gvCaste, dtSession.Value.Year,txtSearch.Text);
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
                RegNo = Convert.ToInt32(row.Cells["gvRegNo"].Value.ToString());
                txtStudentName.Text = row.Cells["gvStuName"].Value.ToString();
                ddGender.SelectedItem = row.Cells["gvGender"].Value.ToString();
                txtFatherName.Text = row.Cells["gvFatherName"].Value.ToString();
                txtMotherName.Text = row.Cells["gvMotherName"].Value.ToString();
                txtFatherProfession.Text = row.Cells["gvFatherProf"].Value.ToString();
                txtMotherProfession.Text = row.Cells["gvMotherProf"].Value.ToString();
                ddRelegion.SelectedItem = row.Cells["gvRelegion"].Value.ToString();
                dtDOB.Value = Convert.ToDateTime(row.Cells["gvDOB"].Value.ToString());
                txtAge.Text = row.Cells["gvAge"].Value.ToString()+" years";
                txtPlaceOfBirth.Text = row.Cells["gvPOB"].Value.ToString();
                dtSession.Value = Convert.ToDateTime(row.Cells["gvSession"].Value.ToString());
                ddLevel.SelectedValue = row.Cells["gvLevelID"].Value.ToString();
                ddClass.SelectedValue = row.Cells["gvClassID"].Value.ToString();
                ddSection.SelectedValue = row.Cells["gvSectionID"].Value.ToString();
                dtAdmissionDate.Value = Convert.ToDateTime(row.Cells["gvAdmissionDate"].Value.ToString());
                txtPhone1.Text = row.Cells["gvPhone1"].Value.ToString();
                txtPhone2.Text = row.Cells["gvPhone2"].Value.ToString();
                txtRegNo.Text = row.Cells["gvRegNo"].Value.ToString();
                txtWhatsApp.Text = row.Cells["gvWhatsapp"].Value.ToString();
                txtAddress.Text = row.Cells["gvAddress"].Value.ToString();
                txtPreviousSchoolName.Text = row.Cells["gvPreSchool"].Value.ToString();
                txtReference.Text= row.Cells["gvReference"].Value.ToString();
                txtStudentCNIC.Text = row.Cells["gvCNICStudent"].Value.ToString();
                txtFatherCNIC.Text = row.Cells["gvCNICFather"].Value.ToString();
                txtCaste.Text = row.Cells["gvCaste"].Value.ToString();
                
                try
                {
                    SqlCommand com = new SqlCommand("stp_SelectStudentImage", MainClass.con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@RegNo", RegNo);
                    MainClass.con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            byte[] arr = (byte[])(dr["Image"]);
                            if (arr == null)
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
        

        private void txtPhone1_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone1.Text != "")
            {
                if (txtPhone1.TextLength != 10)
                {
                    txtPhone1.Focus();
                    MainClass.ShowMsg("A Phone number must have 10 digits!", "Error", "Error");
                    txtPhone1.SelectAll();
                }
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

        private void dtAdmissionDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtAdmissionDate.Value.Date > DateTime.Today.Date) { errAdmissionDate.Visible = true; } else { errAdmissionDate.Visible = false; }
        }

        private void txtWhatsApp_Validating(object sender, CancelEventArgs e)
        {
            if (txtWhatsApp.Text != "")
            {
                if (txtWhatsApp.TextLength != 10)
                {
                    txtWhatsApp.Focus();
                    MainClass.ShowMsg("A Phone number must have 10 digits!", "Error", "Error");
                    txtWhatsApp.SelectAll();
                }
                if (!rgPhone.Match(txtWhatsApp.Text).Success)
                {
                    txtWhatsApp.Focus();
                    MainClass.ShowMsg("Invalid!\n\nType in this format 3001234567", "Error", "Error");
                    txtWhatsApp.SelectAll();
                }
            }
        }

        private void txtStudentCNIC_Validating(object sender, CancelEventArgs e)
        {
            if (txtStudentCNIC.Text != "")
            {
                if (!rgCNIC.Match(txtStudentCNIC.Text).Success)
                {
                    txtStudentCNIC.SelectAll();
                    txtStudentCNIC.Focus();
                    MainClass.ShowMsg("Invalid Format!\n\nWrite in this format 12345-1234567-1", "Error", "Errror");
                }
            }
        }

        private void txtFatherCNIC_Validating(object sender, CancelEventArgs e)
        {
           
            if (txtFatherCNIC.Text != "")
            {
                if (!rgCNIC.Match(txtFatherCNIC.Text).Success)
                {
                    txtFatherCNIC.SelectAll();
                    txtFatherCNIC.Focus();
                    MainClass.ShowMsg("Invalid Format!\n\nWrite in this format 12345-1234567-1", "Error", "Errror");
                }
            }
        }
    }
}
