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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MainClass.GetDropdownList("stp_SelectCampuses", ddCampus, "Name", "CampID");
            if (ddCampus.Items.Count>1)
            {
                ddCampus.SelectedIndex = 1;
            }
            
            ddCampus.Focus();
        }

        MainClass main = new MainClass();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ddCampus.SelectedIndex == 0 || ddCampus.SelectedIndex == -1) { errCampus.Visible = true; } else { errCampus.Visible = false; }
            if (txtUsername.Text == ""){errUsername.Visible = true;}else{ errUsername.Visible = false;}
            if (txtPassword.Text == "") { errPassword.Visible = true; } else { errPassword.Visible = false; }
            if (errUsername.Visible||errPassword.Visible||errCampus.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "error");
            }
            else
            {
                if (main.UserLogin(Convert.ToInt32(ddCampus.SelectedValue),txtUsername.Text,txtPassword.Text))
                {
                    if (MainClass.STAFFROLE=="Admin")
                    {
                        dbAdmin hom = new SchoolManagementSystem.dbAdmin();
                        MainClass.ShowWindow(hom, this, MDI.ActiveForm);
                    }
                    else if (MainClass.STAFFROLE == "Principal")
                    {
                        dbPrincipal pri = new SchoolManagementSystem.dbPrincipal();
                        MainClass.ShowWindow(pri, this, MDI.ActiveForm);
                    }
                    else if (MainClass.STAFFROLE == "Faculty")
                    {
                        dbFaculty obj = new dbFaculty();
                        MainClass.ShowWindow(obj, this, MDI.ActiveForm);
                        
                    }
                }
                else
                {
                    MainClass.ShowMsg("Invalid login details!", "Error", "error");
                }
            }
        }
        private void ddCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddCampus.SelectedIndex == 0 || ddCampus.SelectedIndex == -1) { errCampus.Visible = true; } else { errCampus.Visible = false; }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text=="")
            {
                errUsername.Visible = true;
            }
            else
            {
                errUsername.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                errPassword.Visible = true;
            }
            else
            {
                errPassword.Visible = false;
            }
        }

        
    }
}
