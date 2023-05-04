namespace ISS
{
    partial class Birthdays
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvRegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(260, 834);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Size = new System.Drawing.Size(260, 784);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(844, 834);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Size = new System.Drawing.Size(844, 784);
            this.panel6.Controls.SetChildIndex(this.panel1, 0);
            this.panel6.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Text = " ,  (  )";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 717);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Birthday Kids";
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
            this.gvRegNo,
            this.gvStuName,
            this.gvFatherName,
            this.gvDOB,
            this.gvAge,
            this.gvClass,
            this.gvSection});
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
            this.dataGridView1.Size = new System.Drawing.Size(838, 693);
            this.dataGridView1.TabIndex = 0;
            // 
            // gvSNO
            // 
            this.gvSNO.HeaderText = "Sr.No.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            // 
            // gvRegNo
            // 
            this.gvRegNo.HeaderText = "Reg No.";
            this.gvRegNo.Name = "gvRegNo";
            this.gvRegNo.ReadOnly = true;
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
            // gvDOB
            // 
            this.gvDOB.HeaderText = "DOB";
            this.gvDOB.Name = "gvDOB";
            this.gvDOB.ReadOnly = true;
            // 
            // gvAge
            // 
            this.gvAge.HeaderText = "Age";
            this.gvAge.Name = "gvAge";
            this.gvAge.ReadOnly = true;
            // 
            // gvClass
            // 
            this.gvClass.HeaderText = "Class";
            this.gvClass.Name = "gvClass";
            this.gvClass.ReadOnly = true;
            // 
            // gvSection
            // 
            this.gvSection.HeaderText = "Section";
            this.gvSection.Name = "gvSection";
            this.gvSection.ReadOnly = true;
            // 
            // Birthdays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 834);
            this.Name = "Birthdays";
            this.Text = "Birthdays";
            this.Load += new System.EventHandler(this.Birthdays_Load);
            this.LeftPanel.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvRegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSection;
    }
}