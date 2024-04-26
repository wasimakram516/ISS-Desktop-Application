namespace SchoolManagementSystem
{
    partial class MonthlyExpensesView
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvExpenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvExpenseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvReceiptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvReceiptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceiptName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReceiptNo = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.errDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.errAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.errDescription = new System.Windows.Forms.Label();
            this.ddExpenseType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errExpenseType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtMonthYear = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(847, 67);
            // 
            // txtSearch
            // 
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Size = new System.Drawing.Size(130, 25);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LeftPanel.Size = new System.Drawing.Size(257, 651);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblTotal);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.dtMonthYear);
            this.pnlDetails.Controls.Add(this.btnLoad);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.txtReceiptName);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.txtReceiptNo);
            this.pnlDetails.Controls.Add(this.dtDate);
            this.pnlDetails.Controls.Add(this.label9);
            this.pnlDetails.Controls.Add(this.errDate);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.txtAmount);
            this.pnlDetails.Controls.Add(this.errAmount);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Controls.Add(this.txtDescription);
            this.pnlDetails.Controls.Add(this.errDescription);
            this.pnlDetails.Controls.Add(this.ddExpenseType);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.errExpenseType);
            this.pnlDetails.Location = new System.Drawing.Point(0, 37);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlDetails.Size = new System.Drawing.Size(257, 614);
            this.pnlDetails.Controls.SetChildIndex(this.errExpenseType, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label6, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddExpenseType, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errDescription, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtDescription, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label8, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errAmount, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtAmount, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errDate, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label9, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtDate, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtReceiptNo, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label5, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtReceiptName, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnLoad, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtMonthYear, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label7, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblTotal, 0);
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
            this.RightPanel.Size = new System.Drawing.Size(847, 651);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Location = new System.Drawing.Point(0, 37);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel6.Size = new System.Drawing.Size(847, 614);
            this.panel6.Controls.SetChildIndex(this.panel1, 0);
            this.panel6.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel4
            // 
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Size = new System.Drawing.Size(847, 37);
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
            this.lblTopUser.Text = " ,  (  )";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 547);
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
            this.gvExpenseID,
            this.gvDate,
            this.gvExpenseType,
            this.gvDescription,
            this.gvAmount,
            this.gvReceiptName,
            this.gvReceiptNo});
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(841, 523);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gvSNO
            // 
            this.gvSNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNO.HeaderText = "Sr.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Width = 49;
            // 
            // gvExpenseID
            // 
            this.gvExpenseID.HeaderText = "Expense ID";
            this.gvExpenseID.Name = "gvExpenseID";
            this.gvExpenseID.ReadOnly = true;
            this.gvExpenseID.Visible = false;
            // 
            // gvDate
            // 
            dataGridViewCellStyle2.Format = "M";
            dataGridViewCellStyle2.NullValue = null;
            this.gvDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvDate.HeaderText = "Date";
            this.gvDate.Name = "gvDate";
            this.gvDate.ReadOnly = true;
            this.gvDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gvExpenseType
            // 
            this.gvExpenseType.HeaderText = "Expense Type";
            this.gvExpenseType.Name = "gvExpenseType";
            this.gvExpenseType.ReadOnly = true;
            // 
            // gvDescription
            // 
            this.gvDescription.HeaderText = "Description";
            this.gvDescription.Name = "gvDescription";
            this.gvDescription.ReadOnly = true;
            // 
            // gvAmount
            // 
            this.gvAmount.HeaderText = "Amount";
            this.gvAmount.Name = "gvAmount";
            this.gvAmount.ReadOnly = true;
            // 
            // gvReceiptName
            // 
            this.gvReceiptName.HeaderText = "Receipt Name";
            this.gvReceiptName.Name = "gvReceiptName";
            this.gvReceiptName.ReadOnly = true;
            // 
            // gvReceiptNo
            // 
            this.gvReceiptNo.HeaderText = "Receipt #";
            this.gvReceiptNo.Name = "gvReceiptNo";
            this.gvReceiptNo.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 99;
            this.label2.Text = "Receipt Name";
            // 
            // txtReceiptName
            // 
            this.txtReceiptName.Location = new System.Drawing.Point(5, 396);
            this.txtReceiptName.Name = "txtReceiptName";
            this.txtReceiptName.Size = new System.Drawing.Size(248, 25);
            this.txtReceiptName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 98;
            this.label5.Text = "Receipt #";
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Location = new System.Drawing.Point(5, 447);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(248, 25);
            this.txtReceiptNo.TabIndex = 7;
            this.txtReceiptNo.TextChanged += new System.EventHandler(this.txtReceiptNo_TextChanged);
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "dddd , dd-MMMM-yyyy";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(5, 180);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(248, 25);
            this.dtDate.TabIndex = 2;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 96;
            this.label9.Text = "Date";
            // 
            // errDate
            // 
            this.errDate.AutoSize = true;
            this.errDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDate.Location = new System.Drawing.Point(236, 157);
            this.errDate.Name = "errDate";
            this.errDate.Size = new System.Drawing.Size(20, 28);
            this.errDate.TabIndex = 97;
            this.errDate.Text = "*";
            this.errDate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 94;
            this.label1.Text = "Amount (Rs.)";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(5, 346);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(248, 25);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // errAmount
            // 
            this.errAmount.AutoSize = true;
            this.errAmount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errAmount.Location = new System.Drawing.Point(237, 324);
            this.errAmount.Name = "errAmount";
            this.errAmount.Size = new System.Drawing.Size(20, 28);
            this.errAmount.TabIndex = 95;
            this.errAmount.Text = "*";
            this.errAmount.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 92;
            this.label8.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(5, 276);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(248, 45);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // errDescription
            // 
            this.errDescription.AutoSize = true;
            this.errDescription.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDescription.Location = new System.Drawing.Point(236, 254);
            this.errDescription.Name = "errDescription";
            this.errDescription.Size = new System.Drawing.Size(20, 28);
            this.errDescription.TabIndex = 93;
            this.errDescription.Text = "*";
            this.errDescription.Visible = false;
            // 
            // ddExpenseType
            // 
            this.ddExpenseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddExpenseType.FormattingEnabled = true;
            this.ddExpenseType.Items.AddRange(new object[] {
            "Advertisement",
            "Cleaning Materials",
            "Daily Utilities",
            "Maintenance",
            "Miscellaneous",
            "Purchasing",
            "Rent",
            "Refreshment",
            "Stationery",
            "Utility Bills",
            "Welfare"});
            this.ddExpenseType.Location = new System.Drawing.Point(6, 227);
            this.ddExpenseType.Name = "ddExpenseType";
            this.ddExpenseType.Size = new System.Drawing.Size(248, 25);
            this.ddExpenseType.TabIndex = 3;
            this.ddExpenseType.SelectedIndexChanged += new System.EventHandler(this.ddExpenseType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 90;
            this.label6.Text = "Expense Type";
            // 
            // errExpenseType
            // 
            this.errExpenseType.AutoSize = true;
            this.errExpenseType.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errExpenseType.Location = new System.Drawing.Point(237, 206);
            this.errExpenseType.Name = "errExpenseType";
            this.errExpenseType.Size = new System.Drawing.Size(20, 28);
            this.errExpenseType.TabIndex = 91;
            this.errExpenseType.Text = "*";
            this.errExpenseType.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 102;
            this.label3.Text = "Month - Year";
            // 
            // dtMonthYear
            // 
            this.dtMonthYear.CustomFormat = "MMMM - yyyy";
            this.dtMonthYear.Location = new System.Drawing.Point(5, 84);
            this.dtMonthYear.Name = "dtMonthYear";
            this.dtMonthYear.ShowUpDown = true;
            this.dtMonthYear.Size = new System.Drawing.Size(249, 25);
            this.dtMonthYear.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(5, 115);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(248, 38);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 103;
            this.label7.Text = "Gross Total : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(109, 475);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 21);
            this.lblTotal.TabIndex = 104;
            this.lblTotal.Text = "Rs. 0";
            // 
            // MonthlyExpensesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 651);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MonthlyExpensesView";
            this.Text = "View Monthly Expenses";
            this.Load += new System.EventHandler(this.MonthlyExpensesView_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReceiptName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReceiptNo;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label errDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label errAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label errDescription;
        private System.Windows.Forms.ComboBox ddExpenseType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label errExpenseType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtMonthYear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvExpenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvExpenseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvReceiptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvReceiptNo;
    }
}