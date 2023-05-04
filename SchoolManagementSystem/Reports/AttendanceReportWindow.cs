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
    public partial class AttendanceReportWindow : Sample
    {
        
        ReportDocument rd;
        public AttendanceReportWindow()
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

        private void AttendanceReportWindow_Load(object sender, EventArgs e)
        {
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

        private void LoadReport(int clsID, int secID, byte month, Int16 year)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetAttendanceReportMonthly", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ClassID", clsID);
                com.Parameters.AddWithValue("@SectionID", secID);
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@Year", year);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\AttendanceReportMonthly.rpt");
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
            if (ddClass.SelectedIndex < 1)
            {
                errClass.Visible = true;
            }
            else
            {
                errClass.Visible = false;
            }
        }

        private void ddSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSection.SelectedIndex < 1)
            {
                errSection.Visible = true;
            }
            else
            {
                errSection.Visible = false;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex < 1)
            {
                errClass.Visible = true;
            }
            else
            {
                errClass.Visible = false;
            }
            if (ddSection.SelectedIndex < 1)
            {
                errSection.Visible = true;
            }
            else
            {
                errSection.Visible = false;
            }
            if (errClass.Visible || errSection.Visible)
            {
                MainClass.ShowMsg("Fields with * are mendatory!", "Error", "Error");
            }
            else
            {
                LoadReport(Convert.ToInt16(ddClass.SelectedValue), Convert.ToInt16(ddSection.SelectedValue), Convert.ToByte(dateTimePicker1.Value.Month), Convert.ToInt16(dateTimePicker1.Value.Year));
            }
        }

        private void AttendanceReportWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }

    }
}
