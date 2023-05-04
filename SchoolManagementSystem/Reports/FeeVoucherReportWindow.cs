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
    public partial class FeeVoucherReportWindow : Sample
    {
        Regex rgPhone = new Regex("^[0-9]*$");                  //    3001234567
        Regex rgCNIC = new Regex("^(\\d{5}-\\d{7}-\\d)$");
        ReportDocument rd;
        public FeeVoucherReportWindow()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dbReports obj = new ISS.dbReports();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void FeeVoucherReportWindow_Load(object sender, EventArgs e)
        {
            LoadList1();
            chkStudent.Checked = true;
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
        }
        
        private void LoadReport(int Session,int clsID, int secID,int month,int year)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetFeeVouchersReportWRTClass", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Session", Session);
                com.Parameters.AddWithValue("@ClassID", clsID);
                com.Parameters.AddWithValue("@SectionID", secID);
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@Year", year);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\FeeVouchersReport.rpt");
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

        private void LoadReport2(string Phone)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetFeeVouchersReportWRTFather", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Phone", Phone);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\FeeVouchersReportWRTFather.rpt");
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
            if (errClass.Visible||errSection.Visible)
            {
                MainClass.ShowMsg("Fields with * are mendatory!", "Error", "Error");
            }
            else
            {
                LoadReport(dtSession.Value.Year,Convert.ToInt16(ddClass.SelectedValue), Convert.ToInt16(ddSection.SelectedValue),dtMonthYear.Value.Month,dtMonthYear.Value.Year);
            }
        }

        private void FeeVoucherReportWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }

        private void chkStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStudent.Checked)
            {
                chkFather.Checked = false;
                pnlFather.Visible = false;
                pnlStudent.Visible = true;
            }
        }

        private void chkFather_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFather.Checked)
            {
                chkStudent.Checked = false;
                pnlStudent.Visible = false;
                pnlFather.Visible = true;
            }
        }
        
        private void txtFatherPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtFatherPhone.Text != "")
            {
                if (txtFatherPhone.TextLength != 10)
                {
                    txtFatherPhone.Focus();
                    MainClass.ShowMsg("A Phone number must have 10 digits!", "Error", "Error");
                    txtFatherPhone.SelectAll();
                }
                if (!rgPhone.Match(txtFatherPhone.Text).Success)
                {
                    txtFatherPhone.Focus();
                    MainClass.ShowMsg("Invalid!\n\nType in this format 3001234567", "Error", "Error");
                    txtFatherPhone.SelectAll();
                }
            }
        }

        private void btnLoad2_Click(object sender, EventArgs e)
        {
            if (txtFatherPhone.Text!="")
            {
                LoadReport2(txtFatherPhone.Text);
            }
            else
            {
                MainClass.ShowMsg("Please, Enter phone number to load voucher!", "Stoped", "Success");
            }
        }
    }

}
