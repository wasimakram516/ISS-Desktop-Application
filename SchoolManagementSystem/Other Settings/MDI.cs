using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ISS
{
    public partial class MDI : Form
    {
        
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            if (File.Exists(MainClass.path + "\\connect"))
            {
                Login obj = new Login();
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Maximized;
                obj.Show();
            }
            else
            {
                SettingsWindow obj = new SettingsWindow();
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Maximized;
                obj.Show();
            }

            if (MainClass.STAFFROLE =="Faculty")
            {
                settingsToolStripMenuItem.Enabled = false;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWindow obj = new SettingsWindow();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure, You want to close the application?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
        
    }
}
