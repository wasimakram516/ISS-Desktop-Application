namespace ISS
{
    partial class dbFeeManagement
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPaymentMethods = new System.Windows.Forms.Button();
            this.btnFeeStructure = new System.Windows.Forms.Button();
            this.btnFeeConcession = new System.Windows.Forms.Button();
            this.btnFeeVouchers = new System.Windows.Forms.Button();
            this.btnFeePayments = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(260, 834);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Size = new System.Drawing.Size(260, 784);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.SetChildIndex(this.label4, 0);
            this.panel3.Controls.SetChildIndex(this.btnBack, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(844, 834);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel1);
            this.panel6.Size = new System.Drawing.Size(844, 784);
            // 
            // panel4
            // 
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // lblTopUser
            // 
            this.lblTopUser.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnPaymentMethods, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFeeStructure, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFeeConcession, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFeeVouchers, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFeePayments, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 784);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnPaymentMethods
            // 
            this.btnPaymentMethods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPaymentMethods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentMethods.Image = global::ISS.Properties.Resources.icons8_e_learning_96;
            this.btnPaymentMethods.Location = new System.Drawing.Point(3, 3);
            this.btnPaymentMethods.Name = "btnPaymentMethods";
            this.btnPaymentMethods.Size = new System.Drawing.Size(205, 190);
            this.btnPaymentMethods.TabIndex = 0;
            this.btnPaymentMethods.Text = "PAYMENT METHODS";
            this.btnPaymentMethods.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPaymentMethods.UseVisualStyleBackColor = true;
            this.btnPaymentMethods.Click += new System.EventHandler(this.btnPaymentMethods_Click);
            // 
            // btnFeeStructure
            // 
            this.btnFeeStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeeStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeeStructure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeeStructure.Image = global::ISS.Properties.Resources.icons8_bank_card_missing_96;
            this.btnFeeStructure.Location = new System.Drawing.Point(214, 3);
            this.btnFeeStructure.Name = "btnFeeStructure";
            this.btnFeeStructure.Size = new System.Drawing.Size(205, 190);
            this.btnFeeStructure.TabIndex = 3;
            this.btnFeeStructure.Text = "FEE STRUCTURE";
            this.btnFeeStructure.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFeeStructure.UseVisualStyleBackColor = true;
            this.btnFeeStructure.Click += new System.EventHandler(this.btnFeeStructure_Click);
            // 
            // btnFeeConcession
            // 
            this.btnFeeConcession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeeConcession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeeConcession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeeConcession.Image = global::ISS.Properties.Resources.icons8_tax_96;
            this.btnFeeConcession.Location = new System.Drawing.Point(425, 3);
            this.btnFeeConcession.Name = "btnFeeConcession";
            this.btnFeeConcession.Size = new System.Drawing.Size(205, 190);
            this.btnFeeConcession.TabIndex = 2;
            this.btnFeeConcession.Text = "FEE CONCESSION";
            this.btnFeeConcession.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFeeConcession.UseVisualStyleBackColor = true;
            this.btnFeeConcession.Click += new System.EventHandler(this.btnFeeConcession_Click);
            // 
            // btnFeeVouchers
            // 
            this.btnFeeVouchers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeeVouchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeeVouchers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeeVouchers.Image = global::ISS.Properties.Resources.icons8_transaction_list_96;
            this.btnFeeVouchers.Location = new System.Drawing.Point(636, 3);
            this.btnFeeVouchers.Name = "btnFeeVouchers";
            this.btnFeeVouchers.Size = new System.Drawing.Size(205, 190);
            this.btnFeeVouchers.TabIndex = 1;
            this.btnFeeVouchers.Text = "GENERATE FEE VOUCHERS";
            this.btnFeeVouchers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFeeVouchers.UseVisualStyleBackColor = true;
            this.btnFeeVouchers.Click += new System.EventHandler(this.btnFeeVouchers_Click);
            // 
            // btnFeePayments
            // 
            this.btnFeePayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeePayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeePayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeePayments.Image = global::ISS.Properties.Resources.icons8_cash_in_hand_96;
            this.btnFeePayments.Location = new System.Drawing.Point(3, 199);
            this.btnFeePayments.Name = "btnFeePayments";
            this.btnFeePayments.Size = new System.Drawing.Size(205, 190);
            this.btnFeePayments.TabIndex = 4;
            this.btnFeePayments.Text = "FEE PAYMENTS";
            this.btnFeePayments.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFeePayments.UseVisualStyleBackColor = true;
            this.btnFeePayments.Click += new System.EventHandler(this.btnFeePayments_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::ISS.Properties.Resources.back_wite;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 50);
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 784);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fee Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbFeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 834);
            this.Name = "dbFeeManagement";
            this.Text = "Fee Management Dashboard";
            this.LeftPanel.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPaymentMethods;
        private System.Windows.Forms.Button btnFeeStructure;
        private System.Windows.Forms.Button btnFeeConcession;
        private System.Windows.Forms.Button btnFeeVouchers;
        private System.Windows.Forms.Button btnFeePayments;
        private System.Windows.Forms.Label label1;
    }
}