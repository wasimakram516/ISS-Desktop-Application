namespace ISS
{
    partial class StaffAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.errDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.lblExistAttend = new System.Windows.Forms.Label();
            this.gvCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAttendID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Size = new System.Drawing.Size(169, 30);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(334, 1037);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblExistAttend);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.dateTimePicker1);
            this.pnlDetails.Controls.Add(this.btnLoad);
            this.pnlDetails.Controls.Add(this.errDate);
            this.pnlDetails.Size = new System.Drawing.Size(334, 987);
            this.pnlDetails.Controls.SetChildIndex(this.errDate, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnLoad, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblExistAttend, 0);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(334, 50);
            // 
            // RightPanel
            // 
            this.RightPanel.Location = new System.Drawing.Point(334, 0);
            this.RightPanel.Size = new System.Drawing.Size(1085, 1037);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Size = new System.Drawing.Size(1085, 987);
            this.panel6.Controls.SetChildIndex(this.panel1, 0);
            this.panel6.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1085, 50);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(235, 0);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTopUser.Size = new System.Drawing.Size(762, 50);
            this.lblTopUser.Text = " , ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Date of Attendance";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dddd , dd-MMMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 150);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 30);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(13, 192);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(315, 51);
            this.btnLoad.TabIndex = 24;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // errDate
            // 
            this.errDate.AutoSize = true;
            this.errDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDate.Location = new System.Drawing.Point(302, 120);
            this.errDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errDate.Name = "errDate";
            this.errDate.Size = new System.Drawing.Size(25, 35);
            this.errDate.TabIndex = 27;
            this.errDate.Text = "*";
            this.errDate.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.chkSelectAll);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1085, 896);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvCheck,
            this.gvSNO,
            this.gvStaffID,
            this.gvCNIC,
            this.gvStaff,
            this.gvRole,
            this.gvAttendID,
            this.gvDate,
            this.gvStatus});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 838);
            this.dataGridView1.TabIndex = 0;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSelectAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkSelectAll.Location = new System.Drawing.Point(4, 27);
            this.chkSelectAll.Margin = new System.Windows.Forms.Padding(4);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(1077, 27);
            this.chkSelectAll.TabIndex = 98;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // lblExistAttend
            // 
            this.lblExistAttend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExistAttend.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistAttend.Location = new System.Drawing.Point(12, 373);
            this.lblExistAttend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExistAttend.Name = "lblExistAttend";
            this.lblExistAttend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExistAttend.Size = new System.Drawing.Size(389, 96);
            this.lblExistAttend.TabIndex = 28;
            this.lblExistAttend.Text = "Attendance is already marked!\r\n\r\nPress Edit button to update it!";
            this.lblExistAttend.Visible = false;
            // 
            // gvCheck
            // 
            this.gvCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvCheck.HeaderText = "";
            this.gvCheck.Name = "gvCheck";
            this.gvCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gvCheck.Width = 23;
            // 
            // gvSNO
            // 
            this.gvSNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNO.HeaderText = "Sr. No.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Width = 90;
            // 
            // gvStaffID
            // 
            this.gvStaffID.HeaderText = "Staff ID";
            this.gvStaffID.Name = "gvStaffID";
            this.gvStaffID.ReadOnly = true;
            this.gvStaffID.Visible = false;
            // 
            // gvCNIC
            // 
            this.gvCNIC.HeaderText = "CNIC";
            this.gvCNIC.Name = "gvCNIC";
            this.gvCNIC.ReadOnly = true;
            // 
            // gvStaff
            // 
            this.gvStaff.HeaderText = "Staff Name";
            this.gvStaff.Name = "gvStaff";
            this.gvStaff.ReadOnly = true;
            // 
            // gvRole
            // 
            this.gvRole.HeaderText = "Role";
            this.gvRole.Name = "gvRole";
            this.gvRole.ReadOnly = true;
            // 
            // gvAttendID
            // 
            this.gvAttendID.HeaderText = "Attendance ID";
            this.gvAttendID.Name = "gvAttendID";
            this.gvAttendID.ReadOnly = true;
            this.gvAttendID.Visible = false;
            // 
            // gvDate
            // 
            dataGridViewCellStyle2.NullValue = "-";
            this.gvDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvDate.HeaderText = "Date";
            this.gvDate.Name = "gvDate";
            this.gvDate.ReadOnly = true;
            this.gvDate.Visible = false;
            // 
            // gvStatus
            // 
            dataGridViewCellStyle3.NullValue = "-";
            this.gvStatus.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gvStatus.HeaderText = "Attendance";
            this.gvStatus.Items.AddRange(new object[] {
            "P",
            "A",
            "L",
            "HL",
            "GL"});
            this.gvStatus.Name = "gvStatus";
            this.gvStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // StaffAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 1037);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "StaffAttendance";
            this.Text = "Staff Attendance";
            this.Load += new System.EventHandler(this.StaffAttendance_Load);
            this.LeftPanel.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label errDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Label lblExistAttend;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAttendID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn gvStatus;
    }
}