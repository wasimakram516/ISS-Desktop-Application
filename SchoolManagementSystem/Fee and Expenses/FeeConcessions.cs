using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISS
{
    public partial class FeeConcessions : Sample2
    {
        
        int edit = 0;
        int FeeConcessionID;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        public FeeConcessions()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbFeeManagement stm = new ISS.dbFeeManagement();
            MainClass.ShowWindow(stm, this, MDI.ActiveForm);
        }

        private void FeeConcessions_Load(object sender, EventArgs e)
        {
            MainClass.Disable(pnlDetails);
            LoadList();
        }
        private void LoadList()
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


        private void ddClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; }
            else
            {
                errClass.Visible = false;
                if (ddClass.SelectedIndex > 0 && ddSection.SelectedIndex > 0)
                {
                    MainClass.GetDropdownListWithTwoParameters("stp_SelectStudentsFromAdmissions", ddStudent, "StuName", "RegNo", "@ClassID", Convert.ToInt32(ddClass.SelectedValue), "@SectionID", Convert.ToInt32(ddSection.SelectedValue));
                }
            }
        }

        private void ddSection_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ddSection.SelectedIndex == 0 || ddSection.SelectedIndex == -1) { errSection.Visible = true; }
            else
            {
                errSection.Visible = false;
                if (ddClass.SelectedIndex > 0 && ddSection.SelectedIndex > 0)
                {
                    MainClass.GetDropdownListWithTwoParameters("stp_SelectStudentsFromAdmissions", ddStudent, "StuName", "RegNo", "@ClassID", Convert.ToInt32(ddClass.SelectedValue), "@SectionID", Convert.ToInt32(ddSection.SelectedValue));
                }
            }
        }

        private void ddStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddStudent.SelectedIndex == 0 || ddStudent.SelectedIndex == -1) { errStudent.Visible = true; } else { errStudent.Visible = false; }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text=="") { errDiscount.Visible = true; } else { errDiscount.Visible = false; }
            if (txtDiscount.Text!="")
            {
                if (!rg.Match(txtDiscount.Text).Success)
                {
                    txtDiscount.Focus();
                    txtDiscount.Clear();
                }
            }
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            if (txtReason.Text == "") { errReason.Visible = true; } else { errReason.Visible = false; }
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
            if (ddSection.SelectedIndex == 0 || ddSection.SelectedIndex == -1) { errSection.Visible = true; } else { errSection.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddStudent.SelectedIndex == 0 || ddStudent.SelectedIndex == -1) { errStudent.Visible = true; } else { errStudent.Visible = false; }
            if (txtDiscount.Text == "") { errDiscount.Visible = true; } else { errDiscount.Visible = false; }
            if (txtReason.Text == "") { errReason.Visible = true; } else { errReason.Visible = false; }

            if (errClass.Visible || errSection.Visible|| errStudent.Visible||errDiscount.Visible||errReason.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                if (edit == 0)//code for save operation
                {
                        clsInsertion.AddFeeConcession(Convert.ToInt64(ddStudent.SelectedValue), Convert.ToSingle(txtDiscount.Text), txtReason.Text);
                        MainClass.DisableReset(pnlDetails);
                    LoadData();
                }
                else if (edit == 1)//code for update operation
                {
                    clsUpdation.UpdateFeeConcession(FeeConcessionID, Convert.ToSingle(txtDiscount.Text), txtReason.Text);
                    MainClass.DisableReset(pnlDetails);
                    LoadData();
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete Fee Concesssion for" + ddStudent.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                        clsDeletion.Delete(FeeConcessionID, "stp_DeleteFeeConcessions", "@FeeConcID");
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
            clsSelection.SelectFeeConcession(dataGridView1, gvFeeConcID,gvLevelID,gvLevel, gvClassID, gvClass, gvSectionID, gvSection, gvRegNo, gvStuName, gvDiscount, gvReason);
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        private void SearchData()
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectFeeConcession(dataGridView1, gvFeeConcID, gvLevelID, gvLevel, gvClassID, gvClass, gvSectionID, gvSection, gvRegNo, gvStuName, gvDiscount, gvReason,txtSearch.Text);
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
                MainClass.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                FeeConcessionID = Convert.ToInt32(row.Cells["gvFeeConcID"].Value.ToString());
                ddLevel.SelectedValue= row.Cells["gvLevelID"].Value;
                ddClass.SelectedValue = row.Cells["gvClassID"].Value;
                ddSection.SelectedValue = row.Cells["gvSectionID"].Value.ToString();
                ddStudent.SelectedValue = row.Cells["gvRegNo"].Value.ToString();
                txtDiscount.Text = row.Cells["gvDiscount"].Value.ToString();
                txtReason.Text = row.Cells["gvReason"].Value.ToString();
            }
        }
    }
}
