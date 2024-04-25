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
    public partial class dbCampusManagement : Sample
    {
        public dbCampusManagement()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dbPrincipal ad = new SchoolManagementSystem.dbPrincipal();
            MainClass.ShowWindow(ad, this, MDI.ActiveForm);
        }

        private void btnCampuses_Click(object sender, EventArgs e)
        {
            Campuses cam = new SchoolManagementSystem.Campuses();
            MainClass.ShowWindow(cam, this, MDI.ActiveForm);
        }

        private void btnLevels_Click(object sender, EventArgs e)
        {
            Levels lvl = new SchoolManagementSystem.Levels();
            MainClass.ShowWindow(lvl, this, MDI.ActiveForm);
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            Classes cls = new Classes();
            MainClass.ShowWindow(cls, this, MDI.ActiveForm);
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            Sections s = new Sections();
            MainClass.ShowWindow(s, this, MDI.ActiveForm);
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            Groups grp = new Groups();
            MainClass.ShowWindow(grp, this, MDI.ActiveForm);
        }

        private void btnPeriods_Click(object sender, EventArgs e)
        {
            Periods p = new Periods();
            MainClass.ShowWindow(p, this, MDI.ActiveForm);
        }

        private void btnClassTimings_Click(object sender, EventArgs e)
        {
            ClassTimings ct = new ClassTimings();
            MainClass.ShowWindow(ct, this, MDI.ActiveForm);
        }
        

        private void btnShifts_Click(object sender, EventArgs e)
        {
            Shifts shft = new SchoolManagementSystem.Shifts();
            MainClass.ShowWindow(shft, this, MDI.ActiveForm);
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            Subjects obj = new SchoolManagementSystem.Subjects();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }
    }
}
