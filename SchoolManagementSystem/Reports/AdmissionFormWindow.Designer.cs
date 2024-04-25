namespace SchoolManagementSystem
{
    partial class AdmissionFormWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.ddStudent = new System.Windows.Forms.ComboBox();
            this.errStudent = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ddSection = new System.Windows.Forms.ComboBox();
            this.errSection = new System.Windows.Forms.Label();
            this.dtSession = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ddLevel = new System.Windows.Forms.ComboBox();
            this.errLevel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ddClass = new System.Windows.Forms.ComboBox();
            this.errClass = new System.Windows.Forms.Label();
            this.btnAdmissionForm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtWhatsApp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWhatsapp = new System.Windows.Forms.Button();
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
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.btnWhatsapp);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.txtWhatsApp);
            this.pnlDetails.Controls.Add(this.btnAdmissionForm);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.ddStudent);
            this.pnlDetails.Controls.Add(this.errStudent);
            this.pnlDetails.Controls.Add(this.label13);
            this.pnlDetails.Controls.Add(this.ddSection);
            this.pnlDetails.Controls.Add(this.errSection);
            this.pnlDetails.Controls.Add(this.dtSession);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.ddLevel);
            this.pnlDetails.Controls.Add(this.errLevel);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.ddClass);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 121;
            this.label2.Text = "Student";
            // 
            // ddStudent
            // 
            this.ddStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddStudent.FormattingEnabled = true;
            this.ddStudent.Location = new System.Drawing.Point(6, 279);
            this.ddStudent.Name = "ddStudent";
            this.ddStudent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddStudent.Size = new System.Drawing.Size(248, 25);
            this.ddStudent.TabIndex = 4;
            this.ddStudent.SelectedIndexChanged += new System.EventHandler(this.ddStudent_SelectedIndexChanged);
            // 
            // errStudent
            // 
            this.errStudent.AutoSize = true;
            this.errStudent.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errStudent.Location = new System.Drawing.Point(234, 257);
            this.errStudent.Name = "errStudent";
            this.errStudent.Size = new System.Drawing.Size(20, 28);
            this.errStudent.TabIndex = 122;
            this.errStudent.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 19);
            this.label13.TabIndex = 119;
            this.label13.Text = "Section";
            // 
            // ddSection
            // 
            this.ddSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddSection.FormattingEnabled = true;
            this.ddSection.Location = new System.Drawing.Point(6, 230);
            this.ddSection.Name = "ddSection";
            this.ddSection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddSection.Size = new System.Drawing.Size(248, 25);
            this.ddSection.TabIndex = 3;
            this.ddSection.SelectedIndexChanged += new System.EventHandler(this.ddSection_SelectedIndexChanged);
            // 
            // errSection
            // 
            this.errSection.AutoSize = true;
            this.errSection.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSection.Location = new System.Drawing.Point(234, 208);
            this.errSection.Name = "errSection";
            this.errSection.Size = new System.Drawing.Size(20, 28);
            this.errSection.TabIndex = 120;
            this.errSection.Text = "*";
            // 
            // dtSession
            // 
            this.dtSession.CustomFormat = "yyyy";
            this.dtSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSession.Location = new System.Drawing.Point(6, 84);
            this.dtSession.Name = "dtSession";
            this.dtSession.ShowUpDown = true;
            this.dtSession.Size = new System.Drawing.Size(248, 25);
            this.dtSession.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 116;
            this.label1.Text = "Session";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 114;
            this.label7.Text = "Select Level";
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLevel.FormattingEnabled = true;
            this.ddLevel.Location = new System.Drawing.Point(6, 132);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddLevel.Size = new System.Drawing.Size(248, 25);
            this.ddLevel.TabIndex = 1;
            this.ddLevel.SelectedIndexChanged += new System.EventHandler(this.ddLevel_SelectedIndexChanged);
            // 
            // errLevel
            // 
            this.errLevel.AutoSize = true;
            this.errLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLevel.Location = new System.Drawing.Point(234, 110);
            this.errLevel.Name = "errLevel";
            this.errLevel.Size = new System.Drawing.Size(20, 28);
            this.errLevel.TabIndex = 115;
            this.errLevel.Text = "*";
            this.errLevel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 112;
            this.label3.Text = "Select Class";
            // 
            // ddClass
            // 
            this.ddClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddClass.FormattingEnabled = true;
            this.ddClass.Location = new System.Drawing.Point(6, 181);
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
            this.errClass.Location = new System.Drawing.Point(234, 159);
            this.errClass.Name = "errClass";
            this.errClass.Size = new System.Drawing.Size(20, 28);
            this.errClass.TabIndex = 113;
            this.errClass.Text = "*";
            this.errClass.Visible = false;
            // 
            // btnAdmissionForm
            // 
            this.btnAdmissionForm.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAdmissionForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmissionForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmissionForm.Location = new System.Drawing.Point(6, 360);
            this.btnAdmissionForm.Name = "btnAdmissionForm";
            this.btnAdmissionForm.Size = new System.Drawing.Size(248, 40);
            this.btnAdmissionForm.TabIndex = 5;
            this.btnAdmissionForm.Text = "LOAD ADMISSION FORM";
            this.btnAdmissionForm.UseVisualStyleBackColor = false;
            this.btnAdmissionForm.Click += new System.EventHandler(this.btnAdmissionForm_Click);
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
            this.btnBack.Size = new System.Drawing.Size(45, 50);
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(844, 699);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txtWhatsApp
            // 
            this.txtWhatsApp.Enabled = false;
            this.txtWhatsApp.Location = new System.Drawing.Point(6, 329);
            this.txtWhatsApp.Name = "txtWhatsApp";
            this.txtWhatsApp.Size = new System.Drawing.Size(248, 25);
            this.txtWhatsApp.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 124;
            this.label5.Text = "WhatsApp Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 125;
            this.label6.Text = "Send Via";
            // 
            // btnWhatsapp
            // 
            this.btnWhatsapp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWhatsapp.FlatAppearance.BorderSize = 0;
            this.btnWhatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhatsapp.Image = global::SchoolManagementSystem.Properties.Resources.whatsApp_small;
            this.btnWhatsapp.Location = new System.Drawing.Point(135, 406);
            this.btnWhatsapp.Name = "btnWhatsapp";
            this.btnWhatsapp.Size = new System.Drawing.Size(55, 45);
            this.btnWhatsapp.TabIndex = 126;
            this.btnWhatsapp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWhatsapp.UseVisualStyleBackColor = true;
            this.btnWhatsapp.Click += new System.EventHandler(this.btnWhatsapp_Click);
            // 
            // AdmissionFormWindow
            // 
            this.AcceptButton = this.btnAdmissionForm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 749);
            this.Name = "AdmissionFormWindow";
            this.Text = "Admission Forms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdmissionFormWindow_FormClosing);
            this.Load += new System.EventHandler(this.AdmissionFormWindow_Load);
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddStudent;
        private System.Windows.Forms.Label errStudent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ddSection;
        private System.Windows.Forms.Label errSection;
        private System.Windows.Forms.DateTimePicker dtSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddLevel;
        private System.Windows.Forms.Label errLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddClass;
        private System.Windows.Forms.Label errClass;
        private System.Windows.Forms.Button btnAdmissionForm;
        private System.Windows.Forms.Button btnBack;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWhatsApp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnWhatsapp;
    }
}