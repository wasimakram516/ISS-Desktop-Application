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
    public partial class ResultsView : Sample2
    {
        
        Int64 ResultID, ResultDetailID;
        int edit;
        float GObtained = 0, GPercentage = 0, GTotal = 0, passingPercentage=0;
        string GGrade;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        Regex rgNumber = new Regex("^[0-9]*$");

        public ResultsView()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            ResultsWindow obj = new SchoolManagementSystem.ResultsWindow();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void ResultsView_Load(object sender, EventArgs e)
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
            MainClass.GetDropdownListWithFourParameters("stp_SelectStudentsWRT_Session_Class_Section", ddStudent, "StuName", "RegNo", "@Session", dtSession.Value.Year, "@ClassID", Convert.ToInt32(ddClass.SelectedValue), "@SectionID", Convert.ToInt32(ddSection.SelectedValue), "@ExamTypeID", Convert.ToInt32(ddExamType.SelectedValue));
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
                LoadList3();
            }
            else
            {
                ddClass.DataSource = null;
            }
        }

        private void ddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddExamType.SelectedIndex > 0 && ddClass.SelectedIndex > 0 && ddSection.SelectedIndex > 0)
            {
                LoadList3();
            }
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
                if (ddExamType.SelectedIndex > 0 && ddClass.SelectedIndex > 0 && ddSection.SelectedIndex > 0)
                {
                    passingPercentage = clsSelection.SelectPassingPercentage(Convert.ToInt32(ddSubject.SelectedValue), Convert.ToInt64(ddExamType.SelectedValue));

                    float Total = clsSelection.SelectTotalMarksFromsExamDetails(Convert.ToInt64(ddExamType.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), Convert.ToInt32(ddSubject.SelectedValue));
                    txtPassPercent.Text = passingPercentage.ToString();
                    txtTotalMarks.Text = Total.ToString();
                }
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
                    if (Convert.ToSingle(txtObtainedMarks.Text) > Convert.ToSingle(txtTotalMarks.Text))
                    {
                        txtObtainedMarks.Focus();
                        txtObtainedMarks.Text = "";
                    }
                    else
                    {
                        double Percent = (Convert.ToSingle(txtObtainedMarks.Text) / Convert.ToSingle(txtTotalMarks.Text)) * 100;
                        txtPercentage.Text = Percent.ToString();

                        string Grade = GradeCalculator(Percent);
                        txtGrade.Text = Grade;
                    }
                }
            }
        }
        
        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            if (!rgNumber.Match(txtPosition.Text).Success)
            {
                txtPosition.Focus();
                txtPosition.Text = "";
            }
        }


        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex == 0 || ddExamType.SelectedIndex == -1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }

            if (errExamType.Visible || errLevel.Visible || errClass.Visible || errSection.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                LoadList3();
                LoadData();
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
            GTotal = 0;
            GObtained = 0;
            GPercentage = 0;
            GGrade = "";
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            MainClass.Enable(pnlDetails);
            txtPassPercent.Enabled = false;
            txtTotalMarks.Enabled = false;
            txtPercentage.Enabled = false;
            txtGrade.Enabled = false;
            edit = 1;
            GTotal = 0;
            GObtained = 0;
            GPercentage = 0;
            GGrade = "";
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex == 0 || ddExamType.SelectedIndex == -1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
            if (ddStudent.SelectedIndex == 0 || ddStudent.SelectedIndex == -1) { errStudent.Visible = true; } else { errStudent.Visible = false; }
            if (txtGrandremarks.Text == "") { errGrandRemarks.Visible = true; } else { errGrandRemarks.Visible = false; }
            if (ddSubject.SelectedIndex == 0 || ddSubject.SelectedIndex == -1) { errSubject.Visible = true; } else { errSubject.Visible = false; }
            if (txtObtainedMarks.Text == "") { errObtainedMarks.Visible = true; } else { errObtainedMarks.Visible = false; }
            

            if (errExamType.Visible || errLevel.Visible || errClass.Visible || errGrandRemarks.Visible || errSection.Visible || errSubject.Visible || errStudent.Visible | errObtainedMarks.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }

            else 
            {
                if (edit==1)
                {
                    try
                    {
                        int checkRsltDtls = clsUpdation.UpdateResultDetails(ResultDetailID, Convert.ToSingle(txtObtainedMarks.Text), Convert.ToSingle(txtPercentage.Text), txtGrade.Text,"");

                        LoadData();

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (Convert.ToInt64(row.Cells["gvResultID"].Value) == ResultID)
                            {
                                GTotal += Convert.ToSingle(row.Cells["gvTotal"].Value);
                                GObtained += Convert.ToSingle(row.Cells["gvObtained"].Value);
                            }
                        }

                        GPercentage = (GObtained / GTotal) * 100;
                        GGrade = GradeCalculator(GPercentage);
                        int position = 0;
                        if (txtPosition.Text=="")
                        {
                            position = 0;
                        }
                        else
                        {
                            position = Convert.ToInt32(txtPosition.Text);
                        }
                        int checkReslt = clsUpdation.UpdateResults(ResultID, GObtained, GPercentage, GGrade, txtGrandremarks.Text,position);

                        GTotal = 0;
                        GObtained = 0;
                        GPercentage = 0;
                        GGrade = "";
                        if (checkReslt > 0 && checkRsltDtls > 0)
                        {
                            MainClass.ShowMsg("Result of " + ddStudent.Text + " Updated Successfully!", "Success", "Success");
                            LoadData();
                        }
                    }
                    catch (Exception x)
                    {
                        MainClass.ShowMsg(x.Message, "Error", "Error");
                    }
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit==1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, You want to delete Result of " + ddStudent.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.Delete(ResultID, "stp_DeleteResults", "@ResultID");
                    LoadData();
                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please, Press the Load Button to Load Records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void LoadData()
        {
            clsSelection.SelectResultDetails(dataGridView1, gvResultID, gvResultDetailID, gvRegNo, GvStuName, gvSubjectID, gvSubject, gvTotal, gvObtained, gvPercentage,
                gvGrade, gvRemarks, gvGrandObtained, gvGrandpercentage, gvGrandGrade, gvGrandRemarks,gvPosition, dtSession.Value.Year, Convert.ToInt64(ddExamType.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue));
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        private void SearchData()
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectResultDetails(dataGridView1, gvResultID, gvResultDetailID, gvRegNo, GvStuName, gvSubjectID, gvSubject, gvTotal, gvObtained, gvPercentage,
               gvGrade, gvRemarks, gvGrandObtained, gvGrandpercentage, gvGrandGrade, gvGrandRemarks, gvPosition, dtSession.Value.Year, Convert.ToInt64(ddExamType.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue),txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                MainClass.Disable(pnlDetails);
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ResultID = Convert.ToInt64(row.Cells["gvResultID"].Value.ToString());
                ResultDetailID = Convert.ToInt64(row.Cells["gvResultDetailID"].Value.ToString());
                ddStudent.SelectedValue = row.Cells["gvRegNo"].Value;
                txtGrandremarks.Text = row.Cells["gvGrandRemarks"].Value.ToString();
                ddSubject.SelectedValue = row.Cells["gvSubjectID"].Value;
                txtTotalMarks.Text = row.Cells["gvTotal"].Value.ToString();
                txtObtainedMarks.Text = row.Cells["gvObtained"].Value.ToString();
                txtPercentage.Text = row.Cells["gvPercentage"].Value.ToString();
                txtGrade.Text = row.Cells["gvGrade"].Value.ToString();
                txtPosition.Text = row.Cells["gvPosition"].Value.ToString();
            }
        }
    }
}

