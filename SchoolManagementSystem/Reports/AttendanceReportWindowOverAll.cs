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
    public partial class AttendanceReportWindowOverAll : Sample
    {
        ReportDocument rd;

        public AttendanceReportWindowOverAll()
        {
            InitializeComponent();
        }

        private void AttendanceReportWindowOverAll_Load(object sender, EventArgs e)
        {
            LoadList1();
        }

        private void LoadList1()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectSectionsWRTCampus", ddSection, "Name", "SectionID", "@CampusID", MainClass.CAMPUSID);
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
            if (ddSection.SelectedIndex < 1)
            {
                errSection.Visible = true;
            }
            else
            {
                errSection.Visible = false;
            }
            if ( errSection.Visible)
            {
                MainClass.ShowMsg("Fields with * are mendatory!", "Error", "Error");
            }
            else
            {
                LoadReport(dateTimePicker1.Value, Convert.ToInt32(ddSection.SelectedValue));
            }
        }

        private void LoadReport(DateTime date,int sectioID)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetOverAllAttendanceReportWRTDate", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Date", date);
                com.Parameters.AddWithValue("@SectionID", sectioID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\AttendanceReportDaily.rpt");
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
    }
}
