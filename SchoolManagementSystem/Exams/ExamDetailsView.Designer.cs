namespace SchoolManagementSystem
{
    partial class ExamDetailsView
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvExamTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvExamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvExamDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLevelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvClassiD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSectionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvExamDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvTotalMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPassingPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.ddSection = new System.Windows.Forms.ComboBox();
            this.errSection = new System.Windows.Forms.Label();
            this.ddExamType = new System.Windows.Forms.ComboBox();
            this.dtExamDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errExamType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPassingPercent = new System.Windows.Forms.TextBox();
            this.errPassingPercent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddSubjects = new System.Windows.Forms.ComboBox();
            this.errSubject = new System.Windows.Forms.Label();
            this.dtSession = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ddLevel = new System.Windows.Forms.ComboBox();
            this.errLevel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ddClass = new System.Windows.Forms.ComboBox();
            this.errClass = new System.Windows.Forms.Label();
            this.errTotalMarks = new System.Windows.Forms.Label();
            this.errExamDate = new System.Windows.Forms.Label();
            this.btnAddToList = new System.Windows.Forms.Button();
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
            this.pnlDetails.Controls.Add(this.btnAddToList);
            this.pnlDetails.Controls.Add(this.label13);
            this.pnlDetails.Controls.Add(this.ddSection);
            this.pnlDetails.Controls.Add(this.errSection);
            this.pnlDetails.Controls.Add(this.ddExamType);
            this.pnlDetails.Controls.Add(this.dtExamDate);
            this.pnlDetails.Controls.Add(this.label9);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.errExamType);
            this.pnlDetails.Controls.Add(this.label10);
            this.pnlDetails.Controls.Add(this.txtPassingPercent);
            this.pnlDetails.Controls.Add(this.errPassingPercent);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Controls.Add(this.txtTotalMarks);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.ddSubjects);
            this.pnlDetails.Controls.Add(this.errSubject);
            this.pnlDetails.Controls.Add(this.dtSession);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.ddLevel);
            this.pnlDetails.Controls.Add(this.errLevel);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.ddClass);
            this.pnlDetails.Controls.Add(this.errClass);
            this.pnlDetails.Controls.Add(this.errTotalMarks);
            this.pnlDetails.Controls.Add(this.errExamDate);
            this.pnlDetails.Size = new System.Drawing.Size(332, 987);
            this.pnlDetails.Controls.SetChildIndex(this.errExamDate, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errTotalMarks, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errClass, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddClass, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errLevel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddLevel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label7, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtSession, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errSubject, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddSubjects, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label5, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtTotalMarks, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label8, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errPassingPercent, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtPassingPercent, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label10, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errExamType, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label6, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label9, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtExamDate, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddExamType, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errSection, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddSection, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label13, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnAddToList, 0);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1087, 896);
            this.groupBox2.TabIndex = 11;
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
            this.gvSNO,
            this.gvExamTypeID,
            this.gvExamName,
            this.gvExamID,
            this.gvExamDetailID,
            this.gvLevelID,
            this.gvLevel,
            this.gvClassiD,
            this.gvClass,
            this.gvSectionID,
            this.gvSection,
            this.gvSubjectID,
            this.gvSubject,
            this.gvExamDate,
            this.gvTotalMarks,
            this.gvPassingPercent});
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 865);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gvSNO
            // 
            this.gvSNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNO.HeaderText = "Sr. No.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Width = 90;
            // 
            // gvExamTypeID
            // 
            this.gvExamTypeID.HeaderText = "Exam Type ID";
            this.gvExamTypeID.Name = "gvExamTypeID";
            this.gvExamTypeID.ReadOnly = true;
            this.gvExamTypeID.Visible = false;
            // 
            // gvExamName
            // 
            this.gvExamName.HeaderText = "Exam Name";
            this.gvExamName.Name = "gvExamName";
            this.gvExamName.ReadOnly = true;
            // 
            // gvExamID
            // 
            this.gvExamID.HeaderText = "Exam ID";
            this.gvExamID.Name = "gvExamID";
            this.gvExamID.ReadOnly = true;
            this.gvExamID.Visible = false;
            // 
            // gvExamDetailID
            // 
            this.gvExamDetailID.HeaderText = "Exam Detail ID";
            this.gvExamDetailID.Name = "gvExamDetailID";
            this.gvExamDetailID.ReadOnly = true;
            this.gvExamDetailID.Visible = false;
            // 
            // gvLevelID
            // 
            this.gvLevelID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvLevelID.HeaderText = "Level ID";
            this.gvLevelID.Name = "gvLevelID";
            this.gvLevelID.ReadOnly = true;
            this.gvLevelID.Visible = false;
            // 
            // gvLevel
            // 
            this.gvLevel.HeaderText = "Level";
            this.gvLevel.Name = "gvLevel";
            this.gvLevel.ReadOnly = true;
            // 
            // gvClassiD
            // 
            this.gvClassiD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvClassiD.HeaderText = "Class ID";
            this.gvClassiD.Name = "gvClassiD";
            this.gvClassiD.ReadOnly = true;
            this.gvClassiD.Visible = false;
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
            // gvSubjectID
            // 
            this.gvSubjectID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSubjectID.HeaderText = "Subject ID";
            this.gvSubjectID.Name = "gvSubjectID";
            this.gvSubjectID.ReadOnly = true;
            this.gvSubjectID.Visible = false;
            // 
            // gvSubject
            // 
            this.gvSubject.HeaderText = "Subject";
            this.gvSubject.Name = "gvSubject";
            this.gvSubject.ReadOnly = true;
            // 
            // gvExamDate
            // 
            dataGridViewCellStyle2.Format = "dd-MMMM-yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.gvExamDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvExamDate.HeaderText = "Exam Date";
            this.gvExamDate.Name = "gvExamDate";
            this.gvExamDate.ReadOnly = true;
            // 
            // gvTotalMarks
            // 
            this.gvTotalMarks.HeaderText = "Total Marks";
            this.gvTotalMarks.Name = "gvTotalMarks";
            this.gvTotalMarks.ReadOnly = true;
            // 
            // gvPassingPercent
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.gvPassingPercent.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvPassingPercent.HeaderText = "Passing %";
            this.gvPassingPercent.Name = "gvPassingPercent";
            this.gvPassingPercent.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 390);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 23);
            this.label13.TabIndex = 130;
            this.label13.Text = "Section";
            // 
            // ddSection
            // 
            this.ddSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddSection.FormattingEnabled = true;
            this.ddSection.Location = new System.Drawing.Point(8, 419);
            this.ddSection.Margin = new System.Windows.Forms.Padding(4);
            this.ddSection.Name = "ddSection";
            this.ddSection.Size = new System.Drawing.Size(318, 31);
            this.ddSection.TabIndex = 110;
            this.ddSection.SelectedIndexChanged += new System.EventHandler(this.ddSection_SelectedIndexChanged_1);
            // 
            // errSection
            // 
            this.errSection.AutoSize = true;
            this.errSection.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSection.Location = new System.Drawing.Point(305, 390);
            this.errSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errSection.Name = "errSection";
            this.errSection.Size = new System.Drawing.Size(25, 35);
            this.errSection.TabIndex = 131;
            this.errSection.Text = "*";
            // 
            // ddExamType
            // 
            this.ddExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddExamType.FormattingEnabled = true;
            this.ddExamType.Location = new System.Drawing.Point(8, 156);
            this.ddExamType.Margin = new System.Windows.Forms.Padding(4);
            this.ddExamType.Name = "ddExamType";
            this.ddExamType.Size = new System.Drawing.Size(318, 31);
            this.ddExamType.TabIndex = 107;
            this.ddExamType.SelectedIndexChanged += new System.EventHandler(this.ddExamType_SelectedIndexChanged);
            // 
            // dtExamDate
            // 
            this.dtExamDate.CustomFormat = "dddd , dd-MMMM-yyyy";
            this.dtExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtExamDate.Location = new System.Drawing.Point(8, 556);
            this.dtExamDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtExamDate.Name = "dtExamDate";
            this.dtExamDate.Size = new System.Drawing.Size(318, 30);
            this.dtExamDate.TabIndex = 112;
            this.dtExamDate.ValueChanged += new System.EventHandler(this.dtExamDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 525);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 23);
            this.label9.TabIndex = 128;
            this.label9.Text = "Exam Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 126;
            this.label6.Text = "Exam Type";
            // 
            // errExamType
            // 
            this.errExamType.AutoSize = true;
            this.errExamType.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errExamType.Location = new System.Drawing.Point(305, 127);
            this.errExamType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errExamType.Name = "errExamType";
            this.errExamType.Size = new System.Drawing.Size(25, 35);
            this.errExamType.TabIndex = 127;
            this.errExamType.Text = "*";
            this.errExamType.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 663);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 23);
            this.label10.TabIndex = 124;
            this.label10.Text = "Passing Percentage";
            // 
            // txtPassingPercent
            // 
            this.txtPassingPercent.Location = new System.Drawing.Point(8, 693);
            this.txtPassingPercent.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassingPercent.Name = "txtPassingPercent";
            this.txtPassingPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassingPercent.Size = new System.Drawing.Size(318, 30);
            this.txtPassingPercent.TabIndex = 114;
            this.txtPassingPercent.TextChanged += new System.EventHandler(this.txtPassingPercent_TextChanged_1);
            // 
            // errPassingPercent
            // 
            this.errPassingPercent.AutoSize = true;
            this.errPassingPercent.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPassingPercent.Location = new System.Drawing.Point(305, 663);
            this.errPassingPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errPassingPercent.Name = "errPassingPercent";
            this.errPassingPercent.Size = new System.Drawing.Size(25, 35);
            this.errPassingPercent.TabIndex = 125;
            this.errPassingPercent.Text = "*";
            this.errPassingPercent.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 594);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.TabIndex = 122;
            this.label8.Text = "Total Marks";
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(8, 624);
            this.txtTotalMarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalMarks.Size = new System.Drawing.Size(318, 30);
            this.txtTotalMarks.TabIndex = 113;
            this.txtTotalMarks.TextChanged += new System.EventHandler(this.txtTotalMarks_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 456);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 120;
            this.label5.Text = "Select Subject";
            // 
            // ddSubjects
            // 
            this.ddSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddSubjects.FormattingEnabled = true;
            this.ddSubjects.Location = new System.Drawing.Point(8, 486);
            this.ddSubjects.Margin = new System.Windows.Forms.Padding(4);
            this.ddSubjects.Name = "ddSubjects";
            this.ddSubjects.Size = new System.Drawing.Size(318, 31);
            this.ddSubjects.TabIndex = 111;
            this.ddSubjects.SelectedIndexChanged += new System.EventHandler(this.ddSubjects_SelectedIndexChanged_1);
            // 
            // errSubject
            // 
            this.errSubject.AutoSize = true;
            this.errSubject.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSubject.Location = new System.Drawing.Point(305, 456);
            this.errSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errSubject.Name = "errSubject";
            this.errSubject.Size = new System.Drawing.Size(25, 35);
            this.errSubject.TabIndex = 121;
            this.errSubject.Text = "*";
            this.errSubject.Visible = false;
            // 
            // dtSession
            // 
            this.dtSession.CustomFormat = "yyyy";
            this.dtSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSession.Location = new System.Drawing.Point(8, 91);
            this.dtSession.Margin = new System.Windows.Forms.Padding(4);
            this.dtSession.Name = "dtSession";
            this.dtSession.ShowUpDown = true;
            this.dtSession.Size = new System.Drawing.Size(318, 30);
            this.dtSession.TabIndex = 106;
            this.dtSession.ValueChanged += new System.EventHandler(this.dtSession_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 119;
            this.label1.Text = "Session";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 117;
            this.label7.Text = "Select Level";
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLevel.FormattingEnabled = true;
            this.ddLevel.Location = new System.Drawing.Point(8, 285);
            this.ddLevel.Margin = new System.Windows.Forms.Padding(4);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.Size = new System.Drawing.Size(318, 31);
            this.ddLevel.TabIndex = 108;
            this.ddLevel.SelectedIndexChanged += new System.EventHandler(this.ddLevel_SelectedIndexChanged_1);
            // 
            // errLevel
            // 
            this.errLevel.AutoSize = true;
            this.errLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLevel.Location = new System.Drawing.Point(305, 256);
            this.errLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errLevel.Name = "errLevel";
            this.errLevel.Size = new System.Drawing.Size(25, 35);
            this.errLevel.TabIndex = 118;
            this.errLevel.Text = "*";
            this.errLevel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 115;
            this.label3.Text = "Select Class";
            // 
            // ddClass
            // 
            this.ddClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddClass.FormattingEnabled = true;
            this.ddClass.Location = new System.Drawing.Point(8, 352);
            this.ddClass.Margin = new System.Windows.Forms.Padding(4);
            this.ddClass.Name = "ddClass";
            this.ddClass.Size = new System.Drawing.Size(318, 31);
            this.ddClass.TabIndex = 109;
            this.ddClass.SelectedIndexChanged += new System.EventHandler(this.ddClass_SelectedIndexChanged_1);
            // 
            // errClass
            // 
            this.errClass.AutoSize = true;
            this.errClass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errClass.Location = new System.Drawing.Point(305, 322);
            this.errClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errClass.Name = "errClass";
            this.errClass.Size = new System.Drawing.Size(25, 35);
            this.errClass.TabIndex = 116;
            this.errClass.Text = "*";
            this.errClass.Visible = false;
            // 
            // errTotalMarks
            // 
            this.errTotalMarks.AutoSize = true;
            this.errTotalMarks.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errTotalMarks.Location = new System.Drawing.Point(305, 594);
            this.errTotalMarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errTotalMarks.Name = "errTotalMarks";
            this.errTotalMarks.Size = new System.Drawing.Size(25, 35);
            this.errTotalMarks.TabIndex = 123;
            this.errTotalMarks.Text = "*";
            this.errTotalMarks.Visible = false;
            // 
            // errExamDate
            // 
            this.errExamDate.AutoSize = true;
            this.errExamDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errExamDate.Location = new System.Drawing.Point(305, 525);
            this.errExamDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errExamDate.Name = "errExamDate";
            this.errExamDate.Size = new System.Drawing.Size(25, 35);
            this.errExamDate.TabIndex = 129;
            this.errExamDate.Text = "*";
            this.errExamDate.Visible = false;
            // 
            // btnAddToList
            // 
            this.btnAddToList.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddToList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToList.Location = new System.Drawing.Point(8, 198);
            this.btnAddToList.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(319, 54);
            this.btnAddToList.TabIndex = 132;
            this.btnAddToList.Text = "LOAD";
            this.btnAddToList.UseVisualStyleBackColor = false;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // ExamDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 1037);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "ExamDetailsView";
            this.Text = "View Exam Details";
            this.Load += new System.EventHandler(this.ExamDetailsView_Load);
            this.LeftPanel.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ddSection;
        private System.Windows.Forms.Label errSection;
        private System.Windows.Forms.ComboBox ddExamType;
        private System.Windows.Forms.DateTimePicker dtExamDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label errExamType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPassingPercent;
        private System.Windows.Forms.Label errPassingPercent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddSubjects;
        private System.Windows.Forms.Label errSubject;
        private System.Windows.Forms.DateTimePicker dtSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddLevel;
        private System.Windows.Forms.Label errLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddClass;
        private System.Windows.Forms.Label errClass;
        private System.Windows.Forms.Label errTotalMarks;
        private System.Windows.Forms.Label errExamDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvExamTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvExamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvExamDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvLevelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvClassiD;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSectionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvExamDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvTotalMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPassingPercent;
        private System.Windows.Forms.Button btnAddToList;
    }
}