using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class StaffAttendance : Sample2
    {
        
        int edit = 0, chkStaff = 0, CountAttend = 0;
        int exist = 0;
        string exception;

        public StaffAttendance()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            if (MainClass.STAFFROLE == "Admin")
            {
                dbAdmin hom = new SchoolManagementSystem.dbAdmin();
                MainClass.ShowWindow(hom, this, MDI.ActiveForm);
            }
            else if (MainClass.STAFFROLE == "Principal")
            {
                dbStaffManagement stm = new SchoolManagementSystem.dbStaffManagement();
                MainClass.ShowWindow(stm, this, MDI.ActiveForm);
            }
            else
            {
                Login obj = new Login();
                MainClass.ShowWindow(obj, this, MDI.ActiveForm);
            }
        }

        private void StaffAttendance_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            MainClass.DisableReset(pnlDetails);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date > DateTime.Now.Date) { errDate.Visible = true; } else { errDate.Visible = false; }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (dateTimePicker1.Value.Date > DateTime.Now.Date) { errDate.Visible = true; } else { errDate.Visible = false; }
            if (errDate.Visible)
            {
                MainClass.ShowMsg("Invalid Date!", "Error", "Error");
            }
            else
            {
                chkSelectAll.Enabled = true;
                lblExistAttend.Visible = false;
                dataGridView1.DataSource = null;
                exist = clsSelection.SelectExistStaffAttendance(dateTimePicker1.Value);

                if (exist > 0) // If attendance is already marked
                {
                    lblExistAttend.Visible = true;

                    clsSelection.SelectStaffAttendance(dataGridView1, gvAttendID, gvStaffID, gvCNIC, gvStaff, gvRole, gvDate, gvStatus, dateTimePicker1.Value, MainClass.CAMPUSID);
                    MainClass.SNO(dataGridView1, "gvSNO");
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.ReadOnly = true;
                    }
                    chkSelectAll.Enabled = false;
                    MainClass.CheckUnCheck(dataGridView1, chkSelectAll, "gvCheck");
                }

                else // If attendance is not marked
                {
                    lblExistAttend.Visible = false;

                    clsSelection.SelectStaffDetailsForAttendance(dataGridView1, gvStaffID, gvCNIC, gvStaff, gvRole, MainClass.CAMPUSID);
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
            chkSelectAll.Enabled = true;
            exception = null;
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
            if (dateTimePicker1.Value.Date > DateTime.Now.Date) { errDate.Visible = true; } else { errDate.Visible = false; }
            if (errDate.Visible)
            {
                MainClass.ShowMsg("Invalid Date!", "Error", "Error");
            }
            else
            {
                if (edit == 0)//code for save operation
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1) // Present will be marked of selected staff
                        {
                            chkStaff = 1;
                            try
                            {
                                clsInsertion.AddStaffAttendance(Convert.ToInt32(row.Cells["gvStaffID"].Value), dateTimePicker1.Value, "P");
                            }
                            catch (Exception x)
                            {
                                exception = x.Message;
                            }
                        }
                        else if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 0) // Leave will be marked of un selected staff
                        {
                            chkStaff = 1;
                            try
                            {
                                clsInsertion.AddStaffAttendance(Convert.ToInt32(row.Cells["gvStaffID"].Value), dateTimePicker1.Value, "L");
                            }
                            catch (Exception x)
                            {
                                exception = x.Message;
                            }
                        }
                    }

                    if (chkStaff < 1)
                    {
                        MainClass.ShowMsg("Select at least 1 Staff to continue...", "Error", "Error");
                    }
                    else if (exception != null)
                    {
                        MainClass.ShowMsg(exception, "Error", "Error");
                    }
                    else
                    {
                        MainClass.ShowMsg("Attendance of " + dataGridView1.Rows.Count + " staff member(s) has been marked successfully!", "Success", "Success");
                        //MainClass.DisableReset(pnlDetails);
                        CountAttend = 0;
                        chkStaff = 0;
                        dataGridView1.DataSource = null;

                    }

                }

                else if (edit == 1) //code for update operation
                {

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                        {
                            chkStaff = 1;
                            try
                            {
                                clsUpdation.UpdateStaffAttendance(Convert.ToInt32(row.Cells["gvAttendID"].Value), dateTimePicker1.Value, row.Cells["gvStatus"].Value.ToString());
                                CountAttend++;

                            }
                            catch (Exception x)
                            {
                                exception = x.Message;
                            }
                        }
                    }

                    if (chkStaff < 1)
                    {
                        MainClass.ShowMsg("Select at least 1 Staff to continue...", "Error", "Error");
                    }

                    else if (exception != null)
                    {
                        MainClass.ShowMsg(exception, "Error", "Error");
                    }

                    else
                    {
                        MainClass.ShowMsg("Attendance of " + CountAttend + " Staff of  has been Updated successfully!", "Success", "Success");
                        MainClass.DisableReset(pnlDetails);
                        lblExistAttend.Visible = false;
                        CountAttend = 0;
                        dataGridView1.DataSource = null;
                    }
                }
            }
        }



        public override void btnDelete_Click(object sender, EventArgs e)
        {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete attendance of "+dateTimePicker1.Value+"?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.Delete(dateTimePicker1.Value, "stp_DeleteStaffAttendance", "@date");
                    MainClass.DisableReset(pnlDetails);
                    LoadData();
                }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please, Press the Load Button to Load Records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

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
