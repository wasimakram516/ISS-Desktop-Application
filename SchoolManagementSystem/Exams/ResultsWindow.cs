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

namespace ISS
{
    public partial class ResultsWindow : Sample2
    {
        int SuccessCount;
        float GObtained = 0, GPercentage = 0, GTotal = 0;
        string GGrade;
        public float passingPercentage = 0;

        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        public ResultsWindow()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbExaminations obj = new ISS.dbExaminations();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void ResultsWindow_Load(object sender, EventArgs e)
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
            MainClass.GetDropdownListWithThreeParameters("stp_SelectSubjectsFromsExamDetails", ddSubject, "Subject", "SubjectID", "@ExamTypeID", Convert.ToInt64(ddExamType.SelectedValue), "@ClassID", Convert.ToInt32(ddClass.SelectedValue), "@SectionID", Convert.ToInt32(ddSection.SelectedValue));
            MainClass.GetDropdownListWithFourParameters("[stp_SelectStudentsWRT_Level_Session_Class_Section_And_Status]", ddStudent, "RegNoStuName", "RegNo", "@LevelID", Convert.ToInt32(ddLevel.SelectedValue), "@ClassID", Convert.ToInt32(ddClass.SelectedValue), "@SectionID", Convert.ToInt32(ddSection.SelectedValue), "@Session",dtSession.Value.Year);
        }
        
        private string GradeCalculator(double p)
        {
            if (p <= passingPercentage)
            {
                return "F";
            }

            else if (p >= 80 && p <= 100)
            {
                return "A+";
            }

            else if (p >= 70 && p < 80)
            {
                return "A";
            }

            else if (p >= 60 && p < 70)
            {
                return "B";
            }

            else if (p >= 50 && p < 60)
            {
                return "C";
            }

            else if (p >= 40 && p < 50)
            {
                return "D";
            }

            else
            {
                return "";
            }
        }

