namespace SchoolManagementSystem
{
    partial class ActiveStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.ddLevel = new System.Windows.Forms.ComboBox();
            this.errLevel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ddSection = new System.Windows.Forms.ComboBox();
            this.errSection = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ddClass = new System.Windows.Forms.ComboBox();
            this.errClass = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvRegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLevelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSectionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtSession = new System.Windows.Forms.DateTimePicker();
            this.lblLeftStudent = new System.Windows.Forms.Label();
            this.ddLeftStudent = new System.Windows.Forms.ComboBox();
            this.pnlLeftStudent = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.ddLeftReason = new System.Windows.Forms.ComboBox();
            this.errLeftReason = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ddStatus = new System.Windows.Forms.ComboBox();
            this.dtLeftDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.errStatus = new System.Windows.Forms.Label();
            this.pnlPromoteStudent = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.ddPReason = new System.Windows.Forms.ComboBox();
            this.errPReason = new System.Windows.Forms.Label();
            this.dtPSession = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.errPSession = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ddPLevel = new System.Windows.Forms.ComboBox();
            this.errPLevel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ddPSection = new System.Windows.Forms.ComboBox();
            this.errPSection = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ddPClass = new System.Windows.Forms.ComboBox();
            this.errPClass = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlLeftStudent.SuspendLayout();
            this.pnlPromoteStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(260, 749);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblLeftStudent);
            this.pnlDetails.Controls.Add(this.ddLeftStudent);
            this.pnlDetails.Controls.Add(this.dtSession);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.btnLoad);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.ddLevel);
            this.pnlDetails.Controls.Add(this.errLevel);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Controls.Add(this.ddSection);
            this.pnlDetails.Controls.Add(this.errSection);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.ddClass);
            this.pnlDetails.Controls.Add(this.errClass);
            this.pnlDetails.Controls.Add(this.pnlPromoteStudent);
            this.pnlDetails.Controls.Add(this.pnlLeftStudent);
            this.pnlDetails.Size = new System.Drawing.Size(260, 699);
            this.pnlDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDetails_Paint);
            this.pnlDetails.Controls.SetChildIndex(this.pnlLeftStudent, 0);
            this.pnlDetails.Controls.SetChildIndex(this.pnlPromoteStudent, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errClass, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddClass, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errSection, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddSection, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label8, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errLevel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddLevel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label7, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnLoad, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtSession, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddLeftStudent, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblLeftStudent, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(844, 749);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Size = new System.Drawing.Size(844, 699);
            this.panel6.Controls.SetChildIndex(this.panel1, 0);
            this.panel6.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Text = " , ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Select Level";
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLevel.FormattingEnabled = true;
            this.ddLevel.Location = new System.Drawing.Point(129, 88);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.Size = new System.Drawing.Size(125, 25);
            this.ddLevel.TabIndex = 1;
            this.ddLevel.SelectedIndexChanged += new System.EventHandler(this.ddLevel_SelectedIndexChanged);
            // 
            // errLevel
            // 
            this.errLevel.AutoSize = true;
            this.errLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLevel.Location = new System.Drawing.Point(237, 67);
            this.errLevel.Name = "errLevel";
            this.errLevel.Size = new System.Drawing.Size(20, 28);
            this.errLevel.TabIndex = 33;
            this.errLevel.Text = "*";
            this.errLevel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Select Section";
            // 
            // ddSection
            // 
            this.ddSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddSection.FormattingEnabled = true;
            this.ddSection.Location = new System.Drawing.Point(129, 134);
            this.ddSection.Name = "ddSection";
            this.ddSection.Size = new System.Drawing.Size(125, 25);
            this.ddSection.TabIndex = 3;
            this.ddSection.SelectedIndexChanged += new System.EventHandler(this.ddSection_SelectedIndexChanged);
            // 
            // errSection
            // 
            this.errSection.AutoSize = true;
            this.errSection.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSection.Location = new System.Drawing.Point(226, 112);
            this.errSection.Name = "errSection";
            this.errSection.Size = new System.Drawing.Size(20, 28);
            this.errSection.TabIndex = 30;
            this.errSection.Text = "*";
            this.errSection.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Select Class";
            // 
            // ddClass
            // 
            this.ddClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddClass.FormattingEnabled = true;
            this.ddClass.Location = new System.Drawing.Point(6, 134);
            this.ddClass.Name = "ddClass";
            this.ddClass.Size = new System.Drawing.Size(117, 25);
            this.ddClass.TabIndex = 2;
            this.ddClass.SelectedIndexChanged += new System.EventHandler(this.ddClass_SelectedIndexChanged);
            // 
            // errClass
            // 
            this.errClass.AutoSize = true;
            this.errClass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errClass.Location = new System.Drawing.Point(103, 112);
            this.errClass.Name = "errClass";
            this.errClass.Size = new System.Drawing.Size(20, 28);
            this.errClass.TabIndex = 28;
            this.errClass.Text = "*";
            this.errClass.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.chkSelectAll);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 632);
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
            this.gvFatherName,
            this.gvLevelID,
            this.gvLevel,
            this.gvClassID,
            this.gvClass,
            this.gvSectionID,
            this.gvSection,
            this.gvSession,
            this.gvStatus});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(838, 585);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gvCheck
            // 
            this.gvCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvCheck.FalseValue = "0";
            this.gvCheck.HeaderText = "";
            this.gvCheck.Name = "gvCheck";
            this.gvCheck.TrueValue = "1";
            this.gvCheck.Width = 5;
            // 
            // gvSNO
            // 
            this.gvSNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNO.HeaderText = "";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Width = 19;
            // 
            // gvRegNo
            // 
            this.gvRegNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvRegNo.HeaderText = "Reg. No.";
            this.gvRegNo.Name = "gvRegNo";
            this.gvRegNo.ReadOnly = true;
            this.gvRegNo.Width = 60;
            // 
            // gvStuName
            // 
            this.gvStuName.HeaderText = "Student Name";
            this.gvStuName.Name = "gvStuName";
            this.gvStuName.ReadOnly = true;
            // 
            // gvFatherName
            // 
            this.gvFatherName.HeaderText = "Father Name";
            this.gvFatherName.Name = "gvFatherName";
            this.gvFatherName.ReadOnly = true;
            // 
            // gvLevelID
            // 
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
            // gvClassID
            // 
            this.gvClassID.HeaderText = "Class ID";
            this.gvClassID.Name = "gvClassID";
            this.gvClassID.ReadOnly = true;
            this.gvClassID.Visible = false;
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
            // gvSession
            // 
            this.gvSession.HeaderText = "Session";
            this.gvSession.Name = "gvSession";
            this.gvSession.ReadOnly = true;
            // 
            // gvStatus
            // 
            this.gvStatus.HeaderText = "Status";
            this.gvStatus.Name = "gvStatus";
            this.gvStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkSelectAll.Location = new System.Drawing.Point(3, 21);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(838, 23);
            this.chkSelectAll.TabIndex = 97;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(6, 165);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(248, 40);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 28);
            this.label2.TabIndex = 35;
            this.label2.Text = "*";
            this.label2.Visible = false;
            // 
            // dtSession
            // 
            this.dtSession.CustomFormat = "yyyy";
            this.dtSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSession.Location = new System.Drawing.Point(6, 88);
            this.dtSession.Name = "dtSession";
            this.dtSession.ShowUpDown = true;
            this.dtSession.Size = new System.Drawing.Size(117, 25);
            this.dtSession.TabIndex = 0;
            // 
            // lblLeftStudent
            // 
            this.lblLeftStudent.AutoSize = true;
            this.lblLeftStudent.Location = new System.Drawing.Point(6, 206);
            this.lblLeftStudent.Name = "lblLeftStudent";
            this.lblLeftStudent.Size = new System.Drawing.Size(106, 19);
            this.lblLeftStudent.TabIndex = 38;
            this.lblLeftStudent.Text = "Left / Promoted";
            this.lblLeftStudent.Visible = false;
            // 
            // ddLeftStudent
            // 
            this.ddLeftStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLeftStudent.FormattingEnabled = true;
            this.ddLeftStudent.Items.AddRange(new object[] {
            "Left",
            "Promoted"});
            this.ddLeftStudent.Location = new System.Drawing.Point(6, 228);
            this.ddLeftStudent.Name = "ddLeftStudent";
            this.ddLeftStudent.Size = new System.Drawing.Size(248, 25);
            this.ddLeftStudent.TabIndex = 5;
            this.ddLeftStudent.Visible = false;
            this.ddLeftStudent.SelectedIndexChanged += new System.EventHandler(this.ddLeft_SelectedIndexChanged);
            // 
            // pnlLeftStudent
            // 
            this.pnlLeftStudent.Controls.Add(this.label10);
            this.pnlLeftStudent.Controls.Add(this.ddLeftReason);
            this.pnlLeftStudent.Controls.Add(this.errLeftReason);
            this.pnlLeftStudent.Controls.Add(this.label6);
            this.pnlLeftStudent.Controls.Add(this.ddStatus);
            this.pnlLeftStudent.Controls.Add(this.dtLeftDate);
            this.pnlLeftStudent.Controls.Add(this.label5);
            this.pnlLeftStudent.Controls.Add(this.errStatus);
            this.pnlLeftStudent.Location = new System.Drawing.Point(0, 259);
            this.pnlLeftStudent.Name = "pnlLeftStudent";
            this.pnlLeftStudent.Size = new System.Drawing.Size(260, 152);
            this.pnlLeftStudent.TabIndex = 39;
            this.pnlLeftStudent.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 19);
            this.label10.TabIndex = 44;
            this.label10.Text = "Reason";
            // 
            // ddLeftReason
            // 
            this.ddLeftReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLeftReason.FormattingEnabled = true;
            this.ddLeftReason.Items.AddRange(new object[] {
            "Left",
            "Certified"});
            this.ddLeftReason.Location = new System.Drawing.Point(6, 77);
            this.ddLeftReason.Name = "ddLeftReason";
            this.ddLeftReason.Size = new System.Drawing.Size(248, 25);
            this.ddLeftReason.TabIndex = 1;
            this.ddLeftReason.SelectedIndexChanged += new System.EventHandler(this.ddLeftReason_SelectedIndexChanged);
            // 
            // errLeftReason
            // 
            this.errLeftReason.AutoSize = true;
            this.errLeftReason.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLeftReason.Location = new System.Drawing.Point(234, 55);
            this.errLeftReason.Name = "errLeftReason";
            this.errLeftReason.Size = new System.Drawing.Size(20, 28);
            this.errLeftReason.TabIndex = 45;
            this.errLeftReason.Text = "*";
            this.errLeftReason.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "Status";
            // 
            // ddStatus
            // 
            this.ddStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddStatus.FormattingEnabled = true;
            this.ddStatus.Items.AddRange(new object[] {
            "In-active"});
            this.ddStatus.Location = new System.Drawing.Point(6, 127);
            this.ddStatus.Name = "ddStatus";
            this.ddStatus.Size = new System.Drawing.Size(248, 25);
            this.ddStatus.TabIndex = 2;
            this.ddStatus.SelectedIndexChanged += new System.EventHandler(this.ddStatus_SelectedIndexChanged);
            // 
            // dtLeftDate
            // 
            this.dtLeftDate.CustomFormat = "dd-MMM-yyyy";
            this.dtLeftDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLeftDate.Location = new System.Drawing.Point(6, 26);
            this.dtLeftDate.Name = "dtLeftDate";
            this.dtLeftDate.Size = new System.Drawing.Size(248, 25);
            this.dtLeftDate.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Left Date";
            // 
            // errStatus
            // 
            this.errStatus.AutoSize = true;
            this.errStatus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errStatus.Location = new System.Drawing.Point(234, 105);
            this.errStatus.Name = "errStatus";
            this.errStatus.Size = new System.Drawing.Size(20, 28);
            this.errStatus.TabIndex = 42;
            this.errStatus.Text = "*";
            this.errStatus.Visible = false;
            // 
            // pnlPromoteStudent
            // 
            this.pnlPromoteStudent.Controls.Add(this.label12);
            this.pnlPromoteStudent.Controls.Add(this.ddPReason);
            this.pnlPromoteStudent.Controls.Add(this.errPReason);
            this.pnlPromoteStudent.Controls.Add(this.dtPSession);
            this.pnlPromoteStudent.Controls.Add(this.label9);
            this.pnlPromoteStudent.Controls.Add(this.errPSession);
            this.pnlPromoteStudent.Controls.Add(this.label11);
            this.pnlPromoteStudent.Controls.Add(this.ddPLevel);
            this.pnlPromoteStudent.Controls.Add(this.errPLevel);
            this.pnlPromoteStudent.Controls.Add(this.label13);
            this.pnlPromoteStudent.Controls.Add(this.ddPSection);
            this.pnlPromoteStudent.Controls.Add(this.errPSection);
            this.pnlPromoteStudent.Controls.Add(this.label15);
            this.pnlPromoteStudent.Controls.Add(this.ddPClass);
            this.pnlPromoteStudent.Controls.Add(this.errPClass);
            this.pnlPromoteStudent.Location = new System.Drawing.Point(3, 259);
            this.pnlPromoteStudent.Name = "pnlPromoteStudent";
            this.pnlPromoteStudent.Size = new System.Drawing.Size(260, 152);
            this.pnlPromoteStudent.TabIndex = 40;
            this.pnlPromoteStudent.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 19);
            this.label12.TabIndex = 50;
            this.label12.Text = "Reason";
            // 
            // ddPReason
            // 
            this.ddPReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddPReason.FormattingEnabled = true;
            this.ddPReason.Items.AddRange(new object[] {
            "Conditionally Promoted",
            "Certified"});
            this.ddPReason.Location = new System.Drawing.Point(3, 124);
            this.ddPReason.Name = "ddPReason";
            this.ddPReason.Size = new System.Drawing.Size(245, 25);
            this.ddPReason.TabIndex = 4;
            this.ddPReason.SelectedIndexChanged += new System.EventHandler(this.ddPReason_SelectedIndexChanged);
            // 
            // errPReason
            // 
            this.errPReason.AutoSize = true;
            this.errPReason.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPReason.Location = new System.Drawing.Point(234, 102);
            this.errPReason.Name = "errPReason";
            this.errPReason.Size = new System.Drawing.Size(20, 28);
            this.errPReason.TabIndex = 51;
            this.errPReason.Text = "*";
            this.errPReason.Visible = false;
            // 
            // dtPSession
            // 
            this.dtPSession.CustomFormat = "yyyy";
            this.dtPSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPSession.Location = new System.Drawing.Point(3, 29);
            this.dtPSession.Name = "dtPSession";
            this.dtPSession.ShowUpDown = true;
            this.dtPSession.Size = new System.Drawing.Size(123, 25);
            this.dtPSession.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "Session";
            // 
            // errPSession
            // 
            this.errPSession.AutoSize = true;
            this.errPSession.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPSession.Location = new System.Drawing.Point(106, 5);
            this.errPSession.Name = "errPSession";
            this.errPSession.Size = new System.Drawing.Size(20, 28);
            this.errPSession.TabIndex = 47;
            this.errPSession.Text = "*";
            this.errPSession.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(128, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 19);
            this.label11.TabIndex = 44;
            this.label11.Text = "Level";
            // 
            // ddPLevel
            // 
            this.ddPLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddPLevel.FormattingEnabled = true;
            this.ddPLevel.Location = new System.Drawing.Point(128, 29);
            this.ddPLevel.Name = "ddPLevel";
            this.ddPLevel.Size = new System.Drawing.Size(123, 25);
            this.ddPLevel.TabIndex = 0;
            this.ddPLevel.SelectedIndexChanged += new System.EventHandler(this.ddPLevel_SelectedIndexChanged);
            // 
            // errPLevel
            // 
            this.errPLevel.AutoSize = true;
            this.errPLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPLevel.Location = new System.Drawing.Point(231, 6);
            this.errPLevel.Name = "errPLevel";
            this.errPLevel.Size = new System.Drawing.Size(20, 28);
            this.errPLevel.TabIndex = 45;
            this.errPLevel.Text = "*";
            this.errPLevel.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(128, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 19);
            this.label13.TabIndex = 42;
            this.label13.Text = "Section";
            // 
            // ddPSection
            // 
            this.ddPSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddPSection.FormattingEnabled = true;
            this.ddPSection.Location = new System.Drawing.Point(128, 77);
            this.ddPSection.Name = "ddPSection";
            this.ddPSection.Size = new System.Drawing.Size(123, 25);
            this.ddPSection.TabIndex = 2;
            this.ddPSection.SelectedIndexChanged += new System.EventHandler(this.ddPSection_SelectedIndexChanged);
            // 
            // errPSection
            // 
            this.errPSection.AutoSize = true;
            this.errPSection.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPSection.Location = new System.Drawing.Point(231, 54);
            this.errPSection.Name = "errPSection";
            this.errPSection.Size = new System.Drawing.Size(20, 28);
            this.errPSection.TabIndex = 43;
            this.errPSection.Text = "*";
            this.errPSection.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 19);
            this.label15.TabIndex = 40;
            this.label15.Text = "Class";
            // 
            // ddPClass
            // 
            this.ddPClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddPClass.FormattingEnabled = true;
            this.ddPClass.Location = new System.Drawing.Point(3, 77);
            this.ddPClass.Name = "ddPClass";
            this.ddPClass.Size = new System.Drawing.Size(123, 25);
            this.ddPClass.TabIndex = 1;
            this.ddPClass.SelectedIndexChanged += new System.EventHandler(this.ddPClass_SelectedIndexChanged);
            // 
            // errPClass
            // 
            this.errPClass.AutoSize = true;
            this.errPClass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPClass.Location = new System.Drawing.Point(106, 54);
            this.errPClass.Name = "errPClass";
            this.errPClass.Size = new System.Drawing.Size(20, 28);
            this.errPClass.TabIndex = 41;
            this.errPClass.Text = "*";
            this.errPClass.Visible = false;
            // 
            // ActiveStudents
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 749);
            this.Name = "ActiveStudents";
            this.Text = "Currently Enrolled Students";
            this.Load += new System.EventHandler(this.Students_Load);
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
            this.pnlLeftStudent.ResumeLayout(false);
            this.pnlLeftStudent.PerformLayout();
            this.pnlPromoteStudent.ResumeLayout(false);
            this.pnlPromoteStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddLevel;
        private System.Windows.Forms.Label errLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddSection;
        private System.Windows.Forms.Label errSection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddClass;
        private System.Windows.Forms.Label errClass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DateTimePicker dtSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLeftStudent;
        private System.Windows.Forms.ComboBox ddLeftStudent;
        private System.Windows.Forms.Panel pnlLeftStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddStatus;
        private System.Windows.Forms.DateTimePicker dtLeftDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlPromoteStudent;
        private System.Windows.Forms.DateTimePicker dtPSession;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label errPSession;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ddPLevel;
        private System.Windows.Forms.Label errPLevel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ddPSection;
        private System.Windows.Forms.Label errPSection;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ddPClass;
        private System.Windows.Forms.Label errPClass;
        private System.Windows.Forms.Label errStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvRegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvLevelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSectionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ddLeftReason;
        private System.Windows.Forms.Label errLeftReason;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ddPReason;
        private System.Windows.Forms.Label errPReason;
    }
}