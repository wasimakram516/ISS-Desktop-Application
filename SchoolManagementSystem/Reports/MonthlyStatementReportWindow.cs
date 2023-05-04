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
    public partial class MonthlyStatementReportWindow : Sample
    {
        public MonthlyStatementReportWindow()
        {
            InitializeComponent();
        }
        ReportDocument rd;
        private void btnBack_Click(object sender, EventArgs e)
        {
            dbReports obj = new ISS.dbReports();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadReport(Convert.ToInt32(dtMonthYear.Value.Month), Convert.ToInt32(dtMonthYear.Value.Year));
        }

        private void LoadReport(int Month, int Year)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetMonthlyStatement_WRT_Month_Year", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Month", Month);
                com.Parameters.AddWithValue("@Year", Year);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\MonthlyStatement.rpt");
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
