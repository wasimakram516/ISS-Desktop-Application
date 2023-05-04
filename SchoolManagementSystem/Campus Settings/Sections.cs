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
    public partial class Sections : Sample2
    {
        
        int edit = 0;
        int SectionID;

        public Sections()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbCampusManagement cm = new ISS.dbCampusManagement();
            MainClass.ShowWindow(cm, this, MDI.ActiveForm);
        }

        private void Sections_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
        }

        private void txtSectionName_TextChanged(object sender, EventArgs e)
        {
            if (txtSectionName.Text == "") { errSectionname.Visible = true; } else { errSectionname.Visible = false; }

        }

        private void ddStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }

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
           
            if (txtSectionName.Text == "") { errSectionname.Visible = true; } else { errSectionname.Visible = false; }
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
            if (errStatus.Visible || errStatus.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                int Stat = 0;
                if (ddStatus.SelectedIndex == 0)
                {
                    Stat = 1;
                }
                else
                {
                    Stat = 0;
                }
                if (edit == 0)//code for save operation
                {
                        clsInsertion.AddSections(MainClass.CAMPUSID, txtSectionName.Text, Convert.ToByte(Stat));
                        LoadData();
                        MainClass.DisableReset(pnlDetails);
                }

                else if (edit == 1)//code for update operation
                {
                        clsUpdation.UpdateSections(SectionID, MainClass.CAMPUSID, txtSectionName.Text, Convert.ToByte(Stat));
                        LoadData();
                        MainClass.DisableReset(pnlDetails);
                }
            }

        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtSectionName.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.Delete(SectionID, "stp_DeleteSections", "@SectionID");
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
            clsSelection.SelectSections(dataGridView1, gvSectionID, gvCampusID, gvCampus, gvSectionName,gvSectionStatus,MainClass.CAMPUSID);
            MainClass.SNO(dataGridView1, "gvSerialNo");
        }
        private void SearchData()
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectSections(dataGridView1, gvSectionID, gvCampusID, gvCampus, gvSectionName, gvSectionStatus, MainClass.CAMPUSID,txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSerialNo");
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
                SectionID = Convert.ToInt32(row.Cells["gvSectionID"].Value.ToString());
                txtSectionName.Text = row.Cells["gvSectionName"].Value.ToString();
                ddStatus.SelectedItem = row.Cells["gvSectionStatus"].Value.ToString();
            }
        }

    }
}
    