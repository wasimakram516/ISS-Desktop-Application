namespace ISS
{
    partial class Sections
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
            this.txtSectionName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ddStatus = new System.Windows.Forms.ComboBox();
            this.errSectionname = new System.Windows.Forms.Label();
            this.errStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCampusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCampus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSectionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSectionStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlDetails.Controls.Add(this.txtSectionName);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.ddStatus);
            this.pnlDetails.Controls.Add(this.errSectionname);
            this.pnlDetails.Controls.Add(this.errStatus);
            this.pnlDetails.Controls.SetChildIndex(this.errStatus, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errSectionname, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddStatus, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label7, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label8, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtSectionName, 0);
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
            // txtSectionName
            // 
            this.txtSectionName.Location = new System.Drawing.Point(12, 81);
            this.txtSectionName.MaxLength = 15;
            this.txtSectionName.Name = "txtSectionName";
            this.txtSectionName.Size = new System.Drawing.Size(242, 25);
            this.txtSectionName.TabIndex = 0;
            this.txtSectionName.TextChanged += new System.EventHandler(this.txtSectionName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Section Name";
            // 
            // ddStatus
            // 
            this.ddStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddStatus.FormattingEnabled = true;
            this.ddStatus.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.ddStatus.Location = new System.Drawing.Point(12, 129);
            this.ddStatus.Name = "ddStatus";
            this.ddStatus.Size = new System.Drawing.Size(242, 25);
            this.ddStatus.TabIndex = 1;
            this.ddStatus.SelectedIndexChanged += new System.EventHandler(this.ddStatus_SelectedIndexChanged);
            // 
            // errSectionname
            // 
            this.errSectionname.AutoSize = true;
            this.errSectionname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSectionname.Location = new System.Drawing.Point(234, 61);
            this.errSectionname.Name = "errSectionname";
            this.errSectionname.Size = new System.Drawing.Size(20, 28);
            this.errSectionname.TabIndex = 31;
            this.errSectionname.Text = "*";
            this.errSectionname.Visible = false;
            // 
            // errStatus
            // 
            this.errStatus.AutoSize = true;
            this.errStatus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errStatus.Location = new System.Drawing.Point(234, 109);
            this.errStatus.Name = "errStatus";
            this.errStatus.Size = new System.Drawing.Size(20, 28);
            this.errStatus.TabIndex = 30;
            this.errStatus.Text = "*";
            this.errStatus.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 694);
            this.groupBox2.TabIndex = 3;
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
            this.gvSectionID,
            this.gvSectionName,
            this.gvSectionStatus});
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
            // gvSerialNo
            // 
            this.gvSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSerialNo.HeaderText = "Sr.No.";
            this.gvSerialNo.Name = "gvSerialNo";
            this.gvSerialNo.ReadOnly = true;
            this.gvSerialNo.Width = 70;
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
            // gvSectionID
            // 
            this.gvSectionID.HeaderText = "Section ID";
            this.gvSectionID.Name = "gvSectionID";
            this.gvSectionID.ReadOnly = true;
            this.gvSectionID.Visible = false;
            // 
            // gvSectionName
            // 
            this.gvSectionName.HeaderText = "Section";
            this.gvSectionName.Name = "gvSectionName";
            this.gvSectionName.ReadOnly = true;
            // 
            // gvSectionStatus
            // 
            this.gvSectionStatus.HeaderText = "Status";
            this.gvSectionStatus.Name = "gvSectionStatus";
            this.gvSectionStatus.ReadOnly = true;
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 811);
            this.Name = "Sections";
            this.Text = "Sections";
            this.Load += new System.EventHandler(this.Sections_Load);
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

        private System.Windows.Forms.TextBox txtSectionName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddStatus;
        private System.Windows.Forms.Label errSectionname;
        private System.Windows.Forms.Label errStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCampusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCampus;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSectionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSectionStatus;
    }
}