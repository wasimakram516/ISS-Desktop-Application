using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
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
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool isMissingInformation = false;

            // Validate fields
            isMissingInformation |= ValidateField(txtDataSource, errDataSource);

            if (isMissingInformation)
            {
                MessageBox.Show("Fields with * are mandatory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Build and save the connection string
            sb.AppendFormat("Data Source={0}\\SQLEXPRESS;Initial Catalog=dbSMS;Integrated Security=true;MultipleActiveResultSets=true;", txtDataSource.Text);
            string connectionString = sb.ToString();
            File.WriteAllText(MainClass.path + "\\ISSConnect", connectionString);

            // Initialize the database and navigate accordingly
            if (InitializeDatabase(connectionString))
            {
                MessageBox.Show("Settings saved and database initialized successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowLoginWindow();
            }
        }

        private bool ValidateField(TextBox textBox, Label errorLabel)
        {
            bool isFieldEmpty = string.IsNullOrWhiteSpace(textBox.Text);
            errorLabel.Visible = isFieldEmpty;
            return isFieldEmpty;
        }

        private bool InitializeDatabase(string connectionString)
        {
            string databaseName = "dbSMS"; 
            string scriptFilePath = Path.Combine(Application.StartupPath, "dbScript.sql"); // Path to your SQL script

            try
            {
                string masterConnectionString = connectionString.Replace($"Initial Catalog={databaseName};", "Initial Catalog=master;");

                using (var connection = new SqlConnection(masterConnectionString))
                {
                    connection.Open();
                    string dbCreationScript = $@"
                IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = N'{databaseName}')
                BEGIN
                    CREATE DATABASE [{databaseName}];
                END";

                    using (var command = new SqlCommand(dbCreationScript, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                // Now that the database is created, run the script to create tables and stored procedures
                if (File.Exists(scriptFilePath))
                {
                    string scriptContent = File.ReadAllText(scriptFilePath);
                    ExecuteSqlScript(connectionString.Replace("master", databaseName), scriptContent);
                }
                else
                {
                    MessageBox.Show($"The script file was not found in path: {scriptFilePath}", "Script File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true; // Success
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize database: " + ex.Message, "Database Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Failure
            }
        }

        private void ExecuteSqlScript(string connectionString, string scriptContent)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Split the script on "GO" commands
                string[] scriptBatches = scriptContent.Split(new string[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var batch in scriptBatches)
                {
                    using (var command = new SqlCommand(batch, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }


            }
        }


        private void ShowLoginWindow()
        {
            Login log = new Login();
            MainClass.ShowWindow(log, this, MDI.ActiveForm);
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
                dbPrincipal pri = new SchoolManagementSystem.dbPrincipal();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
