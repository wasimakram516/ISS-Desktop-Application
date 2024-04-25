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
    public partial class ExamDetails : Sample2
    {
        
        int edit = 0, check1, check2;
        float GrandTotal;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        public ExamDetails()
        {
            InitializeComponent();
        }

        private void ExamType_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            MainClass.DisableReset(pnlDetails);
            LoadList1();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbExaminations obj = new SchoolManagementSystem.dbExaminations();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
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
            if (ddExamType.SelectedIndex == 0 || ddExamType.SelectedIndex == -1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
        }

        private void ddLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddLevel.SelectedIndex > 0)
            {
                LoadList2();
            }
        }

        private void ddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }

            if (ddClass.SelectedIndex > 0)
            {
                LoadList3();
            }
        }

        private void ddSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
        }


        private void ddSubjexts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSubjects.SelectedIndex == -1 || ddSubjects.SelectedIndex == 0) { errSubject.Visible = true; } else { errSubject.Visible = false; }
        }

        private void dtExamDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtExamDate.Value.Date < DateTime.Now.Date) { errExamDate.Visible = true; } else { errExamDate.Visible = false; }
        }

        private void txtTotalMarks_TextChanged(object sender, EventArgs e)
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

        private void txtPassingPercent_TextChanged(object sender, EventArgs e)
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

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex == 0 || ddExamType.SelectedIndex == -1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
            if (ddSubjects.SelectedIndex == -1 || ddSubjects.SelectedIndex == 0) { errSubject.Visible = true; } else { errSubject.Visible = false; }
            if (dtExamDate.Value.Date < DateTime.Now.Date) { errExamDate.Visible = true; } else { errExamDate.Visible = false; }
            if (txtTotalMarks.Text == "") { errTotalMarks.Visible = true; } else { errTotalMarks.Visible = false; }
            if (txtPassingPercent.Text == "") { errPassingPercent.Visible = true; } else { errPassingPercent.Visible = false; }

            if (errExamType.Visible || errLevel.Visible || errClass.Visible || errSubject.Visible || errTotalMarks.Visible || errPassingPercent.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }

            if (errExamDate.Visible)
            {
                MainClass.ShowMsg("Invalid Exam Date!", "Error", "Error");
            }

            else
            {
                dataGridView1.Rows.Add(ddLevel.SelectedValue, ddLevel.Text, ddClass.SelectedValue, ddClass.Text, ddSection.SelectedValue, ddSection.Text, ddSubjects.SelectedValue, ddSubjects.Text, dtExamDate.Value, txtTotalMarks.Text, txtPassingPercent.Text);
                txtTotalMarks.Text = "";
                txtPassingPercent.Text = "";
                lblTotal.Text = dataGridView1.Rows.Count.ToString();
                ddSubjects.Focus();
            }

        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            GrandTotal = 0;
            MainClass.EnableReset(pnlDetails);
            LoadList1();
            GrandTotal = 0;
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex == 0 || ddExamType.SelectedIndex == -1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }

            if (errClass.Visible || errSection.Visible || errExamType.Visible || errLevel.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }

            else
            {
                if (edit == 0) //Code for save operation
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            GrandTotal = 0;

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                GrandTotal += Convert.ToSingle(row.Cells["gvTotalMarks"].Value);
                            }

                            check1 = clsInsertion.AddExams(Convert.ToInt64(ddExamType.SelectedValue), Convert.ToInt32(ddLevel.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), GrandTotal);

                            GrandTotal = 0;

                            if (check1 > 0)
                            {
                                Int64 ExamID = clsSelection.SelectExamID();

                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    check2 = clsInsertion.AddExamDetails(ExamID, Convert.ToInt32(row.Cells["gvSubjectID"].Value),
                                        Convert.ToDateTime(row.Cells["gvExamDate"].Value.ToString()),
                                        Convert.ToSingle(row.Cells["gvTotalMarks"].Value.ToString()),
                                        Convert.ToSingle(row.Cells["gvPassingPercent"].Value.ToString()));
                                }
                                if (check2 > 0)
                                {
                                    sc.Complete();
                                    GrandTotal = 0;
                                    MainClass.ShowMsg("Exam Details of " + lblTotal.Text + " Subject for " + ddExamType.Text + " added successfully!", "Success", "Success");
                                }
                            }

                            else
                            {
                                GrandTotal = 0;
                                MainClass.ShowMsg("You might have already saved record of this Class.\n\nIf yes, then you can't add it again.\n\nFor tecnical assistance, contact your developer", "Error", "Error");
                            }
                        }
                        dataGridView1.Rows.Clear();
                        MainClass.DisableReset(pnlDetails);
                        lblTotal.Text = "";
                        GrandTotal = 0;
                    }
                    else
                    {
                        GrandTotal = 0;
                        MainClass.ShowMsg("PLease, enter at least 1 subject to continue..", "Error", "Error");
                    }

                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            ExamDetailsView obj = new SchoolManagementSystem.ExamDetailsView();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 11)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    lblTotal.Text = (dataGridView1.Rows.Count - 1).ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }


    }
}
