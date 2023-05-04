namespace ISS
{
    partial class FeeVoucher
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
            this.txtLateFeeFine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonthlyFee = new System.Windows.Forms.TextBox();
            this.dtMonthYear = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.ddBank = new System.Windows.Forms.ComboBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkAdmissionFee = new System.Windows.Forms.CheckBox();
            this.chkAbcentFee = new System.Windows.Forms.CheckBox();
            this.chkExamFee = new System.Windows.Forms.CheckBox();
            this.chkBooksFee = new System.Windows.Forms.CheckBox();
            this.chkMiscFee = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvRegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSectionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFeeVoucherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPresentFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.errBank = new System.Windows.Forms.Label();
            this.errDueDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ddSection = new System.Windows.Forms.ComboBox();
            this.errSection = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddLevel = new System.Windows.Forms.ComboBox();
            this.errLevel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ddClass = new System.Windows.Forms.ComboBox();
            this.errClass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtSession = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRegNoLoad = new System.Windows.Forms.Button();
            this.chkLateSurchage = new System.Windows.Forms.CheckBox();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(809, 67);
            // 
            // txtSearch
            // 
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Size = new System.Drawing.Size(127, 25);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LeftPanel.Size = new System.Drawing.Size(257, 554);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.chkLateSurchage);
            this.pnlDetails.Controls.Add(this.btnRegNoLoad);
            this.pnlDetails.Controls.Add(this.dtSession);
            this.pnlDetails.Controls.Add(this.label12);
            this.pnlDetails.Controls.Add(this.label11);
            this.pnlDetails.Controls.Add(this.label10);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.txtRegNo);
            this.pnlDetails.Controls.Add(this.label13);
            this.pnlDetails.Controls.Add(this.ddSection);
            this.pnlDetails.Controls.Add(this.errSection);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.ddLevel);
            this.pnlDetails.Controls.Add(this.errLevel);
            this.pnlDetails.Controls.Add(this.label9);
            this.pnlDetails.Controls.Add(this.ddClass);
            this.pnlDetails.Controls.Add(this.errClass);
            this.pnlDetails.Controls.Add(this.chkMiscFee);
            this.pnlDetails.Controls.Add(this.chkExamFee);
            this.pnlDetails.Controls.Add(this.chkBooksFee);
            this.pnlDetails.Controls.Add(this.chkAbcentFee);
            this.pnlDetails.Controls.Add(this.chkAdmissionFee);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Controls.Add(this.ddBank);
            this.pnlDetails.Controls.Add(this.lblBank);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.dtDueDate);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.dtMonthYear);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.txtLateFeeFine);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.txtMonthlyFee);
            this.pnlDetails.Controls.Add(this.errBank);
            this.pnlDetails.Controls.Add(this.errDueDate);
            this.pnlDetails.Location = new System.Drawing.Point(0, 37);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlDetails.Size = new System.Drawing.Size(257, 517);
            this.pnlDetails.Controls.SetChildIndex(this.errDueDate, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errBank, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtMonthlyFee, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtLateFeeFine, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label7, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtMonthYear, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label5, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtDueDate, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label6, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblBank, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddBank, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label8, 0);
            this.pnlDetails.Controls.SetChildIndex(this.chkAdmissionFee, 0);
            this.pnlDetails.Controls.SetChildIndex(this.chkAbcentFee, 0);
            this.pnlDetails.Controls.SetChildIndex(this.chkBooksFee, 0);
            this.pnlDetails.Controls.SetChildIndex(this.chkExamFee, 0);
            this.pnlDetails.Controls.SetChildIndex(this.chkMiscFee, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errClass, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddClass, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label9, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errLevel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddLevel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errSection, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddSection, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label13, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtRegNo, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label10, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label11, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label12, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtSession, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnRegNoLoad, 0);
            this.pnlDetails.Controls.SetChildIndex(this.chkLateSurchage, 0);
            // 
            // panel3
            // 
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Size = new System.Drawing.Size(257, 37);
            // 
            // RightPanel
            // 
            this.RightPanel.Location = new System.Drawing.Point(257, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RightPanel.Size = new System.Drawing.Size(809, 554);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Location = new System.Drawing.Point(0, 37);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel6.Size = new System.Drawing.Size(809, 517);
            this.panel6.Controls.SetChildIndex(this.panel1, 0);
            this.panel6.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel4
            // 
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Size = new System.Drawing.Size(809, 37);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(158, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Size = new System.Drawing.Size(99, 37);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopUser.Size = new System.Drawing.Size(593, 37);
            this.lblTopUser.Text = " , ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 82;
            this.label7.Text = "Late Fee Fine";
            // 
            // txtLateFeeFine
            // 
            this.txtLateFeeFine.Enabled = false;
            this.txtLateFeeFine.Location = new System.Drawing.Point(131, 299);
            this.txtLateFeeFine.Name = "txtLateFeeFine";
            this.txtLateFeeFine.Size = new System.Drawing.Size(122, 25);
            this.txtLateFeeFine.TabIndex = 8;
            this.txtLateFeeFine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 80;
            this.label3.Text = "Monthly Fee";
            // 
            // txtMonthlyFee
            // 
            this.txtMonthlyFee.Enabled = false;
            this.txtMonthlyFee.Location = new System.Drawing.Point(8, 299);
            this.txtMonthlyFee.Name = "txtMonthlyFee";
            this.txtMonthlyFee.Size = new System.Drawing.Size(117, 25);
            this.txtMonthlyFee.TabIndex = 7;
            this.txtMonthlyFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtMonthYear
            // 
            this.dtMonthYear.CustomFormat = "MMMM-yyyy";
            this.dtMonthYear.Location = new System.Drawing.Point(9, 42);
            this.dtMonthYear.Name = "dtMonthYear";
            this.dtMonthYear.ShowUpDown = true;
            this.dtMonthYear.Size = new System.Drawing.Size(246, 25);
            this.dtMonthYear.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 86;
            this.label5.Text = "Select Month / Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 88;
            this.label6.Text = "Select Due Date";
            // 
            // dtDueDate
            // 
            this.dtDueDate.CustomFormat = "dd-MMM-yyyy";
            this.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDueDate.Location = new System.Drawing.Point(7, 349);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(246, 25);
            this.dtDueDate.TabIndex = 9;
            this.dtDueDate.ValueChanged += new System.EventHandler(this.dtDueDate_ValueChanged);
            // 
            // ddBank
            // 
            this.ddBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddBank.FormattingEnabled = true;
            this.ddBank.Location = new System.Drawing.Point(7, 399);
            this.ddBank.Name = "ddBank";
            this.ddBank.Size = new System.Drawing.Size(246, 25);
            this.ddBank.TabIndex = 10;
            this.ddBank.SelectedIndexChanged += new System.EventHandler(this.ddBank_SelectedIndexChanged);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(4, 377);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(78, 19);
            this.lblBank.TabIndex = 89;
            this.lblBank.Text = "Select Bank";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 19);
            this.label8.TabIndex = 91;
            this.label8.Text = "Select other Fee";
            // 
            // chkAdmissionFee
            // 
            this.chkAdmissionFee.AutoSize = true;
            this.chkAdmissionFee.Location = new System.Drawing.Point(8, 461);
            this.chkAdmissionFee.Name = "chkAdmissionFee";
            this.chkAdmissionFee.Size = new System.Drawing.Size(116, 23);
            this.chkAdmissionFee.TabIndex = 11;
            this.chkAdmissionFee.Text = "Admission Fee";
            this.chkAdmissionFee.UseVisualStyleBackColor = true;
            // 
            // chkAbcentFee
            // 
            this.chkAbcentFee.AutoSize = true;
            this.chkAbcentFee.Location = new System.Drawing.Point(8, 490);
            this.chkAbcentFee.Name = "chkAbcentFee";
            this.chkAbcentFee.Size = new System.Drawing.Size(100, 23);
            this.chkAbcentFee.TabIndex = 12;
            this.chkAbcentFee.Text = "Abcent Fine";
            this.chkAbcentFee.UseVisualStyleBackColor = true;
            // 
            // chkExamFee
            // 
            this.chkExamFee.AutoSize = true;
            this.chkExamFee.Location = new System.Drawing.Point(136, 461);
            this.chkExamFee.Name = "chkExamFee";
            this.chkExamFee.Size = new System.Drawing.Size(85, 23);
            this.chkExamFee.TabIndex = 14;
            this.chkExamFee.Text = "Exam Fee";
            this.chkExamFee.UseVisualStyleBackColor = true;
            // 
            // chkBooksFee
            // 
            this.chkBooksFee.AutoSize = true;
            this.chkBooksFee.Location = new System.Drawing.Point(8, 519);
            this.chkBooksFee.Name = "chkBooksFee";
            this.chkBooksFee.Size = new System.Drawing.Size(90, 23);
            this.chkBooksFee.TabIndex = 13;
            this.chkBooksFee.Text = "Books Fee";
            this.chkBooksFee.UseVisualStyleBackColor = true;
            // 
            // chkMiscFee
            // 
            this.chkMiscFee.AutoSize = true;
            this.chkMiscFee.Location = new System.Drawing.Point(136, 490);
            this.chkMiscFee.Name = "chkMiscFee";
            this.chkMiscFee.Size = new System.Drawing.Size(81, 23);
            this.chkMiscFee.TabIndex = 15;
            this.chkMiscFee.Text = "Misc Fee";
            this.chkMiscFee.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.chkSelectAll);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 450);
            this.groupBox2.TabIndex = 6;
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
            this.gvClassID,
            this.gvClass,
            this.gvSectionID,
            this.gvSection,
            this.gvFeeVoucherID,
            this.gvDueDate,
            this.gvPresentFee,
            this.gvDiscount,
            this.gvReason});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.dataGridView1.Size = new System.Drawing.Size(803, 403);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gvCheck
            // 
            this.gvCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvCheck.FalseValue = "0";
            this.gvCheck.HeaderText = "";
            this.gvCheck.Name = "gvCheck";
            this.gvCheck.ReadOnly = true;
            this.gvCheck.TrueValue = "1";
            this.gvCheck.Width = 5;
            // 
            // gvSNO
            // 
            this.gvSNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNO.HeaderText = "Sr. No.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.Width = 69;
            // 
            // gvRegNo
            // 
            this.gvRegNo.HeaderText = "Reg. No.";
            this.gvRegNo.Name = "gvRegNo";
            this.gvRegNo.ReadOnly = true;
            // 
            // gvStuName
            // 
            this.gvStuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvStuName.HeaderText = "Student Name";
            this.gvStuName.Name = "gvStuName";
            this.gvStuName.ReadOnly = true;
            this.gvStuName.Width = 112;
            // 
            // gvFatherName
            // 
            this.gvFatherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvFatherName.HeaderText = "Father Name";
            this.gvFatherName.Name = "gvFatherName";
            this.gvFatherName.ReadOnly = true;
            this.gvFatherName.Width = 104;
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
            this.gvClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvClass.HeaderText = "Class";
            this.gvClass.Name = "gvClass";
            this.gvClass.ReadOnly = true;
            this.gvClass.Width = 65;
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
            this.gvSection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSection.HeaderText = "Section";
            this.gvSection.Name = "gvSection";
            this.gvSection.ReadOnly = true;
            this.gvSection.Width = 78;
            // 
            // gvFeeVoucherID
            // 
            this.gvFeeVoucherID.HeaderText = "Fee Voucher ID";
            this.gvFeeVoucherID.Name = "gvFeeVoucherID";
            this.gvFeeVoucherID.ReadOnly = true;
            // 
            // gvDueDate
            // 
            this.gvDueDate.HeaderText = "Due Date";
            this.gvDueDate.Name = "gvDueDate";
            this.gvDueDate.ReadOnly = true;
            // 
            // gvPresentFee
            // 
            this.gvPresentFee.HeaderText = "Present Fee";
            this.gvPresentFee.Name = "gvPresentFee";
            this.gvPresentFee.ReadOnly = true;
            // 
            // gvDiscount
            // 
            this.gvDiscount.HeaderText = "Concession";
            this.gvDiscount.Name = "gvDiscount";
            this.gvDiscount.ReadOnly = true;
            // 
            // gvReason
            // 
            this.gvReason.HeaderText = "Reason";
            this.gvReason.Name = "gvReason";
            this.gvReason.ReadOnly = true;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkSelectAll.Location = new System.Drawing.Point(3, 21);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(803, 23);
            this.chkSelectAll.TabIndex = 97;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // errBank
            // 
            this.errBank.AutoSize = true;
            this.errBank.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errBank.Location = new System.Drawing.Point(233, 377);
            this.errBank.Name = "errBank";
            this.errBank.Size = new System.Drawing.Size(20, 28);
            this.errBank.TabIndex = 97;
            this.errBank.Text = "*";
            this.errBank.Visible = false;
            // 
            // errDueDate
            // 
            this.errDueDate.AutoSize = true;
            this.errDueDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDueDate.Location = new System.Drawing.Point(233, 328);
            this.errDueDate.Name = "errDueDate";
            this.errDueDate.Size = new System.Drawing.Size(20, 28);
            this.errDueDate.TabIndex = 98;
            this.errDueDate.Text = "*";
            this.errDueDate.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(128, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 19);
            this.label13.TabIndex = 133;
            this.label13.Text = "Section";
            // 
            // ddSection
            // 
            this.ddSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddSection.FormattingEnabled = true;
            this.ddSection.Location = new System.Drawing.Point(132, 141);
            this.ddSection.Name = "ddSection";
            this.ddSection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddSection.Size = new System.Drawing.Size(123, 25);
            this.ddSection.TabIndex = 4;
            this.ddSection.SelectedIndexChanged += new System.EventHandler(this.ddSection_SelectedIndexChanged_1);
            // 
            // errSection
            // 
            this.errSection.AutoSize = true;
            this.errSection.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSection.Location = new System.Drawing.Point(229, 119);
            this.errSection.Name = "errSection";
            this.errSection.Size = new System.Drawing.Size(20, 28);
            this.errSection.TabIndex = 134;
            this.errSection.Text = "*";
            this.errSection.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 130;
            this.label2.Text = "Select Level";
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLevel.FormattingEnabled = true;
            this.ddLevel.Location = new System.Drawing.Point(132, 91);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddLevel.Size = new System.Drawing.Size(122, 25);
            this.ddLevel.TabIndex = 2;
            this.ddLevel.SelectedIndexChanged += new System.EventHandler(this.ddLevel_SelectedIndexChanged);
            // 
            // errLevel
            // 
            this.errLevel.AutoSize = true;
            this.errLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLevel.Location = new System.Drawing.Point(234, 68);
            this.errLevel.Name = "errLevel";
            this.errLevel.Size = new System.Drawing.Size(20, 28);
            this.errLevel.TabIndex = 131;
            this.errLevel.Text = "*";
            this.errLevel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 128;
            this.label9.Text = "Select Class";
            // 
            // ddClass
            // 
            this.ddClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddClass.FormattingEnabled = true;
            this.ddClass.Location = new System.Drawing.Point(8, 141);
            this.ddClass.Name = "ddClass";
            this.ddClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddClass.Size = new System.Drawing.Size(118, 25);
            this.ddClass.TabIndex = 3;
            this.ddClass.SelectedIndexChanged += new System.EventHandler(this.ddClass_SelectedIndexChanged_1);
            // 
            // errClass
            // 
            this.errClass.AutoSize = true;
            this.errClass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errClass.Location = new System.Drawing.Point(106, 119);
            this.errClass.Name = "errClass";
            this.errClass.Size = new System.Drawing.Size(20, 28);
            this.errClass.TabIndex = 129;
            this.errClass.Text = "*";
            this.errClass.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 19);
            this.label1.TabIndex = 136;
            this.label1.Text = "_______________OR________________";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Enabled = false;
            this.txtRegNo.Location = new System.Drawing.Point(131, 193);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(124, 25);
            this.txtRegNo.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 137;
            this.label10.Text = "Reg. No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 19);
            this.label11.TabIndex = 138;
            this.label11.Text = "_________________________________________";
            // 
            // dtSession
            // 
            this.dtSession.CustomFormat = "yyyy";
            this.dtSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSession.Location = new System.Drawing.Point(8, 91);
            this.dtSession.Name = "dtSession";
            this.dtSession.ShowUpDown = true;
            this.dtSession.Size = new System.Drawing.Size(118, 25);
            this.dtSession.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 19);
            this.label12.TabIndex = 140;
            this.label12.Text = "Session";
            // 
            // btnRegNoLoad
            // 
            this.btnRegNoLoad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnRegNoLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegNoLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegNoLoad.Location = new System.Drawing.Point(10, 240);
            this.btnRegNoLoad.Name = "btnRegNoLoad";
            this.btnRegNoLoad.Size = new System.Drawing.Size(244, 33);
            this.btnRegNoLoad.TabIndex = 6;
            this.btnRegNoLoad.Text = "LOAD";
            this.btnRegNoLoad.UseVisualStyleBackColor = false;
            this.btnRegNoLoad.Click += new System.EventHandler(this.btnRegNoLoad_Click);
            // 
            // chkLateSurchage
            // 
            this.chkLateSurchage.AutoSize = true;
            this.chkLateSurchage.Location = new System.Drawing.Point(136, 519);
            this.chkLateSurchage.Name = "chkLateSurchage";
            this.chkLateSurchage.Size = new System.Drawing.Size(119, 23);
            this.chkLateSurchage.TabIndex = 141;
            this.chkLateSurchage.Text = "Late Surcharge";
            this.chkLateSurchage.UseVisualStyleBackColor = true;
            // 
            // FeeVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 554);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FeeVoucher";
            this.Text = "Fee Vouchers";
            this.Load += new System.EventHandler(this.FeeVoucher_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtMonthYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLateFeeFine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonthlyFee;
        private System.Windows.Forms.ComboBox ddBank;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDueDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkMiscFee;
        private System.Windows.Forms.CheckBox chkExamFee;
        private System.Windows.Forms.CheckBox chkBooksFee;
        private System.Windows.Forms.CheckBox chkAbcentFee;
        private System.Windows.Forms.CheckBox chkAdmissionFee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Label errBank;
        private System.Windows.Forms.Label errDueDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ddSection;
        private System.Windows.Forms.Label errSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddLevel;
        private System.Windows.Forms.Label errLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ddClass;
        private System.Windows.Forms.Label errClass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtSession;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRegNoLoad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvRegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSectionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFeeVoucherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPresentFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvReason;
        private System.Windows.Forms.CheckBox chkLateSurchage;
    }
}