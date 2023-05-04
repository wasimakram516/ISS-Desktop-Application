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
    public partial class dbReports : Sample
    {
        public dbReports()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dbPrincipal obj = new dbPrincipal();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnStudentLists_Click(object sender, EventArgs e)
        {
            ActiveStudentsReportWindow obj = new ActiveStudentsReportWindow();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnAdmissionForms_Click(object sender, EventArgs e)
        {
            AdmissionFormWindow obj = new AdmissionFormWindow();
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

        private void btnFeeVouchers_Click(object sender, EventArgs e)
        {
            FeeVoucherReportWindow obj = new FeeVoucherReportWindow();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnFeePayments_Click(object sender, EventArgs e)
        {
            FeePaymentReportWindow obj = new FeePaymentReportWindow();
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

        private void btnSchoolLeavingCertificates_Click(object sender, EventArgs e)
        {
            SchoolLeavingCertificateWindow obj = new SchoolLeavingCertificateWindow();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnExperienceLetters_Click(object sender, EventArgs e)
        {
            StaffLetters obj = new StaffLetters();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnSalarySlip_Click(object sender, EventArgs e)
        {
            SalaryReportWindow obj = new SalaryReportWindow();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnFeeDefaulter_Click(object sender, EventArgs e)
        {
            FeeDefaultersListWindow obj = new FeeDefaultersListWindow();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnDailyAttendance_Click(object sender, EventArgs e)
        {
            AttendanceReportWindowOverAll obj = new AttendanceReportWindowOverAll();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnRevenueLists_Click(object sender, EventArgs e)
        {
            FeeRevenueList obj = new FeeRevenueList();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnMonthlyStatement_Click(object sender, EventArgs e)
        {
            MonthlyStatementReportWindow obj = new MonthlyStatementReportWindow();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnIDCards_Click(object sender, EventArgs e)
        {
            IDCards obj = new IDCards();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }
    }
}
