using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ExamDetailsView : Sample2
    {

        int edit = 0;
        int check1 = 0, check2 = 0;
        Int64 examID, examDetailID;
        float GrandTotal;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        public ExamDetailsView()
        {
            InitializeComponent();
        }


        public override void btnBack_Click(object sender, EventArgs e)
        {
            ExamDetails obj = new SchoolManagementSystem.ExamDetails();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void ExamDetailsView_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            MainClass.DisableReset(pnlDetails);
            LoadList1();
        }

        private void LoadList1()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectSectionsWRTCampus", ddSection, "Name", "SectionID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectExamTypesWRTSession", ddExamType, "ExamName", "ExamTypeID", "@Session", dtSession.Value.Year);
        }

        private void LoadList2()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectClassesWRTLevels", ddClass, "Class", "ClassID", "@LevelID", Convert.ToInt32(ddLevel.SelectedValue));
        }

        private void LoadList3()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectSubjectsWRTClasses", ddSubjects, "Subject", "SubjectID", "@ClassID", Convert.ToInt32(ddClass.SelectedValue));
        }

        private void dtSession_ValueChanged(object sender, EventArgs e)
        {
            LoadList1();
        }

        private void ddExamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex == 0 || ddExamType.SelectedIndex == -1) { errExamType.Visible = true; }
            else
            {
                errExamType.Visible = false;
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex == 0 || ddExamType.SelectedIndex == -1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
            if (errExamType.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                LoadData(dtSession.Value.Year, Convert.ToInt64(ddExamType.SelectedValue));
            }
        }

        private void ddLevel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }

            if (ddLevel.SelectedIndex > 0)
            {
                LoadList2();
            }
        }

        private void ddClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }

            if (ddClass.SelectedIndex > 0)
            {
                LoadList3();
            }
        }

        private void ddSection_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
        }

        private void ddSubjects_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ddSubjects.SelectedIndex == -1 || ddSubjects.SelectedIndex == 0) { errSubject.Visible = true; } else { errSubject.Visible = false; }
        }

        private void dtExamDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalMarks_TextChanged_1(object sender, EventArgs e)
        {
            if (txtTotalMarks.Text == "") { errTotalMarks.Visible = true; }
            else
            {
                errTotalMarks.Visible = false;

                if (!rg.Match(txtTotalMarks.Text).Success)
                {
                    txtTotalMarks.Focus();
                    txtTotalMarks.Text = "";
                }
            }
        }

        private void txtPassingPercent_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPassingPercent.Text == "") { errPassingPercent.Visible = true; }
            else
            {
                errPassingPercent.Visible = false;

                if (!rg.Match(txtPassingPercent.Text).Success)
                {
                    txtPassingPercent.Focus();
                    txtPassingPercent.Text = "";
                }
            }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.EnableReset(pnlDetails);
            LoadList1();
            GrandTotal = 0;
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(pnlDetails);
            GrandTotal = 0;
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex == 0 || ddExamType.SelectedIndex == -1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
            if (ddSubjects.SelectedIndex == -1 || ddSubjects.SelectedIndex == 0) { errSubject.Visible = true; } else { errSubject.Visible = false; }
            if (txtTotalMarks.Text == "") { errTotalMarks.Visible = true; } else { errTotalMarks.Visible = false; }
            if (txtPassingPercent.Text == "") { errPassingPercent.Visible = true; } else { errPassingPercent.Visible = false; }

            if (errExamType.Visible || errLevel.Visible || errClass.Visible || errSection.Visible || errSubject.Visible || errTotalMarks.Visible || errPassingPercent.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }

            else
            {
                if (edit == 0) //Code for save operation
                {
                    MainClass.ShowMsg("PLease, navigate to the previous window to add new record!", "Error", "Error");
                }
                else if (edit == 1) //Code for update operation
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            GrandTotal = 0;
                            check1 = clsUpdation.UpdateExamDetails(examDetailID, Convert.ToInt32(ddSubjects.SelectedValue), dtExamDate.Value, Convert.ToSingle(txtTotalMarks.Text), Convert.ToSingle(txtPassingPercent.Text));
                            LoadData(dtSession.Value.Year, Convert.ToInt64(ddExamType.SelectedValue));
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (Convert.ToInt64(row.Cells["gvExamID"].Value.ToString()) == examID)
                                {
                                    GrandTotal += Convert.ToSingle(row.Cells["gvTotalMarks"].Value);
                                }
                            }
                            check2 = clsUpdation.UpdateExams(examID, Convert.ToInt64(ddExamType.SelectedValue), Convert.ToInt32(ddLevel.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), GrandTotal);

                            GrandTotal = 0;
                            sc.Complete();

                        }
                        if (check1 > 0 && check2 > 0)
                        {
                            MainClass.ShowMsg("Exam Details of " + ddSubjects.Text + " updated successfully!", "Success", "Success");
                           
                            MainClass.Disable(pnlDetails);
                        }
                    }
                    else
                    {
                        MainClass.ShowMsg("PLease, select at least 1 subject to continue..", "Error", "Error");
                    }
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, You want to delete?\n\nIf you proceed, Exam details for " + ddClass.Text + " will be deleted.\n\nYou may update this detail either.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.Delete(examID, "stp_DeleteExamDetails", "@ExamID");
                    LoadData(dtSession.Value.Year, Convert.ToInt64(ddExamType.SelectedValue));
                    MainClass.DisableReset(pnlDetails);
                }
            }

        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex < 1)
            {
                MessageBox.Show("Please, Select An Exam to Load Records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LoadData(dtSession.Value.Year, Convert.ToInt64(ddExamType.SelectedValue));
            }

        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex < 1)
            {
                MessageBox.Show("Please, Select An Exam to Load Records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SearchData(txtSearch.Text, dtSession.Value.Year, Convert.ToInt64(ddExamType.SelectedValue));
            }

        }

        private void LoadData(int session, Int64 Examtype)
        {
            clsSelection.SelectExamDetails(dataGridView1, gvExamTypeID, gvExamName, gvExamID, gvExamDetailID, gvLevelID, gvLevel, gvClassiD, gvClass, gvSectionID, gvSection, gvSubjectID, gvSubject, gvExamDate, gvTotalMarks, gvPassingPercent, session, Examtype);
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        private void SearchData(string text, int session, Int64 Examtype)
        {
            if (txtSearch.Text != "")
            {
                clsSelection.SelectExamDetails(dataGridView1, gvExamTypeID, gvExamName, gvExamID, gvExamDetailID, gvLevelID, gvLevel, gvClassiD, gvClass, gvSectionID, gvSection, gvSubjectID, gvSubject, gvExamDate, gvTotalMarks, gvPassingPercent, session, Examtype, text);
                MainClass.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                LoadData(dtSession.Value.Year, Convert.ToInt64(ddExamType.SelectedValue));
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                examID = Convert.ToInt64(row.Cells["gvExamID"].Value.ToString());
                examDetailID = Convert.ToInt64(row.Cells["gvExamDetailID"].Value.ToString());
                ddExamType.SelectedValue = row.Cells["gvExamTypeID"].Value.ToString();
                ddLevel.SelectedValue = row.Cells["gvLevelID"].Value.ToString();
                ddClass.SelectedValue = row.Cells["gvClassiD"].Value.ToString();
                ddSection.SelectedValue = row.Cells["gvSectionID"].Value.ToString();
                ddSubjects.SelectedValue = row.Cells["gvSubjectID"].Value.ToString();
                dtExamDate.Value = Convert.ToDateTime(row.Cells["gvExamDate"].Value.ToString());
                txtTotalMarks.Text = row.Cells["gvTotalMarks"].Value.ToString();
                txtPassingPercent.Text = row.Cells["gvPassingPercent"].Value.ToString();
            }
        }
    }
}
