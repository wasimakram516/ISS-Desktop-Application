namespace SchoolManagementSystem
{
    partial class ActiveStudentsReportWindow
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
            this.dtSession = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ddLevel = new System.Windows.Forms.ComboBox();
            this.errLevel = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.chkContactList = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ddSection = new System.Windows.Forms.ComboBox();
            this.errSection = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ddClass = new System.Windows.Forms.ComboBox();
            this.errClass = new System.Windows.Forms.Label();
            this.chkNameList = new System.Windows.Forms.CheckBox();
            this.chkResultList = new System.Windows.Forms.CheckBox();
            this.chkResultCards = new System.Windows.Forms.CheckBox();
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
            this.LeftPanel.Size = new System.Drawing.Size(260, 651);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.chkResultCards);
            this.pnlDetails.Controls.Add(this.chkResultList);
            this.pnlDetails.Controls.Add(this.chkNameList);
            this.pnlDetails.Controls.Add(this.label13);
            this.pnlDetails.Controls.Add(this.ddSection);
            this.pnlDetails.Controls.Add(this.errSection);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Controls.Add(this.ddClass);
            this.pnlDetails.Controls.Add(this.errClass);
            this.pnlDetails.Controls.Add(this.chkContactList);
            this.pnlDetails.Controls.Add(this.dtSession);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.btnLoad);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.ddLevel);
            this.pnlDetails.Controls.Add(this.errLevel);
            this.pnlDetails.Location = new System.Drawing.Point(0, 37);
            this.pnlDetails.Size = new System.Drawing.Size(260, 614);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Size = new System.Drawing.Size(260, 37);
            this.panel3.Controls.SetChildIndex(this.label4, 0);
            this.panel3.Controls.SetChildIndex(this.btnBack, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(844, 651);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.crystalReportViewer1);
            this.panel6.Location = new System.Drawing.Point(0, 37);
            this.panel6.Size = new System.Drawing.Size(844, 614);
            // 
            // panel4
            // 
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Size = new System.Drawing.Size(844, 37);
            // 
            // label4
            // 
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Size = new System.Drawing.Size(99, 37);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Size = new System.Drawing.Size(461, 37);
            this.lblTopUser.Text = " , ";
            // 
            // dtSession
            // 
            this.dtSession.CustomFormat = "yyyy";
            this.dtSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSession.Location = new System.Drawing.Point(6, 85);
            this.dtSession.Name = "dtSession";
            this.dtSession.ShowUpDown = true;
            this.dtSession.Size = new System.Drawing.Size(248, 25);
            this.dtSession.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Session";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(3, 380);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(254, 40);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "Select Level";
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLevel.FormattingEnabled = true;
            this.ddLevel.Location = new System.Drawing.Point(6, 134);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.Size = new System.Drawing.Size(248, 25);
            this.ddLevel.TabIndex = 1;
            this.ddLevel.SelectedIndexChanged += new System.EventHandler(this.ddLevel_SelectedIndexChanged);
            // 
            // errLevel
            // 
            this.errLevel.AutoSize = true;
            this.errLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLevel.Location = new System.Drawing.Point(237, 112);
            this.errLevel.Name = "errLevel";
            this.errLevel.Size = new System.Drawing.Size(20, 28);
            this.errLevel.TabIndex = 46;
            this.errLevel.Text = "*";
            this.errLevel.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::SchoolManagementSystem.Properties.Resources.back_wite;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 37);
            this.btnBack.TabIndex = 16;
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
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(844, 614);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // chkContactList
            // 
            this.chkContactList.AutoSize = true;
            this.chkContactList.Location = new System.Drawing.Point(6, 293);
            this.chkContactList.Name = "chkContactList";
            this.chkContactList.Size = new System.Drawing.Size(126, 23);
            this.chkContactList.TabIndex = 4;
            this.chkContactList.Text = "Contact No. List";
            this.chkContactList.UseVisualStyleBackColor = true;
            this.chkContactList.CheckedChanged += new System.EventHandler(this.chkContactList_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 19);
            this.label13.TabIndex = 139;
            this.label13.Text = "Section";
            // 
            // ddSection
            // 
            this.ddSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddSection.FormattingEnabled = true;
            this.ddSection.Location = new System.Drawing.Point(7, 233);
            this.ddSection.Name = "ddSection";
            this.ddSection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddSection.Size = new System.Drawing.Size(247, 25);
            this.ddSection.TabIndex = 3;
            this.ddSection.SelectedIndexChanged += new System.EventHandler(this.ddSection_SelectedIndexChanged);
            // 
            // errSection
            // 
            this.errSection.AutoSize = true;
            this.errSection.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSection.Location = new System.Drawing.Point(237, 211);
            this.errSection.Name = "errSection";
            this.errSection.Size = new System.Drawing.Size(20, 28);
            this.errSection.TabIndex = 140;
            this.errSection.Text = "*";
            this.errSection.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 137;
            this.label8.Text = "Select Class";
            // 
            // ddClass
            // 
            this.ddClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddClass.FormattingEnabled = true;
            this.ddClass.Location = new System.Drawing.Point(6, 183);
            this.ddClass.Name = "ddClass";
            this.ddClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddClass.Size = new System.Drawing.Size(248, 25);
            this.ddClass.TabIndex = 2;
            this.ddClass.SelectedIndexChanged += new System.EventHandler(this.ddClass_SelectedIndexChanged);
            // 
            // errClass
            // 
            this.errClass.AutoSize = true;
            this.errClass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errClass.Location = new System.Drawing.Point(237, 161);
            this.errClass.Name = "errClass";
            this.errClass.Size = new System.Drawing.Size(20, 28);
            this.errClass.TabIndex = 138;
            this.errClass.Text = "*";
            this.errClass.Visible = false;
            // 
            // chkNameList
            // 
            this.chkNameList.AutoSize = true;
            this.chkNameList.Location = new System.Drawing.Point(7, 264);
            this.chkNameList.Name = "chkNameList";
            this.chkNameList.Size = new System.Drawing.Size(89, 23);
            this.chkNameList.TabIndex = 141;
            this.chkNameList.Text = "Name List";
            this.chkNameList.UseVisualStyleBackColor = true;
            this.chkNameList.CheckedChanged += new System.EventHandler(this.chkNameList_CheckedChanged);
            // 
            // chkResultList
            // 
            this.chkResultList.AutoSize = true;
            this.chkResultList.Location = new System.Drawing.Point(6, 322);
            this.chkResultList.Name = "chkResultList";
            this.chkResultList.Size = new System.Drawing.Size(90, 23);
            this.chkResultList.TabIndex = 142;
            this.chkResultList.Text = "Result List";
            this.chkResultList.UseVisualStyleBackColor = true;
            this.chkResultList.CheckedChanged += new System.EventHandler(this.chkResultList_CheckedChanged);
            // 
            // chkResultCards
            // 
            this.chkResultCards.AutoSize = true;
            this.chkResultCards.Location = new System.Drawing.Point(6, 351);
            this.chkResultCards.Name = "chkResultCards";
            this.chkResultCards.Size = new System.Drawing.Size(104, 23);
            this.chkResultCards.TabIndex = 142;
            this.chkResultCards.Text = "Result Cards";
            this.chkResultCards.UseVisualStyleBackColor = true;
            this.chkResultCards.CheckedChanged += new System.EventHandler(this.chkResultCards_CheckedChanged);
            // 
            // ActiveStudentsReportWindow
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 651);
            this.Name = "ActiveStudentsReportWindow";
            this.Text = "Students Lists";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActiveStudentsReportWindow_FormClosing);
            this.Load += new System.EventHandler(this.ActiveStudentsReportWindow_Load);
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

        private System.Windows.Forms.DateTimePicker dtSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddLevel;
        private System.Windows.Forms.Label errLevel;
        private System.Windows.Forms.Button btnBack;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.CheckBox chkContactList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ddSection;
        private System.Windows.Forms.Label errSection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddClass;
        private System.Windows.Forms.Label errClass;
        private System.Windows.Forms.CheckBox chkResultList;
        private System.Windows.Forms.CheckBox chkNameList;
        private System.Windows.Forms.CheckBox chkResultCards;
    }
}