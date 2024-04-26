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
    public partial class dbNotifications : Sample
    {
        public dbNotifications()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MainClass.STAFFROLE == "Admin")
            {
                dbAdmin hom = new SchoolManagementSystem.dbAdmin();
                MainClass.ShowWindow(hom, this, MDI.ActiveForm);
            }
            else if (MainClass.STAFFROLE == "Principal")
            {
                dbPrincipal ad = new SchoolManagementSystem.dbPrincipal();
                MainClass.ShowWindow(ad, this, MDI.ActiveForm);
            }
            else
            {
                Login obj = new Login();
                MainClass.ShowWindow(obj, this, MDI.ActiveForm);
            }

        }

        private void btnAbsentMessages_Click(object sender, EventArgs e)
        {
            AbsentNotifications ad = new SchoolManagementSystem.AbsentNotifications();
            MainClass.ShowWindow(ad, this, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          SMS.ManualNotifications obj= new SchoolManagementSystem.SMS.ManualNotifications();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }
    }
}
