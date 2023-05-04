namespace ISS
{
    partial class FeeDefaultersListWindow
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dtSession = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ddLevel = new System.Windows.Forms.ComboBox();
            this.errLevel = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
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
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LeftPanel.Size = new System.Drawing.Size(334, 1037);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.dtSession);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.ddLevel);
            this.pnlDetails.Controls.Add(this.errLevel);
            this.pnlDetails.Controls.Add(this.btnLoad);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDetails.Size = new System.Drawing.Size(334, 987);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Size = new System.Drawing.Size(334, 50);
            this.panel3.Controls.SetChildIndex(this.label4, 0);
            this.panel3.Controls.SetChildIndex(this.btnBack, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Location = new System.Drawing.Point(334, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RightPanel.Size = new System.Drawing.Size(1085, 1037);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.crystalReportViewer1);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Size = new System.Drawing.Size(1085, 987);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1085, 50);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(235, 0);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopUser.Size = new System.Drawing.Size(593, 50);
            this.lblTopUser.Text = " ,  (  )";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::ISS.Properties.Resources.back_wite;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 50);
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1085, 987);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dtSession
            // 
            this.dtSession.CustomFormat = "yyyy";
            this.dtSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSession.Location = new System.Drawing.Point(10, 119);
            this.dtSession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtSession.Name = "dtSession";
            this.dtSession.ShowUpDown = true;
            this.dtSession.Size = new System.Drawing.Size(315, 30);
            this.dtSession.TabIndex = 137;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 147;
            this.label6.Text = "Session";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 145;
            this.label7.Text = "Select Level";
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLevel.FormattingEnabled = true;
            this.ddLevel.Location = new System.Drawing.Point(10, 188);
            this.ddLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddLevel.Size = new System.Drawing.Size(315, 31);
            this.ddLevel.TabIndex = 138;
            this.ddLevel.SelectedIndexChanged += new System.EventHandler(this.ddLevel_SelectedIndexChanged);
            // 
            // errLevel
            // 
            this.errLevel.AutoSize = true;
            this.errLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLevel.Location = new System.Drawing.Point(301, 157);
            this.errLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errLevel.Name = "errLevel";
            this.errLevel.Size = new System.Drawing.Size(25, 35);
            this.errLevel.TabIndex = 146;
            this.errLevel.Text = "*";
            this.errLevel.Visible = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(10, 230);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(315, 54);
            this.btnLoad.TabIndex = 142;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // FeeDefaultersListWindow
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 1037);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FeeDefaultersListWindow";
            this.Text = "Fee Defaulters List";
            this.Load += new System.EventHandler(this.FeeDefaultersListWindow_Load);
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
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DateTimePicker dtSession;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddLevel;
        private System.Windows.Forms.Label errLevel;
        private System.Windows.Forms.Button btnLoad;
    }
}