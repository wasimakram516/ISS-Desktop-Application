using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISS
{
    public partial class StaffSalary : Sample2
    {

        int edit = 0, chkStaff, CountSalary, TWD, TP, TA, TL, THL, TGL;
        Int64 staffSaleryID;
        float TSalery, PaidSalery, DeductedSalary, Bonus;
        double HLP = 0.5;
        byte stat;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        string exception;

        public StaffSalary()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbStaffManagement stm = new ISS.dbStaffManagement();
            MainClass.ShowWindow(stm, this, MDI.ActiveForm);
        }

        private void StaffSalery_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void chk500_CheckedChanged(object sender, EventArgs e)
        {
            if (chk500.Checked)
            {
                chk1000.Checked = false;
            }
        }

        private void chk1000_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1000.Checked)
            {
                chk500.Checked = false;
            }
        }

        private void LoadData()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                if (clsSelection.SelectExistStaffSalary(dtMonthYear.Value.Month, dtMonthYear.Value.Year) > 0)
                {
                    lblExistSalary.Visible = true;
                    chkSelectAll.Enabled = false;
                    clsSelection.SelectStaffSalery(dataGridView1, gvStaffID, gvCNIC, gvStaff, gvRole, gvScale, gvSalery, gvWorkingDays, gvTP, gvTA, gvTL, gvHL, gvGL, gvPaidSalary, gvSalaryID, gvPaidDate, gvStatus, gvBonus, dtMonthYear.Value.Month, dtMonthYear.Value.Year);
                    MainClass.SNO(dataGridView1, "gvSNO");
                }
                else
                {
                    lblExistSalary.Visible = false;
                    chkSelectAll.Enabled = true;
                    clsSelection.SelectStaffForSalery(dataGridView1, gvStaffID, gvCNIC, gvStaff, gvRole, gvScale, gvSalery, gvWorkingDays, gvTP, gvTA, gvTL, gvHL, gvGL, gvPaidSalary, dtMonthYear.Value.Month, dtMonthYear.Value.Year);
                    MainClass.SNO(dataGridView1, "gvSNO");
                    SalaryCalculator();
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }

        }

        private void SalaryCalculator()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TSalery = Convert.ToSingle(row.Cells["gvSalery"].Value.ToString());
                TWD = Convert.ToInt32(row.Cells["gvWorkingDays"].Value.ToString()); // No of days in which attendance is marked
                TP = Convert.ToInt32(row.Cells["gvTP"].Value.ToString());
                TA = Convert.ToInt32(row.Cells["gvTA"].Value.ToString());
                TL = Convert.ToInt32(row.Cells["gvTL"].Value.ToString());
                THL = Convert.ToInt32(row.Cells["gvHL"].Value.ToString());
                TGL = Convert.ToInt32(row.Cells["gvGL"].Value.ToString());

                TP = TP + TGL;                    // No deduction for gazetted leaves

                if (TWD >= 24)                    // to make attendance days equal to no of days of month
                {
                    TWD = TWD + 4;
                }
                if (TWD >= 28) // when working days are full 
                {

                    DeductedSalary = (TSalery / 30) * TA;
                    PaidSalery = TSalery - DeductedSalary;
                    row.Cells["gvPaidSalary"].Value = PaidSalery;

                    if (TL > 2) // when leaves are more than 2
                    {

                        DeductedSalary = (TSalery / 30) * TL;
                        PaidSalery = PaidSalery - DeductedSalary;
                        row.Cells["gvPaidSalary"].Value = PaidSalery;

                        if (THL >= 1)
                        {
                            float HLSalary = (TSalery / 30) * THL;
                            HLSalary = Convert.ToSingle(HLSalary * HLP);
                            PaidSalery = PaidSalery - HLSalary;
                            row.Cells["gvPaidSalary"].Value = PaidSalery;
                        }
                    }

                    else if (TL <= 2) // when leaves are less than or equal to 2
                    {
                        if (TL == 0 && THL > 4)
                        {
                            float HLSalary = (TSalery / 30) * THL;
                            HLSalary = Convert.ToSingle(HLSalary * HLP);
                            PaidSalery = PaidSalery - HLSalary;
                            row.Cells["gvPaidSalary"].Value = PaidSalery;
                        }

                        else if ((TL == 1 && THL > 2) || (TL == 2 && THL >= 1))
                        {
                            DeductedSalary = (TSalery / 30) * TL;
                            PaidSalery = PaidSalery - DeductedSalary;

                            float HLSalary = (TSalery / 30) * THL;
                            HLSalary = Convert.ToSingle(HLSalary * HLP);
                            PaidSalery = PaidSalery - HLSalary;
                            row.Cells["gvPaidSalary"].Value = PaidSalery;
                        }
                    }
                }

                else // when working days are less than 28
                {
                    PaidSalery = (TSalery / 30) * TP;
                    row.Cells["gvPaidSalary"].Value = PaidSalery;

                    if (THL > 1)
                    {
                        float HLSalary = (TSalery / 30) * THL;
                        HLSalary = Convert.ToSingle(HLSalary * HLP);
                        PaidSalery = PaidSalery + HLSalary;
                        row.Cells["gvPaidSalary"].Value = PaidSalery;
                    }

                    else if (THL <= 1)
                    {
                        TP = TP + THL;
                        PaidSalery = (TSalery / 30) * TP;
                        row.Cells["gvPaidSalary"].Value = PaidSalery;
                    }
                }
            }
        }

        private void txtPaidSalery_TextChanged(object sender, EventArgs e)
        {
            if (txtPaidSalery.Text == "") { errPaidSalery.Visible = true; } else { errPaidSalery.Visible = false; }

            if (txtPaidSalery.Text != "")
            {
                if (!rg.Match(txtPaidSalery.Text).Success)
                {
                    txtPaidSalery.Focus();
                    txtPaidSalery.Clear();
                }
            }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;

            MainClass.EnableReset(pnlDetails);
            chkSelectAll.Enabled = true;
            txtStaffName.Enabled = false;
            txtRole.Enabled = false;
            txtScale.Enabled = false;
            txtTotalSalery.Enabled = false;
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(pnlDetails);
            chkSelectAll.Enabled = true;
            txtStaffName.Enabled = false;
            txtRole.Enabled = false;
            txtScale.Enabled = false;
            txtTotalSalery.Enabled = false;

        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (edit == 0)//code for save operation
            {
                if (clsSelection.SelectExistStaffSalary(dtMonthYear.Value.Month, dtMonthYear.Value.Year) > 0)
                {
                    MainClass.ShowMsg("Salary of this Month has been paid already.\nPress Edit Button to update it.", "Error", "Error");
                }

                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        chkStaff = 1;
                        Int16 status = 0;

                        if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1) // to add pay status as Piad
                        {
                            status = 1;
                        }
                        else
                        {
                            status = 0;
                        }
                        try
                        {
                            clsInsertion.AddSalery(Convert.ToByte(dtMonthYear.Value.Month), Convert.ToInt16(dtMonthYear.Value.Year), Convert.ToInt32(row.Cells["gvStaffID"].Value), Convert.ToSingle(row.Cells["gvPaidSalary"].Value.ToString()), dtPayDate.Value, status, 0);
                            CountSalary++;
                        }
                        catch (Exception x)
                        {
                            exception = x.Message;
                        }
                    }

                    if (chkStaff < 1)
                    {
                        MainClass.ShowMsg("Load at least 1 Staff to continue...", "Error", "Error");
                    }

                    else if (exception != null)
                    {
                        MainClass.ShowMsg(exception, "Error", "Error");
                    }

                    else
                    {
                        MainClass.ShowMsg("Salery of " + CountSalary + " staff has been saved successfully!", "Success", "Success");
                        MainClass.DisableReset(pnlDetails);
                        CountSalary = 0;
                        exception = null;
                        LoadData();
                    }
                }
            }

            else if (edit == 1) //code for update operation
            {
                if (txtPaidSalery.Text == "") { errPaidSalery.Visible = true; } else { errPaidSalery.Visible = false; }
                if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
                if (errPaidSalery.Visible || errStatus.Visible)
                {
                    MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
                }
                else
                {
                    if (ddStatus.SelectedIndex == 0)
                    {
                        stat = 1;
                    }
                    else
                    {
                        stat = 0;
                    }
                    if (chk500.Checked)
                    {
                        Bonus = 500;
                    }
                    else if (chk1000.Checked)
                    {
                        Bonus = 1000;
                    }
                    else if (!chk1000.Checked && !chk500.Checked)
                    {
                        Bonus = 0;
                    }
                    try
                    {
                        if (staffSaleryID == 0)
                        {
                            MainClass.ShowMsg("First you have to save the salery to update it!\nPress Add button and then Load the record(s) again to Save.", "Information", "Success");
                        }
                        else
                        {
                            int check = clsUpdation.UpdateSalery(staffSaleryID, Convert.ToSingle(txtPaidSalery.Text), dtPayDate.Value, stat, Bonus);
                            if (check == 1)
                            {
                                MainClass.ShowMsg("Pay Status of " + txtStaffName.Text + " has been Updated successfully!", "Success", "Success");
                                LoadData();
                            }
                            else
                            {
                                MainClass.ShowMsg("Not Updated!", "Error", "Error");
                            }
                        }

                    }
                    catch (Exception x)
                    {
                        MainClass.ShowMsg(x.Message, "Error", "Error");
                    }
                }
            }
        }


        public override void btnDelete_Click(object sender, EventArgs e)
        {
            MainClass.ShowMsg("Request Denied!\nSalary details can not be deleted.", "Error", "Error");
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
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {

                int col = e.ColumnIndex;
                int ro = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (col != 0) // if checkbox of gridview is not clicked
                {
                    MainClass.Disable(pnlDetails);
                    if (clsSelection.SelectExistStaffSalary(dtMonthYear.Value.Month, dtMonthYear.Value.Year) > 0)
                    {
                        staffSaleryID = Convert.ToInt64(row.Cells["gvSalaryID"].Value);
                        dtPayDate.Value = Convert.ToDateTime(row.Cells["gvPaidDate"].Value.ToString());
                        ddStatus.SelectedItem = row.Cells["gvStatus"].Value.ToString();
                    }
                    else
                    {
                        staffSaleryID = 0;
                        dtPayDate.Value = DateTime.Now;
                        ddStatus.SelectedIndex = 1;
                    }

                    txtStaffName.Text = row.Cells["gvStaff"].Value.ToString();
                    txtRole.Text = row.Cells["gvRole"].Value.ToString();
                    txtScale.Text = row.Cells["gvScale"].Value.ToString();
                    txtTotalSalery.Text = row.Cells["gvSalery"].Value.ToString();
                    txtPaidSalery.Text = row.Cells["gvPaidSalary"].Value.ToString();
                    if (row.Cells["gvBonus"].Value != null)
                    {
                        if (row.Cells["gvBonus"].Value.ToString() == "500")
                        {
                            chk500.Checked = true;
                        }
                        else if (row.Cells["gvBonus"].Value.ToString() == "1000")
                        {
                            chk1000.Checked = true;
                        }
                        else
                        {
                            chk500.Checked = false;
                            chk1000.Checked = false;
                        }
                    }
                }
            }
        }
    }
}
