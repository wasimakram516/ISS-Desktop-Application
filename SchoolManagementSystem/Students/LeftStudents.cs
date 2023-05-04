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

namespace ISS
{
    public partial class LeftStudents : Sample2
    {
        Int64 RegNo;
        int edit = 0, count = 0;
        private int checkStudent;
        private int CheckLeftStudent;

        public LeftStudents()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbStudemtManagement obj = new ISS.dbStudemtManagement();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void LeftStudents_Load(object sender, EventArgs e)
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

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.EnableReset(pnlDetails);
            LoadList1();
        }


        public override void btnView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please, Press the Load Button to Load Records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadData()
        {
            clsSelection.SelectLeftStudents(dataGridView1, gvLeftID, gvSession, gvCampusID, gvCampus, gvRegNo, gvStuName, gvGender, gvFatherName, gvPhone1, gvPhone2,
                gvAddress, gvLevelID, gvLevel, gvClassID, gvClass, gvSectionID, gvSection, gvAdmissionDate, gvLeftDate, dtSession.Value.Year,
                Convert.ToInt32(ddLevel.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue));

            MainClass.SNO(dataGridView1, "gvSNO");
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex == 0 || ddSection.SelectedIndex == -1) { errSection.Visible = true; } else { errSection.Visible = false; }

            if (errLevel.Visible || errSection.Visible || errClass.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    if (ddStatus.SelectedIndex > -1)
                    {
                        DialogResult dr = MessageBox.Show("Are you sure, you want to proceed ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                checkStudent = 1;
                                if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                                {
                                    try
                                    {
                                        using (TransactionScope sc = new TransactionScope())
                                        {
                                            clsUpdation.UpdateStudentStatus(Convert.ToInt64(row.Cells["gvRegNo"].Value), 1);
                                            clsDeletion.Delete(Convert.ToInt64(row.Cells["gvRegNo"].Value), "stp_DeleteLeftStudents", "@RegNo");
                                            sc.Complete();
                                            count = 1;
                                        }

                                    }
                                    catch (Exception x)
                                    {
                                        MainClass.ShowMsg(x.Message, "Error", "Error");
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
                                ddStatus.SelectedIndex = -1;
                                lblStatus.Visible = false;
                                ddStatus.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                clsSelection.SelectLeftStudents(dataGridView1, gvLeftID, gvSession, gvCampusID, gvCampus, gvRegNo, gvStuName, gvGender, gvFatherName, gvPhone1, gvPhone2,
                gvAddress, gvLevelID, gvLevel, gvClassID, gvClass, gvSectionID, gvSection, gvAdmissionDate, gvLeftDate, dtSession.Value.Year,
                Convert.ToInt32(ddLevel.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), txtSearch.Text);

                MainClass.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                LoadData();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void errLevel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                lblStatus.Visible = true;
                ddStatus.Visible = true;
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

