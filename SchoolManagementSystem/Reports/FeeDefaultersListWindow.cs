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
    public partial class FeeDefaultersListWindow : Sample
    {
        public FeeDefaultersListWindow()
        {
            InitializeComponent();
        }
        ReportDocument rd;

        private void LoadList1()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
        }

        private void FeeDefaultersListWindow_Load(object sender, EventArgs e)
        {
            LoadList1();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dbReports obj = new ISS.dbReports();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void ddLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
        }

        private void LoadReport(int Session, int levelID)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetFeeDefaultersListWRTLevel", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Session", Session);
                com.Parameters.AddWithValue("@LevelID", levelID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\FeeDefaultersReport.rpt");
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (errLevel.Visible)
            {
                MainClass.ShowMsg("Fields with * are mendatory!", "Error", "Error");
            }
            else
            {
                LoadReport(dtSession.Value.Year, Convert.ToInt16(ddLevel.SelectedValue));
            }
        }
    }
}
