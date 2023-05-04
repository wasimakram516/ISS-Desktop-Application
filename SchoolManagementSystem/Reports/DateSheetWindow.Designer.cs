namespace ISS
{
    partial class DateSheetWindow
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
            this.btnBack = new System.Windows.Forms.Button();
            this.ddExamType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errExamType = new System.Windows.Forms.Label();
            this.dtSession = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnDateSheet = new System.Windows.Forms.Button();
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
            this.pnlDetails.Controls.Add(this.btnDateSheet);
            this.pnlDetails.Controls.Add(this.ddExamType);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.errExamType);
            this.pnlDetails.Controls.Add(this.dtSession);
            this.pnlDetails.Controls.Add(this.label1);
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
            // ddExamType
            // 
            this.ddExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddExamType.FormattingEnabled = true;
            this.ddExamType.Location = new System.Drawing.Point(4, 126);
            this.ddExamType.Name = "ddExamType";
            this.ddExamType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddExamType.Size = new System.Drawing.Size(250, 25);
            this.ddExamType.TabIndex = 1;
            this.ddExamType.SelectedIndexChanged += new System.EventHandler(this.ddExamType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 102;
            this.label6.Text = "Exam Name";
            // 
            // errExamType
            // 
            this.errExamType.AutoSize = true;
            this.errExamType.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errExamType.Location = new System.Drawing.Point(234, 105);
            this.errExamType.Name = "errExamType";
            this.errExamType.Size = new System.Drawing.Size(20, 28);
            this.errExamType.TabIndex = 103;
            this.errExamType.Text = "*";
            this.errExamType.Visible = false;
            // 
            // dtSession
            // 
            this.dtSession.CustomFormat = "yyyy";
            this.dtSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSession.Location = new System.Drawing.Point(3, 74);
            this.dtSession.Name = "dtSession";
            this.dtSession.ShowUpDown = true;
            this.dtSession.Size = new System.Drawing.Size(251, 25);
            this.dtSession.TabIndex = 0;
            this.dtSession.ValueChanged += new System.EventHandler(this.dtSession_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 101;
            this.label1.Text = "Session";
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
            this.crystalReportViewer1.TabIndex = 4;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnDateSheet
            // 
            this.btnDateSheet.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDateSheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDateSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateSheet.Location = new System.Drawing.Point(3, 157);
            this.btnDateSheet.Name = "btnDateSheet";
            this.btnDateSheet.Size = new System.Drawing.Size(251, 40);
            this.btnDateSheet.TabIndex = 2;
            this.btnDateSheet.Text = "LOAD DATESHEET";
            this.btnDateSheet.UseVisualStyleBackColor = false;
            this.btnDateSheet.Click += new System.EventHandler(this.btnDateSheet_Click);
            // 
            // DateSheetWindow
            // 
            this.AcceptButton = this.btnDateSheet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 749);
            this.Name = "DateSheetWindow";
            this.Text = "Date Sheets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DateSheetWindow_FormClosing);
            this.Load += new System.EventHandler(this.DateSheetWindow_Load);
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
        private System.Windows.Forms.ComboBox ddExamType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label errExamType;
        private System.Windows.Forms.DateTimePicker dtSession;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnDateSheet;
    }
}