namespace ISS
{
    partial class dbAdmin
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
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnBirthdays = new System.Windows.Forms.Button();
            this.btnStaffAttendance = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
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
            this.LeftPanel.Size = new System.Drawing.Size(260, 749);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Size = new System.Drawing.Size(260, 699);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(844, 749);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel1);
            this.panel6.Size = new System.Drawing.Size(844, 699);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LinkBtnLogOut);
            this.panel4.Controls.SetChildIndex(this.lblTopUser, 0);
            this.panel4.Controls.SetChildIndex(this.LinkBtnLogOut, 0);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Text = " ,  (  )";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnAttendance, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExams, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBirthdays, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStaffAttendance, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNotifications, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 699);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnAttendance
            // 
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Image = global::ISS.Properties.Resources.icons8_attendance_96;
            this.btnAttendance.Location = new System.Drawing.Point(3, 3);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(205, 168);
            this.btnAttendance.TabIndex = 9;
            this.btnAttendance.Text = "STUDENT ATTENDANCE";
            this.btnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnExams
            // 
            this.btnExams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExams.Image = global::ISS.Properties.Resources.icons8_pass_fail_96;
            this.btnExams.Location = new System.Drawing.Point(636, 3);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(205, 168);
            this.btnExams.TabIndex = 4;
            this.btnExams.Text = "EXAMINATIONS";
            this.btnExams.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExams.UseVisualStyleBackColor = true;
            this.btnExams.Click += new System.EventHandler(this.btnExams_Click);
            // 
            // btnBirthdays
            // 
            this.btnBirthdays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBirthdays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBirthdays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBirthdays.Image = global::ISS.Properties.Resources.Birthday_cake;
            this.btnBirthdays.Location = new System.Drawing.Point(3, 177);
            this.btnBirthdays.Name = "btnBirthdays";
            this.btnBirthdays.Size = new System.Drawing.Size(205, 168);
            this.btnBirthdays.TabIndex = 8;
            this.btnBirthdays.Text = "BIRTHDAYS";
            this.btnBirthdays.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBirthdays.UseVisualStyleBackColor = true;
            this.btnBirthdays.Click += new System.EventHandler(this.btnBirthdays_Click);
            // 
            // btnStaffAttendance
            // 
            this.btnStaffAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStaffAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffAttendance.Image = global::ISS.Properties.Resources.icons8_edit_property_961;
            this.btnStaffAttendance.Location = new System.Drawing.Point(214, 3);
            this.btnStaffAttendance.Name = "btnStaffAttendance";
            this.btnStaffAttendance.Size = new System.Drawing.Size(205, 168);
            this.btnStaffAttendance.TabIndex = 10;
            this.btnStaffAttendance.Text = "STAFF ATTENDANCE";
            this.btnStaffAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStaffAttendance.UseVisualStyleBackColor = true;
            this.btnStaffAttendance.Click += new System.EventHandler(this.btnStaffAttendance_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Image = global::ISS.Properties.Resources.Messages;
            this.btnNotifications.Location = new System.Drawing.Point(425, 3);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(205, 168);
            this.btnNotifications.TabIndex = 6;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNotifications.UseVisualStyleBackColor = true;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // LinkBtnLogOut
            // 
            this.LinkBtnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkBtnLogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.LinkBtnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkBtnLogOut.Location = new System.Drawing.Point(766, 0);
            this.LinkBtnLogOut.Name = "LinkBtnLogOut";
            this.LinkBtnLogOut.Size = new System.Drawing.Size(78, 50);
            this.LinkBtnLogOut.TabIndex = 14;
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
            this.label1.Size = new System.Drawing.Size(260, 699);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 749);
            this.Name = "dbAdmin";
            this.Text = "dbAdmin";
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
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnBirthdays;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnStaffAttendance;
        private System.Windows.Forms.LinkLabel LinkBtnLogOut;
        private System.Windows.Forms.Label label1;
    }
}