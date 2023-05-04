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
    public partial class Attendance : Sample2
    {
        
        int edit=0;
        private int chkStudent, CountAttend, TotalStudents = 0;
        private string exception;
        private string stuName;
        private Int64 AttendanceID;
        private int exist;

        public Attendance()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            if (MainClass.STAFFROLE == "Admin")
            {
                dbAdmin hom = new ISS.dbAdmin();
                MainClass.ShowWindow(hom, this, MDI.ActiveForm);
            }
            else if (MainClass.STAFFROLE == "Principal")
            {
                dbStudemtManagement stm = new ISS.dbStudemtManagement();
                MainClass.ShowWindow(stm, this, MDI.ActiveForm);
            }
            else
            {
                Login obj = new Login();
                MainClass.ShowWindow(obj, this, MDI.ActiveForm);
            }
        }

        private void Attendance_Load(object sender, EventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date <= DateTime.Today.Date) { errDate.Visible = false; }else { errDate.Visible = true; }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (ddClass.SelectedIndex < 1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex < 1) { errSection.Visible = true; } else { errSection.Visible = false; }
            if (dateTimePicker1.Value.Date <= DateTime.Today.Date) { errDate.Visible = false; } else { errDate.Visible = true; }
            if (errDate.Visible)
            {
                MainClass.ShowMsg("You can not mark attendance at this date!", "Error", "Error");
            }
            else if (errClass.Visible || errSection.Visible)
            {
                MainClass.ShowMsg("Fields with * are mendatory!", "Error", "Error");
            }
            else
            {
                chkSelectAll.Enabled = true;
                lblExistAttend.Visible = false;
                dataGridView1.DataSource = null;

                exist = clsSelection.SelectAttendanceExistWRTDate(dateTimePicker1.Value, Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue));

                if (exist > 0) // if Attendance is already marked
                {
                    lblExistAttend.Visible = true;

                    clsSelection.SelectAttendanceWRTDate(dataGridView1, gvRegNo, gvStuName, gvCLassID, gvClass, gvSectionID, gvSection, gvAttendID, gvDate, gvStatus, dateTimePicker1.Value, Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue));
                    MainClass.SNO(dataGridView1, "gvSNO");
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.ReadOnly = true;
                    }
                    chkSelectAll.Enabled = false;
                    MainClass.CheckUnCheck(dataGridView1, chkSelectAll, "gvCheck");

                }
                else // if Attendance is not marked yet
                {
                    lblExistAttend.Visible = false;
                    chkSelectAll.Enabled = true;

                    clsSelection.SelectStudentsForAttendance(dataGridView1, gvRegNo, gvStuName, gvCLassID, gvClass, gvSectionID, gvSection, Convert.ToInt32(ddLevel.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), dtSession.Value.Year);
                    MainClass.SNO(dataGridView1, "gvSNO");
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.Cells["gvStatus"].ReadOnly = true;
                    }
                    MainClass.CheckUnCheck(dataGridView1, chkSelectAll, "gvCheck");
                }
            }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            lblExistAttend.Visible = false;
            MainClass.EnableReset(pnlDetails);
            LoadList1();
            chkSelectAll.Enabled = true;
            exception = null;
            if (dataGridView1.Rows.Count>0)
            {
                dataGridView1.DataSource = null;
            }
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(pnlDetails);
            chkSelectAll.Enabled = true;
            exception = null;

            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.ReadOnly = false;
                }
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex < 1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex < 1) { errSection.Visible = true; } else { errSection.Visible = false; }
            if (errClass.Visible || errSection.Visible)
            {
                MainClass.ShowMsg("Fields with * are mendatory!", "Error", "Error");
            }
            else
            {
                if (edit == 0)//code for save operation
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1) //present will be marked for selected students
                        {
                            chkStudent = 1;
                            try
                            {
                                clsInsertion.AddStudentsAttendance(dateTimePicker1.Value, Convert.ToInt64(row.Cells["gvRegNo"].Value), Convert.ToInt32(row.Cells["gvClassID"].Value), Convert.ToInt32(row.Cells["gvSectionID"].Value), "P");
                            }
                            catch (Exception x)
                            {
                                exception = x.Message;
                            }
                        }

                        else if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 0) // Absent will be marked for not selected students
                        {
                            chkStudent = 1;
                            try
                            {
                                clsInsertion.AddStudentsAttendance(dateTimePicker1.Value, Convert.ToInt64(row.Cells["gvRegNo"].Value), Convert.ToInt32(row.Cells["gvClassID"].Value), Convert.ToInt32(row.Cells["gvSectionID"].Value), "A");
                            }
                            catch (Exception x)
                            {
                                exception = x.Message;
                            }
                        }
                    }

                    if (chkStudent < 1)
                    {
                        MainClass.ShowMsg("Select at least 1 Student to continue...", "Error", "Error");
                    }
                    else if (exception != null)
                    {
                        MainClass.ShowMsg(exception, "Error", "Error");
                    }
                    else
                    {
                        MainClass.ShowMsg("Attendance of "+dataGridView1.Rows.Count+" students of " + ddClass.Text + " " + ddSection.Text + " has been marked successfully!", "Success", "Success");
                        //MainClass.DisableReset(pnlDetails);
                        edit = 0;
                        dataGridView1.DataSource = null;

                    }

                }

                else if (edit == 1) //code for update operation
                {

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                        {
                            chkStudent = 1;
                            try
                            {
                                clsUpdation.UpdateStudentsAttendance(Convert.ToInt64(row.Cells["gvAttendID"].Value), dateTimePicker1.Value, row.Cells["gvStatus"].Value.ToString());
                                CountAttend++;

                            }
                            catch (Exception x)
                            {
                                exception = x.Message;
                            }
                        }
                    }

                    if (chkStudent < 1)
                    {
                        MainClass.ShowMsg("Select at least 1 Student to continue...", "Error", "Error");
                    }
                    else if (exception != null)
                    {
                        MainClass.ShowMsg(exception, "Error", "Error");
                    }
                    else
                    {
                        MainClass.ShowMsg("Attendance of " + CountAttend + " student(s) of " + ddClass.Text + " " + ddSection.Text + " has been Updated successfully!", "Success", "Success");
                        //MainClass.DisableReset(pnlDetails);
                        lblExistAttend.Visible = false;
                        TotalStudents = 0;
                        CountAttend = 0;
                        dataGridView1.DataSource = null;
                    }
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete attendance of " + dateTimePicker1.Value + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.Delete(dateTimePicker1.Value, "stp_DeleteAttendance", "@date");
                    MainClass.DisableReset(pnlDetails);
                    LoadData();
                }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please, Press the Load Button to Load Records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        

        private void dataGridView1_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["gvDate"].Value = null;
                row.Cells["gvStatus"].Value = null;
            }
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            clsSelection.SearchAttendanceWRTDate(dataGridView1, gvRegNo, gvStuName, gvCLassID, gvClass, gvSectionID, gvSection, gvAttendID, gvDate, gvStatus, dateTimePicker1.Value, Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), txtSearch.Text);
            MainClass.SNO(dataGridView1, "gvSNO");

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
