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

namespace ISS
{
    public partial class ActiveStudentsReportWindow : Sample
    {
        ReportDocument rd;
        public ActiveStudentsReportWindow()
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
                dbReports obj = new ISS.dbReports();
                MainClass.ShowWindow(obj, this, MDI.ActiveForm);
            }
        }

        private void ActiveStudentsReportWindow_Load(object sender, EventArgs e)
        {
            LoadList1();
        }

        private void LoadReport1(int session,int ClassID, int SectionID)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetStudentReportWRTStatusActive", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@ClassID", ClassID);
                com.Parameters.AddWithValue("@SectionID", SectionID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\StudentsContactList.rpt");
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

        private void LoadReport2(int session, int ClassID, int SectionID)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetStudentReportWRTStatusActive", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@ClassID", ClassID);
                com.Parameters.AddWithValue("@SectionID", SectionID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\StudentsNameList.rpt");
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

        private void LoadReport3(int session, int ClassID, int SectionID)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetStudentReportWRTStatusActive", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@ClassID", ClassID);
                com.Parameters.AddWithValue("@SectionID", SectionID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\StudentsResultList.rpt");
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

        private void LoadReport4(int session, int ClassID, int SectionID)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetStudentReportWRTStatusActive", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@ClassID", ClassID);
                com.Parameters.AddWithValue("@SectionID", SectionID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\StudentsResultCards.rpt");
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
            if (errLevel.Visible || errClass.Visible ||errSection.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!","Error","Error");
            }
            else
            {
                if (chkContactList.Checked)
                {
                    LoadReport1( Convert.ToInt32(dtSession.Value.Year),Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue));
                }
                else if(chkNameList.Checked)
                {
                    LoadReport2(Convert.ToInt32(dtSession.Value.Year), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue));
                }
                else if (chkResultList.Checked)
                {
                    LoadReport3(Convert.ToInt32(dtSession.Value.Year), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue));
                }
                else if (chkResultCards.Checked)
                {
                    LoadReport4(Convert.ToInt32(dtSession.Value.Year), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue));
                }
                else
                {
                    MainClass.ShowMsg("Please, Select a list to load!", "Stoped", "Success");
                }
            }
        }

        private void ActiveStudentsReportWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }

        private void chkContactList_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContactList.Checked)
            {
                chkNameList.Checked = false;
                chkResultList.Checked = false;
                chkResultCards.Checked = false;
            }
        }

        private void chkNameList_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNameList.Checked)
            {
                chkContactList.Checked = false;
                chkResultList.Checked = false;
                chkResultCards.Checked = false;
            }
        }

        private void chkResultList_CheckedChanged(object sender, EventArgs e)
        {
            if (chkResultList.Checked)
            {
                chkNameList.Checked = false;
                chkContactList.Checked = false;
                chkResultCards.Checked = false;
            }
        }

        private void chkResultCards_CheckedChanged(object sender, EventArgs e)
        {
            if (chkResultCards.Checked)
            {
                chkNameList.Checked = false;
                chkContactList.Checked = false;
                chkResultList.Checked = false;
            }
        }
    }
}
