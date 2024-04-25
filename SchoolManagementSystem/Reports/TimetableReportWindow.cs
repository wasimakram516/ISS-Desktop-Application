using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class TimetableReportWindow : Sample
    {
        
        ReportDocument rd;
        public TimetableReportWindow()
        {
            InitializeComponent();
        }

        private void LoadList1()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectFacultyFromStaffWRTCampus", ddFaculty, "Staff", "StaffID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectSectionsWRTCampus", ddSection, "Name", "SectionID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectSectionsWRTCampus", ddSection2, "Name", "SectionID", "@CampusID", MainClass.CAMPUSID);
        }
        private void LoadList2()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectClassesWRTLevels", ddClass, "Class", "ClassID", "@LevelID", Convert.ToInt32(ddLevel.SelectedValue));
        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            LoadList1();
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
                dbReports stm = new SchoolManagementSystem.dbReports();
                MainClass.ShowWindow(stm, this, MDI.ActiveForm);
            }
        }

        //private void loadReport(int? ClassID, int? SectionID, int? FacultyID)
        //{
        //    try
        //    {
        //        rd = new ReportDocument();
        //        var data = obj.stp_GetTimeTableReport(ClassID, SectionID, FacultyID);
        //        rd.Load(Application.StartupPath + "\\Reports\\TimeTableReport.rpt");
        //        rd.SetDataSource(data.ToList());
        //        crystalReportViewer1.ReportSource = rd;
        //        crystalReportViewer1.RefreshReport();
        //    }
        //    catch (Exception x)
        //    {
        //        clsMainClass.ShowMsg(x.Message, "ERROR", "Error");
        //        if (rd!=null)
        //        {
        //            rd.Close();
        //        }
        //    } 
        //}

        private void loadReport(int ClassID, int SectionID)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetTimeTableReportWRTClassAndSection", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ClassID", ClassID);
                com.Parameters.AddWithValue("@SectionID", SectionID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\TimeTableReport.rpt");
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

        private void loadReport2(int FaculyID)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetTimeTableReportWRTFaculty", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@FacultyID", FaculyID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\TimeTableReport2.rpt");
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

        //private void loadReport2(int SectionID)
        //{
        //    try
        //    {
        //        rd = new ReportDocument();
        //        var data = obj.stp_GetTimeTableReportWRTSection(SectionID);
        //        rd.Load(Application.StartupPath + "\\Reports\\TimeTableReport2.rpt");
        //        rd.SetDataSource(data.ToList());
        //        crystalReportViewer1.ReportSource = rd;
        //        crystalReportViewer1.RefreshReport();
        //    }
        //    catch (Exception x)
        //    {
        //        clsMainClass.ShowMsg(x.Message, "ERROR", "Error");
        //        if (rd != null)
        //        {
        //            rd.Close();
        //        }
        //    }
        //}


        private void loadReport3(int SectionID)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetTimeTableReportWRTSection", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@SectionID", SectionID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\TimeTableReport3.rpt");
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

        private void Timetable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }

        private void LnkbtnReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ddLevel.SelectedIndex = 0;
            if (ddLevel.SelectedIndex>0)
            {

                ddClass.SelectedIndex = 0;
            }
            else
            {

                ddClass.SelectedIndex = -1;
            }
            ddSection.SelectedIndex = 0;
            ddFaculty.SelectedIndex = 0;
            ddSection2.SelectedIndex = 0;
        }

        private void ddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex>0)
            {
                ddFaculty.SelectedIndex = 0;
                ddSection2.SelectedIndex = 0;
            }
        }

        private void ddSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSection.SelectedIndex > 0)
            {
                ddFaculty.SelectedIndex = 0;
                ddSection2.SelectedIndex = 0;
            }
        }

        private void ddFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddFaculty.SelectedIndex > 0)
            {
                ddLevel.SelectedIndex = 0;
                ddSection.SelectedIndex = 0;
                ddSection2.SelectedIndex = 0;
            }
        }

        private void ddSection2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSection2.SelectedIndex > 0)
            {
                ddLevel.SelectedIndex = 0;
                ddSection.SelectedIndex = 0;
                ddFaculty.SelectedIndex = 0;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex > 0 && ddSection.SelectedIndex > 0)
            {
                loadReport(Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue));
            }
            else if (ddFaculty.SelectedIndex > 0)
            {
                loadReport2(Convert.ToInt32(ddFaculty.SelectedValue));
            }
            else if (ddSection2.SelectedIndex > 0)
            {
                loadReport3(Convert.ToInt32(ddSection2.SelectedValue));
            }
            else
            {
                MainClass.ShowMsg("You can Load TimeTable by selecting either Class + Section , by Faculty or by Section Only!", "ERROR", "Error");
            }
        }

        private void ddLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex > 0)
            {
                LoadList2();
            }
            else
            {
                ddClass.DataSource = null;
            }
        }
    }
}
