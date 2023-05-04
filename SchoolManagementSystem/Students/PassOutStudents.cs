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
    public partial class PassOutStudents : Sample2
    {
        

        public PassOutStudents()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbStudemtManagement obj = new ISS.dbStudemtManagement();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void PassOutStudents_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            MainClass.DisableReset(pnlDetails);
            LoadList1();
        }

        private void LoadList1()
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

        private void ddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
        }

        private void ddSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }

            if (errLevel.Visible || errClass.Visible || errSection.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            clsSelection.SelectPassoutStudents(dataGridView1, gvLeftID, gvSession, gvCampusID, gvCampus, gvRegNo, gvStuName, gvGender, gvFatherName, gvPhone1, gvPhone2,
                gvAddress, gvLevelID, gvLevel, gvClassID, gvClass, gvSectionID, gvSection, gvAdmissionDate, gvPassoutDate, dtSession.Value.Year,
                Convert.ToInt32(ddLevel.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue));

            MainClass.SNO(dataGridView1, "gvSNO");
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.EnableReset(pnlDetails);
            LoadList1();
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please, Press the Load Button to Load Records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectPassoutStudents(dataGridView1, gvLeftID, gvSession, gvCampusID, gvCampus, gvRegNo, gvStuName, gvGender, gvFatherName, gvPhone1, gvPhone2,
                gvAddress, gvLevelID, gvLevel, gvClassID, gvClass, gvSectionID, gvSection, gvAdmissionDate, gvPassoutDate, dtSession.Value.Year,
                Convert.ToInt32(ddLevel.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue),txtSearch.Text);

                MainClass.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                LoadData();
            }
        }
    }
}

