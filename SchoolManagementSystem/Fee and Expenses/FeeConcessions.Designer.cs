namespace ISS
{
    partial class FeeConcessions
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
            this.ddStudent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errStudent = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.errDiscount = new System.Windows.Forms.Label();
            this.errReason = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.ddSection = new System.Windows.Forms.ComboBox();
            this.errSection = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ddLevel = new System.Windows.Forms.ComboBox();
            this.errLevel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ddClass = new System.Windows.Forms.ComboBox();
            this.errClass = new System.Windows.Forms.Label();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFeeConcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvRegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLevelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSectionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.label13);
            this.pnlDetails.Controls.Add(this.ddSection);
            this.pnlDetails.Controls.Add(this.errSection);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Controls.Add(this.ddLevel);
            this.pnlDetails.Controls.Add(this.errLevel);
            this.pnlDetails.Controls.Add(this.label9);
            this.pnlDetails.Controls.Add(this.ddClass);
            this.pnlDetails.Controls.Add(this.errClass);
            this.pnlDetails.Controls.Add(this.txtReason);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.txtDiscount);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.ddStudent);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.errStudent);
            this.pnlDetails.Controls.Add(this.errReason);
            this.pnlDetails.Controls.Add(this.errDiscount);
            this.pnlDetails.Controls.SetChildIndex(this.errDiscount, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errReason, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errStudent, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddStudent, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label5, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtDiscount, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label6, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtReason, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errClass, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddClass, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label9, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errLevel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddLevel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label8, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errSection, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddSection, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label13, 0);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Controls.SetChildIndex(this.panel1, 0);
            this.panel6.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Text = " , ";
            // 
            // ddStudent
            // 
            this.ddStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddStudent.FormattingEnabled = true;
            this.ddStudent.Location = new System.Drawing.Point(6, 236);
            this.ddStudent.Name = "ddStudent";
            this.ddStudent.Size = new System.Drawing.Size(246, 25);
            this.ddStudent.TabIndex = 2;
            this.ddStudent.SelectedIndexChanged += new System.EventHandler(this.ddStudent_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 91;
            this.label3.Text = "Select Student";
            // 
            // errStudent
            // 
            this.errStudent.AutoSize = true;
            this.errStudent.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errStudent.Location = new System.Drawing.Point(232, 216);
            this.errStudent.Name = "errStudent";
            this.errStudent.Size = new System.Drawing.Size(20, 28);
            this.errStudent.TabIndex = 93;
            this.errStudent.Text = "*";
            this.errStudent.Visible = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(5, 287);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(247, 25);
            this.txtDiscount.TabIndex = 3;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 94;
            this.label5.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 96;
            this.label6.Text = "Reason";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(6, 337);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(246, 25);
            this.txtReason.TabIndex = 4;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // errDiscount
            // 
            this.errDiscount.AutoSize = true;
            this.errDiscount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDiscount.Location = new System.Drawing.Point(232, 266);
            this.errDiscount.Name = "errDiscount";
            this.errDiscount.Size = new System.Drawing.Size(20, 28);
            this.errDiscount.TabIndex = 98;
            this.errDiscount.Text = "*";
            this.errDiscount.Visible = false;
            // 
            // errReason
            // 
            this.errReason.AutoSize = true;
            this.errReason.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errReason.Location = new System.Drawing.Point(232, 317);
            this.errReason.Name = "errReason";
            this.errReason.Size = new System.Drawing.Size(20, 28);
            this.errReason.TabIndex = 99;
            this.errReason.Text = "*";
            this.errReason.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 694);
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
            this.gvSNO,
            this.gvFeeConcID,
            this.gvRegNo,
            this.gvStuName,
            this.gvLevelID,
            this.gvLevel,
            this.gvClassID,
            this.gvClass,
            this.gvSectionID,
            this.gvSection,
            this.gvDiscount,
            this.gvReason});
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
            this.dataGridView1.Size = new System.Drawing.Size(838, 670);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 19);
            this.label13.TabIndex = 142;
            this.label13.Text = "Section";
            // 
            // ddSection
            // 
            this.ddSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddSection.FormattingEnabled = true;
            this.ddSection.Location = new System.Drawing.Point(7, 188);
            this.ddSection.Name = "ddSection";
            this.ddSection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddSection.Size = new System.Drawing.Size(245, 25);
            this.ddSection.TabIndex = 137;
            this.ddSection.SelectedIndexChanged += new System.EventHandler(this.ddSection_SelectedIndexChanged_1);
            // 
            // errSection
            // 
            this.errSection.AutoSize = true;
            this.errSection.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSection.Location = new System.Drawing.Point(232, 166);
            this.errSection.Name = "errSection";
            this.errSection.Size = new System.Drawing.Size(20, 28);
            this.errSection.TabIndex = 143;
            this.errSection.Text = "*";
            this.errSection.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 140;
            this.label8.Text = "Select Level";
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLevel.FormattingEnabled = true;
            this.ddLevel.Location = new System.Drawing.Point(6, 88);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddLevel.Size = new System.Drawing.Size(246, 25);
            this.ddLevel.TabIndex = 135;
            this.ddLevel.SelectedIndexChanged += new System.EventHandler(this.ddLevel_SelectedIndexChanged);
            // 
            // errLevel
            // 
            this.errLevel.AutoSize = true;
            this.errLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLevel.Location = new System.Drawing.Point(232, 65);
            this.errLevel.Name = "errLevel";
            this.errLevel.Size = new System.Drawing.Size(20, 28);
            this.errLevel.TabIndex = 141;
            this.errLevel.Text = "*";
            this.errLevel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 138;
            this.label9.Text = "Select Class";
            // 
            // ddClass
            // 
            this.ddClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddClass.FormattingEnabled = true;
            this.ddClass.Location = new System.Drawing.Point(6, 138);
            this.ddClass.Name = "ddClass";
            this.ddClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddClass.Size = new System.Drawing.Size(246, 25);
            this.ddClass.TabIndex = 136;
            this.ddClass.SelectedIndexChanged += new System.EventHandler(this.ddClass_SelectedIndexChanged_1);
            // 
            // errClass
            // 
            this.errClass.AutoSize = true;
            this.errClass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errClass.Location = new System.Drawing.Point(232, 116);
            this.errClass.Name = "errClass";
            this.errClass.Size = new System.Drawing.Size(20, 28);
            this.errClass.TabIndex = 139;
            this.errClass.Text = "*";
            this.errClass.Visible = false;
            // 
            // gvSNO
            // 
            this.gvSNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNO.HeaderText = "Sr. No.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Width = 74;
            // 
            // gvFeeConcID
            // 
            this.gvFeeConcID.HeaderText = "Fee Concession ID";
            this.gvFeeConcID.Name = "gvFeeConcID";
            this.gvFeeConcID.ReadOnly = true;
            this.gvFeeConcID.Visible = false;
            // 
            // gvRegNo
            // 
            this.gvRegNo.HeaderText = "Reg No";
            this.gvRegNo.Name = "gvRegNo";
            this.gvRegNo.ReadOnly = true;
            // 
            // gvStuName
            // 
            this.gvStuName.HeaderText = "Student";
            this.gvStuName.Name = "gvStuName";
            this.gvStuName.ReadOnly = true;
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
            // gvDiscount
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.gvDiscount.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvDiscount.HeaderText = "Discount";
            this.gvDiscount.Name = "gvDiscount";
            this.gvDiscount.ReadOnly = true;
            // 
            // gvReason
            // 
            this.gvReason.HeaderText = "Reason";
            this.gvReason.Name = "gvReason";
            this.gvReason.ReadOnly = true;
            // 
            // FeeConcessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 811);
            this.Name = "FeeConcessions";
            this.Text = "Fee Concessions";
            this.Load += new System.EventHandler(this.FeeConcessions_Load);
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

        private System.Windows.Forms.ComboBox ddStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errStudent;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errReason;
        private System.Windows.Forms.Label errDiscount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ddSection;
        private System.Windows.Forms.Label errSection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddLevel;
        private System.Windows.Forms.Label errLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ddClass;
        private System.Windows.Forms.Label errClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFeeConcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvRegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvLevelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSectionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvReason;
    }
}