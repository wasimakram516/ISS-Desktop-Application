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
    public partial class dbExaminations : Sample
    {
        public dbExaminations()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MainClass.STAFFROLE == "Admin")
            {
                dbAdmin hom = new SchoolManagementSystem.dbAdmin();
                MainClass.ShowWindow(hom, this, MDI.ActiveForm);
            }
            else if (MainClass.STAFFROLE == "Principal")
            {
                dbPrincipal ad = new SchoolManagementSystem.dbPrincipal();
                MainClass.ShowWindow(ad, this, MDI.ActiveForm);
            }
            else
            {
                Login obj = new Login();
                MainClass.ShowWindow(obj, this, MDI.ActiveForm);
            }
        }
        
        private void btnExamDetails_Click(object sender, EventArgs e)
        {
            ExamDetails OBJ = new SchoolManagementSystem.ExamDetails();
            MainClass.ShowWindow(OBJ, this, MDI.ActiveForm);
        }

        private void btnExamType_Click(object sender, EventArgs e)
        {
            ExamTypes OBJ = new SchoolManagementSystem.ExamTypes();
            MainClass.ShowWindow(OBJ, this, MDI.ActiveForm);
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            ResultsWindow OBJ = new SchoolManagementSystem.ResultsWindow();
            MainClass.ShowWindow(OBJ, this, MDI.ActiveForm);
        }

       
    }
}
