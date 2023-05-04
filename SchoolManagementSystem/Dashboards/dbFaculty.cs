using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISS
{
    public partial class dbFaculty : Sample
    {
        public dbFaculty()
        {
            InitializeComponent();
        }

        private void LinkBtnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure, You want to logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Login log = new ISS.Login();
                MainClass.ShowWindow(log, this, MDI.ActiveForm);
            }
        }

        private void btnStudentLists_Click(object sender, EventArgs e)
        {
            ActiveStudentsReportWindow obj = new ActiveStudentsReportWindow();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceReportWindow obj = new AttendanceReportWindow();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            TimetableReportWindow obj = new TimetableReportWindow();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnDateSheets_Click(object sender, EventArgs e)
        {
            DateSheetWindow obj = new DateSheetWindow();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnResultCards_Click(object sender, EventArgs e)
        {
            ResultCards obj = new ResultCards();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnExperienceLetters_Click(object sender, EventArgs e)
        {
            StaffLetters obj = new StaffLetters();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }
    }
}
