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
    public partial class dbStaffManagement : Sample
    {
        public dbStaffManagement()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dbPrincipal adm = new ISS.dbPrincipal();
            MainClass.ShowWindow(adm, this, MDI.ActiveForm);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff ST = new ISS.Staff();
            MainClass.ShowWindow(ST, this, MDI.ActiveForm);
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            Assignments asn = new ISS.Assignments();
            MainClass.ShowWindow(asn, this, MDI.ActiveForm);
        }

        private void btnStaffAttendance_Click(object sender, EventArgs e)
        {
            StaffAttendance obj = new ISS.StaffAttendance();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnSalaray_Click(object sender, EventArgs e)
        {
            StaffSalary obj = new ISS.StaffSalary();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }
    }
}
