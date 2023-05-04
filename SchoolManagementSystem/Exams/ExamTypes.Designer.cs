namespace ISS
{
    partial class ExamTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtSession = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.errExamName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvExamTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvExamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvResultDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvResultTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvResultVenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtResultDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.errResultDate = new System.Windows.Forms.Label();
            this.dtResultTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.errResultTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultVenue = new System.Windows.Forms.TextBox();
            this.errResultVenue = new System.Windows.Forms.Label();
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
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.txtResultVenue);
            this.pnlDetails.Controls.Add(this.errResultVenue);
            this.pnlDetails.Controls.Add(this.dtResultTime);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.errResultTime);
            this.pnlDetails.Controls.Add(this.dtResultDate);
            this.pnlDetails.Controls.Add(this.label11);
            this.pnlDetails.Controls.Add(this.errResultDate);
            this.pnlDetails.Controls.Add(this.label10);
            this.pnlDetails.Controls.Add(this.txtExamName);
            this.pnlDetails.Controls.Add(this.dtSession);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.errExamName);
            this.pnlDetails.Controls.SetChildIndex(this.errExamName, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtSession, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtExamName, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label10, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errResultDate, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label11, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtResultDate, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errResultTime, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtResultTime, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errResultVenue, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtResultVenue, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label3, 0);
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
            // dtSession
            // 
            this.dtSession.CustomFormat = "yyyy";
            this.dtSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSession.Location = new System.Drawing.Point(6, 86);
            this.dtSession.Name = "dtSession";
            this.dtSession.ShowUpDown = true;
            this.dtSession.Size = new System.Drawing.Size(248, 25);
            this.dtSession.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "Session";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 59;
            this.label10.Text = "Exam Name";
            // 
            // txtExamName
            // 
            this.txtExamName.Location = new System.Drawing.Point(6, 137);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(248, 25);
            this.txtExamName.TabIndex = 1;
            this.txtExamName.TextChanged += new System.EventHandler(this.txtExamName_TextChanged);
            // 
            // errExamName
            // 
            this.errExamName.AutoSize = true;
            this.errExamName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errExamName.Location = new System.Drawing.Point(234, 115);
            this.errExamName.Name = "errExamName";
            this.errExamName.Size = new System.Drawing.Size(20, 28);
            this.errExamName.TabIndex = 64;
            this.errExamName.Text = "*";
            this.errExamName.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 694);
            this.groupBox2.TabIndex = 10;
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
            this.gvSession,
            this.gvExamName,
            this.gvResultDate,
            this.gvResultTime,
            this.gvResultVenue});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
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
            // gvSNO
            // 
            this.gvSNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNO.HeaderText = "Sr. No.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Width = 74;
            // 
            // gvExamTypeID
            // 
            this.gvExamTypeID.HeaderText = "Exam Type ID";
            this.gvExamTypeID.Name = "gvExamTypeID";
            this.gvExamTypeID.ReadOnly = true;
            this.gvExamTypeID.Visible = false;
            // 
            // gvSession
            // 
            dataGridViewCellStyle2.Format = "yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.gvSession.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvSession.HeaderText = "Session";
            this.gvSession.Name = "gvSession";
            this.gvSession.ReadOnly = true;
            // 
            // gvExamName
            // 
            this.gvExamName.HeaderText = "Exam Name";
            this.gvExamName.Name = "gvExamName";
            this.gvExamName.ReadOnly = true;
            // 
            // gvResultDate
            // 
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.gvResultDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvResultDate.HeaderText = "Result Date";
            this.gvResultDate.Name = "gvResultDate";
            this.gvResultDate.ReadOnly = true;
            // 
            // gvResultTime
            // 
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.gvResultTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvResultTime.HeaderText = "Result Time";
            this.gvResultTime.Name = "gvResultTime";
            this.gvResultTime.ReadOnly = true;
            // 
            // gvResultVenue
            // 
            this.gvResultVenue.HeaderText = "Result Venue";
            this.gvResultVenue.Name = "gvResultVenue";
            this.gvResultVenue.ReadOnly = true;
            // 
            // dtResultDate
            // 
            this.dtResultDate.CustomFormat = "dddd , dd-MMMM-yyyy";
            this.dtResultDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtResultDate.Location = new System.Drawing.Point(6, 186);
            this.dtResultDate.Name = "dtResultDate";
            this.dtResultDate.Size = new System.Drawing.Size(248, 25);
            this.dtResultDate.TabIndex = 2;
            this.dtResultDate.ValueChanged += new System.EventHandler(this.dtResultDate_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 107;
            this.label11.Text = "Result Date";
            // 
            // errResultDate
            // 
            this.errResultDate.AutoSize = true;
            this.errResultDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errResultDate.Location = new System.Drawing.Point(237, 164);
            this.errResultDate.Name = "errResultDate";
            this.errResultDate.Size = new System.Drawing.Size(20, 28);
            this.errResultDate.TabIndex = 108;
            this.errResultDate.Text = "*";
            this.errResultDate.Visible = false;
            // 
            // dtResultTime
            // 
            this.dtResultTime.CustomFormat = "hh:mm tt";
            this.dtResultTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtResultTime.Location = new System.Drawing.Point(6, 235);
            this.dtResultTime.Name = "dtResultTime";
            this.dtResultTime.ShowUpDown = true;
            this.dtResultTime.Size = new System.Drawing.Size(248, 25);
            this.dtResultTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 110;
            this.label2.Text = "Result Time";
            // 
            // errResultTime
            // 
            this.errResultTime.AutoSize = true;
            this.errResultTime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errResultTime.Location = new System.Drawing.Point(237, 213);
            this.errResultTime.Name = "errResultTime";
            this.errResultTime.Size = new System.Drawing.Size(20, 28);
            this.errResultTime.TabIndex = 111;
            this.errResultTime.Text = "*";
            this.errResultTime.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 113;
            this.label3.Text = "Result Venue";
            // 
            // txtResultVenue
            // 
            this.txtResultVenue.Location = new System.Drawing.Point(6, 284);
            this.txtResultVenue.Name = "txtResultVenue";
            this.txtResultVenue.Size = new System.Drawing.Size(248, 25);
            this.txtResultVenue.TabIndex = 4;
            // 
            // errResultVenue
            // 
            this.errResultVenue.AutoSize = true;
            this.errResultVenue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errResultVenue.Location = new System.Drawing.Point(234, 262);
            this.errResultVenue.Name = "errResultVenue";
            this.errResultVenue.Size = new System.Drawing.Size(20, 28);
            this.errResultVenue.TabIndex = 114;
            this.errResultVenue.Text = "*";
            this.errResultVenue.Visible = false;
            // 
            // ExamTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 811);
            this.Name = "ExamTypes";
            this.Text = "Exam Types";
            this.Load += new System.EventHandler(this.ExamTypes_Load);
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

        private System.Windows.Forms.DateTimePicker dtSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.Label errExamName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtResultDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label errResultDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultVenue;
        private System.Windows.Forms.Label errResultVenue;
        private System.Windows.Forms.DateTimePicker dtResultTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errResultTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvExamTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvExamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvResultDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvResultTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvResultVenue;
    }
}