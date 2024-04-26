using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class dbPrincipal : Sample
    {
        public dbPrincipal()
        {
            InitializeComponent();
        }

        int check = 0;
        private void dbAdmin_Load(object sender, EventArgs e)
        {
            label1.Text = MainClass.STAFFROLE + " Dashboard";
            
            check= clsSelection.SelectCheckStudentBirthday(Convert.ToInt32(DateTime.Now.Day), Convert.ToInt32(DateTime.Now.Month));
            if (check==1)
            {
                btnBirthdays.Image = Properties.Resources.Birthday_gift;
            }
            else
            {
                btnBirthdays.Image = Properties.Resources.Birthday_cake;
            }
        }

        private void btnCampusManagement_Click(object sender, EventArgs e)
        {
            dbCampusManagement cm = new dbCampusManagement();
            MainClass.ShowWindow(cm, this, MDI.ActiveForm);
        }

        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            dbStaffManagement STM = new SchoolManagementSystem.dbStaffManagement();
            MainClass.ShowWindow(STM, this, MDI.ActiveForm);
        }

        private void btnFeeManagement_Click(object sender, EventArgs e)
        {
            dbFeeManagement fm = new dbFeeManagement();
            MainClass.ShowWindow(fm, this, MDI.ActiveForm);
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            dbStudemtManagement sm = new dbStudemtManagement();
            MainClass.ShowWindow(sm, this, MDI.ActiveForm);
        }

        private void LinkBtnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure, You want to logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Login log = new SchoolManagementSystem.Login();
                MainClass.ShowWindow(log, this, MDI.ActiveForm);
            }
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            dbExaminations obj = new dbExaminations();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            dbReports obj = new dbReports();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            dbNotifications obj = new dbNotifications();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            dbExpenditures obj = new dbExpenditures();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnBirthdays_Click(object sender, EventArgs e)
        {
            Birthdays obj = new Birthdays();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }
    }
}
