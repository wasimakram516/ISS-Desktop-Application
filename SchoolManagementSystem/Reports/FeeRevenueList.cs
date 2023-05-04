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
    public partial class FeeRevenueList : Sample
    {
        public FeeRevenueList()
        {
            InitializeComponent();
        }

        ReportDocument rd;

        private void FeeRevenueList_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dbReports obj = new ISS.dbReports();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadReport(dtFrom.Value, dtTo.Value);
        }

        private void LoadReport(DateTime from, DateTime to)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetMonthlyRevenueListReport", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@From", from);
                com.Parameters.AddWithValue("@To", to);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\FeeRevenueReport.rpt");
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
