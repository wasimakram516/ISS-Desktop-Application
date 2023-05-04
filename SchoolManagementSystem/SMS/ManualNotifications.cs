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

namespace ISS.SMS
{
    public partial class ManualNotifications : Sample2
    {
        Regex rgPhone = new Regex("^[0-9]*$");                  //    3001234567

        static string MyUsername = "03006064344"; //Your Username At Sendpk.com 923027018278
        static string MyPassword = "thbcw@385"; //Your Password At Sendpk.com Saim2015
        static string toNumber;   //= "923027018278"; //Recepient cell phone number with country code 
        static string Masking = "TIPS"; //Your Company Brand Name 
        static string MessageText;   //= "SMS Sent using .Net";

        public ManualNotifications()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbNotifications obj = new ISS.dbNotifications();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                MainClass.CheckUnCheck(dataGridView1, chkSelectAll, "gvCheck");
            }
        }

        private void chkPhone1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPhone1.Checked)
            {
                chkPhone2.Checked = false;
                chkWhatsApp.Checked = false;
                txtToNumber.Text = "";
            }
        }

        private void chkPhone2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPhone2.Checked)
            {
                chkPhone1.Checked = false;
                chkWhatsApp.Checked = false;
                txtToNumber.Text = "";
            }
        }

        private void chkWhatsApp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWhatsApp.Checked)
            {
                chkPhone1.Checked = false;
                chkPhone2.Checked = false;
                txtToNumber.Text = "";
            }
        }

        private void ManualNotifications_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            MainClass.DisableReset(pnlDetails);
            LoadList1();
        }

        private void LoadList1()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectSectionsWRTCampus", ddSection, "Name", "SectionID", "@CampusID", MainClass.CAMPUSID);
        }

        private void LoadList2()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectClassesWRTLevels", ddClass, "Class", "ClassID", "@LevelID", Convert.ToInt32(ddLevel.SelectedValue));
        }

        private void ddLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }

            if (ddLevel.SelectedIndex > 0)
            {
                LoadList2();
            }
            else
            {
                ddClass.DataSource = null;
            }
        }

        private void ddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex < 1) { errClass.Visible = true; } else { errClass.Visible = false; }
        }

        private void ddSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSection.SelectedIndex < 1) { errSection.Visible = true; } else { errSection.Visible = false; }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (ddClass.SelectedIndex < 1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex < 1) { errSection.Visible = true; } else { errSection.Visible = false; }

            if (errClass.Visible || errSection.Visible)
            {
                MainClass.ShowMsg("Fields with * are mendatory!", "Error", "Error");
            }
            else
            {
                clsSelection.SelectStudentsForMessages(dataGridView1, gvRegNo, gvStuName, gvFatherName, gvLevelID, gvLevel, gvClassID, gvClass, gvSectionID, gvSection, gvPhone1, gvPhone2, gvWhatsapp, dtSession.Value.Year, Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue));
                MainClass.SNO(dataGridView1, "gvSNO");
            }
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.EnableReset(pnlDetails);
            LoadList1();
        }

        private void txtToNumber_Validating(object sender, CancelEventArgs e)
        {
            if (txtToNumber.Text != "")
            {
                if (txtToNumber.TextLength != 10)
                {
                    txtToNumber.Focus();
                    MainClass.ShowMsg("A Phone number must have 10 digits!", "Error", "Error");
                    txtToNumber.SelectAll();
                }
                if (!rgPhone.Match(txtToNumber.Text).Success)
                {
                    txtToNumber.Focus();
                    MainClass.ShowMsg("Invalid!\n\nType in this format 3001234567", "Error", "Error");
                    txtToNumber.SelectAll();
                }
            }
        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (chkPhone1.Checked || chkPhone2.Checked || chkWhatsApp.Checked) // if any of the checkbox is checked, Text will be sent to to the selected students
            {
                if (dataGridView1.Rows.Count<=0)
                {
                    MainClass.ShowMsg("Please, Load records to continue.", "load Records", "Success");
                }

                else 
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        MainClass.ShowMsg("Please, Select records to continue.", "Select Records", "Success");
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Are you sure, You want to send multiple WhatsaApp Messages?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                                {
                                    if (chkPhone1.Checked)
                                    {
                                        toNumber = "+92" + row.Cells["gvPhone1"].Value.ToString();
                                        MessageText = txtMessage.Text;
                                        MainClass.SEND_WHATSAPP(toNumber, MessageText);
                                    }
                                    else if (chkPhone2.Checked)
                                    {
                                        if (row.Cells["gvPhone2"].Value.ToString() != "")
                                        {
                                            toNumber = "+92" + row.Cells["gvPhone2"].Value.ToString();
                                            MessageText = txtMessage.Text;
                                            MainClass.SEND_WHATSAPP(toNumber, MessageText);
                                        }
                                    }
                                    else if (chkWhatsApp.Checked)
                                    {
                                        if (row.Cells["gvWhatsapp"].Value.ToString() != "")
                                        {
                                            toNumber = "+92" + row.Cells["gvWhatsapp"].Value.ToString();
                                            MessageText = txtMessage.Text;
                                            MainClass.SEND_WHATSAPP(toNumber, MessageText);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            else // if number is entered then text will be sent to the entered number
            {
                DialogResult dr = MessageBox.Show("Are you sure, You want to send a WhatsaApp Message?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (txtToNumber.Text == "")
                    {
                        MainClass.ShowMsg("Please, Enter a number to continue.", "Number Required", "Success");
                        txtToNumber.Focus();
                    }
                    else
                    {
                        toNumber = "+92" + txtToNumber.Text;
                        MessageText = txtMessage.Text;
                        MainClass.SEND_WHATSAPP(toNumber, MessageText);
                    }
                }
            }
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {
            string Response = "";
            int SMSCount = 0;
            int count = 0;

            if (chkPhone1.Checked || chkPhone2.Checked || chkWhatsApp.Checked) // if any of the checkbox is checked, Text will be sent to to the selected students
            {
                if (dataGridView1.Rows.Count <= 0)
                {
                    MainClass.ShowMsg("Please, Load records to continue.", "load Records", "Success");
                }

                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        MainClass.ShowMsg("Please, Select records to continue.", "Select Records", "Success");
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Are you sure, You want to send multiple SMS?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                                {
                                    if (chkPhone1.Checked)
                                    {
                                        toNumber = "0" + row.Cells["gvPhone1"].Value.ToString();
                                        MessageText = txtMessage.Text;
                                        Response = MainClass.SEND_SMS(Masking, toNumber, MessageText, MyUsername, MyPassword);
                                        if (Response != null)
                                        {
                                            SMSCount++;
                                        }
                                    }
                                    else if (chkPhone2.Checked)
                                    {
                                        if (row.Cells["gvPhone2"].Value.ToString() != "")
                                        {
                                            toNumber = "0" + row.Cells["gvPhone1"].Value.ToString();
                                            MessageText = txtMessage.Text;
                                            Response = MainClass.SEND_SMS(Masking, toNumber, MessageText, MyUsername, MyPassword);
                                            if (Response != null)
                                            {
                                                SMSCount++;
                                            }
                                        }
                                    }
                                    else if (chkWhatsApp.Checked)
                                    {
                                        if (row.Cells["gvWhatsapp"].Value.ToString() != "")
                                        {
                                            toNumber = "0" + row.Cells["gvPhone1"].Value.ToString();
                                            MessageText = txtMessage.Text;
                                            Response = MainClass.SEND_SMS(Masking, toNumber, MessageText, MyUsername, MyPassword);
                                            if (Response != null)
                                            {
                                                SMSCount++;
                                            }
                                        }
                                    }
                                }
                            }

                            if (SMSCount > 0)
                            {
                                MessageBox.Show(SMSCount + " message(s) Sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(Response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

            else // if number is entered then text will be sent to the entered number
            {
                if (txtToNumber.Text == "")
                {
                    MainClass.ShowMsg("Please, Enter a number to continue.", "Number Required", "Success");
                    txtToNumber.Focus();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Are you sure, You want to send an SMS?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        toNumber = "0" + txtToNumber.Text;
                        MessageText = txtMessage.Text;
                        Response = MainClass.SEND_SMS(Masking, toNumber, MessageText, MyUsername, MyPassword);
                        if (Response != null)
                        {
                            SMSCount++;
                        }
                        if (SMSCount > 0)
                        {
                            MessageBox.Show(SMSCount + " message(s) Sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(Response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            }
        }

        private void txtToNumber_TextChanged(object sender, EventArgs e)
        {
            if (chkPhone1.Checked || chkPhone2.Checked || chkWhatsApp.Checked)
            {
                chkPhone1.Checked = false;
                chkPhone2.Checked = false;
                chkWhatsApp.Checked = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
