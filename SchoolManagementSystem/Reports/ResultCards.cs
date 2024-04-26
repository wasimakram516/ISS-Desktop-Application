using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ResultCards : Sample
    {
        ReportDocument rd;
        public ResultCards()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MainClass.STAFFROLE == "Faculty")
            {
                dbFaculty obj = new dbFaculty();
                MainClass.ShowWindow(obj, this, MDI.ActiveForm);

            }
            else
            {
                dbReports obj = new SchoolManagementSystem.dbReports();
                MainClass.ShowWindow(obj, this, MDI.ActiveForm);
            }
        }

        private void ResultCards_Load(object sender, EventArgs e)
        {
            LoadList1();
        }

        private void LoadList1()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectSectionsWRTCampus", ddSection, "Name", "SectionID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectSectionsWRTCampus", ddSection1, "Name", "SectionID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectExamTypesWRTSession", ddExamType, "ExamName", "ExamTypeID", "@Session", dtSession.Value.Year);
        }
        private void LoadList2()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectClassesWRTLevels", ddClass, "Class", "ClassID", "@LevelID", Convert.ToInt32(ddLevel.SelectedValue));
        }
        private void LoadList3()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectClassesWRTLevels", ddClass1, "Class", "ClassID", "@LevelID", Convert.ToInt32(ddLevel.SelectedValue));
        }
        private void LoadList4()
        {
            MainClass.GetDropdownListWithFourParameters("stp_SelectStudentsWRT_Session_Class_Section", ddStudent, "StuName", "RegNo", "@Session", dtSession.Value.Year, "@ClassID", Convert.ToInt32(ddClass1.SelectedValue), "@SectionID", Convert.ToInt32(ddSection1.SelectedValue), "@ExamTypeID", Convert.ToInt32(ddExamType.SelectedValue));
        }
        private void LoadReport1(int Session, Int64 ExamTypeID, int LevelID,int ClassID,int SectionID)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetResultDetailsReportWRT_Level", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Session", Session);
                com.Parameters.AddWithValue("@ExamTypeID", ExamTypeID);
                com.Parameters.AddWithValue("@LevelID", LevelID);
                com.Parameters.AddWithValue("@ClassID", ClassID);
                com.Parameters.AddWithValue("@SectionID", SectionID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\ResultCardReport1.rpt");
                rd.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rd;
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception x)
            {
                MainClass.ShowMsg(x.Message, "Error", "Error");
                if (rd != null)
                {
                    rd.Close();
                }
            }
        }

        private void LoadReport2(int Session, Int64 ExamTypeID, int ClassID, int SectionID)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetResultDetailsReport", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Session", Session);
                com.Parameters.AddWithValue("@ExamTypeID", ExamTypeID);
                com.Parameters.AddWithValue("@ClassID", ClassID);
                com.Parameters.AddWithValue("@SectionID", SectionID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\ResultCardReport2.rpt");
                rd.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rd;
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception x)
            {
                MainClass.ShowMsg(x.Message, "Error", "Error");
                if (rd != null)
                {
                    rd.Close();
                }
            }
        }

        private void LoadReport3(int Session, Int64 ExamTypeID, int LevelID, int ClassID, int SectionID, Int64 RegNo)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetResultDetailsReportWRT_RegNo", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Session", Session);
                com.Parameters.AddWithValue("@ExamTypeID", ExamTypeID);
                com.Parameters.AddWithValue("@LevelID", LevelID);
                com.Parameters.AddWithValue("@ClassID", ClassID);
                com.Parameters.AddWithValue("@SectionID", SectionID);
                com.Parameters.AddWithValue("@RegNo", RegNo);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\ResultCardReport1.rpt");
                rd.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rd;
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception x)
            {
                MainClass.ShowMsg(x.Message, "Error", "Error");
                if (rd != null)
                {
                    rd.Close();
                }
            }
        }

        private void dtSession_ValueChanged(object sender, EventArgs e)
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectExamTypesWRTSession", ddExamType, "ExamName", "ExamTypeID", "@Session", dtSession.Value.Year);
        }

        private void ddExamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex == 0 || ddExamType.SelectedIndex == -1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
            if (ddExamType.SelectedIndex > 0 && ddClass1.SelectedIndex > 0 && ddSection1.SelectedIndex > 0)
            {
                LoadList4();
            }
        }

        private void ddLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; }else { errLevel.Visible = false; }

            if (ddLevel.SelectedIndex>0)
            {
                LoadList2();
                LoadList3();
            }
            else
            {
                ddClass.DataSource = null;
                ddClass1.DataSource = null;
            }
        }
        private void ddClass1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex > 0 && ddClass1.SelectedIndex > 0 && ddSection1.SelectedIndex > 0)
            {
                LoadList4();
            }
        }

        private void ddSection1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSection1.SelectedIndex>0)
            {
                ddClass.DataSource = null;
                ddSection.SelectedIndex = 0;
            }
            if (ddExamType.SelectedIndex > 0 && ddClass1.SelectedIndex > 0 && ddSection1.SelectedIndex > 0)
            {
                LoadList4();
            }
        }

        private void ddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex==0)
            {
                errSection.Visible = false;
                ddSection.SelectedIndex = 0;
            }

            if (ddClass.SelectedIndex > 0)
            {
                if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
            }
        }

        private void ddSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddClass.SelectedIndex>0)
            {
                if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
            }
            if (ddSection.SelectedIndex > 0)
            {
                ddSection1.SelectedIndex = 0;
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex == 0 || ddExamType.SelectedIndex == -1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex==-1)
            {
                ddSection.SelectedIndex = 0;
            }

            if (ddClass.SelectedIndex > 0)
            {
                if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
            }
            if (errExamType.Visible || errLevel.Visible || errSection.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                if (ddLevel.SelectedIndex>0 && ddSection1.SelectedIndex>0 && ddClass1.SelectedIndex>0 && ddStudent.SelectedIndex<=0)
                {
                    LoadReport1(dtSession.Value.Year, Convert.ToInt64(ddExamType.SelectedValue), Convert.ToInt32(ddLevel.SelectedValue), Convert.ToInt32(ddClass1.SelectedValue), Convert.ToInt32(ddSection1.SelectedValue));
                }

                else if (ddClass.SelectedIndex>0 && ddSection.SelectedIndex>0)
                {
                    LoadReport2(dtSession.Value.Year, Convert.ToInt64(ddExamType.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue));
                }
                else if (ddStudent.SelectedIndex>0)
                {
                    LoadReport3(dtSession.Value.Year, Convert.ToInt64(ddExamType.SelectedValue), Convert.ToInt32(ddLevel.SelectedValue), Convert.ToInt32(ddClass1.SelectedValue), Convert.ToInt32(ddSection1.SelectedValue),Convert.ToInt64(ddStudent.SelectedValue));
                }
                
            }
        }

        private void ResultCards_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }

        private void txtWhatsApp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ddStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddStudent.SelectedIndex == 0 || ddStudent.SelectedIndex == -1) { errStudent.Visible = true; }
            else
            {
                errStudent.Visible = false;

                string whatsapp = clsSelection.SelectStudentsWhatsAppNumber(Convert.ToInt64(ddStudent.SelectedValue));
                txtWhatsApp.Text = whatsapp;
            }
        }

        private void errStudent_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void errSection1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void errSection_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void errExamType_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void errLevel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void errClass_Click(object sender, EventArgs e)
        {

        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure, You want to send a WhatsaApp Message?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (txtWhatsApp.Text == "")
                {
                    MainClass.ShowMsg("WhatsApp Number isn't provided.", "Number Required", "Error");
                    txtWhatsApp.Focus();
                }
                else
                {
                    string toNumber = "+92" + txtWhatsApp.Text;
                    MainClass.SEND_WHATSAPP(toNumber, " ");
                }
            }
        }
    }
}
