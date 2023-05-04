namespace ISS
{
    partial class FeePaymentReportWindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.ddSection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errSection = new System.Windows.Forms.Label();
            this.errClass = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtSession = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ddLevel = new System.Windows.Forms.ComboBox();
            this.errLevel = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(260, 749);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.ddLevel);
            this.pnlDetails.Controls.Add(this.errLevel);
            this.pnlDetails.Controls.Add(this.dtSession);
            this.pnlDetails.Controls.Add(this.label12);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.dateTimePicker1);
            this.pnlDetails.Controls.Add(this.btnLoad);
            this.pnlDetails.Controls.Add(this.ddSection);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.ddClass);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.errSection);
            this.pnlDetails.Controls.Add(this.errClass);
            this.pnlDetails.Size = new System.Drawing.Size(260, 699);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.SetChildIndex(this.label4, 0);
            this.panel3.Controls.SetChildIndex(this.btnBack, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(844, 749);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.crystalReportViewer1);
            this.panel6.Size = new System.Drawing.Size(844, 699);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Text = " , ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Select Month / Year";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMMM -  yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 277);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 25);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(11, 308);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(242, 43);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ddSection
            // 
            this.ddSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddSection.FormattingEnabled = true;
            this.ddSection.Location = new System.Drawing.Point(10, 227);
            this.ddSection.Name = "ddSection";
            this.ddSection.Size = new System.Drawing.Size(242, 25);
            this.ddSection.TabIndex = 3;
            this.ddSection.SelectedIndexChanged += new System.EventHandler(this.ddSection_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Section";
            // 
            // ddClass
            // 
            this.ddClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddClass.FormattingEnabled = true;
            this.ddClass.Location = new System.Drawing.Point(11, 178);
            this.ddClass.Name = "ddClass";
            this.ddClass.Size = new System.Drawing.Size(241, 25);
            this.ddClass.TabIndex = 2;
            this.ddClass.SelectedIndexChanged += new System.EventHandler(this.ddClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select Class";
            // 
            // errSection
            // 
            this.errSection.AutoSize = true;
            this.errSection.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSection.Location = new System.Drawing.Point(232, 206);
            this.errSection.Name = "errSection";
            this.errSection.Size = new System.Drawing.Size(20, 28);
            this.errSection.TabIndex = 21;
            this.errSection.Text = "*";
            // 
            // errClass
            // 
            this.errClass.AutoSize = true;
            this.errClass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errClass.Location = new System.Drawing.Point(232, 154);
            this.errClass.Name = "errClass";
            this.errClass.Size = new System.Drawing.Size(20, 28);
            this.errClass.TabIndex = 20;
            this.errClass.Text = "*";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(844, 699);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            // dtSession
            // 
            this.dtSession.CustomFormat = "yyyy";
            this.dtSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSession.Location = new System.Drawing.Point(11, 77);
            this.dtSession.Name = "dtSession";
            this.dtSession.ShowUpDown = true;
            this.dtSession.Size = new System.Drawing.Size(241, 25);
            this.dtSession.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 19);
            this.label12.TabIndex = 142;
            this.label12.Text = "Session";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 144;
            this.label5.Text = "Select Level";
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLevel.FormattingEnabled = true;
            this.ddLevel.Location = new System.Drawing.Point(11, 126);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddLevel.Size = new System.Drawing.Size(242, 25);
            this.ddLevel.TabIndex = 1;
            this.ddLevel.SelectedIndexChanged += new System.EventHandler(this.ddLevel_SelectedIndexChanged);
            // 
            // errLevel
            // 
            this.errLevel.AutoSize = true;
            this.errLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLevel.Location = new System.Drawing.Point(232, 105);
            this.errLevel.Name = "errLevel";
            this.errLevel.Size = new System.Drawing.Size(20, 28);
            this.errLevel.TabIndex = 145;
            this.errLevel.Text = "*";
            this.errLevel.Visible = false;
            // 
            // FeePaymentReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 749);
            this.Name = "FeePaymentReportWindow";
            this.Text = "Fee Payment Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FeePaymentReportWindow_FormClosing);
            this.Load += new System.EventHandler(this.FeePaymentReportWindow_Load);
            this.LeftPanel.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox ddSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errSection;
        private System.Windows.Forms.Label errClass;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DateTimePicker dtSession;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddLevel;
        private System.Windows.Forms.Label errLevel;
    }
}