using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AbsentNotifications : Sample2
    {
        int total = 0;
        static string RegNo, Student, StudentClass, Section, Status;
        static string MyUsername = "03006064344"; //Your Username At Sendpk.com 923027018278
        static string MyPassword = "thbcw@385"; //Your Password At Sendpk.com Saim2015
        static string toNumber;   //= "923027018278"; //Recepient cell phone number with country code 
        static string Masking = "TIPS"; //Your Company Brand Name 
        static string MessageText;   //= "SMS Sent using .Net";

        public AbsentNotifications()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbNotifications obj = new SchoolManagementSystem.dbNotifications();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {
            int count = 0;

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
                    DialogResult dr = MessageBox.Show("Are you sure, You want to send WhatsaApp Messages?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                            {
                                RegNo = row.Cells["gvRegNo"].Value.ToString();
                                Student = row.Cells["gvStuName"].Value.ToString();
                                StudentClass = row.Cells["gvClass"].Value.ToString();
                                Section = row.Cells["gvSection"].Value.ToString();

                                if (row.Cells["gvStatus"].Value.ToString() == "A")
                                {
                                    Status = "absent";
                                }
                                else if (row.Cells["gvStatus"].Value.ToString() == "L")
                                {
                                    Status = "on leave";
                                }

                                if (chkPhone1.Checked)
                                {
                                    toNumber = "+92" + row.Cells["gvPhone1"].Value.ToString();
                                    MessageText = "Dear Parents! \n" + Student + " Registration No: " + RegNo + " of class " + StudentClass + " - " + Section + " is " + Status + " today. \nTALEEM UL ISLAM SCHOOL, (" + MainClass.CAMPUSNAME + "). ";
                                    MainClass.SEND_WHATSAPP(toNumber, MessageText);
                                }
                                else if (chkPhone2.Checked)
                                {
                                    if (row.Cells["gvPhone2"].Value.ToString() != "")
                                    {
                                        toNumber = "+92" + row.Cells["gvPhone2"].Value.ToString();
                                        MessageText = "Dear Parents! \n" + Student + " Registration No: " + RegNo + " of class " + StudentClass + " - " + Section + " is " + Status + " today. \nTALEEM UL ISLAM SCHOOL, (" + MainClass.CAMPUSNAME + "). ";
                                        MainClass.SEND_WHATSAPP(toNumber, MessageText);
                                    }
                                }
                                else if (chkWhatsApp.Checked)
                                {
                                    if (row.Cells["gvWhatsApp"].Value.ToString() != "")
                                    {
                                        toNumber = "+92" + row.Cells["gvWhatsApp"].Value.ToString();
                                        MessageText = "Dear Parents! \n" + Student + " Registration No: " + RegNo + " of class " + StudentClass + " - " + Section + " is " + Status + " today. \nTALEEM UL ISLAM SCHOOL, (" + MainClass.CAMPUSNAME + "). ";
                                        MainClass.SEND_WHATSAPP(toNumber, MessageText);
                                    }
                                }

                            }
                        }
                    }

                }
            }
        }
        private void chkPhone1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPhone1.Checked)
            {
                chkPhone2.Checked = false;
                chkWhatsApp.Checked = false;
            }
        }

        private void chkPhone2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPhone2.Checked)
            {
                chkPhone1.Checked = false;
                chkWhatsApp.Checked = false;
            }
        }

        private void chkWhatsApp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWhatsApp.Checked)
            {
                chkPhone1.Checked = false;
                chkPhone2.Checked = false;
            }
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {
            string Response = "";
            int SMSCount = 0;
            int count = 0;

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
                    DialogResult dr = MessageBox.Show("Are you sure, You want to send SMS Messages?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                            {

                                RegNo = row.Cells["gvRegNo"].Value.ToString();
                                Student = row.Cells["gvStuName"].Value.ToString();
                                StudentClass = row.Cells["gvClass"].Value.ToString();
                                Section = row.Cells["gvSection"].Value.ToString();

                                if (row.Cells["gvStatus"].Value.ToString() == "A")
                                {
                                    Status = "absent";
                                }
                                else if (row.Cells["gvStatus"].Value.ToString() == "L")
                                {
                                    Status = "on leave";
                                }

                                if (chkPhone1.Checked)
                                {
                                    toNumber = "0" + row.Cells["gvPhone1"].Value.ToString();
                                    MessageText = "Dear Parents! \n" + Student + " Registration No: " + RegNo + " of class " + StudentClass + " - " + Section + " is " + Status + " today. \nTALEEM UL ISLAM SCHOOL, (" + MainClass.CAMPUSNAME + "). ";
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
                                        toNumber = "0" + row.Cells["gvPhone2"].Value.ToString();
                                        MessageText = "Dear Parents! \n" + Student + " Registration No: " + RegNo + " of class " + StudentClass + " - " + Section + " is " + Status + " today. \nTALEEM UL ISLAM SCHOOL, (" + MainClass.CAMPUSNAME + "). ";
                                        Response = MainClass.SEND_SMS(Masking, toNumber, MessageText, MyUsername, MyPassword);
                                        if (Response != null)
                                        {
                                            SMSCount++;
                                        }
                                    }
                                }
                                else if (chkWhatsApp.Checked)
                                {
                                    if (row.Cells["gvWhatsApp"].Value.ToString() != "")
                                    {
                                        toNumber = "0" + row.Cells["gvWhatsApp"].Value.ToString();
                                        MessageText = "Dear Parents! \n" + Student + " Registration No: " + RegNo + " of class " + StudentClass + " - " + Section + " is " + Status + " today. \nTALEEM UL ISLAM SCHOOL, (" + MainClass.CAMPUSNAME + "). ";
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


        public override void btnView_Click(object sender, EventArgs e)
        {
            int exist = clsSelection.SelectAttendanceExistWRTDate(DateTime.Today, 0, 0);
            if (exist > 0)
            {
                clsSelection.SelectAbsentStudentsWRTDate(dataGridView1, gvRegNo, gvStuName,gvFatherName, gvPhone1,gvPhone2,gvWhatsApp, gvCLassID, gvClass, gvSectionID, gvSection, gvDate, gvStatus, DateTime.Today);
                MainClass.SNO(dataGridView1, "gvSNO");
                total = dataGridView1.Rows.Count;
            }

            else
            {
                MainClass.ShowMsg("Please, Mark attendance of at least one class to continue!", "Error", "Error");
            }
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                clsSelection.SelectAbsentStudentsWRTDate(dataGridView1, gvRegNo, gvStuName, gvFatherName, gvPhone1, gvPhone2, gvWhatsApp, gvCLassID, gvClass, gvSectionID, gvSection, gvDate, gvStatus, DateTime.Today, txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                clsSelection.SelectAbsentStudentsWRTDate(dataGridView1, gvRegNo, gvStuName, gvFatherName, gvPhone1, gvPhone2, gvWhatsApp, gvCLassID, gvClass, gvSectionID, gvSection, gvDate, gvStatus, DateTime.Today);
                MainClass.SNO(dataGridView1, "gvSNO");
            }
        }


        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                MainClass.CheckUnCheck(dataGridView1, chkSelectAll, "gvCheck");
            }
        }
    }
}
