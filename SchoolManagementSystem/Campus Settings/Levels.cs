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
    public partial class Levels : Sample2
    {
        
        int edit = 0;
        int LevelID;

        public Levels()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbCampusManagement cm = new ISS.dbCampusManagement();
            MainClass.ShowWindow(cm, this, MDI.ActiveForm);
        }

        private void Levels_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
        }

        private void txtLevel_TextChanged(object sender, EventArgs e)
        {
            if (txtLevel.Text == "") { errLevel.Visible = true; } else { errLevel.Visible = false; }
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

            if (txtLevel.Text == "") { errLevel.Visible = true; } else { errLevel.Visible = false; }

            if (errLevel.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                if (edit == 0)//code for save operation
                {
                    clsInsertion.AddLevels(txtLevel.Text, MainClass.CAMPUSID);
                    LoadData();
                    MainClass.DisableReset(pnlDetails);
                }
                else if (edit == 1)//code for update operation
                {
                    clsUpdation.UpdateLevels(LevelID, txtLevel.Text, MainClass.CAMPUSID);
                    LoadData();
                    MainClass.DisableReset(pnlDetails);

                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtLevel.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.Delete(LevelID, "stp_DeleteLevels", "@LevelID");
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
            clsSelection.SelectLevels(dataGridView1, gvCampusID, gvCampus, gvLevelID, gvLevel, MainClass.CAMPUSID);
            MainClass.SNO(dataGridView1, "gvSerialNo");
        }

        private void SearchData()
        {
            if (txtSearch.Text != "")
            {
                clsSelection.SelectLevels(dataGridView1, gvCampusID, gvCampus, gvLevelID, gvLevel, MainClass.CAMPUSID, txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSerialNo");
            }
            else
            {
                clsSelection.SelectLevels(dataGridView1, gvCampusID, gvCampus, gvLevelID, gvLevel, MainClass.CAMPUSID);
                MainClass.SNO(dataGridView1, "gvSerialNo");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                edit = 1;
                MainClass.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                LevelID = Convert.ToInt32(row.Cells["gvLevelID"].Value.ToString());
                txtLevel.Text = row.Cells["gvLevel"].Value.ToString();
            }
        }


    }
}
