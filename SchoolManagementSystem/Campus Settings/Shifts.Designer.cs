namespace ISS
{
    partial class Shifts
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
            this.txtShiftName = new System.Windows.Forms.TextBox();
            this.dtStartTine = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtEndtime = new System.Windows.Forms.DateTimePicker();
            this.errShiftName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCampusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCampus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvShiftID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvShiftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errStart = new System.Windows.Forms.Label();
            this.errEnd = new System.Windows.Forms.Label();
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
            this.pnlDetails.Controls.Add(this.dtEndtime);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.dtStartTine);
            this.pnlDetails.Controls.Add(this.txtShiftName);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.errShiftName);
            this.pnlDetails.Controls.Add(this.errEnd);
            this.pnlDetails.Controls.Add(this.errStart);
            this.pnlDetails.Controls.SetChildIndex(this.errStart, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errEnd, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errShiftName, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtShiftName, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtStartTine, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtEndtime, 0);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sift Name";
            // 
            // txtShiftName
            // 
            this.txtShiftName.Location = new System.Drawing.Point(7, 85);
            this.txtShiftName.Name = "txtShiftName";
            this.txtShiftName.Size = new System.Drawing.Size(247, 25);
            this.txtShiftName.TabIndex = 0;
            this.txtShiftName.TextChanged += new System.EventHandler(this.txtShiftName_TextChanged);
            // 
            // dtStartTine
            // 
            this.dtStartTine.CustomFormat = "hh:mm tt";
            this.dtStartTine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTine.Location = new System.Drawing.Point(7, 133);
            this.dtStartTine.Name = "dtStartTine";
            this.dtStartTine.ShowUpDown = true;
            this.dtStartTine.Size = new System.Drawing.Size(247, 25);
            this.dtStartTine.TabIndex = 1;
            this.dtStartTine.ValueChanged += new System.EventHandler(this.dtStartTine_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "End Time";
            // 
            // dtEndtime
            // 
            this.dtEndtime.CustomFormat = "hh:mm tt";
            this.dtEndtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndtime.Location = new System.Drawing.Point(7, 183);
            this.dtEndtime.Name = "dtEndtime";
            this.dtEndtime.ShowUpDown = true;
            this.dtEndtime.Size = new System.Drawing.Size(247, 25);
            this.dtEndtime.TabIndex = 2;
            this.dtEndtime.ValueChanged += new System.EventHandler(this.dtEndtime_ValueChanged);
            // 
            // errShiftName
            // 
            this.errShiftName.AutoSize = true;
            this.errShiftName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errShiftName.Location = new System.Drawing.Point(234, 63);
            this.errShiftName.Name = "errShiftName";
            this.errShiftName.Size = new System.Drawing.Size(20, 28);
            this.errShiftName.TabIndex = 7;
            this.errShiftName.Text = "*";
            this.errShiftName.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 694);
            this.groupBox2.TabIndex = 4;
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
            this.gvSNo,
            this.gvCampusID,
            this.gvCampus,
            this.gvShiftID,
            this.gvShiftName,
            this.gvStartTime,
            this.gvEndTime});
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
            this.dataGridView1.Size = new System.Drawing.Size(838, 670);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gvSNo
            // 
            this.gvSNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNo.HeaderText = "Sr.No.";
            this.gvSNo.Name = "gvSNo";
            this.gvSNo.ReadOnly = true;
            this.gvSNo.Width = 70;
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
            // gvShiftID
            // 
            this.gvShiftID.HeaderText = "Shift ID";
            this.gvShiftID.Name = "gvShiftID";
            this.gvShiftID.ReadOnly = true;
            this.gvShiftID.Visible = false;
            // 
            // gvShiftName
            // 
            this.gvShiftName.HeaderText = "Shift";
            this.gvShiftName.Name = "gvShiftName";
            this.gvShiftName.ReadOnly = true;
            // 
            // gvStartTime
            // 
            this.gvStartTime.HeaderText = "From";
            this.gvStartTime.Name = "gvStartTime";
            this.gvStartTime.ReadOnly = true;
            // 
            // gvEndTime
            // 
            this.gvEndTime.HeaderText = "To";
            this.gvEndTime.Name = "gvEndTime";
            this.gvEndTime.ReadOnly = true;
            // 
            // errStart
            // 
            this.errStart.AutoSize = true;
            this.errStart.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errStart.Location = new System.Drawing.Point(234, 110);
            this.errStart.Name = "errStart";
            this.errStart.Size = new System.Drawing.Size(20, 28);
            this.errStart.TabIndex = 11;
            this.errStart.Text = "*";
            this.errStart.Visible = false;
            // 
            // errEnd
            // 
            this.errEnd.AutoSize = true;
            this.errEnd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errEnd.Location = new System.Drawing.Point(234, 161);
            this.errEnd.Name = "errEnd";
            this.errEnd.Size = new System.Drawing.Size(20, 28);
            this.errEnd.TabIndex = 12;
            this.errEnd.Text = "*";
            this.errEnd.Visible = false;
            // 
            // Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 811);
            this.Name = "Shifts";
            this.Text = "Shifts";
            this.Load += new System.EventHandler(this.Shifts_Load);
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
        private System.Windows.Forms.TextBox txtShiftName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtEndtime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtStartTine;
        private System.Windows.Forms.Label errShiftName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label errEnd;
        private System.Windows.Forms.Label errStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCampusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCampus;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvShiftID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvShiftName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvEndTime;
    }
}