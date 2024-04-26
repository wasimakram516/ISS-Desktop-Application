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
    public partial class dbStudemtManagement : Sample
    {
        public dbStudemtManagement()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dbPrincipal adm = new SchoolManagementSystem.dbPrincipal();
            MainClass.ShowWindow(adm, this, MDI.ActiveForm);
        }

        private void btnAdmissions_Click(object sender, EventArgs e)
        {
            Admissions ad = new SchoolManagementSystem.Admissions();
            MainClass.ShowWindow(ad, this, MDI.ActiveForm);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Attendance obj = new SchoolManagementSystem.Attendance();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            ActiveStudents obj = new SchoolManagementSystem.ActiveStudents();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnPassoutStudents_Click(object sender, EventArgs e)
        {
            PassOutStudents obj = new SchoolManagementSystem.PassOutStudents();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnLeftStudents_Click(object sender, EventArgs e)
        {
            LeftStudents obj = new SchoolManagementSystem.LeftStudents();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

       
    }
}
