using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    class MainClass
    {
        
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string conn="";
        public static string ConStr()
        {
            if (File.Exists(MainClass.path + "\\connect"))
            {
                conn = File.ReadAllText(path + "\\Connect");
            }
            else
            {
                SettingsWindow obj = new SettingsWindow();
                obj.MdiParent = MDI.ActiveForm;
                obj.WindowState = FormWindowState.Maximized;
                obj.Show();
            }
            
            return conn;
        }

        public static SqlConnection con = new SqlConnection(ConStr());

        public static void SNO(DataGridView gv,string columnName)
        {
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[columnName].Value = count;
            }
        }

        public static void ShowWindow(Form OpenWin,Form CloseWin,Form MDI)
        {
            CloseWin.Close();
            OpenWin.WindowState = FormWindowState.Maximized;
            OpenWin.MdiParent = MDI;
            OpenWin.Show();
        }

        public static DialogResult ShowMsg(string msg, string heading, string type)
        {
            if (type=="Success")
            {
                return MessageBox.Show(msg,heading,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CheckUnCheck(DataGridView gv,CheckBox chkBox,string gvChkColumn)
        {
            if (chkBox.Checked)
            {
                foreach (DataGridViewRow row in gv.Rows)
                {
                    row.Cells[gvChkColumn].Value = 1;
                }
            }
            else
            {
                foreach (DataGridViewRow row in gv.Rows)
                {
                    row.Cells[gvChkColumn].Value = 0;
                }
            }
        }

        private static int StaffID;
        private static string StaffName;
        private static string StaffRole;
        private static int CampusID;
        private static string Campus;

        public static int STAFFID
        {
            get
            {
                return StaffID;
            }
            private set
            {
                StaffID = value;
            }
        }

        public static string STAFFNAME
        {
            get
            {
                return StaffName;
            }
            private set
            {
                StaffName = value;
            }
        }

        public static string STAFFROLE
        {
            get
            {
                return StaffRole;
            }
            private set
            {
                StaffRole = value;
            }
        }

        public static int CAMPUSID
        {
            get
            {
                return CampusID;
            }
            private set
            {
                CampusID = value;
            }
        }

        public static string CAMPUSNAME
        {
            get
            {
                return Campus;
            }
            private set
            {
                Campus = value;
            }
        }

        bool chkLogin;
        public bool UserLogin( int CampID,string Username, string Password) // these values are given by user at runtime
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UserLogin", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CampusID", CampID);
                com.Parameters.AddWithValue("@Username", Username);
                com.Parameters.AddWithValue("@Password", Password);
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        chkLogin = true;

                        StaffID = Convert.ToInt32(dr["StaffID"].ToString());
                        StaffName = dr["Name"].ToString();
                        StaffRole = dr["Role"].ToString();
                        CampusID = Convert.ToInt32(dr["CampusID"].ToString());
                        Campus = dr["Campus"].ToString();
                    }
                }
                else
                {
                    chkLogin = false;
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return chkLogin;
        }

        public static void GetDropdownList(string procedure, ComboBox cb, string DisplayMember, string ValueMember)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand com = new SqlCommand(procedure, MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "~~~Select~~~" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }
        
        public static void GetDropdownListWithOneParameters(string procedure, ComboBox cb, string DisplayMember, string ValueMember, string param1, object val1)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand com = new SqlCommand(procedure, MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue(param1, val1);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "~~~Select~~~" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void GetDropdownListWithTwoParameters(string procedure, ComboBox cb, string DisplayMember, string ValueMember, string param1, object val1, string param2, object val2)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand com = new SqlCommand(procedure, MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue(param1, val1);
                com.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "~~~Select~~~" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void GetDropdownListWithThreeParameters(string procedure, ComboBox cb, string DisplayMember, string ValueMember, string param1, object val1, string param2, object val2,string param3, object val3)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand com = new SqlCommand(procedure, MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue(param1, val1);
                com.Parameters.AddWithValue(param2, val2);
                com.Parameters.AddWithValue(param3, val3);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "~~~Select~~~" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void GetDropdownListWithFourParameters(string procedure, ComboBox cb, string DisplayMember, string ValueMember, string param1, object val1, string param2, object val2, string param3, object val3, string param4, object val4)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand com = new SqlCommand(procedure, MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue(param1, val1);
                com.Parameters.AddWithValue(param2, val2);
                com.Parameters.AddWithValue(param3, val3);
                com.Parameters.AddWithValue(param4, val4);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "~~~Select~~~" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void DisableReset(Panel p)
        {
            foreach (Control  ctr in p.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = false;
                    txt.Text = "";
                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = false;
                    chk.Checked = false;
                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = false;
                    dtp.Value = DateTime.Now;
                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = false;
                   
                }
                if (ctr is PictureBox)
                {
                    PictureBox pic = (PictureBox)ctr;
                    pic.Image = null;

                }
                if (ctr is ListBox)
                {
                    ListBox lb = (ListBox)ctr;
                    lb.Enabled = false;
                    lb.ClearSelected();
                }
            }
        }

        public static void Disable(Panel p)
        {
            foreach (Control ctr in p.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = false;
                    
                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = false;
                    
                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = false;
                    
                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = false;
                   
                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = false;
                    
                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = false;

                }
                if (ctr is ListBox)
                {
                    ListBox lb = (ListBox)ctr;
                    lb.Enabled = false;
                }
            }
        }

        public static void EnableReset(Panel p)
        {
            foreach (Control ctr in p.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = true;
                    txt.Text = "";
                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = true;
                    chk.Checked = false;
                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = true;

                }
                if (ctr is PictureBox)
                {
                    PictureBox pic = (PictureBox)ctr;
                    pic.Image = null;

                }
                if (ctr is ListBox)
                {
                    ListBox lb = (ListBox)ctr;
                    lb.Enabled = true;
                    lb.ClearSelected();
                }
            }
        }

        public static void Enable(Panel p)
        {
            foreach (Control ctr in p.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = true;

                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = true;

                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = true;

                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = true;

                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = true;

                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = true;

                }
                if (ctr is ListBox)
                {
                    ListBox lb = (ListBox)ctr;
                    lb.Enabled = true;
                }
            }
        }

        public static void EnableReset(GroupBox gb)
        {
            foreach (Control ctr in gb.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = true;
                    txt.Text = "";
                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = true;
                    chk.Checked = false;
                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = true;

                }
                if (ctr is PictureBox)
                {
                    PictureBox pic = (PictureBox)ctr;
                    pic.Image = null;

                }
                if (ctr is ListBox)
                {
                    ListBox lb = (ListBox)ctr;
                    lb.Enabled = true;
                    lb.ClearSelected();
                }
            }
        }

        public static void SEND_WHATSAPP(string number, string message)
        {
            try
            {
                System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" + number + "&text=" + message);
            }
            catch (Exception x)
            {
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static string SEND_SMS(string Masking, string toNumber, string MessageText, string MyUsername, string MyPassword)
        {
            String URI = "http://weblogin.premiumsms.pk" +
            "/sendsms_url.html?" +
            "Username=" + MyUsername +
            "&Password=" + MyPassword +
            "&From=" + Masking +
            "&To=" + toNumber +
            "&Message=" + Uri.UnescapeDataString(MessageText); // Visual Studio 10-15 
                                                               // "//&message=" + System.Net.WebUtility.UrlEncode(MessageText);// Visual Studio 12 
            try
            {
                WebRequest req = WebRequest.Create(URI);
                WebResponse resp = req.GetResponse();
                var sr = new System.IO.StreamReader(resp.GetResponseStream());
                return sr.ReadToEnd().Trim();
            }
            catch (WebException ex)
            {
                var httpWebResponse = ex.Response as HttpWebResponse;
                if (httpWebResponse != null)
                {
                    switch (httpWebResponse.StatusCode)
                    {
                        case HttpStatusCode.NotFound:
                            return "404:URL not found :" + URI;
                            break;
                        case HttpStatusCode.BadRequest:
                            return "400:Bad Request";
                            break;
                        default:
                            return httpWebResponse.StatusCode.ToString();
                    }
                }
            }
            return null;

        }

    }
}
