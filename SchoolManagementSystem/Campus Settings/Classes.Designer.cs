namespace ISS
{
    partial class Classes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddStatus = new System.Windows.Forms.ComboBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.errClass = new System.Windows.Forms.Label();
            this.errStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ddLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errLevel = new System.Windows.Forms.Label();
            this.txtClassNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errClassNumber = new System.Windows.Forms.Label();
            this.gvSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCampusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCampus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLevelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvClassNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Size = new System.Drawing.Size(875, 60);
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(138, 25);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.txtClassNumber);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.errClassNumber);
            this.pnlDetails.Controls.Add(this.ddLevel);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.errLevel);
            this.pnlDetails.Controls.Add(this.txtClassName);
            this.pnlDetails.Controls.Add(this.ddStatus);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.errClass);
            this.pnlDetails.Controls.Add(this.errStatus);
            this.pnlDetails.Controls.SetChildIndex(this.errStatus, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errClass, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddStatus, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtClassName, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errLevel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddLevel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errClassNumber, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label5, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtClassNumber, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(875, 811);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Size = new System.Drawing.Size(875, 761);
            this.panel6.Controls.SetChildIndex(this.panel1, 0);
            this.panel6.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(875, 50);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Text = " , ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status";
            // 
            // ddStatus
            // 
            this.ddStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddStatus.FormattingEnabled = true;
            this.ddStatus.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.ddStatus.Location = new System.Drawing.Point(12, 172);
            this.ddStatus.Name = "ddStatus";
            this.ddStatus.Size = new System.Drawing.Size(242, 25);
            this.ddStatus.TabIndex = 2;
            this.ddStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(12, 127);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(242, 25);
            this.txtClassName.TabIndex = 1;
            this.txtClassName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // errClass
            // 
            this.errClass.AutoSize = true;
            this.errClass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errClass.Location = new System.Drawing.Point(234, 109);
            this.errClass.Name = "errClass";
            this.errClass.Size = new System.Drawing.Size(20, 28);
            this.errClass.TabIndex = 21;
            this.errClass.Text = "*";
            this.errClass.Visible = false;
            // 
            // errStatus
            // 
            this.errStatus.AutoSize = true;
            this.errStatus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errStatus.Location = new System.Drawing.Point(231, 152);
            this.errStatus.Name = "errStatus";
            this.errStatus.Size = new System.Drawing.Size(20, 28);
            this.errStatus.TabIndex = 22;
            this.errStatus.Text = "*";
            this.errStatus.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 701);
            this.groupBox2.TabIndex = 2;
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
            this.gvSerialNo,
            this.gvCampusID,
            this.gvCampus,
            this.gvLevelID,
            this.gvLevel,
            this.gvClassID,
            this.gvClassName,
            this.gvStatus,
            this.gvClassNumber});
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(869, 677);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLevel.FormattingEnabled = true;
            this.ddLevel.Location = new System.Drawing.Point(12, 81);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.Size = new System.Drawing.Size(242, 25);
            this.ddLevel.TabIndex = 0;
            this.ddLevel.SelectedIndexChanged += new System.EventHandler(this.ddLevel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Level";
            // 
            // errLevel
            // 
            this.errLevel.AutoSize = true;
            this.errLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLevel.Location = new System.Drawing.Point(233, 59);
            this.errLevel.Name = "errLevel";
            this.errLevel.Size = new System.Drawing.Size(20, 28);
            this.errLevel.TabIndex = 25;
            this.errLevel.Text = "*";
            this.errLevel.Visible = false;
            // 
            // txtClassNumber
            // 
            this.txtClassNumber.Location = new System.Drawing.Point(12, 220);
            this.txtClassNumber.Name = "txtClassNumber";
            this.txtClassNumber.Size = new System.Drawing.Size(242, 25);
            this.txtClassNumber.TabIndex = 26;
            this.txtClassNumber.TextChanged += new System.EventHandler(this.txtClassNumber_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Class Number";
            // 
            // errClassNumber
            // 
            this.errClassNumber.AutoSize = true;
            this.errClassNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errClassNumber.Location = new System.Drawing.Point(234, 202);
            this.errClassNumber.Name = "errClassNumber";
            this.errClassNumber.Size = new System.Drawing.Size(20, 28);
            this.errClassNumber.TabIndex = 28;
            this.errClassNumber.Text = "*";
            this.errClassNumber.Visible = false;
            // 
            // gvSerialNo
            // 
            this.gvSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSerialNo.HeaderText = "Sr. No.";
            this.gvSerialNo.Name = "gvSerialNo";
            this.gvSerialNo.ReadOnly = true;
            this.gvSerialNo.Width = 74;
            // 
            // gvCampusID
            // 
            this.gvCampusID.HeaderText = "Campus ID";
            this.gvCampusID.Name = "gvCampusID";
            this.gvCampusID.ReadOnly = true;
            this.gvCampusID.Visible = false;
            // 
            // gvCampus
            // 
            this.gvCampus.HeaderText = "Campus";
            this.gvCampus.Name = "gvCampus";
            this.gvCampus.ReadOnly = true;
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
            this.gvClassID.HeaderText = "ClassID";
            this.gvClassID.Name = "gvClassID";
            this.gvClassID.ReadOnly = true;
            this.gvClassID.Visible = false;
            // 
            // gvClassName
            // 
            this.gvClassName.HeaderText = "Class";
            this.gvClassName.Name = "gvClassName";
            this.gvClassName.ReadOnly = true;
            // 
            // gvStatus
            // 
            this.gvStatus.HeaderText = "Status";
            this.gvStatus.Name = "gvStatus";
            this.gvStatus.ReadOnly = true;
            // 
            // gvClassNumber
            // 
            this.gvClassNumber.HeaderText = "Class #";
            this.gvClassNumber.Name = "gvClassNumber";
            this.gvClassNumber.ReadOnly = true;
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 811);
            this.Name = "Classes";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.Classes_Load);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.ComboBox ddStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errClass;
        private System.Windows.Forms.Label errStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ddLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errLevel;
        private System.Windows.Forms.TextBox txtClassNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errClassNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCampusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCampus;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvLevelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvClassNumber;
    }
}