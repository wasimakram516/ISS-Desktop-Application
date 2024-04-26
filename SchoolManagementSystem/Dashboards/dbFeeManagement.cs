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
    public partial class dbFeeManagement : Sample
    {
        public dbFeeManagement()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dbPrincipal ad = new SchoolManagementSystem.dbPrincipal();
            MainClass.ShowWindow(ad, this, MDI.ActiveForm);
        }

        private void btnPaymentMethods_Click(object sender, EventArgs e)
        {
            PaymentMethod pm = new SchoolManagementSystem.PaymentMethod();
            MainClass.ShowWindow(pm, this, MDI.ActiveForm);
        }

        private void btnFeeStructure_Click(object sender, EventArgs e)
        {
            FeeStructure fs = new SchoolManagementSystem.FeeStructure();
            MainClass.ShowWindow(fs, this, MDI.ActiveForm);
        }

        private void btnFeeConcession_Click(object sender, EventArgs e)
        {
            FeeConcessions fc = new FeeConcessions();
            MainClass.ShowWindow(fc, this, MDI.ActiveForm);
        }

        private void btnFeeVouchers_Click(object sender, EventArgs e)
        {
            FeeVoucher fv = new FeeVoucher();
            MainClass.ShowWindow(fv, this, MDI.ActiveForm);
        }

        private void btnFeePayments_Click(object sender, EventArgs e)
        {
            FeePayments obj = new SchoolManagementSystem.FeePayments();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }
    }
}
