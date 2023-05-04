namespace ISS
{
    partial class dbStudemtManagement
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
            this.btnAdmissions = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnPassoutStudents = new System.Windows.Forms.Button();
            this.btnLeftStudents = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.SetChildIndex(this.label4, 0);
            this.panel3.Controls.SetChildIndex(this.btnBack, 0);
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
            this.tableLayoutPanel1.Controls.Add(this.btnAdmissions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAttendance, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStudents, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPassoutStudents, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLeftStudents, 0, 1);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnAdmissions
            // 
            this.btnAdmissions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmissions.Image = global::ISS.Properties.Resources.Add_Students2;
            this.btnAdmissions.Location = new System.Drawing.Point(3, 3);
            this.btnAdmissions.Name = "btnAdmissions";
            this.btnAdmissions.Size = new System.Drawing.Size(205, 190);
            this.btnAdmissions.TabIndex = 0;
            this.btnAdmissions.Text = "NEW ADMISSIONS";
            this.btnAdmissions.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdmissions.UseVisualStyleBackColor = true;
            this.btnAdmissions.Click += new System.EventHandler(this.btnAdmissions_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Image = global::ISS.Properties.Resources.icons8_attendance_96;
            this.btnAttendance.Location = new System.Drawing.Point(214, 3);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(205, 190);
            this.btnAttendance.TabIndex = 1;
            this.btnAttendance.Text = "ATTENDANCE";
            this.btnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Image = global::ISS.Properties.Resources.icons8_classroom_96;
            this.btnStudents.Location = new System.Drawing.Point(425, 3);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(205, 190);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "ENROLLED STUDENTS";
            this.btnStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnPassoutStudents
            // 
            this.btnPassoutStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassoutStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassoutStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassoutStudents.Image = global::ISS.Properties.Resources.icons8_student_male_96;
            this.btnPassoutStudents.Location = new System.Drawing.Point(636, 3);
            this.btnPassoutStudents.Name = "btnPassoutStudents";
            this.btnPassoutStudents.Size = new System.Drawing.Size(205, 190);
            this.btnPassoutStudents.TabIndex = 3;
            this.btnPassoutStudents.Text = "PASS OUT STUDENTS";
            this.btnPassoutStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPassoutStudents.UseVisualStyleBackColor = true;
            this.btnPassoutStudents.Click += new System.EventHandler(this.btnPassoutStudents_Click);
            // 
            // btnLeftStudents
            // 
            this.btnLeftStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeftStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeftStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftStudents.Image = global::ISS.Properties.Resources.icons8_leaving_queue_96;
            this.btnLeftStudents.Location = new System.Drawing.Point(3, 199);
            this.btnLeftStudents.Name = "btnLeftStudents";
            this.btnLeftStudents.Size = new System.Drawing.Size(205, 190);
            this.btnLeftStudents.TabIndex = 4;
            this.btnLeftStudents.Text = "LEFT STUDENTS";
            this.btnLeftStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLeftStudents.UseVisualStyleBackColor = true;
            this.btnLeftStudents.Click += new System.EventHandler(this.btnLeftStudents_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::ISS.Properties.Resources.back_wite;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 50);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 784);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbStudemtManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 834);
            this.Name = "dbStudemtManagement";
            this.Text = "Student Management Dashboard";
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

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAdmissions;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnPassoutStudents;
        private System.Windows.Forms.Button btnLeftStudents;
        private System.Windows.Forms.Label label1;
    }
}