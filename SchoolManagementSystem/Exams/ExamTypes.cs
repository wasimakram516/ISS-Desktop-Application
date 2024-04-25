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
    public partial class ExamTypes : Sample2
    {
        
        int edit = 0;
        Int64 ExamTYpeID;
        public ExamTypes()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbExaminations obj = new SchoolManagementSystem.dbExaminations();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void ExamTypes_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            MainClass.DisableReset(pnlDetails);
        }

        private void txtExamName_TextChanged(object sender, EventArgs e)
        {
            if (txtExamName.Text == "") { errExamName.Visible = true; }else { errExamName.Visible = false; }
        }

        private void dtResultDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtResultDate.Value.Date < DateTime.Now.Date) { errResultDate.Visible = true; } else { errResultDate.Visible = false; }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.EnableReset(pnlDetails);
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(pnlDetails);
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (txtExamName.Text == "") { errExamName.Visible = true; } else { errExamName.Visible = false; }
            if (errExamName.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                if (edit == 0) //Code for save operation
                {
                        clsInsertion.AddExamTypes(dtSession.Value, txtExamName.Text, dtResultDate.Value, dtResultTime.Value.TimeOfDay, txtResultVenue.Text);
                        Loaddata();
                        MainClass.DisableReset(pnlDetails);
                }
                else if (edit==1)//Code for update operation
                {
                        clsUpdation.UpdateExamTypes(ExamTYpeID, dtSession.Value, txtExamName.Text, dtResultDate.Value, dtResultTime.Value.TimeOfDay, txtResultVenue.Text);
                        Loaddata();
                        MainClass.DisableReset(pnlDetails);
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure, you want to delete "+txtExamName.Text+" ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                    clsDeletion.Delete(ExamTYpeID, "stp_DeleteExamTypes", "@ExamTypeID");
                    Loaddata();
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData(txtSearch.Text);
        }

        private void Loaddata()
        {
            clsSelection.SelectExamTypes(dataGridView1, gvExamTypeID, gvSession, gvExamName, gvResultDate, gvResultTime, gvResultVenue);
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        private void SearchData(string text)
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectExamTypes(dataGridView1, gvExamTypeID, gvSession, gvExamName, gvResultDate, gvResultTime, gvResultVenue,txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                Loaddata();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1 && e.ColumnIndex!=-1)
            {
                edit = 1;
                MainClass.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ExamTYpeID = Convert.ToInt64(row.Cells["gvExamTypeID"].Value);
                dtSession.Value = Convert.ToDateTime(row.Cells["gvSession"].Value.ToString());
                txtExamName.Text = row.Cells["gvExamName"].Value.ToString();
                dtResultDate.Value = Convert.ToDateTime(row.Cells["gvResultDate"].Value.ToString());
                dtResultTime.Value = Convert.ToDateTime(row.Cells["gvResultTime"].Value.ToString());
                txtResultVenue.Text = row.Cells["gvResultVenue"].Value.ToString();
            }
        }

       
    }
}
