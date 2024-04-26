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
    public partial class Periods : Sample2
    {
        
        int edit = 0;
        int periodID;

        public Periods()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbCampusManagement cm = new SchoolManagementSystem.dbCampusManagement();
            MainClass.ShowWindow(cm, this, MDI.ActiveForm);
        }

        private void Periods_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
        }

        private void txtPeriod_TextChanged(object sender, EventArgs e)
        {
            if (txtPeriod.Text == "") { errPeriods.Visible = true; } else { errPeriods.Visible = false; }
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
            if (txtPeriod.Text == "") { errPeriods.Visible = true; } else { errPeriods.Visible = false; }
            if (errPeriods.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                if (edit == 0)//code for save operation
                {
                    clsInsertion.AddPeriods(txtPeriod.Text);
                    LoadData();
                    MainClass.DisableReset(pnlDetails);
                }
                else if (edit == 1)//code for update operation
                {
                    clsUpdation.UpdatePeriods(periodID, txtPeriod.Text);
                    LoadData();
                    MainClass.DisableReset(pnlDetails);
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtPeriod.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.Delete(periodID, "stp_DeletePeriods", "@PeriodID");
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
            clsSelection.SelectPeriods(dataGridView1, gvPeriodID, gvPeriod);
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        private void SearchData()
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectPeriods(dataGridView1, gvPeriodID, gvPeriod,txtSearch.Text);
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
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                periodID = Convert.ToInt32(row.Cells["gvPeriodID"].Value.ToString());
                txtPeriod.Text = row.Cells["gvPeriod"].Value.ToString();
                MainClass.Disable(pnlDetails);
            }
        }
    }
}
