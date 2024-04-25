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
    public partial class FeeVoucher : Sample2
    {
        
        int edit = 0;
        int chkStudent, chkVouher, GenerateVoucher = 0, ReGenerateVoucher = 0,LATE;
        Int16 AdmFee, AbsentFee, BooksFee, ExamsFee, MiscFee, LateFee;
        string exception;
        private int chkFeeVoucherWRTClass = 0;
        private int checkFeeVouchersWRTRegNO = 0;
        string[] FEE = new string[2];

        string[] PRESENTFEE = new string[8];
        Int64 FeeVoucerID = 0;

        public FeeVoucher()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbFeeManagement stm = new SchoolManagementSystem.dbFeeManagement();
            MainClass.ShowWindow(stm, this, MDI.ActiveForm);
        }

        private void FeeVoucher_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            MainClass.DisableReset(pnlDetails);
            dataGridView1.AutoGenerateColumns = false;
            LoadList1();
        }
        private void LoadList1()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectSectionsWRTCampus", ddSection, "Name", "SectionID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownList("stp_SelectPaymentMethods", ddBank, "Bank", "BankID");
        }

        private void LoadList2()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectClassesWRTLevels", ddClass, "Class", "ClassID", "@LevelID", Convert.ToInt32(ddLevel.SelectedValue));
        }

        private void LoadStudent()
        {
            chkFeeVoucherWRTClass = clsSelection.SelectCheckFeeVouchersWRTClass(dtSession.Value.Year, Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), Convert.ToInt32(dtMonthYear.Value.Month), Convert.ToInt32(dtMonthYear.Value.Year));
            if (chkFeeVoucherWRTClass > 0)
            {
                clsSelection.SelectGetFeeVouchersWRTClass(dataGridView1, gvRegNo, gvStuName, gvFatherName, gvClassID, gvClass, gvSectionID, gvSection, gvFeeVoucherID,gvDueDate,gvPresentFee, gvDiscount,gvReason, dtSession.Value.Year, Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), Convert.ToInt32(dtMonthYear.Value.Month), Convert.ToInt32(dtMonthYear.Value.Year));
                MainClass.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                clsSelection.SelectStudentsForFeeVouchers(dataGridView1, gvRegNo, gvStuName, gvFatherName, gvClassID, gvClass, gvSectionID, gvSection, Convert.ToInt32(ddLevel.SelectedValue), Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), dtSession.Value.Year);
                MainClass.SNO(dataGridView1, "gvSNO");
            }
        }

        private void LoadStudentWRT_RegNo()
        {

            checkFeeVouchersWRTRegNO = clsSelection.SelectCheckFeeVouchersWRTRegNo(dtSession.Value.Year, Convert.ToInt64(txtRegNo.Text), Convert.ToByte(dtMonthYear.Value.Month), Convert.ToInt16(dtMonthYear.Value.Year));


            if (checkFeeVouchersWRTRegNO > 0)
            {
                clsSelection.SelectGetFeeVouchersWRTRegNo(dataGridView1, gvRegNo, gvStuName, gvFatherName, gvClassID, gvClass, gvSectionID, gvSection, gvFeeVoucherID, gvDueDate, gvPresentFee, gvDiscount, gvReason, dtSession.Value.Year, Convert.ToInt64(txtRegNo.Text), Convert.ToInt32(dtMonthYear.Value.Month), Convert.ToInt32(dtMonthYear.Value.Year));
                MainClass.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                clsSelection.SelectStudentsWRT_RegNo_Session(dataGridView1, gvRegNo, gvStuName, gvFatherName, gvClassID, gvClass, gvSectionID, gvSection, Convert.ToInt64(txtRegNo.Text), dtSession.Value.Year);
                MainClass.SNO(dataGridView1, "gvSNO");
            }

        }

        private float PresentFeeCalculator(Int64 RegNo, Int16 adStat, Int16 absentStat, Int16 SecurityStat, Int16 SportsStat, Int16 MiscStat, Int16 LateStat)
        {
            float PresentFee=0, monthlyFee=0, Discount=0, AdmissionFee=0, AbcentFee=0, SecurityFee=0, SportsFee=0, MiscFee=0;
            int LateSurcharge = 0;

            PRESENTFEE = clsSelection.SelectPresentFeeForFeeVoucers(dtSession.Value.Year, RegNo, dtMonthYear.Value.Month,
                dtMonthYear.Value.Year, adStat, absentStat, SecurityStat, SportsStat, MiscStat,LateStat);
            monthlyFee = Convert.ToSingle(PRESENTFEE[0]);
            Discount = Convert.ToSingle(PRESENTFEE[1]);
            AdmissionFee = Convert.ToSingle(PRESENTFEE[2]);
            AbcentFee = Convert.ToSingle(PRESENTFEE[3]);
            SecurityFee = Convert.ToSingle(PRESENTFEE[4]);
            SportsFee = Convert.ToSingle(PRESENTFEE[5]);
            MiscFee = Convert.ToSingle(PRESENTFEE[6]);
            LateSurcharge = Convert.ToInt32(PRESENTFEE[7]);
            
            return PresentFee = (monthlyFee - Discount) + AdmissionFee + AbcentFee + SecurityFee + SportsFee + MiscFee + LateSurcharge;
        }

        private int LATE_SURCHARGE(Int64 RegNo, Int16 adStat, Int16 absentStat, Int16 SecurityStat, Int16 SportsStat, Int16 MiscStat, Int16 LateStat)
        {
            int LateSurcharge = 0;

            PRESENTFEE = clsSelection.SelectPresentFeeForFeeVoucers(dtSession.Value.Year, RegNo, dtMonthYear.Value.Month,
                dtMonthYear.Value.Year, adStat, absentStat, SecurityStat, SportsStat, MiscStat, LateStat);
           
            LateSurcharge = Convert.ToInt32(PRESENTFEE[7]);

            return LateSurcharge;
        }


        private void ddLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }

            if (ddLevel.SelectedIndex > 0)
            {
                LoadList2();
            }
            else
            {
                ddClass.DataSource = null;
            }
        }

        private void ddClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }

        }

        private void ddSection_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }


        private void btnRegNoLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (txtRegNo.Text != "") //if you are loading data according to reg no.
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.DataSource = null;
                }
                else
                {
                    LoadStudentWRT_RegNo();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        FEE = clsSelection.SelectMonthlyFeeWRTClass(Convert.ToInt32(row.Cells["gvClassID"].Value.ToString()));
                        txtMonthlyFee.Text = Math.Truncate(Convert.ToDouble(FEE[0])).ToString();
                        txtLateFeeFine.Text = Math.Truncate(Convert.ToDouble(FEE[1])).ToString();
                    }
                }
            }

            else // if reg no is not provided
            {
                if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
                if (ddSection.SelectedIndex == 0 || ddSection.SelectedIndex == -1) { errSection.Visible = true; } else { errSection.Visible = false; }
                if (errClass.Visible || errSection.Visible)
                {
                    MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
                }
                else
                {
                    if (ddClass.SelectedIndex != 0 && ddClass.SelectedIndex != -1 && ddSection.SelectedIndex != 0 && ddSection.SelectedIndex != -1)
                    {
                        LoadStudent();

                        FEE = clsSelection.SelectMonthlyFeeWRTClass(Convert.ToInt32(ddClass.SelectedValue));
                        txtMonthlyFee.Text = Math.Truncate(Convert.ToDouble(FEE[0])).ToString();
                        txtLateFeeFine.Text = Math.Truncate(Convert.ToDouble(FEE[1])).ToString();

                        MainClass.CheckUnCheck(dataGridView1, chkSelectAll, "gvCheck");
                    }
                }
            }
        }

        private void dtDueDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtDueDate.Value.Date < DateTime.Today.Date)
            {
                errDueDate.Visible = true;
            }
            else
            {
                errDueDate.Visible = false;
            }
        }

        private void ddBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddBank.SelectedIndex == 0 || ddBank.SelectedIndex == -1) { errBank.Visible = true; } else { errBank.Visible = false; }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.EnableReset(pnlDetails);
            dataGridView1.DataSource = null;
            txtMonthlyFee.Enabled = false;
            txtLateFeeFine.Enabled = false;
            LoadList1();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            MainClass.Enable(pnlDetails);
            txtMonthlyFee.Enabled = false;
            txtLateFeeFine.Enabled = false;
        }



        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "") //if Registration No is empty
            {
                if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
                if (ddSection.SelectedIndex == 0 || ddSection.SelectedIndex == -1) { errSection.Visible = true; } else { errSection.Visible = false; }
                if (dtDueDate.Value.Date < DateTime.Now.Date) { errDueDate.Visible = true; } else { errDueDate.Visible = false; }
                if (ddBank.SelectedIndex == 0 || ddBank.SelectedIndex == -1) { errBank.Visible = true; } else { errBank.Visible = false; }
                if (errDueDate.Visible)
                {
                    MainClass.ShowMsg("Due date can not be less than Today", "Stop!", "Error");
                }
                else if (errClass.Visible || errSection.Visible || errBank.Visible)
                {
                    MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
                }

                else
                {
                    AdmFee = chkAdmissionFee.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
                    AbsentFee = chkAbcentFee.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
                    BooksFee = chkBooksFee.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
                    ExamsFee = chkExamFee.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
                    MiscFee = chkMiscFee.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
                    LateFee = chkLateSurchage.Checked ? Convert.ToByte(1) : Convert.ToByte(0);

                    if (dataGridView1.Rows.Count>0)//code for save operation
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                            {
                                chkStudent = 1;
                                if (row.Cells["gvFeeVoucherID"].Value == null || row.Cells["gvFeeVoucherID"].Value.ToString() == "")
                                {
                                    try
                                    {
                                        int chk = clsInsertion.AddFeeVouchers(
                                                Convert.ToInt32(dtSession.Value.Year), 
                                                Convert.ToInt32(dtMonthYear.Value.Month),
                                                Convert.ToInt32(dtMonthYear.Value.Year),
                                                Convert.ToInt64(row.Cells["gvRegNo"].Value),
                                                Convert.ToInt32(ddClass.SelectedValue),
                                                Convert.ToInt32(ddSection.SelectedValue),
                                                dtDueDate.Value,
                                                Convert.ToInt32(ddBank.SelectedValue),
                                                 PresentFeeCalculator(Convert.ToInt64(row.Cells["gvRegNo"].Value), AdmFee, AbsentFee, BooksFee, ExamsFee, MiscFee,LateFee),0,
                                                AdmFee, AbsentFee, BooksFee, ExamsFee,MiscFee,
                                                LATE_SURCHARGE(Convert.ToInt64(row.Cells["gvRegNo"].Value), AdmFee, AbsentFee, BooksFee, ExamsFee, MiscFee, LateFee));
                                        if (chk > 0)
                                        {
                                            GenerateVoucher = 1;
                                        }
                                    }
                                    catch (Exception x)
                                    {
                                        MainClass.ShowMsg(x.Message, "Error", "Error");
                                    }
                                }
                                else  //code for update operation
                                {
                                    chkVouher = 1;
                                }
                            }
                        }
                        if (chkVouher == 1)
                        {
                            DialogResult dr = MessageBox.Show("Fee Vouchers of this month for " + ddClass.Text + " " + ddSection.Text + " are already available.\n\nDo You want to update them anyways?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                                    {
                                        chkStudent = 1;
                                        try
                                        {
                                            int chk = clsUpdation.UpdateFeeVouchers(Convert.ToInt64(row.Cells["gvFeeVoucherID"].Value),
                                                 Convert.ToInt32(dtSession.Value.Year),
                                                 Convert.ToInt32(dtMonthYear.Value.Month),
                                                 Convert.ToInt32(dtMonthYear.Value.Year),
                                                 Convert.ToInt64(row.Cells["gvRegNo"].Value),
                                                 Convert.ToInt32(ddClass.SelectedValue),
                                                 Convert.ToInt32(ddSection.SelectedValue),
                                                 dtDueDate.Value,
                                                 Convert.ToInt32(ddBank.SelectedValue), 
                                                 AdmFee, AbsentFee, BooksFee, ExamsFee, MiscFee, LATE_SURCHARGE(Convert.ToInt64(row.Cells["gvRegNo"].Value), AdmFee, AbsentFee, BooksFee, ExamsFee, MiscFee, LateFee),
                                                 PresentFeeCalculator(Convert.ToInt64(row.Cells["gvRegNo"].Value), AdmFee, AbsentFee, BooksFee, ExamsFee, MiscFee, LateFee));

                                            if (chk > 0)
                                            {
                                                ReGenerateVoucher = 1;
                                            }
                                        }
                                        catch (Exception x)
                                        {
                                            MainClass.ShowMsg(x.Message, "Error", "Error");
                                        }
                                    }
                                }
                            }
                        }
                        if (chkStudent < 1)
                        {
                            MainClass.ShowMsg("Select at least 1 Student to generate Fee Voucher", "Error", "Error");
                        }

                        else if (GenerateVoucher == 1)
                        {
                            MainClass.ShowMsg(" Fee Voucher(s) Generated for selected student(s) of " + ddClass.Text + " " + ddSection.Text, "Success", "Success");
                            MainClass.DisableReset(pnlDetails);
                            dataGridView1.DataSource = null;
                        }

                        else if (ReGenerateVoucher == 1)
                        {
                            MainClass.ShowMsg(" Fee Voucher(s) Updated for selected student(s) of " + ddClass.Text + " " + ddSection.Text, "Success", "Success");
                            MainClass.DisableReset(pnlDetails);
                            dataGridView1.DataSource = null;
                        }

                    }
                }

            }

            else // if Registration no. is provided
            {
                if (dtDueDate.Value.Date < DateTime.Now.Date) { errDueDate.Visible = true; } else { errDueDate.Visible = false; }
                if (ddBank.SelectedIndex == 0 || ddBank.SelectedIndex == -1) { errBank.Visible = true; } else { errBank.Visible = false; }
                if (errDueDate.Visible)
                {
                    MainClass.ShowMsg("Due date can not be less than Today", "Stop!", "Error");
                }
                else if (errBank.Visible)
                {
                    MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
                }

                else
                {
                    AdmFee = chkAdmissionFee.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
                    AbsentFee = chkAbcentFee.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
                    BooksFee = chkBooksFee.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
                    ExamsFee = chkExamFee.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
                    MiscFee = chkMiscFee.Checked ? Convert.ToByte(1) : Convert.ToByte(0);

                    if (edit == 0)//code for save operation
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                            {
                                chkStudent = 1;
                                if (row.Cells["gvFeeVoucherID"].Value == null || row.Cells["gvFeeVoucherID"].Value.ToString() == "")
                                {
                                    try
                                    {
                                        int chk = clsInsertion.AddFeeVouchers(
                                            Convert.ToInt32(dtSession.Value.Year), 
                                            Convert.ToInt32(dtMonthYear.Value.Month),
                                                Convert.ToInt32(dtMonthYear.Value.Year),
                                                Convert.ToInt64(row.Cells["gvRegNo"].Value.ToString()),
                                                Convert.ToInt32(row.Cells["gvClassID"].Value.ToString()),
                                                Convert.ToInt32(row.Cells["gvSectionID"].Value.ToString()),
                                                dtDueDate.Value,
                                                Convert.ToInt32(ddBank.SelectedValue),
                                                 PresentFeeCalculator(Convert.ToInt64(row.Cells["gvRegNo"].Value), AdmFee, AbsentFee, BooksFee, ExamsFee, MiscFee, LateFee), 0,
                                                AdmFee, AbsentFee, BooksFee, ExamsFee, MiscFee, 
                                                LATE_SURCHARGE(Convert.ToInt64(row.Cells["gvRegNo"].Value), AdmFee, AbsentFee, BooksFee, ExamsFee, MiscFee, LateFee));

                                        if (chk > 0)
                                        {
                                            GenerateVoucher = 1;
                                        }

                                    }
                                    catch (Exception x)
                                    {
                                        MainClass.ShowMsg(x.Message, "Error", "Error");
                                    }
                                }
                                else  //code for update operation
                                {
                                    chkVouher = 1;
                                }
                            }
                        }
                        if (chkVouher == 1)
                        {
                            DialogResult dr = MessageBox.Show("Fee Vouchers of this month for this student is already available.\n\nDo You want to update it anyways?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {

                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                                    {
                                        chkStudent = 1;
                                        try
                                        {
                                            int chk = clsUpdation.UpdateFeeVouchers(Convert.ToInt64(row.Cells["gvFeeVoucherID"].Value),
                                                Convert.ToInt32(dtSession.Value.Year),
                                                 Convert.ToInt32(dtMonthYear.Value.Month),
                                                 Convert.ToInt32(dtMonthYear.Value.Year),
                                                 Convert.ToInt64(row.Cells["gvRegNo"].Value.ToString()),
                                                Convert.ToInt32(row.Cells["gvClassID"].Value.ToString()),
                                                 Convert.ToInt32(row.Cells["gvSectionID"].Value.ToString()),
                                                 dtDueDate.Value,
                                                 Convert.ToInt32(ddBank.SelectedValue), 
                                                 AdmFee, AbsentFee, BooksFee, ExamsFee, MiscFee, LATE_SURCHARGE(Convert.ToInt64(row.Cells["gvRegNo"].Value), AdmFee, AbsentFee, BooksFee, ExamsFee, MiscFee, LateFee),
                                                 PresentFeeCalculator(Convert.ToInt64(row.Cells["gvRegNo"].Value), AdmFee, AbsentFee, BooksFee, ExamsFee, MiscFee, LateFee));

                                            if (chk > 0)
                                            {
                                                ReGenerateVoucher = 1;
                                            }

                                        }
                                        catch (Exception x)
                                        {
                                            MainClass.ShowMsg(x.Message, "Error", "Error");
                                        }
                                    }
                                }
                            }
                        }
                        if (chkStudent < 1)
                        {
                            MainClass.ShowMsg("Select at least 1 Student to generate Fee Voucher", "Error", "Error");
                        }

                        else if (GenerateVoucher == 1)
                        {
                            MainClass.ShowMsg(" Fee Voucher(s) Generated for the selected student(s)", "Success", "Success");
                            MainClass.DisableReset(pnlDetails);
                            dataGridView1.DataSource = null;
                        }

                        else if (ReGenerateVoucher == 1)
                        {
                            MainClass.ShowMsg(" Fee Voucher(s) Updated for the selected student(s)", "Success", "Success");
                            MainClass.DisableReset(pnlDetails);
                            dataGridView1.DataSource = null;
                        }
                    }
                }
            }
        }



        public override void btnDelete_Click(object sender, EventArgs e)

        {
            int check = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                {
                    check++;
                }
            }

            if (check>0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete Fee Vouchers of selected students ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    foreach  (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToInt32( row.Cells["gvCheck"].Value) ==1)
                        {
                            clsDeletion.Delete(Convert.ToInt64(row.Cells["gvFeeVoucherID"].Value), "stp_DeleteFeeVoucers", "@FeeVoucersID");
                        }
                    }
                   
                    LoadData();
                    check = 0;
                }
            }
            else
            {
                MainClass.ShowMsg("Please select at least 1 voucher to continue...", "Error", "Error");
            }

        }



        public override void btnView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please, Press the Load Button to Load Records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                MainClass.CheckUnCheck(dataGridView1, chkSelectAll, "gvCheck");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                {
                    row.Cells["gvCheck"].Value = 0;
                }
                else
                {
                    row.Cells["gvCheck"].Value = 1;
                }
                FeeVoucerID = Convert.ToInt64(row.Cells["gvFeeVoucherID"].Value);
            }
        }
    }
}
