namespace SchoolManagementSystem
{
    partial class PaymentMethod
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.errAccount = new System.Windows.Forms.Label();
            this.errAddress = new System.Windows.Forms.Label();
            this.errbranch = new System.Windows.Forms.Label();
            this.errBank = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvBankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.txtAccount);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.txtAddress);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.txtBranch);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.txtBank);
            this.pnlDetails.Controls.Add(this.errAccount);
            this.pnlDetails.Controls.Add(this.errAddress);
            this.pnlDetails.Controls.Add(this.errbranch);
            this.pnlDetails.Controls.Add(this.errBank);
            this.pnlDetails.Controls.SetChildIndex(this.errBank, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errbranch, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errAddress, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errAccount, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtBank, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtBranch, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtAddress, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label7, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtAccount, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label6, 0);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 87;
            this.label6.Text = "Account #";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(3, 237);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(251, 25);
            this.txtAccount.TabIndex = 3;
            this.txtAccount.TextChanged += new System.EventHandler(this.txtAccount_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 85;
            this.label7.Text = "Addresss";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(3, 189);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(251, 25);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 83;
            this.label2.Text = "Branch";
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(3, 139);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(251, 25);
            this.txtBranch.TabIndex = 1;
            this.txtBranch.TextChanged += new System.EventHandler(this.txtBranch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 81;
            this.label1.Text = "Bank";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(3, 90);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(251, 25);
            this.txtBank.TabIndex = 0;
            this.txtBank.TextChanged += new System.EventHandler(this.txtBank_TextChanged);
            // 
            // errAccount
            // 
            this.errAccount.AutoSize = true;
            this.errAccount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errAccount.Location = new System.Drawing.Point(234, 217);
            this.errAccount.Name = "errAccount";
            this.errAccount.Size = new System.Drawing.Size(20, 28);
            this.errAccount.TabIndex = 91;
            this.errAccount.Text = "*";
            this.errAccount.Visible = false;
            // 
            // errAddress
            // 
            this.errAddress.AutoSize = true;
            this.errAddress.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errAddress.Location = new System.Drawing.Point(234, 168);
            this.errAddress.Name = "errAddress";
            this.errAddress.Size = new System.Drawing.Size(20, 28);
            this.errAddress.TabIndex = 90;
            this.errAddress.Text = "*";
            this.errAddress.Visible = false;
            // 
            // errbranch
            // 
            this.errbranch.AutoSize = true;
            this.errbranch.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errbranch.Location = new System.Drawing.Point(234, 117);
            this.errbranch.Name = "errbranch";
            this.errbranch.Size = new System.Drawing.Size(20, 28);
            this.errbranch.TabIndex = 89;
            this.errbranch.Text = "*";
            this.errbranch.Visible = false;
            // 
            // errBank
            // 
            this.errBank.AutoSize = true;
            this.errBank.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errBank.Location = new System.Drawing.Point(234, 68);
            this.errBank.Name = "errBank";
            this.errBank.Size = new System.Drawing.Size(20, 28);
            this.errBank.TabIndex = 88;
            this.errBank.Text = "*";
            this.errBank.Visible = false;
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
            this.gvBankID,
            this.gvBank,
            this.gvBranch,
            this.gvAddress,
            this.gvAccount});
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
            this.gvSNO.HeaderText = "SNO";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Width = 62;
            // 
            // gvBankID
            // 
            this.gvBankID.HeaderText = "BankID";
            this.gvBankID.Name = "gvBankID";
            this.gvBankID.ReadOnly = true;
            this.gvBankID.Visible = false;
            // 
            // gvBank
            // 
            this.gvBank.HeaderText = "Bank";
            this.gvBank.Name = "gvBank";
            this.gvBank.ReadOnly = true;
            // 
            // gvBranch
            // 
            this.gvBranch.HeaderText = "Branch";
            this.gvBranch.Name = "gvBranch";
            this.gvBranch.ReadOnly = true;
            // 
            // gvAddress
            // 
            this.gvAddress.HeaderText = "Address";
            this.gvAddress.Name = "gvAddress";
            this.gvAddress.ReadOnly = true;
            // 
            // gvAccount
            // 
            this.gvAccount.HeaderText = "Account #";
            this.gvAccount.Name = "gvAccount";
            this.gvAccount.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 811);
            this.Name = "PaymentMethod";
            this.Text = "Payment Methods";
            this.Load += new System.EventHandler(this.PaymentMethod_Load);
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

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label errAccount;
        private System.Windows.Forms.Label errAddress;
        private System.Windows.Forms.Label errbranch;
        private System.Windows.Forms.Label errBank;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvBankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAccount;
    }
}