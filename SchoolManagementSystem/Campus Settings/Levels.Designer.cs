namespace ISS
{
    partial class Levels
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
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.errLevel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCampusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCampus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLevelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlDetails.Controls.Add(this.txtLevel);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.errLevel);
            this.pnlDetails.Controls.SetChildIndex(this.errLevel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtLevel, 0);
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
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Level";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(12, 81);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(242, 25);
            this.txtLevel.TabIndex = 2;
            this.txtLevel.TextChanged += new System.EventHandler(this.txtLevel_TextChanged);
            // 
            // errLevel
            // 
            this.errLevel.AutoSize = true;
            this.errLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLevel.Location = new System.Drawing.Point(234, 59);
            this.errLevel.Name = "errLevel";
            this.errLevel.Size = new System.Drawing.Size(20, 28);
            this.errLevel.TabIndex = 3;
            this.errLevel.Text = "*";
            this.errLevel.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 701);
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
            this.gvLevelID,
            this.gvLevel});
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
            this.dataGridView1.Size = new System.Drawing.Size(838, 677);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 811);
            this.Name = "Levels";
            this.Text = "Levels";
            this.Load += new System.EventHandler(this.Levels_Load);
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
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label errLevel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCampusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCampus;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvLevelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvLevel;
    }
}