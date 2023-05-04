namespace ISS
{
    partial class Attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.ddSection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errSection = new System.Windows.Forms.Label();
            this.errClass = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvRegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCLassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSectionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAttendID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.lblExistAttend = new System.Windows.Forms.Label();
            this.errDate = new System.Windows.Forms.Label();
            this.dtSession = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ddLevel = new System.Windows.Forms.ComboBox();
            this.errLevel = new System.Windows.Forms.Label();
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
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1087, 91);
            // 
            // txtSearch
            // 
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Size = new System.Drawing.Size(166, 30);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(332, 1037);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.dtSession);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.ddLevel);
            this.pnlDetails.Controls.Add(this.errLevel);
            this.pnlDetails.Controls.Add(this.lblExistAttend);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.dateTimePicker1);
            this.pnlDetails.Controls.Add(this.btnLoad);
            this.pnlDetails.Controls.Add(this.ddSection);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.ddClass);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.errSection);
            this.pnlDetails.Controls.Add(this.errClass);
            this.pnlDetails.Controls.Add(this.errDate);
            this.pnlDetails.Size = new System.Drawing.Size(332, 987);
            this.pnlDetails.Controls.SetChildIndex(this.errDate, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errClass, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errSection, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddClass, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddSection, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnLoad, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblExistAttend, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errLevel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddLevel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label7, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label5, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtSession, 0);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(332, 50);
            // 
            // RightPanel
            // 
            this.RightPanel.Location = new System.Drawing.Point(332, 0);
            this.RightPanel.Size = new System.Drawing.Size(1087, 1037);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Size = new System.Drawing.Size(1087, 987);
            this.panel6.Controls.SetChildIndex(this.panel1, 0);
            this.panel6.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1087, 50);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(233, 0);
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
            this.label3.Location = new System.Drawing.Point(10, 391);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date of Attendance";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dddd , dd-MMMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 421);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 30);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(12, 463);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(315, 51);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ddSection
            // 
            this.ddSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddSection.FormattingEnabled = true;
            this.ddSection.Location = new System.Drawing.Point(10, 353);
            this.ddSection.Margin = new System.Windows.Forms.Padding(4);
            this.ddSection.Name = "ddSection";
            this.ddSection.Size = new System.Drawing.Size(314, 31);
            this.ddSection.TabIndex = 3;
            this.ddSection.SelectedIndexChanged += new System.EventHandler(this.ddSection_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Section";
            // 
            // ddClass
            // 
            this.ddClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddClass.FormattingEnabled = true;
            this.ddClass.Location = new System.Drawing.Point(12, 287);
            this.ddClass.Margin = new System.Windows.Forms.Padding(4);
            this.ddClass.Name = "ddClass";
            this.ddClass.Size = new System.Drawing.Size(314, 31);
            this.ddClass.TabIndex = 2;
            this.ddClass.SelectedIndexChanged += new System.EventHandler(this.ddClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select Class";
            // 
            // errSection
            // 
            this.errSection.AutoSize = true;
            this.errSection.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSection.Location = new System.Drawing.Point(301, 325);
            this.errSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errSection.Name = "errSection";
            this.errSection.Size = new System.Drawing.Size(25, 35);
            this.errSection.TabIndex = 21;
            this.errSection.Text = "*";
            this.errSection.Visible = false;
            // 
            // errClass
            // 
            this.errClass.AutoSize = true;
            this.errClass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errClass.Location = new System.Drawing.Point(300, 256);
            this.errClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errClass.Name = "errClass";
            this.errClass.Size = new System.Drawing.Size(25, 35);
            this.errClass.TabIndex = 20;
            this.errClass.Text = "*";
            this.errClass.Visible = false;
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
            this.groupBox2.Size = new System.Drawing.Size(1087, 896);
            this.groupBox2.TabIndex = 8;
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
            this.gvRegNo,
            this.gvStuName,
            this.gvCLassID,
            this.gvClass,
            this.gvSectionID,
            this.gvSection,
            this.gvAttendID,
            this.gvDate,
            this.gvStatus});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 838);
            this.dataGridView1.TabIndex = 99;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError_1);
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
            // gvRegNo
            // 
            this.gvRegNo.HeaderText = "Reg. No.";
            this.gvRegNo.Name = "gvRegNo";
            this.gvRegNo.ReadOnly = true;
            // 
            // gvStuName
            // 
            this.gvStuName.HeaderText = "Student";
            this.gvStuName.Name = "gvStuName";
            this.gvStuName.ReadOnly = true;
            // 
            // gvCLassID
            // 
            this.gvCLassID.HeaderText = "CLass ID";
            this.gvCLassID.Name = "gvCLassID";
            this.gvCLassID.Visible = false;
            // 
            // gvClass
            // 
            this.gvClass.HeaderText = "Class";
            this.gvClass.Name = "gvClass";
            this.gvClass.ReadOnly = true;
            // 
            // gvSectionID
            // 
            this.gvSectionID.HeaderText = "Section ID";
            this.gvSectionID.Name = "gvSectionID";
            this.gvSectionID.ReadOnly = true;
            this.gvSectionID.Visible = false;
            // 
            // gvSection
            // 
            this.gvSection.HeaderText = "Section";
            this.gvSection.Name = "gvSection";
            this.gvSection.ReadOnly = true;
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
            this.gvDate.HeaderText = "Date";
            this.gvDate.Name = "gvDate";
            this.gvDate.ReadOnly = true;
            // 
            // gvStatus
            // 
            dataGridViewCellStyle2.NullValue = "-";
            this.gvStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gvStatus.HeaderText = "Attendance";
            this.gvStatus.Items.AddRange(new object[] {
            "P",
            "A",
            "L"});
            this.gvStatus.Name = "gvStatus";
            this.gvStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSelectAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkSelectAll.Location = new System.Drawing.Point(4, 27);
            this.chkSelectAll.Margin = new System.Windows.Forms.Padding(4);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(1079, 27);
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
            this.lblExistAttend.Location = new System.Drawing.Point(12, 536);
            this.lblExistAttend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExistAttend.Name = "lblExistAttend";
            this.lblExistAttend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExistAttend.Size = new System.Drawing.Size(387, 96);
            this.lblExistAttend.TabIndex = 22;
            this.lblExistAttend.Text = "Attendance is already marked!\r\n\r\nPress Edit button to update it!";
            this.lblExistAttend.Visible = false;
            // 
            // errDate
            // 
            this.errDate.AutoSize = true;
            this.errDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDate.Location = new System.Drawing.Point(301, 391);
            this.errDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errDate.Name = "errDate";
            this.errDate.Size = new System.Drawing.Size(25, 35);
            this.errDate.TabIndex = 23;
            this.errDate.Text = "*";
            this.errDate.Visible = false;
            // 
            // dtSession
            // 
            this.dtSession.CustomFormat = "yyyy";
            this.dtSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSession.Location = new System.Drawing.Point(10, 150);
            this.dtSession.Margin = new System.Windows.Forms.Padding(4);
            this.dtSession.Name = "dtSession";
            this.dtSession.ShowUpDown = true;
            this.dtSession.Size = new System.Drawing.Size(315, 30);
            this.dtSession.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 126;
            this.label5.Text = "Session";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 124;
            this.label7.Text = "Select Level";
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLevel.FormattingEnabled = true;
            this.ddLevel.Location = new System.Drawing.Point(10, 219);
            this.ddLevel.Margin = new System.Windows.Forms.Padding(4);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddLevel.Size = new System.Drawing.Size(315, 31);
            this.ddLevel.TabIndex = 1;
            this.ddLevel.SelectedIndexChanged += new System.EventHandler(this.ddLevel_SelectedIndexChanged);
            // 
            // errLevel
            // 
            this.errLevel.AutoSize = true;
            this.errLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLevel.Location = new System.Drawing.Point(301, 188);
            this.errLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errLevel.Name = "errLevel";
            this.errLevel.Size = new System.Drawing.Size(25, 35);
            this.errLevel.TabIndex = 125;
            this.errLevel.Text = "*";
            this.errLevel.Visible = false;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 1037);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Attendance";
            this.Text = "Students\' Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
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
        private System.Windows.Forms.ComboBox ddSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errSection;
        private System.Windows.Forms.Label errClass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblExistAttend;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Label errDate;
        private System.Windows.Forms.DateTimePicker dtSession;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddLevel;
        private System.Windows.Forms.Label errLevel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvRegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCLassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSectionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAttendID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn gvStatus;
    }
}