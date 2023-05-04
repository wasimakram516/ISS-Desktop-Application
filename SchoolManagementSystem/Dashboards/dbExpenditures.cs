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
    public partial class dbExpenditures : Sample
    {
        public dbExpenditures()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dbPrincipal OBJ = new ISS.dbPrincipal();
            MainClass.ShowWindow(OBJ, this, MDI.ActiveForm);
        }

        private void btnMonthlyExpenses_Click(object sender, EventArgs e)
        {
            MonthlyExpenses OBJ = new ISS.MonthlyExpenses();
            MainClass.ShowWindow(OBJ, this, MDI.ActiveForm);
        }
    }
}
