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
    public partial class Subjects : Sample2
    {
        
        int edit=0,SubjectID;

        public Subjects()
        {
            InitializeComponent();
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
            LoadList();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbCampusManagement obj = new SchoolManagementSystem.dbCampusManagement();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void LoadList()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
        }

        private void ddLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddLevel.SelectedIndex>0)
            {
                MainClass.GetDropdownListWithOneParameters("stp_SelectClassesWRTLevels", ddClass, "Class", "ClassID", "@LevelID", Convert.ToInt32(ddLevel.SelectedValue));
            }
        }

        private void ddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {
            if (txtSubject.Text=="") { errSubject.Visible = true; } else { errSubject.Visible = false; }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (errLevel.Visible || errClass.Visible)
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
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (txtSubject.Text == "") { errSubject.Visible = true; } else { errSubject.Visible = false; }
            if (errLevel.Visible || errSubject.Visible ||errClass.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                if (edit == 0)//code for save operation
                {
                        clsInsertion.AddSubjects(Convert.ToInt32(ddLevel.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), txtSubject.Text);
                        LoadData();
                        MainClass.DisableReset(pnlDetails);

                }
                else if (edit == 1)//code for update operation
                {
                        clsUpdation.UpdateSubjects(SubjectID, Convert.ToInt32(ddLevel.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), txtSubject.Text);
                        LoadData();
                        MainClass.DisableReset(pnlDetails);
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtSubject.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                        clsDeletion.Delete(SubjectID, "stp_DeleteSubjects", "@SubjectID");
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
            clsSelection.SelectSubjects(dataGridView1, gvClassID, gvClassName, gvLevelID, gvLevel, gvSubjectID, gvSubject,Convert.ToInt32( ddClass.SelectedValue));
            MainClass.SNO(dataGridView1, "gvSerialNo");
        }


        private void SearchData()
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectSubjects(dataGridView1, gvClassID, gvClassName, gvLevelID, gvLevel, gvSubjectID, gvSubject, Convert.ToInt32(ddClass.SelectedValue), txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSerialNo");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SubjectID = Convert.ToInt32(row.Cells["gvSubjectID"].Value.ToString());
                txtSubject.Text = row.Cells["gvSubject"].Value.ToString();
                ddLevel.SelectedValue = row.Cells["gvLevelID"].Value.ToString();
                ddClass.SelectedValue = row.Cells["gvClassID"].Value.ToString();
                MainClass.Disable(pnlDetails);
            }
        }
    }
}
