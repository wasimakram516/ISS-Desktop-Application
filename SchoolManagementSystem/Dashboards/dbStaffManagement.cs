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
    public partial class dbStaffManagement : Sample
    {
        public dbStaffManagement()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dbPrincipal adm = new SchoolManagementSystem.dbPrincipal();
            MainClass.ShowWindow(adm, this, MDI.ActiveForm);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff ST = new SchoolManagementSystem.Staff();
            MainClass.ShowWindow(ST, this, MDI.ActiveForm);
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            Assignments asn = new SchoolManagementSystem.Assignments();
            MainClass.ShowWindow(asn, this, MDI.ActiveForm);
        }

        private void btnStaffAttendance_Click(object sender, EventArgs e)
        {
            StaffAttendance obj = new SchoolManagementSystem.StaffAttendance();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnSalaray_Click(object sender, EventArgs e)
        {
            StaffSalary obj = new SchoolManagementSystem.StaffSalary();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }
    }
}
