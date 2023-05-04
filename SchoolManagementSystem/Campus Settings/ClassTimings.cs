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
    public partial class ClassTimings : Sample2
    {
        
        int edit = 0;
        int ClassTimeID;
        public ClassTimings()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbCampusManagement cm = new ISS.dbCampusManagement();
            MainClass.ShowWindow(cm, this, MDI.ActiveForm);
        }

        private void ClassTimings_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
            LoadList();
        }

        private void LoadList()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectShiftsWRTCampus", ddShift, "Name", "ShiftID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownList("stp_SelectPeriods", ddPeriods, "Period", "PeriodID");
        }

        private void txtPeriodNo_TextChanged(object sender, EventArgs e)
        {
            if (ddPeriods.SelectedIndex == 0 || ddPeriods.SelectedIndex == -1) { errPeriodNo.Visible = true; } else { errPeriodNo.Visible = false; }
        }

        private void ddShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ddShift.SelectedIndex == -1 || ddShift.SelectedIndex == 0) { errShift.Visible = true; } else { errShift.Visible = false; }
        }

        private void ddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == -1 || ddLevel.SelectedIndex == 0) { errLevel.Visible = true; } else { errLevel.Visible = false; }
        }

        private void dtStartTine_ValueChanged(object sender, EventArgs e)
        {
            if (dtStartTine.Value > dtEndtime.Value) { errStart.Visible = true; } else { errStart.Visible = false; }
        }

        private void dtEndtime_ValueChanged(object sender, EventArgs e)
        {
            if (dtStartTine.Value > dtEndtime.Value) { errEnd.Visible = true; } else { errEnd.Visible = false; }
        }

        private void ddDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddDays.SelectedIndex == -1) { errDay.Visible = true; } else { errDay.Visible = false; }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (errLevel.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                LoadData();
            }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.EnableReset(pnlDetails);
            LoadList();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(pnlDetails);
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ddPeriods.SelectedIndex == 0 || ddPeriods.SelectedIndex == -1) { errPeriodNo.Visible = true; } else { errPeriodNo.Visible = false; }
            if (ddShift.SelectedIndex == -1 || ddShift.SelectedIndex == 0) { errShift.Visible = true; } else { errShift.Visible = false; }
            if (ddLevel.SelectedIndex == -1 || ddLevel.SelectedIndex == 0) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (dtStartTine.Value > dtEndtime.Value) { errStart.Visible = true; } else { errStart.Visible = false; }
            if (dtStartTine.Value > dtEndtime.Value) { errEnd.Visible = true; } else { errEnd.Visible = false; }
            if (ddDays.SelectedIndex == -1) { errDay.Visible = true; } else { errDay.Visible = false; }

            if (errStart.Visible || errEnd.Visible)
            {
                MainClass.ShowMsg("Start time should be less than end time!", "Error", "Errror");
            }

            else if (errPeriodNo.Visible || errShift.Visible || errLevel.Visible || errDay.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                if (edit == 0)//code for save operation
                {
                    TimeSpan startTime = new TimeSpan(dtStartTine.Value.Hour, dtStartTine.Value.Minute, dtStartTine.Value.Second);
                    TimeSpan EndTime = new TimeSpan(dtEndtime.Value.Hour, dtEndtime.Value.Minute, dtEndtime.Value.Second);
                    clsInsertion.AddClassTimings(Convert.ToInt32(ddPeriods.SelectedValue), Convert.ToInt32(ddShift.SelectedValue), Convert.ToInt32(ddLevel.SelectedValue), startTime, EndTime, ddDays.SelectedIndex.ToString());
                    LoadData();
                }
                else if (edit == 1)//code for update operation
                {
                    TimeSpan startTime = new TimeSpan(dtStartTine.Value.Hour, dtStartTine.Value.Minute, dtStartTine.Value.Second);
                    TimeSpan EndTime = new TimeSpan(dtEndtime.Value.Hour, dtEndtime.Value.Minute, dtEndtime.Value.Second);
                    clsUpdation.UpdateClassTimings(ClassTimeID, Convert.ToInt32(ddPeriods.SelectedValue), Convert.ToInt32(ddShift.SelectedValue), Convert.ToInt32(ddLevel.SelectedValue), startTime, EndTime, ddDays.SelectedIndex.ToString());
                    LoadData();
                }
            }

        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + ddPeriods.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.Delete(ClassTimeID, "stp_DeleteClassTimings", "@CTID");
                    LoadData();
                    MainClass.DisableReset(pnlDetails);
                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            MainClass.ShowMsg("Please, Press the Load Button to continue!", "Stop!", "Success");
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void LoadData()
        {
            clsSelection.SelectClasseTimings(dataGridView1, gvCTID, gvPeriodID, gvPeriod, gvShiftID, gvShiftName, gvLevelID, gvLevel, gvStartTime, gvEndTime, gvDay,Convert.ToInt32(ddLevel.SelectedValue));
            MainClass.SNO(dataGridView1, "gvSNo");
        }
        private void SearchData()
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectClasseTimings(dataGridView1, gvCTID, gvPeriodID, gvPeriod, gvShiftID, gvShiftName, gvLevelID, gvLevel, gvStartTime, gvEndTime, gvDay, Convert.ToInt32(ddLevel.SelectedValue), txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSNo");
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
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ClassTimeID = Convert.ToInt32(row.Cells["gvCTID"].Value.ToString());
                ddPeriods.SelectedValue = row.Cells["gvPeriodID"].Value;
                ddShift.SelectedValue = row.Cells["gvShiftID"].Value;
                ddLevel.SelectedValue = row.Cells["gvLevelID"].Value;
                dtStartTine.Value = Convert.ToDateTime(row.Cells["gvStartTime"].Value.ToString());
                dtEndtime.Value = Convert.ToDateTime(row.Cells["gvEndTime"].Value.ToString());
                ddDays.SelectedItem = row.Cells["gvDay"].Value.ToString();
                MainClass.Disable(pnlDetails);
            }
        }

    }
}
