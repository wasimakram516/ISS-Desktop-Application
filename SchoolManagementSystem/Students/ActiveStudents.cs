using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ActiveStudents : Sample2
    {
        
        Int64 RegNo;
        int edit = 0, count = 0;
        byte stat,lftReason;
        private int checkStudent;
        private int CheckLeftStudent;

        public ActiveStudents()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            MainClass.DisableReset(pnlDetails);
            LoadList();

        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbStudemtManagement obj = new SchoolManagementSystem.dbStudemtManagement();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void LoadList()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectSectionsWRTCampus", ddSection, "Name", "SectionID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddPLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectSectionsWRTCampus", ddPSection, "Name", "SectionID", "@CampusID", MainClass.CAMPUSID);
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
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
        }

        private void ddSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSection.SelectedIndex == 0 || ddSection.SelectedIndex == -1) { errSection.Visible = true; } else { errSection.Visible = false; }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex == 0 || ddSection.SelectedIndex == -1) { errSection.Visible = true; } else { errSection.Visible = false; }
            if (errLevel.Visible || errClass.Visible || errSection.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            clsSelection.SelectStudentsWRT_Level_Session_Class_Section_And_Status(dataGridView1, gvRegNo, gvStuName, gvFatherName, gvLevelID, gvLevel, gvClassID, gvClass,
                gvSectionID, gvSection, gvSession, gvStatus, Convert.ToInt32(ddLevel.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), dtSession.Value.Year);
            MainClass.SNO(dataGridView1, "gvSNO");
        }


        private void ddLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddLeftStudent.SelectedIndex == 0)
            {
                MainClass.EnableReset(pnlPromoteStudent);
                MainClass.EnableReset(pnlLeftStudent);
                pnlPromoteStudent.Visible = false;
                pnlLeftStudent.Visible = true;
            }
            else if (ddLeftStudent.SelectedIndex == 1)
            {
                MainClass.EnableReset(pnlPromoteStudent);
                MainClass.EnableReset(pnlLeftStudent);
                pnlLeftStudent.Visible = false;
                pnlPromoteStudent.Visible = true;
            }
        }

        private void ddLeftReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddLeftReason.SelectedIndex == -1) { errLeftReason.Visible = true; } else { errLeftReason.Visible = false; }
        }

        private void ddStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
        }

        private void ddPLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddPLevel.SelectedIndex == 0 || ddPLevel.SelectedIndex == -1) { errPLevel.Visible = true; } else { errPLevel.Visible = false; }
            if (ddPLevel.SelectedIndex > 0)
            {
                MainClass.GetDropdownListWithOneParameters("stp_SelectClassesWRTLevels", ddPClass, "Class", "ClassID", "@LevelID", Convert.ToInt32(ddPLevel.SelectedValue));
            }
            else
            {
                ddPClass.DataSource = null;
            }

        }

        private void ddPClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddPClass.SelectedIndex == 0 || ddPClass.SelectedIndex == -1) { errPClass.Visible = true; } else { errPClass.Visible = false; }

        }

        private void ddPSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddPSection.SelectedIndex == 0 || ddPSection.SelectedIndex == -1) { errPSection.Visible = true; } else { errPSection.Visible = false; }
        }

        private void ddPReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddPReason.SelectedIndex == -1) { errPReason.Visible = true; } else { errPReason.Visible = false; }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.EnableReset(pnlDetails);
            LoadList();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex == 0 || ddSection.SelectedIndex == -1) { errSection.Visible = true; } else { errSection.Visible = false; }
            if (ddLeftStudent.SelectedIndex != -1)
            {
                if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
                if (ddPLevel.SelectedIndex == 0 || ddPLevel.SelectedIndex == -1) { errPLevel.Visible = true; } else { errPLevel.Visible = false; }
                if (ddPClass.SelectedIndex == 0 || ddPClass.SelectedIndex == -1) { errPClass.Visible = true; } else { errPClass.Visible = false; }
                if (ddPSection.SelectedIndex == 0 || ddPSection.SelectedIndex == -1) { errPSection.Visible = true; } else { errPSection.Visible = false; }
            }
            if (errLevel.Visible || errSection.Visible || errClass.Visible || errStatus.Visible || errPLevel.Visible || errPClass.Visible || errPSection.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                if (edit == 0)//code for save operation
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        if (ddLeftStudent.SelectedIndex>-1)
                        {
                            DialogResult dr = MessageBox.Show("Are you sure, you want to proceed ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                                    {
                                        checkStudent = 1;
                                        if (ddLeftStudent.SelectedIndex == 0) //if student has left school
                                        {
                                            stat = Convert.ToByte(ddLeftStudent.SelectedIndex );
                                            lftReason = Convert.ToByte(ddLeftReason.SelectedIndex);
                                            try
                                            {
                                                using (TransactionScope sc= new TransactionScope())
                                                {
                                                    clsUpdation.UpdateStudentStatus(Convert.ToInt64(row.Cells["gvRegNo"].Value), stat);
                                                    CheckLeftStudent = clsSelection.CheckLeftStudent(Convert.ToInt64(row.Cells["gvRegNo"].Value));

                                                    if (CheckLeftStudent==0)
                                                    {
                                                        clsInsertion.AddLeftStudent(Convert.ToInt64(row.Cells["gvRegNo"].Value), dtLeftDate.Value, lftReason, stat);
                                                        sc.Complete();
                                                        count++;
                                                    }

                                                    else
                                                    {
                                                        clsUpdation.UpdateLeftStudent(Convert.ToInt64(row.Cells["gvRegNo"].Value), dtLeftDate.Value, lftReason, stat);
                                                        sc.Complete();
                                                        count++;
                                                    }
                                                  
                                                }
                                               
                                            }
                                            catch (Exception x)
                                            {
                                                MainClass.ShowMsg(x.Message, "Error", "Error");
                                            }
                                        }

                                        else if (ddLeftStudent.SelectedIndex == 1) //if student has been promoted
                                        {

                                            try
                                            {
                                                clsUpdation.UpdateAdmissionsWRT_Session_Level_Class_Section(Convert.ToInt64(row.Cells["gvRegNo"].Value), Convert.ToInt32(ddPClass.SelectedValue), Convert.ToInt32(ddPSection.SelectedValue), dtPSession.Value, Convert.ToByte(ddPReason.SelectedIndex));
                                                count++;
                                            }
                                            catch (Exception x)
                                            {
                                                MainClass.ShowMsg(x.Message, "Error", "Error");
                                            }
                                        }
                                    }
                                }

                                if (checkStudent < 1)
                                {
                                    MainClass.ShowMsg("Please, Select at least 1 student to continue..", "Error", "Error");
                                }
                                else if (count > 0)
                                {
                                    MainClass.ShowMsg(count + " record(s) updated successfully.", "Success", "Success");
                                    LoadData();
                                    count = 0;
                                    ddLeftStudent.SelectedIndex = -1;
                                    MainClass.EnableReset(pnlPromoteStudent);
                                    MainClass.EnableReset(pnlLeftStudent);
                                    pnlLeftStudent.Visible = false;
                                    pnlPromoteStudent.Visible = false;
                                }
                            }
                        }
                    }
                }

                else if (edit == 1)//code for update operation
                {

                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            MainClass.ShowMsg("Nothing can be deleted here!", "Stop!", "Error");
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please, Press the Load Button to Load Records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectStudentsWRT_Level_Session_Class_Section_And_Status(dataGridView1, gvRegNo, gvStuName, gvFatherName, gvLevelID, gvLevel, gvClassID, gvClass,
                gvSectionID, gvSection, gvSession, gvStatus, Convert.ToInt32(ddLevel.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), dtSession.Value.Year,txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSNO");
            }

            else
            {
                LoadData();
            }
        }

        private void pnlDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                lblLeftStudent.Visible = true;
                ddLeftStudent.Visible = true;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (e.ColumnIndex == 0)
                {
                    if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 0)
                    {
                        row.Cells["gvCheck"].Value = 1;
                    }
                    else
                    {
                        row.Cells["gvCheck"].Value = 0;
                    }
                }
            }
        }

       

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            MainClass.CheckUnCheck(dataGridView1, chkSelectAll, "gvCheck");
        }
    }
}