        private void dtSession_ValueChanged(object sender, EventArgs e)
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectExamTypesWRTSession", ddExamType, "ExamName", "ExamTypeID", "@Session", dtSession.Value.Year);
        }

        private void ddExamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex == 0 || ddExamType.SelectedIndex == -1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
            if (ddExamType.SelectedIndex > 0 && ddClass.SelectedIndex > 0 && ddSection.SelectedIndex > 0)
            {
                LoadList3();
            }
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
            if (ddExamType.SelectedIndex > 0 && ddClass.SelectedIndex > 0 && ddSection.SelectedIndex > 0)
            {
                LoadList3();
            }
        }

        private void ddStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddStudent.SelectedIndex == 0 || ddStudent.SelectedIndex == -1) { errStudent.Visible = true; } else { errStudent.Visible = false; }
        }

        private void txtGrandremarks_TextChanged(object sender, EventArgs e)
        {
            if (txtGrandremarks.Text == "") { errGrandRemarks.Visible = true; } else { errGrandRemarks.Visible = false; }
        }

        private void ddSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSubject.SelectedIndex == 0 || ddSubject.SelectedIndex == -1) { errSubject.Visible = true; }

            else
            {
                errSubject.Visible = false;

                passingPercentage= clsSelection.SelectPassingPercentage(Convert.ToInt32(ddSubject.SelectedValue), Convert.ToInt64(ddExamType.SelectedValue));

                var Total = clsSelection.SelectTotalMarksFromsExamDetails(Convert.ToInt64(ddExamType.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), Convert.ToInt32(ddSubject.SelectedValue));
                txtPassPercent.Text = passingPercentage.ToString();
                txtTotalMarks.Text = Total.ToString();
            }
        }

        private void txtObtainedMarks_TextChanged(object sender, EventArgs e)
            {
            if (txtObtainedMarks.Text == "") { errObtainedMarks.Visible = true; }
            else
            {
                errObtainedMarks.Visible = false;
                
                if (!rg.Match(txtObtainedMarks.Text).Success)
                {
                    txtObtainedMarks.Focus();
                    txtObtainedMarks.Text = "";
                }
                else
                {
                    if (Convert.ToSingle( txtObtainedMarks.Text)> Convert.ToSingle(txtTotalMarks.Text))
                    {
                        txtObtainedMarks.Focus();
                        txtObtainedMarks.Text = "";
                    }
                    else
                    {
                        float p = (Convert.ToSingle(txtObtainedMarks.Text) / Convert.ToSingle(txtTotalMarks.Text)) * 100;
                        txtPercentage.Text = p.ToString();
                        txtGrade.Text = GradeCalculator(p).ToString();
                    }
                   
                }
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex == 0 || ddExamType.SelectedIndex == -1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
            if (ddStudent.SelectedIndex == 0 || ddStudent.SelectedIndex == -1) { errStudent.Visible = true; } else { errStudent.Visible = false; }
            if (txtGrandremarks.Text == "") { errGrandRemarks.Visible = true; } else { errGrandRemarks.Visible = false; }
            if (ddSubject.SelectedIndex == 0 || ddSubject.SelectedIndex == -1) { errSubject.Visible = true; } else { errSubject.Visible = false; }
            if (txtObtainedMarks.Text == "") { errObtainedMarks.Visible = true; } else { errObtainedMarks.Visible = false; }

            if (errExamType.Visible || errLevel.Visible || errClass.Visible || errGrandRemarks.Visible || errSection.Visible || errSubject.Visible || errStudent.Visible || errObtainedMarks.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }

            else
            {
                dataGridView1.Rows.Add(ddStudent.Text, ddSubject.SelectedValue, ddSubject.Text, txtTotalMarks.Text, txtObtainedMarks.Text);

                txtTotalMarks.Text = "";
                txtObtainedMarks.Text = "";
                lblTotal.Text = dataGridView1.Rows.Count.ToString();
                ddSubject.Focus();
            }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.EnableReset(pnlDetails);
            txtPassPercent.Enabled = false;
            txtTotalMarks.Enabled = false;
            txtPercentage.Enabled = false;
            txtGrade.Enabled = false;
            LoadList1();
        }
        
        public override void btnSave_Click(object sender, EventArgs e)  //  code for save operation
        {
            if (ddExamType.SelectedIndex == 0 || ddExamType.SelectedIndex == -1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
            if (ddStudent.SelectedIndex == 0 || ddStudent.SelectedIndex == -1) { errStudent.Visible = true; } else { errStudent.Visible = false; }
            if (txtGrandremarks.Text == "") { errGrandRemarks.Visible = true; } else { errGrandRemarks.Visible = false; }
            if (ddSubject.SelectedIndex == 0 || ddSubject.SelectedIndex == -1) { errSubject.Visible = true; } else { errSubject.Visible = false; }

            if (errExamType.Visible || errLevel.Visible || errClass.Visible || errSection.Visible || errSubject.Visible || errStudent.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else if (dataGridView1.Rows.Count < ddSubject.Items.Count - 1 || dataGridView1.Rows.Count > ddSubject.Items.Count - 1)
            {
                MainClass.ShowMsg("No. of Subjects included in Exam should be equal to the No. of Subjects for Result!", "Error", "Error");
            }
            else
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            GTotal += Convert.ToSingle(row.Cells["gvTotal"].Value);
                            GObtained += Convert.ToSingle(row.Cells["gvObtained"].Value);
                        }

                        GPercentage = (GObtained / GTotal) * 100;
                        GGrade = GradeCalculator(GPercentage);

                        int chkResults = clsInsertion.AddResults(Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), Convert.ToInt64(ddExamType.SelectedValue), Convert.ToInt64(ddStudent.SelectedValue), GObtained, GPercentage, GGrade, txtGrandremarks.Text,0);

                        GTotal = 0;
                        GObtained = 0;
                        GPercentage = 0;
                        GGrade = "";

                        if (chkResults > 0)
                        {
                            Int64 ResultID = clsSelection.SelectResultID();

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                //Percantage and grade calculator
                                double percent = (Convert.ToSingle(row.Cells["gvObtained"].Value.ToString()) / Convert.ToSingle(row.Cells["gvTotal"].Value.ToString())) * 100;
                                string Grade = GradeCalculator(percent);

                                int checkDetail = clsInsertion.AddResultDetails(ResultID,  Convert.ToInt32(row.Cells["gvSubjectID"].Value.ToString()), Convert.ToSingle(row.Cells["gvObtained"].Value.ToString()), percent, Grade,"");

                                if (checkDetail > 0)
                                {
                                    SuccessCount++;
                                    percent = 0;
                                    Grade = "";
                                }

                            }
                        }

                        if (SuccessCount > 0)
                        {
                            MainClass.ShowMsg(SuccessCount + " Subject's Marks of " + ddStudent.Text + " Added Successfully!", "Success", "Success");

                            SuccessCount = 0;
                            dataGridView1.Rows.Clear();
                            lblTotal.Text = "";
                            txtGrandremarks.Text = "";
                            ddSubject.SelectedIndex = 0;
                            txtTotalMarks.Text = "";
                            txtObtainedMarks.Text = "";
                            ddStudent.Focus();
                        }
                    }
                    catch (Exception x)
                    {
                        MainClass.ShowMsg(x.Message, "Error", "Error");
                    }
                    sc.Complete();
                }
            }
        }
        
        public override void btnView_Click(object sender, EventArgs e)
        {
            ResultsView obj = new ISS.ResultsView();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    lblTotal.Text = (dataGridView1.Rows.Count - 1).ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
    }
}
