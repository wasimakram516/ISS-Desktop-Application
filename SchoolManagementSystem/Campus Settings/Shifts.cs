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
    public partial class Shifts : Sample2
    {
        
        int edit = 0;
        int ShiftID;
        public Shifts()
        {
            InitializeComponent();
        }


        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbCampusManagement cm = new ISS.dbCampusManagement();
            MainClass.ShowWindow(cm, this, MDI.ActiveForm);
        }

        private void Shifts_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
        }

        private void txtShiftName_TextChanged(object sender, EventArgs e)
        {
            if (txtShiftName.Text == "") { errShiftName.Visible = true; } else { errShiftName.Visible = false; }
        }

        private void dtStartTine_ValueChanged(object sender, EventArgs e)
        {
            if (dtStartTine.Value > dtEndtime.Value) { errStart.Visible = true; } else { errStart.Visible = false; }
        }
        private void dtEndtime_ValueChanged(object sender, EventArgs e)
        {
            if (dtStartTine.Value > dtEndtime.Value) { errStart.Visible = true; } else { errStart.Visible = false; }
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

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (txtShiftName.Text == "") { errShiftName.Visible = true; } else { errShiftName.Visible = false; }
            if (errStart.Visible || errEnd.Visible) { MainClass.ShowMsg("Starting time should be less than the Ending time!", "Error", "Error"); }

            else if (errShiftName.Visible || errStart.Visible || errEnd.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                if (edit == 0)//code for save operation
                {
                    TimeSpan startTime = new TimeSpan(dtStartTine.Value.Hour, dtStartTine.Value.Minute, dtStartTine.Value.Second);
                    TimeSpan EndTime = new TimeSpan(dtEndtime.Value.Hour, dtEndtime.Value.Minute, dtEndtime.Value.Second);
                    clsInsertion.AddShifts(MainClass.CAMPUSID, txtShiftName.Text, startTime, EndTime);
                    LoadData();
                    MainClass.DisableReset(pnlDetails);

                }

                else if (edit == 1)//code for update operation
                {
                    TimeSpan startTime = new TimeSpan(dtStartTine.Value.Hour, dtStartTine.Value.Minute, dtStartTine.Value.Second);
                    TimeSpan EndTime = new TimeSpan(dtEndtime.Value.Hour, dtEndtime.Value.Minute, dtEndtime.Value.Second);
                    clsUpdation.UpdateShifts(ShiftID, txtShiftName.Text, startTime, EndTime);
                    LoadData();
                    MainClass.DisableReset(pnlDetails);

                }
            }

        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtShiftName.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.Delete(ShiftID, "stp_DeleteShifts", "@ShiftID");
                    MainClass.DisableReset(pnlDetails);
                    LoadData();
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
            clsSelection.SelectShifts(dataGridView1, gvShiftID, gvCampusID, gvCampus, gvShiftName, gvStartTime, gvEndTime);
            MainClass.SNO(dataGridView1, "gvSNo");
        }
        private void SearchData()
        {
            if (txtSearch.Text != "")
            {
                clsSelection.SelectShifts(dataGridView1, gvShiftID, gvCampusID, gvCampus, gvShiftName, gvStartTime, gvEndTime, txtSearch.Text);
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
                MainClass.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ShiftID = Convert.ToInt32(row.Cells["gvShiftID"].Value.ToString());
                txtShiftName.Text = row.Cells["gvShiftName"].Value.ToString();
                dtStartTine.Value = Convert.ToDateTime(row.Cells["gvStartTime"].Value.ToString());
                dtEndtime.Value = Convert.ToDateTime(row.Cells["gvEndTime"].Value.ToString());
            }
        }


    }
}
