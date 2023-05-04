namespace ISS
{
    partial class Campuses
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
            this.txtCampusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ddStatus = new System.Windows.Forms.ComboBox();
            this.errCampusName = new System.Windows.Forms.Label();
            this.errAddress = new System.Windows.Forms.Label();
            this.errPhone1 = new System.Windows.Forms.Label();
            this.errStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCampID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCampus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPhone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPhone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlDetails.Controls.Add(this.ddStatus);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.txtEmail);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.txtPhone2);
            this.pnlDetails.Controls.Add(this.txtPhone1);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.txtAddress);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.txtCampusName);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.errStatus);
            this.pnlDetails.Controls.Add(this.errPhone1);
            this.pnlDetails.Controls.Add(this.errAddress);
            this.pnlDetails.Controls.Add(this.errCampusName);
            this.pnlDetails.Controls.SetChildIndex(this.errCampusName, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errAddress, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errPhone1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errStatus, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtCampusName, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtAddress, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label5, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtPhone1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtPhone2, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label6, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtEmail, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label7, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddStatus, 0);
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
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Campus Name";
            // 
            // txtCampusName
            // 
            this.txtCampusName.Location = new System.Drawing.Point(7, 113);
            this.txtCampusName.Name = "txtCampusName";
            this.txtCampusName.Size = new System.Drawing.Size(247, 25);
            this.txtCampusName.TabIndex = 0;
            this.txtCampusName.TextChanged += new System.EventHandler(this.txtCampusName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(7, 163);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(247, 62);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone 2";
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(7, 250);
            this.txtPhone1.MaxLength = 10;
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(247, 25);
            this.txtPhone1.TabIndex = 2;
            this.txtPhone1.TextChanged += new System.EventHandler(this.txtPhone1_TextChanged);
            this.txtPhone1.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone1_Validating);
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(7, 300);
            this.txtPhone2.MaxLength = 10;
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(247, 25);
            this.txtPhone2.TabIndex = 3;
            this.txtPhone2.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone2_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(7, 350);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 25);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Status";
            // 
            // ddStatus
            // 
            this.ddStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddStatus.FormattingEnabled = true;
            this.ddStatus.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.ddStatus.Location = new System.Drawing.Point(7, 401);
            this.ddStatus.Name = "ddStatus";
            this.ddStatus.Size = new System.Drawing.Size(247, 25);
            this.ddStatus.TabIndex = 5;
            this.ddStatus.SelectedIndexChanged += new System.EventHandler(this.ddStatus_SelectedIndexChanged);
            // 
            // errCampusName
            // 
            this.errCampusName.AutoSize = true;
            this.errCampusName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errCampusName.Location = new System.Drawing.Point(234, 91);
            this.errCampusName.Name = "errCampusName";
            this.errCampusName.Size = new System.Drawing.Size(20, 28);
            this.errCampusName.TabIndex = 13;
            this.errCampusName.Text = "*";
            this.errCampusName.Visible = false;
            // 
            // errAddress
            // 
            this.errAddress.AutoSize = true;
            this.errAddress.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errAddress.Location = new System.Drawing.Point(234, 141);
            this.errAddress.Name = "errAddress";
            this.errAddress.Size = new System.Drawing.Size(20, 28);
            this.errAddress.TabIndex = 14;
            this.errAddress.Text = "*";
            this.errAddress.Visible = false;
            // 
            // errPhone1
            // 
            this.errPhone1.AutoSize = true;
            this.errPhone1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPhone1.Location = new System.Drawing.Point(234, 228);
            this.errPhone1.Name = "errPhone1";
            this.errPhone1.Size = new System.Drawing.Size(20, 28);
            this.errPhone1.TabIndex = 15;
            this.errPhone1.Text = "*";
            this.errPhone1.Visible = false;
            // 
            // errStatus
            // 
            this.errStatus.AutoSize = true;
            this.errStatus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errStatus.Location = new System.Drawing.Point(234, 378);
            this.errStatus.Name = "errStatus";
            this.errStatus.Size = new System.Drawing.Size(20, 28);
            this.errStatus.TabIndex = 16;
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
            this.gvSNO,
            this.gvCampID,
            this.gvCampus,
            this.gvAddress,
            this.gvPhone1,
            this.gvPhone2,
            this.gvEmail,
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
            this.gvSNO.HeaderText = "Sr.No.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Width = 70;
            // 
            // gvCampID
            // 
            this.gvCampID.HeaderText = "Campus ID";
            this.gvCampID.Name = "gvCampID";
            this.gvCampID.ReadOnly = true;
            this.gvCampID.Visible = false;
            // 
            // gvCampus
            // 
            this.gvCampus.HeaderText = "Campus";
            this.gvCampus.Name = "gvCampus";
            this.gvCampus.ReadOnly = true;
            // 
            // gvAddress
            // 
            this.gvAddress.HeaderText = "Address";
            this.gvAddress.Name = "gvAddress";
            this.gvAddress.ReadOnly = true;
            // 
            // gvPhone1
            // 
            this.gvPhone1.HeaderText = "Phone 1";
            this.gvPhone1.Name = "gvPhone1";
            this.gvPhone1.ReadOnly = true;
            // 
            // gvPhone2
            // 
            this.gvPhone2.HeaderText = "Phone 2";
            this.gvPhone2.Name = "gvPhone2";
            this.gvPhone2.ReadOnly = true;
            // 
            // gvEmail
            // 
            this.gvEmail.HeaderText = "Email";
            this.gvEmail.Name = "gvEmail";
            this.gvEmail.ReadOnly = true;
            // 
            // gvStatus
            // 
            this.gvStatus.HeaderText = "Status";
            this.gvStatus.Name = "gvStatus";
            this.gvStatus.ReadOnly = true;
            // 
            // Campuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 811);
            this.Name = "Campuses";
            this.Text = "Campuses";
            this.Load += new System.EventHandler(this.Campuses_Load);
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
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCampusName;
        private System.Windows.Forms.ComboBox ddStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label errStatus;
        private System.Windows.Forms.Label errPhone1;
        private System.Windows.Forms.Label errAddress;
        private System.Windows.Forms.Label errCampusName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCampID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCampus;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPhone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPhone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStatus;
    }
}