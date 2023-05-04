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
    public partial class FeePayments : Sample2
    {
        
        int chkStudent=0,chkFeeVoucherWRTClass;
        string exception;
        byte PaidStat, WithinDueDateStat;

        public FeePayments()
        {
            InitializeComponent();
        }
        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbFeeManagement stm = new ISS.dbFeeManagement();
            MainClass.ShowWindow(stm, this, MDI.ActiveForm);
        }

        private void FeePayments_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
            LoadList1();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void LoadList1()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
            MainClass.GetDropdownListWithOneParameters("stp_SelectSectionsWRTCampus", ddSection, "Name", "SectionID", "@CampusID", MainClass.CAMPUSID);
        }

        private void LoadList2()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectClassesWRTLevels", ddClass, "Class", "ClassID", "@LevelID", Convert.ToInt32(ddLevel.SelectedValue));
        }

        private void LoadStudent()
        {
            chkFeeVoucherWRTClass = clsSelection.SelectCheckFeeVouchersWRTClass(dtSession.Value.Year, Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), Convert.ToByte(dtMonthYear.Value.Month), Convert.ToInt16(dtMonthYear.Value.Year));
            if (chkFeeVoucherWRTClass > 0)
            {
                
                clsSelection.SelectGetFeeVouchersWRTClassForFeePayment(dataGridView1, gvRegNo, gvStuName, gvFatherName, gvFeeVoucherID, gvPaidStatus, gvPaymentDate, dtSession.Value.Year, Convert.ToInt32(ddClass.SelectedValue), Convert.ToInt32(ddSection.SelectedValue), Convert.ToByte(dtMonthYear.Value.Month), Convert.ToInt16(dtMonthYear.Value.Year));

                MainClass.SNO(dataGridView1, "gvSNO");
                //MainClass.CheckUnCheck(dataGridView1, chkSelectAll, "gvCheck");

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ( row.Cells["gvPaidStatus"].Value.ToString() == "Yes")
                    {
                        row.ReadOnly = true;
                    }
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                MainClass.ShowMsg("No record found!", "Error", "Error");
            }
        }

        private void ddLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }

            if (ddLevel.SelectedIndex > 0)
            {
                LoadList2();
            }
            else
            {
                ddClass.DataSource = null;
            }
        }

        private void ddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex != -1 && ddClass.SelectedIndex != 0)
            {
                errClass.Visible = false;
            }
            else
            {
                errClass.Visible = true;
            }
        }

        private void ddSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSection.SelectedIndex != 0 && ddSection.SelectedIndex != -1)
            {
                errSection.Visible = false;
            }
            else
            {
                errSection.Visible = true;
            }
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.EnableReset(pnlDetails);
            dataGridView1.DataSource = null;
            LoadList1();
            exception = null;
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            MainClass.Enable(pnlDetails);
            exception = null;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.ReadOnly = false;
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex != 0 && ddClass.SelectedIndex != -1 && ddSection.SelectedIndex != 0 && ddSection.SelectedIndex != -1)
            {
                LoadStudent();
            }
            else
            {
                errClass.Visible = true;
                errSection.Visible = true;
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
        }



        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddSection.SelectedIndex == 0 || ddSection.SelectedIndex == -1) { errSection.Visible = true; } else { errSection.Visible = false; }

            if (errClass.Visible || errSection.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                int count = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells["gvCheck"].Value) == 1)
                    {
                        chkStudent = 1;
                        PaidStat = row.Cells["gvPaidStatus"].Value.ToString() == "Yes" ? Convert.ToByte(1) : Convert.ToByte(0);
                        try
                        {
                            
                            int chk=clsUpdation.UpdateFeeVouchersWRTStudent(Convert.ToInt64(row.Cells["gvFeeVoucherID"].Value), PaidStat, dtPaymentDate.Value);
                            if (chk>0)
                            {
                                count++;
                            }
                            
                        }
                        catch (Exception x)
                        {
                            exception = x.Message;
                        }

                    }
                }

                if (chkStudent < 1)
                {
                    MainClass.ShowMsg("Select at least 1 Student to continue.", "Error", "Error");
                }
                else if (exception!=null)
                {
                        MainClass.ShowMsg(exception, "Error", "Error");
                }
                else if (count != 0)
                {
                    MainClass.ShowMsg("Payment Status of " + count + " record(s) updated successfully!", "Success", "Success");
                    //MainClass.DisableReset(pnlDetails);
                    dataGridView1.DataSource = null;
                }

            }
        }



        public override void btnDelete_Click(object sender, EventArgs e)
        {
            MainClass.ShowMsg("You can't delete anything here!", "Error", "Error");
        }



        public override void btnView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please, Press the Load Button to Load Records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count==0)
            {
                MessageBox.Show("Please, Press the Load Button to Load Records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        //private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (dataGridView1.Rows.Count != 0)
        //    {
        //        MainClass.CheckUnCheck(dataGridView1, chkSelectAll, "gvCheck");
        //    }
        //}

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //MainClass.Disable(pnlDetails);
                if (row.Cells["gvPaymentDate"].Value.ToString()!="")
                {
                    dtPaymentDate.Value = Convert.ToDateTime(row.Cells["gvPaymentDate"].Value.ToString());
                }
                else
                {
                    dtPaymentDate.Value = DateTime.Now;
                }

                if (e.ColumnIndex == 0)
                {
                    if (row.Cells["gvCheck"].ReadOnly == true)
                    {
                        MainClass.ShowMsg("This is a paid voucher, click edit button to edit this.", "Information", "Error");
                    }
                }
            }
        }
    }
}