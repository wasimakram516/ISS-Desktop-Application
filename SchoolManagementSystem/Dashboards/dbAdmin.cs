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
    public partial class dbAdmin : Sample
    {
        public dbAdmin()
        {
            InitializeComponent();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Attendance obj = new ISS.Attendance();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnStaffAttendance_Click(object sender, EventArgs e)
        {
            StaffAttendance obj = new ISS.StaffAttendance();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            dbNotifications obj = new dbNotifications();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            dbExaminations obj = new dbExaminations();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnBirthdays_Click(object sender, EventArgs e)
        {
            Birthdays obj = new Birthdays();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
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
    }
}
