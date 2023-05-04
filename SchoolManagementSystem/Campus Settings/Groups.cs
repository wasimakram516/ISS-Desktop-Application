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
    public partial class Groups : Sample2
    {
        public Groups()
        {
            InitializeComponent();
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            dbCampusManagement cm = new ISS.dbCampusManagement();
            MainClass.ShowWindow(cm, this, MDI.ActiveForm);
        }
    }
}
