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
    public partial class SchoolLeavingCertificateWindow : Sample
    {
        ReportDocument rd;
        
        public SchoolLeavingCertificateWindow()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dbReports obj = new SchoolManagementSystem.dbReports();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void SchoolLeavingCertificateWindow_Load(object sender, EventArgs e)
        {
            LoadList1();
        }

        private void LoadList1()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectExamTypesWRTSession", ddExamType, "ExamName", "ExamTypeID", "@Session", dtSession.Value.Year);
        }

        private void LoadReport( Int64 RegNo, Int64 ExamTypeID)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetSchoolLeavingCertificate", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@RegNo", RegNo);
                com.Parameters.AddWithValue("@ExamTypeID", ExamTypeID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\SchoolLeavingCertificateReport.rpt");
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
            LoadList1();
        }

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "") { errRegNo.Visible = true; }else { errRegNo.Visible = false; }
        }

        private void ddExamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex<1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "") { errRegNo.Visible = true; } else { errRegNo.Visible = false; }
            if (ddExamType.SelectedIndex < 1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
            if (errRegNo.Visible||errExamType.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                LoadReport( Convert.ToInt64(txtRegNo.Text), Convert.ToInt64(ddExamType.SelectedValue));
            }
        }

        private void SchoolLeavingCertificateWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }
    }
}
