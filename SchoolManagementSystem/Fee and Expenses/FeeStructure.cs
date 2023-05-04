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
    public partial class FeeStructure : Sample2
    {
        
        int edit = 0;
        int FeeStructureID, ClsID;
        float AdmFee, MonthFee, LateFee, AbsentFee;
        float BooksFee, ExamsFee, MiscFee;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        public FeeStructure()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbFeeManagement stm = new ISS.dbFeeManagement();
            MainClass.ShowWindow(stm, this, MDI.ActiveForm);
        }

        private void FeeStructure_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
            LoadList();
        }
        private void LoadList()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
        }
        private void ddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
        }

        private void txtAdmissionFee_TextChanged(object sender, EventArgs e)
        {
            if (txtAdmissionFee.Text == "") { errAdmissionFee.Visible = true; } else { errAdmissionFee.Visible = false; }
            if (txtAdmissionFee.Text != "")
            {
                if (!rg.Match(txtAdmissionFee.Text).Success)
                {
                    txtAdmissionFee.Focus();
                    txtAdmissionFee.Clear();
                }
            }
        }

        private void txtMonthlyFee_TextChanged(object sender, EventArgs e)
        {
            if (txtMonthlyFee.Text == "") { errMonthlyFee.Visible = true; } else { errMonthlyFee.Visible = false; }
            if (txtMonthlyFee.Text != "")
            {
                if (!rg.Match(txtMonthlyFee.Text).Success)
                {
                    txtMonthlyFee.Focus();
                    txtMonthlyFee.Clear();
                }
            }
        }

        private void txtLateFine_TextChanged(object sender, EventArgs e)
        {
            if (txtLateFine.Text == "") { errLateFine.Visible = true; } else { errLateFine.Visible = false; }
            if (txtLateFine.Text != "")
            {
                if (!rg.Match(txtLateFine.Text).Success)
                {
                    txtLateFine.Focus();
                    txtLateFine.Clear();
                }
            }
        }

        private void txtAbcentFine_TextChanged(object sender, EventArgs e)
        {
            if (txtAbsentFine.Text == "") { errAbcentFine.Visible = true; } else { errAbcentFine.Visible = false; }

            if (txtAbsentFine.Text != "")
            {
                if (!rg.Match(txtAbsentFine.Text).Success)
                {
                    txtAbsentFine.Focus();
                    txtAbsentFine.Clear();
                }
            }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.EnableReset(pnlDetails);
            LoadList();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(pnlDetails);
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ddClass.SelectedIndex == 0 || ddClass.SelectedIndex == -1) { errClass.Visible = true; } else { errClass.Visible = false; }
            if (txtAdmissionFee.Text == "") { errAdmissionFee.Visible = true; } else { errAdmissionFee.Visible = false; }
            if (txtMonthlyFee.Text == "") { errMonthlyFee.Visible = true; } else { errMonthlyFee.Visible = false; }
            if (txtLateFine.Text == "") { errLateFine.Visible = true; } else { errLateFine.Visible = false; }
            if (txtAbsentFine.Text == "") { errAbcentFine.Visible = true; } else { errAbcentFine.Visible = false; }

            if (errClass.Visible || errAdmissionFee.Visible || errMonthlyFee.Visible || errLateFine.Visible || errAbcentFine.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                ClsID = Convert.ToInt32(ddClass.SelectedValue);
                AdmFee = Convert.ToSingle(txtAdmissionFee.Text);
                MonthFee = Convert.ToSingle(txtMonthlyFee.Text);
                LateFee = Convert.ToSingle(txtLateFine.Text);
                AbsentFee = Convert.ToSingle(txtAbsentFine.Text);

                if (txtBooksFee.Text != "")
                {
                    BooksFee = Convert.ToSingle(txtBooksFee.Text);
                }
                else
                {
                    BooksFee = 0;
                }

                if (txtExamsFee.Text != "")
                {
                    ExamsFee = Convert.ToSingle(txtExamsFee.Text);
                }
                else
                {
                    ExamsFee = 0;
                }

                if (txtMiscFee.Text != "")
                {
                    MiscFee = Convert.ToSingle(txtMiscFee.Text);
                }
                else
                {
                    MiscFee = 0;
                }

                if (edit == 0)//code for save operation
                {
                        clsInsertion.AddFeeStructure(ClsID, AdmFee, MonthFee, BooksFee, ExamsFee, LateFee, AbsentFee, MiscFee);
                        LoadData();
                   
                }
                else if (edit == 1)//code for update operation
                {
                        clsUpdation.UpdateFeeStructure(FeeStructureID, ClsID, AdmFee, MonthFee, BooksFee, ExamsFee, LateFee, AbsentFee, MiscFee);
                        LoadData();
                }
            }
        }

        private void ddLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == -1 || ddLevel.SelectedIndex == 0) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (ddLevel.SelectedIndex > 0)
            {
                MainClass.GetDropdownListWithOneParameters("stp_SelectClassesWRTLevels", ddClass, "Class", "ClassID", "@LevelID", Convert.ToInt32(ddLevel.SelectedValue));
            }
            else
            {
                ddClass.DataSource = null;
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete Fee for " + ddClass.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                        clsDeletion.Delete(FeeStructureID, "stp_DeleteFeeStructure", "@FeeStrucID");
                        LoadData();
                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void LoadData()
        {
            clsSelection.SelectFeeStructures(dataGridView1, gvFeeStructureID,gvLevelID,gvLevel, gvClassID, gvClass, gvAdmissionFee, gvMonthlyFee, gvBooksFee, gvExamsFee, gvLateFine, gvAbsentFine, gvMiscFee);
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        private void SearchData()
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectFeeStructures(dataGridView1, gvFeeStructureID, gvLevelID, gvLevel, gvClassID, gvClass, gvAdmissionFee, gvMonthlyFee, gvBooksFee, gvExamsFee, gvLateFine, gvAbsentFine, gvMiscFee,txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                edit = 1;
                MainClass.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                FeeStructureID = Convert.ToInt32(row.Cells["gvFeeStructureID"].Value.ToString());
                ddLevel.SelectedValue = row.Cells["gvLevelID"].Value;
                ddClass.SelectedValue = row.Cells["gvClassID"].Value;
                txtAdmissionFee.Text = row.Cells["gvAdmissionFee"].Value.ToString();
                txtMonthlyFee.Text = row.Cells["gvMonthlyFee"].Value.ToString();
                txtLateFine.Text = row.Cells["gvLateFine"].Value.ToString();
                txtAbsentFine.Text = row.Cells["gvAbsentFine"].Value.ToString();
                if (Convert.ToInt32(row.Cells["gvBooksFee"].Value) == 0)
                {
                    txtBooksFee.Text = "";
                }
                else
                {
                    txtBooksFee.Text = row.Cells["gvBooksFee"].Value.ToString();
                }

                if (Convert.ToInt32( row.Cells["gvExamsFee"].Value) == 0)
                {
                    txtExamsFee.Text = "";
                }
                else
                {
                    txtExamsFee.Text = row.Cells["gvExamsFee"].Value.ToString();
                }

                if (Convert.ToInt32(row.Cells["gvMiscFee"].Value) == 0)
                {
                    txtMiscFee.Text = "";
                }
                else
                {
                    txtMiscFee.Text = row.Cells["gvMiscFee"].Value.ToString();
                }
            }
        }
    }
}
