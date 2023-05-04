using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISS
{
    public partial class StaffLetters : Sample
    {
        Regex rgCNIC = new Regex("^(\\d{5}-\\d{7}-\\d)$");
        ReportDocument rd;

        public StaffLetters()
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

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtCNIC.Text=="")
            {
                errCNIC.Visible = true;
            }
            else
            {
                errCNIC.Visible = false;
            }
        }

        private void txtCNIC_Validating(object sender, CancelEventArgs e)
        {
            if (txtCNIC.Text!="")
            {
                if (!rgCNIC.Match(txtCNIC.Text).Success)
                {
                    txtCNIC.Focus();
                    txtCNIC.SelectAll();
                    MainClass.ShowMsg("Invalid Format!\n\nWrite in this format : 12345-1234567-1", "Error", "error");
                }
            }
        }

        private void LoadReport1(string CNIC)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetTeacherExperienceLetter", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CNIC", CNIC);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\ExperienceLetterReport.rpt");
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

        private void LoadReport2(string CNIC)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetTeacherExperienceLetter", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CNIC", CNIC);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\AppointmentLetterReport.rpt");
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
        private void ExperienceLetters_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }

        private void chkExperience_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExperience.Checked)
            {
                chkAppointment.Checked = false;
            }
        }

        private void chkAppointment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAppointment.Checked)
            {
                chkExperience.Checked = false;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (chkExperience.Checked)
            {
                LoadReport1(txtCNIC.Text);
            }
            else if (chkAppointment.Checked)
            {
                LoadReport2(txtCNIC.Text);
            }
        }
    }
}
