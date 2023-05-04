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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }


        public virtual void btnBack_Click(object sender, EventArgs e)
        {
            dbPrincipal OBJ = new ISS.dbPrincipal();
            MainClass.ShowWindow(OBJ, this, MDI.ActiveForm);
        }

        public virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnSave_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnView_Click(object sender, EventArgs e)
        {

        }

        public virtual void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
