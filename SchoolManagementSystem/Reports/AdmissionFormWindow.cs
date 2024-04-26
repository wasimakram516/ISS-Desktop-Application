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
    public partial class AdmissionFormWindow : Sample
    {
        ReportDocument rd;
        public AdmissionFormWindow()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dbReports obj = new SchoolManagementSystem.dbReports();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void AdmissionFormWindow_Load(object sender, EventArgs e)
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

        private void LoadList3()
        {
            MainClass.GetDropdownListWithThreeParameters("stp_SelectStudentWRTClassAndSection", ddStudent, "StuName", "RegNo", "@Session", dtSession.Value.Year, "@ClassID", Convert.ToInt32(ddClass.SelectedValue), "@SectionID", Convert.ToInt32(ddSection.SelectedValue));
        }

        private void LoadReport(int Session, Int64 RegNo)
        {
            try
            {
                rd = new ReportDocument();
                SqlCommand com = new SqlCommand("stp_GetAdmissionFormReport", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Session", Session);
                com.Parameters.AddWithValue("@RegNo", RegNo);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\AdmissionFormReport.rpt");
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
                LoadList3();
            }
            else
            {
                ddClass.DataSource = null;
            }
        }

        private void ddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; }
            else
            {
                errClass.Visible = false;
                LoadList3();
            }
        }

        private void ddSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
            if ( ddClass.SelectedIndex > 0 && ddSection.SelectedIndex > 0)
            {
                LoadList3();
            }
        }

        private void ddStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddStudent.SelectedIndex == 0 || ddStudent.SelectedIndex == -1) { errStudent.Visible = true; }
            else
            {
                errStudent.Visible = false;

                string whatsapp = clsSelection.SelectStudentsWhatsAppNumber(Convert.ToInt64(ddStudent.SelectedValue));
                txtWhatsApp.Text = whatsapp;
            }
        }

        private void btnAdmissionForm_Click(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex == -1 || ddSection.SelectedIndex == 0) { errSection.Visible = true; } else { errSection.Visible = false; }
            if (ddStudent.SelectedIndex == 0 || ddStudent.SelectedIndex == -1) { errStudent.Visible = true; } else { errStudent.Visible = false; }
            if (errLevel.Visible || errClass.Visible || errSection.Visible || errStudent.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                LoadReport(dtSession.Value.Year, Convert.ToInt64(ddStudent.SelectedValue));
            }
        }

        private void AdmissionFormWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure, You want to send a WhatsaApp Message?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (txtWhatsApp.Text == "")
                {
                    MainClass.ShowMsg("WhatsApp Number isn't provided.", "Number Required", "Error");
                    txtWhatsApp.Focus();
                }
                else
                {
                    string toNumber = "+92" + txtWhatsApp.Text;
                    MainClass.SEND_WHATSAPP(toNumber, " ");
                }
            }
        }
    }
}
