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
    public partial class DateSheetWindow : Sample
    {
        ReportDocument rd;
        

        public DateSheetWindow()
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

        private void DateSheetWindow_Load(object sender, EventArgs e)
        {
            LoadList1();
        }
        private void LoadList1()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectExamTypesWRTSession", ddExamType, "ExamName", "ExamTypeID", "@Session", dtSession.Value.Year);
        }

        private void LoadReport(int Session, Int64 ExamTypeID)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetDateSheetWRTSession", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Session", Session);
                com.Parameters.AddWithValue("@ExamTypeID", ExamTypeID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\DateSheetReport.rpt");
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

        private void ddExamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex < 1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
        }

        private void btnDateSheet_Click(object sender, EventArgs e)
        {
            if (ddExamType.SelectedIndex < 1) { errExamType.Visible = true; } else { errExamType.Visible = false; }
            if (errExamType.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                LoadReport(dtSession.Value.Year, Convert.ToInt64(ddExamType.SelectedValue));
            }
        }

        private void DateSheetWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }
    }
}
