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
    public partial class FeePaymentReportWindow : Sample
    {
        
        ReportDocument rd;
        public FeePaymentReportWindow()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dbReports obj = new ISS.dbReports();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void FeePaymentReportWindow_Load(object sender, EventArgs e)
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

        private void LoadReport(int Session,int clsID, int secID, byte month, Int16 year)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetFeeVouchersWRTClass", MainClass.con);
                com.CommandType = CommandType.StoredProcedure; 
                com.Parameters.AddWithValue("@Session", Session);
                com.Parameters.AddWithValue("@ClassID", clsID);
                com.Parameters.AddWithValue("@SectionID", secID);
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@Year", year);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\FeePaymentReport.rpt");
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
            if (errLevel.Visible || errClass.Visible || errSection.Visible)
            {
                MainClass.ShowMsg("Fields with * are mendatory!", "Error", "Error");
            }
            else
            {
                LoadReport(dtSession.Value.Year,Convert.ToInt16(ddClass.SelectedValue), Convert.ToInt16(ddSection.SelectedValue), Convert.ToByte(dateTimePicker1.Value.Month), Convert.ToInt16(dateTimePicker1.Value.Year));
            }
        }

        private void FeePaymentReportWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }

     
    }
}
