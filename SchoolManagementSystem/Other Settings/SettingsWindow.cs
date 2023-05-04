using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISS
{
    public partial class SettingsWindow : Sample
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            if (MainClass.STAFFROLE == "Faculty")
            {
                MainClass.DisableReset(pnlDetails);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (checkBox1.Checked)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                if (txtDataSource.Text == "") { errDataSource.Visible = true; } else { errDataSource.Visible = false; }
                if (txtDatabase.Text == "") { errDatabase.Visible = true; } else { errDatabase.Visible = false; }
                if (errDataSource.Visible || errDatabase.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory!");
                }
                else
                {
                    sb.Append("Data Source=" + txtDataSource.Text + ";Initial Catalog=" + txtDatabase.Text + ";Integrated Security=true;MultipleActiveResultSets=true");
                    File.WriteAllText(MainClass.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.ShowWindow(log, this, MDI.ActiveForm);
                    }
                }
            }
            else
            {
                if (txtDataSource.Text == "") { errDataSource.Visible = true; } else { errDataSource.Visible = false; }
                if (txtDatabase.Text == "") { errDatabase.Visible = true; } else { errDatabase.Visible = false; }
                if (txtUsername.Text == "") { errUsername.Visible = true; } else { errUsername.Visible = false; }
                if (txtPassword.Text == "") { errPassword.Visible = true; } else { errPassword.Visible = false; }
                if (errDataSource.Visible || errDatabase.Visible || errUsername.Visible || errPassword.Visible)
                {
                    MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
                }
                else
                {
                    sb.Append("Data Source=" + txtDataSource.Text + ";Initial Catalog=" + txtDatabase.Text + ";User ID=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";MultipleActiveResultSets=true");
                    File.WriteAllText(MainClass.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.ShowWindow(log, this, MDI.ActiveForm);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MainClass.STAFFROLE == "Admin")
            {
                dbAdmin hom = new ISS.dbAdmin();
                MainClass.ShowWindow(hom, this, MDI.ActiveForm);
            }
            else if (MainClass.STAFFROLE == "Principal")
            {
                dbPrincipal pri = new ISS.dbPrincipal();
                MainClass.ShowWindow(pri, this, MDI.ActiveForm);
            }
            else if (MainClass.STAFFROLE == "Faculty")
            {
                dbFaculty obj = new dbFaculty();
                MainClass.ShowWindow(obj, this, MDI.ActiveForm);
            }
            else
            {
                Login obj = new Login();
                MainClass.ShowWindow(obj, this, MDI.ActiveForm);
            }
        }
    }
}
