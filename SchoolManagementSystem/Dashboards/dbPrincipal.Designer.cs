namespace SchoolManagementSystem
{
    partial class dbPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCampusManagement = new System.Windows.Forms.Button();
            this.btnStaffManagement = new System.Windows.Forms.Button();
            this.btnStudentManagement = new System.Windows.Forms.Button();
            this.btnFeeManagement = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnBirthdays = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.LinkBtnLogOut = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(260, 834);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Size = new System.Drawing.Size(260, 784);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(844, 834);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel1);
            this.panel6.Size = new System.Drawing.Size(844, 784);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LinkBtnLogOut);
            this.panel4.Controls.SetChildIndex(this.lblTopUser, 0);
            this.panel4.Controls.SetChildIndex(this.LinkBtnLogOut, 0);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnCampusManagement, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStaffManagement, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStudentManagement, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFeeManagement, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExams, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNotifications, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExpenses, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBirthdays, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnReports, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 784);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCampusManagement
            // 
            this.btnCampusManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCampusManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCampusManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCampusManagement.Image = global::SchoolManagementSystem.Properties.Resources.icons8_school_building_96;
            this.btnCampusManagement.Location = new System.Drawing.Point(3, 3);
            this.btnCampusManagement.Name = "btnCampusManagement";
            this.btnCampusManagement.Size = new System.Drawing.Size(205, 190);
            this.btnCampusManagement.TabIndex = 0;
            this.btnCampusManagement.Text = "CAMPUS SETTINGS";
            this.btnCampusManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCampusManagement.UseVisualStyleBackColor = true;
            this.btnCampusManagement.Click += new System.EventHandler(this.btnCampusManagement_Click);
            // 
            // btnStaffManagement
            // 
            this.btnStaffManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStaffManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffManagement.Image = global::SchoolManagementSystem.Properties.Resources.icons8_management_96;
            this.btnStaffManagement.Location = new System.Drawing.Point(214, 3);
            this.btnStaffManagement.Name = "btnStaffManagement";
            this.btnStaffManagement.Size = new System.Drawing.Size(205, 190);
            this.btnStaffManagement.TabIndex = 1;
            this.btnStaffManagement.Text = "STAFF MANAGEMENT";
            this.btnStaffManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStaffManagement.UseVisualStyleBackColor = true;
            this.btnStaffManagement.Click += new System.EventHandler(this.btnStaffManagement_Click);
            // 
            // btnStudentManagement
            // 
            this.btnStudentManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStudentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentManagement.Image = global::SchoolManagementSystem.Properties.Resources.icons8_students_96;
            this.btnStudentManagement.Location = new System.Drawing.Point(425, 3);
            this.btnStudentManagement.Name = "btnStudentManagement";
            this.btnStudentManagement.Size = new System.Drawing.Size(205, 190);
            this.btnStudentManagement.TabIndex = 2;
            this.btnStudentManagement.Text = "STUDENT MANAGEMENT";
            this.btnStudentManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStudentManagement.UseVisualStyleBackColor = true;
            this.btnStudentManagement.Click += new System.EventHandler(this.btnStudentManagement_Click);
            // 
            // btnFeeManagement
            // 
            this.btnFeeManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeeManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeeManagement.Image = global::SchoolManagementSystem.Properties.Resources.icons8_cash_in_hand_96;
            this.btnFeeManagement.Location = new System.Drawing.Point(636, 3);
            this.btnFeeManagement.Name = "btnFeeManagement";
            this.btnFeeManagement.Size = new System.Drawing.Size(205, 190);
            this.btnFeeManagement.TabIndex = 3;
            this.btnFeeManagement.Text = "FEE MANAGEMENT";
            this.btnFeeManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFeeManagement.UseVisualStyleBackColor = true;
            this.btnFeeManagement.Click += new System.EventHandler(this.btnFeeManagement_Click);
            // 
            // btnExams
            // 
            this.btnExams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExams.Image = global::SchoolManagementSystem.Properties.Resources.icons8_pass_fail_96;
            this.btnExams.Location = new System.Drawing.Point(3, 199);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(205, 190);
            this.btnExams.TabIndex = 4;
            this.btnExams.Text = "EXAMINATIONS";
            this.btnExams.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExams.UseVisualStyleBackColor = true;
            this.btnExams.Click += new System.EventHandler(this.btnExams_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Image = global::SchoolManagementSystem.Properties.Resources.Messages;
            this.btnNotifications.Location = new System.Drawing.Point(214, 199);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(205, 190);
            this.btnNotifications.TabIndex = 6;
            this.btnNotifications.Text = "NOTIFICATIONS";
            this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNotifications.UseVisualStyleBackColor = true;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Image = global::SchoolManagementSystem.Properties.Resources.budget_96;
            this.btnExpenses.Location = new System.Drawing.Point(425, 199);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(205, 190);
            this.btnExpenses.TabIndex = 7;
            this.btnExpenses.Text = "INCOME AND EXPENDITURES";
            this.btnExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExpenses.UseVisualStyleBackColor = true;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnBirthdays
            // 
            this.btnBirthdays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBirthdays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBirthdays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBirthdays.Image = global::SchoolManagementSystem.Properties.Resources.Birthday_cake;
            this.btnBirthdays.Location = new System.Drawing.Point(636, 199);
            this.btnBirthdays.Name = "btnBirthdays";
            this.btnBirthdays.Size = new System.Drawing.Size(205, 190);
            this.btnBirthdays.TabIndex = 8;
            this.btnBirthdays.Text = "BIRTHDAYS";
            this.btnBirthdays.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBirthdays.UseVisualStyleBackColor = true;
            this.btnBirthdays.Click += new System.EventHandler(this.btnBirthdays_Click);
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Image = global::SchoolManagementSystem.Properties.Resources.icons8_edit_property_961;
            this.btnReports.Location = new System.Drawing.Point(3, 395);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(205, 190);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "REPORTS";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // LinkBtnLogOut
            // 
            this.LinkBtnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkBtnLogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.LinkBtnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkBtnLogOut.Location = new System.Drawing.Point(766, 0);
            this.LinkBtnLogOut.Name = "LinkBtnLogOut";
            this.LinkBtnLogOut.Size = new System.Drawing.Size(78, 50);
            this.LinkBtnLogOut.TabIndex = 13;
            this.LinkBtnLogOut.TabStop = true;
            this.LinkBtnLogOut.Text = "Log out";
            this.LinkBtnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LinkBtnLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkBtnLogOut_LinkClicked);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 784);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 834);
            this.Name = "dbPrincipal";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.dbAdmin_Load);
            this.LeftPanel.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCampusManagement;
        private System.Windows.Forms.Button btnStaffManagement;
        private System.Windows.Forms.Button btnStudentManagement;
        private System.Windows.Forms.Button btnFeeManagement;
        private System.Windows.Forms.LinkLabel LinkBtnLogOut;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnBirthdays;
    }
}