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

namespace SchoolManagementSystem
{
    public partial class Classes : Sample2
    {
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        int edit = 0;
        int ClassID;

        float classNumber;

        public Classes()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbCampusManagement cm = new SchoolManagementSystem.dbCampusManagement();
            MainClass.ShowWindow(cm, this, MDI.ActiveForm);
        }

        private void Classes_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(pnlDetails);
            LoadList();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtClassName.Text == "") { errClass.Visible = true; } else { errClass.Visible = false; }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }

        }

        private void ddLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
        }


        private void txtClassNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtClassNumber.Text == "") { errClassNumber.Visible = true; }
            else
            {
                errClassNumber.Visible = false;
                if (!rg.Match(txtClassNumber.Text).Success)
                {
                    txtClassNumber.Focus();
                    txtClassNumber.Text = "";
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
            if (txtClassName.Text == "") { errClass.Visible = true; } else { errClass.Visible = false; }
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
            if (ddLevel.SelectedIndex == 0 || ddLevel.SelectedIndex == -1) { errLevel.Visible = true; } else { errLevel.Visible = false; }
            if (txtClassNumber.Text == "") { errClassNumber.Visible = true; } else { errClassNumber.Visible = false; }
            if (errClass.Visible || errStatus.Visible || errLevel.Visible|| errClassNumber.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Stop!", "Error");
            }
            else
            {
                int Stat = 0;
                if (ddStatus.SelectedIndex == 0)
                {
                    Stat = 1;
                }
                else
                {
                    Stat = 0;
                }
                if (txtClassNumber.Text!="")
                {
                    classNumber = Convert.ToSingle( txtClassNumber.Text);
                }
                if (edit == 0)//code for save operation
                {
                    clsInsertion.AddClasses(txtClassName.Text, MainClass.CAMPUSID, Convert.ToInt32(ddLevel.SelectedValue), Convert.ToByte(Stat),classNumber);
                    LoadData();
                    MainClass.DisableReset(pnlDetails);
                }
                else if (edit == 1)//code for update operation
                {
                    clsUpdation.UpdateClasses(ClassID, txtClassName.Text, MainClass.CAMPUSID, Convert.ToInt32(ddLevel.SelectedValue), Convert.ToByte(Stat), classNumber);
                    LoadData();
                    MainClass.DisableReset(pnlDetails);
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtClassName.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.Delete(ClassID, "stp_DeleteClasses", "@ClassID");
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

        private void LoadList()
        {
            MainClass.GetDropdownListWithOneParameters("stp_SelectLevelsWRTCampus", ddLevel, "Level", "LevelID", "@CampusID", MainClass.CAMPUSID);
        }

        private void LoadData()
        {
            clsSelection.SelectClasses(dataGridView1, gvClassID, gvClassName, gvCampusID, gvCampus, gvLevelID, gvLevel, gvStatus,gvClassNumber);
            MainClass.SNO(dataGridView1, "gvSerialNo");
        }

        private void SearchData()
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectClasses(dataGridView1, gvClassID, gvClassName, gvCampusID, gvCampus, gvLevelID, gvLevel, gvStatus, gvClassNumber, txtSearch.Text);
                MainClass.SNO(dataGridView1, "gvSerialNo");
            }
            else
            {
                clsSelection.SelectClasses(dataGridView1, gvClassID, gvClassName, gvCampusID, gvCampus, gvLevelID, gvLevel, gvStatus, gvClassNumber);
                MainClass.SNO(dataGridView1, "gvSerialNo");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ClassID = Convert.ToInt32(row.Cells["gvClassID"].Value.ToString());
                txtClassName.Text = row.Cells["gvClassName"].Value.ToString();
                ddLevel.SelectedValue = row.Cells["gvLevelID"].Value.ToString();
                ddStatus.SelectedItem = row.Cells["gvStatus"].Value.ToString();
                txtClassNumber.Text= row.Cells["gvClassNumber"].Value.ToString();
                MainClass.Disable(pnlDetails);
            }
        }

    }
}
