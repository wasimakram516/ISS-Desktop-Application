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
    public partial class Birthdays : Sample2
    {
        public Birthdays()
        {
            InitializeComponent();
        }

        private void Birthdays_Load(object sender, EventArgs e)
        {
            
        }
        public override void btnBack_Click(object sender, EventArgs e)
        {
            if (MainClass.STAFFROLE == "Admin")
            {
                dbAdmin hom = new ISS.dbAdmin();
                MainClass.ShowWindow(hom, this, MDI.ActiveForm);
            }
            else if (MainClass.STAFFROLE == "Principal")
            {
                dbStaffManagement stm = new ISS.dbStaffManagement();
                MainClass.ShowWindow(stm, this, MDI.ActiveForm);
            }
            else
            {
                Login obj = new Login();
                MainClass.ShowWindow(obj, this, MDI.ActiveForm);
            }
        }


        public override void btnView_Click(object sender, EventArgs e)
        {
            clsSelection.SelectStudentBirthday(dataGridView1, gvRegNo, gvStuName, gvFatherName, gvDOB, gvAge, gvClass, gvSection,
                Convert.ToInt32(DateTime.Now.Day), Convert.ToInt32(DateTime.Now.Month));
            MainClass.SNO(dataGridView1, "gvSNO");
        }
    }
}
