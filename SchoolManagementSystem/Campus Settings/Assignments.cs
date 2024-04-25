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
    public partial class Assignments : Sample2
    {
        
        int edit = 0;
        int AssignID;

        public Assignments()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbStaffManagement stm = new SchoolManagementSystem.dbStaffManagement();
            MainClass.ShowWindow(stm, this, MDI.ActiveForm);
        }

        private void Assignments_Load(object sender, EventArgs e)

        {
            MainClass.DisableReset(pnlDetails);
            dataGridView1.AutoGenerateColumns = false;
            LoadList1();
        }


        private void ddShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddShift.SelectedIndex == -1 || ddShift.SelectedIndex == 0) { errShift.Visible = true; } else { errShift.Visible = false; }
            if (ddShift.SelectedIndex>0)
            {
                LoadLiast3();
            }
        }

        private void ddLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddLevel.SelectedIndex>0)
            {
                LoadList2();
                LoadLiast3();
            }
            
        }

        private void ddFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddFaculty.SelectedIndex != 0 && ddFaculty.SelectedIndex != -1)
            {
                txtFaculty.Text = ddFaculty.SelectedValue.ToString();
                errFaculty.Enabled = false;
            }
            else
            {
                errFaculty.Enabled = true;
            }
        }

        
        private void ddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }

            if (ddClass.SelectedIndex>0)
            {
                MainClass.GetDropdownListWithOneParameters("stp_SelectSubjectsWRTClasses", ddSubject, "Subject", "SubjectID", "@ClassID", Convert.ToInt32(ddClass.SelectedValue));
            }
        }

        private void ddSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSection.SelectedIndex == 0 || ddSection.SelectedIndex == -1) { errSection.Visible = true; } else { errSection.Visible = false; }
        }

        private void ddPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddPeriod.SelectedIndex == 0 || ddPeriod.SelectedIndex == -1) { errPeriod.Visible = true; } else { errPeriod.Visible = false; }
        }

        private void ddSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( ddSubject.SelectedIndex == -1 || ddSubject.SelectedIndex == 0) { errSubject.Visible = true; } else { errSubject.Visible = false; }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.EnableReset(pnlDetails);
            txtFaculty.Enabled = false;
            txtFaculty.Text = "";
            LoadList1();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(pnlDetails);
            txtFaculty.Enabled = false;
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ddShift.SelectedIndex == -1 || ddShift.SelectedIndex == 0) { errShift.Visible = true; } else { errShift.Visible = false; }
            if (ddFaculty.SelectedIndex == 0 || ddFaculty.SelectedIndex == -1) { errFaculty.Visible = true; } else { errFaculty.Visible = false; }
            if (ddSection.SelectedIndex == 0 || ddSection.SelectedIndex == -1) { errSection.Visible = true; } else { errSection.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddPeriod.SelectedIndex == 0 || ddPeriod.SelectedIndex == -1) { errPeriod.Visible = true; } else { errPeriod.Visible = false; }
            if (ddSubject.SelectedIndex == -1) { errSubject.Visible = true; } else { errSubject.Visible = false; }
            if (errShift.Visible || errFaculty.Visible || errSection.Visible || errClass.Visible || errPeriod.Visible || errSubject.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                if (edit == 0)//code for save operation
                {
                        clsInsertion.AddClassAssignments(MainClass.CAMPUSID, Convert.ToInt32(ddShift.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), Convert.ToInt32(ddPeriod.SelectedValue), Convert.ToInt32(ddSubject.SelectedValue), Convert.ToInt32(ddFaculty.SelectedValue));
                        LoadData();
                    //MainClass.DisableReset(pnlDetails);
                }
                else if (edit == 1)//code for update operation
                {
                        clsUpdation.UpdateClassAssignments(AssignID, MainClass.CAMPUSID, Convert.ToInt32(ddShift.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), Convert.ToInt32(ddPeriod.SelectedValue), Convert.ToInt32(ddSubject.SelectedValue), Convert.ToInt32(ddFaculty.SelectedValue));
                        LoadData();
                    //MainClass.DisableReset(pnlDetails);
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + ddPeriod.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                        clsDeletion.Delete(AssignID, "stp_DeleteAssignments", "@AssignID");
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
            clsSelection.SelectClassAssignments(dataGridView1, gvAssignID, gvCTID, gvCampusID, gvCampus, gvShiftID, gvShift, gvStaffID, gvStaff, gvLevelID, gvLevel, gvClassID, gvClass, gvSectionID, gvSection, gvPeriodID, gvPeriod, gvSubjectID, gvSubjectName, gvDay);
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        private void SearchData()
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectClassAssignments(dataGridView1, gvAssignID, gvCTID, gvCampusID, gvCampus, gvShiftID, gvShift, gvStaffID, gvStaff, gvLevelID, gvLevel, gvClassID, gvClass, gvSectionID, gvSection, gvPeriodID, gvPeriod, gvSubjectID, gvSubjectName, gvDay,txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                LoadData();
            }
        }

        private void LoadList1()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectShiftsWRTCampus", ddShift, "Name", "ShiftID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectFacultyFromStaffWRTCampus", ddFaculty, "Staff", "StaffID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectSectionsWRTCampus", ddSection, "Name", "SectionID", "@CampusID", MainClass.CAMPUSID);
        }

        private void LoadList2()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectClassesWRTLevels", ddClass, "Class", "ClassID", "@LevelID", Convert.ToInt32(ddLevel.SelectedValue));
            
        }

        private void LoadLiast3()
        {
            MainClass.GetDropdownListWithTwoParameters("stp_SelectPeriodsWRTClassTimings", ddPeriod, "Period", "CTID", "@LevelID", Convert.ToInt32(ddLevel.SelectedValue), "@ShiftID",Convert.ToInt32(ddShift.SelectedValue));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                edit = 1;
                MainClass.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                AssignID = Convert.ToInt32(row.Cells["gvAssignID"].Value.ToString());
                ddShift.SelectedValue = row.Cells["gvShiftID"].Value;
                if (ddShift.SelectedIndex>0)
                {
                    LoadLiast3();
                }
                ddFaculty.SelectedValue = row.Cells["gvStaffID"].Value;
                ddLevel.SelectedValue = row.Cells["gvLevelID"].Value;
                ddClass.SelectedValue = row.Cells["gvClassID"].Value;
                ddSection.SelectedValue = row.Cells["gvSectionID"].Value;
                ddPeriod.SelectedValue = row.Cells["gvCTID"].Value.ToString();
                ddSubject.SelectedValue = row.Cells["gvSubjectID"].Value;
            }
        }

        
    }
}
