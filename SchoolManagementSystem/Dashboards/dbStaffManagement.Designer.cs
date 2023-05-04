namespace ISS
{
    partial class dbStaffManagement
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
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnAssignment = new System.Windows.Forms.Button();
            this.btnStaffAttendance = new System.Windows.Forms.Button();
            this.btnSalaray = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.btnStaff, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAssignment, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStaffAttendance, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSalaray, 3, 0);
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
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnStaff
            // 
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Image = global::ISS.Properties.Resources.icons8_management_96;
            this.btnStaff.Location = new System.Drawing.Point(3, 3);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(205, 190);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.Text = "STAFF";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnAssignment
            // 
            this.btnAssignment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignment.Image = global::ISS.Properties.Resources.icons8_curriculum_961;
            this.btnAssignment.Location = new System.Drawing.Point(214, 3);
            this.btnAssignment.Name = "btnAssignment";
            this.btnAssignment.Size = new System.Drawing.Size(205, 190);
            this.btnAssignment.TabIndex = 1;
            this.btnAssignment.Text = "ASSIGN CLASSES";
            this.btnAssignment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAssignment.UseVisualStyleBackColor = true;
            this.btnAssignment.Click += new System.EventHandler(this.btnAssignment_Click);
            // 
            // btnStaffAttendance
            // 
            this.btnStaffAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStaffAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffAttendance.Image = global::ISS.Properties.Resources.icons8_edit_property_961;
            this.btnStaffAttendance.Location = new System.Drawing.Point(425, 3);
            this.btnStaffAttendance.Name = "btnStaffAttendance";
            this.btnStaffAttendance.Size = new System.Drawing.Size(205, 190);
            this.btnStaffAttendance.TabIndex = 2;
            this.btnStaffAttendance.Text = "STAFF ATTENDANCE";
            this.btnStaffAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStaffAttendance.UseVisualStyleBackColor = true;
            this.btnStaffAttendance.Click += new System.EventHandler(this.btnStaffAttendance_Click);
            // 
            // btnSalaray
            // 
            this.btnSalaray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalaray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalaray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaray.Image = global::ISS.Properties.Resources.icons8_cash_in_hand_96;
            this.btnSalaray.Location = new System.Drawing.Point(636, 3);
            this.btnSalaray.Name = "btnSalaray";
            this.btnSalaray.Size = new System.Drawing.Size(205, 190);
            this.btnSalaray.TabIndex = 3;
            this.btnSalaray.Text = "SALARIES";
            this.btnSalaray.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalaray.UseVisualStyleBackColor = true;
            this.btnSalaray.Click += new System.EventHandler(this.btnSalaray_Click);
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
            this.btnBack.TabIndex = 13;
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
            this.label1.Text = "Staff Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbStaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 834);
            this.Name = "dbStaffManagement";
            this.Text = "Staff Management Dashboard";
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
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnAssignment;
        private System.Windows.Forms.Button btnStaffAttendance;
        private System.Windows.Forms.Button btnSalaray;
        private System.Windows.Forms.Label label1;
    }
}