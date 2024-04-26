namespace SchoolManagementSystem
{
    partial class FeeVoucherReportWindow
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label13 = new System.Windows.Forms.Label();
            this.ddSection = new System.Windows.Forms.ComboBox();
            this.errSection = new System.Windows.Forms.Label();
            this.dtSession = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ddLevel = new System.Windows.Forms.ComboBox();
            this.errLevel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ddClass = new System.Windows.Forms.ComboBox();
            this.errClass = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtMonthYear = new System.Windows.Forms.DateTimePicker();
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.chkStudent = new System.Windows.Forms.CheckBox();
            this.chkFather = new System.Windows.Forms.CheckBox();
            this.pnlFather = new System.Windows.Forms.Panel();
            this.txtFatherPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoad2 = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlStudent.SuspendLayout();
            this.pnlFather.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(260, 749);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.chkFather);
            this.pnlDetails.Controls.Add(this.chkStudent);
            this.pnlDetails.Controls.Add(this.pnlFather);
            this.pnlDetails.Controls.Add(this.pnlStudent);
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
            this.btnBack.Image = global::SchoolManagementSystem.Properties.Resources.back_wite;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 50);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(4, 260);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(245, 38);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "LOAD VOUCHERS";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
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
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 19);
            this.label13.TabIndex = 133;
            this.label13.Text = "Section";
            // 
            // ddSection
            // 
            this.ddSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddSection.FormattingEnabled = true;
            this.ddSection.Location = new System.Drawing.Point(4, 179);
            this.ddSection.Name = "ddSection";
            this.ddSection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddSection.Size = new System.Drawing.Size(245, 25);
            this.ddSection.TabIndex = 3;
            this.ddSection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // errSection
            // 
            this.errSection.AutoSize = true;
            this.errSection.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSection.Location = new System.Drawing.Point(229, 157);
            this.errSection.Name = "errSection";
            this.errSection.Size = new System.Drawing.Size(20, 28);
            this.errSection.TabIndex = 134;
            this.errSection.Text = "*";
            this.errSection.Visible = false;
            // 
            // dtSession
            // 
            this.dtSession.CustomFormat = "yyyy";
            this.dtSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSession.Location = new System.Drawing.Point(3, 28);
            this.dtSession.Name = "dtSession";
            this.dtSession.ShowUpDown = true;
            this.dtSession.Size = new System.Drawing.Size(246, 25);
            this.dtSession.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 132;
            this.label6.Text = "Session";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 130;
            this.label7.Text = "Select Level";
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLevel.FormattingEnabled = true;
            this.ddLevel.Location = new System.Drawing.Point(3, 79);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddLevel.Size = new System.Drawing.Size(246, 25);
            this.ddLevel.TabIndex = 1;
            this.ddLevel.SelectedIndexChanged += new System.EventHandler(this.ddLevel_SelectedIndexChanged);
            // 
            // errLevel
            // 
            this.errLevel.AutoSize = true;
            this.errLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLevel.Location = new System.Drawing.Point(229, 56);
            this.errLevel.Name = "errLevel";
            this.errLevel.Size = new System.Drawing.Size(20, 28);
            this.errLevel.TabIndex = 131;
            this.errLevel.Text = "*";
            this.errLevel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 128;
            this.label8.Text = "Select Class";
            // 
            // ddClass
            // 
            this.ddClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddClass.FormattingEnabled = true;
            this.ddClass.Location = new System.Drawing.Point(3, 129);
            this.ddClass.Name = "ddClass";
            this.ddClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddClass.Size = new System.Drawing.Size(246, 25);
            this.ddClass.TabIndex = 2;
            this.ddClass.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // errClass
            // 
            this.errClass.AutoSize = true;
            this.errClass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errClass.Location = new System.Drawing.Point(229, 107);
            this.errClass.Name = "errClass";
            this.errClass.Size = new System.Drawing.Size(20, 28);
            this.errClass.TabIndex = 129;
            this.errClass.Text = "*";
            this.errClass.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 136;
            this.label5.Text = "Select Month / Year";
            // 
            // dtMonthYear
            // 
            this.dtMonthYear.CustomFormat = "MMMM- yyyy";
            this.dtMonthYear.Location = new System.Drawing.Point(4, 229);
            this.dtMonthYear.Name = "dtMonthYear";
            this.dtMonthYear.ShowUpDown = true;
            this.dtMonthYear.Size = new System.Drawing.Size(245, 25);
            this.dtMonthYear.TabIndex = 4;
            // 
            // pnlStudent
            // 
            this.pnlStudent.Controls.Add(this.dtSession);
            this.pnlStudent.Controls.Add(this.label5);
            this.pnlStudent.Controls.Add(this.btnLoad);
            this.pnlStudent.Controls.Add(this.dtMonthYear);
            this.pnlStudent.Controls.Add(this.label13);
            this.pnlStudent.Controls.Add(this.ddClass);
            this.pnlStudent.Controls.Add(this.ddSection);
            this.pnlStudent.Controls.Add(this.label8);
            this.pnlStudent.Controls.Add(this.errSection);
            this.pnlStudent.Controls.Add(this.ddLevel);
            this.pnlStudent.Controls.Add(this.label6);
            this.pnlStudent.Controls.Add(this.label7);
            this.pnlStudent.Controls.Add(this.errLevel);
            this.pnlStudent.Controls.Add(this.errClass);
            this.pnlStudent.Location = new System.Drawing.Point(4, 111);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(253, 417);
            this.pnlStudent.TabIndex = 137;
            // 
            // chkStudent
            // 
            this.chkStudent.AutoSize = true;
            this.chkStudent.Location = new System.Drawing.Point(7, 51);
            this.chkStudent.Name = "chkStudent";
            this.chkStudent.Size = new System.Drawing.Size(107, 23);
            this.chkStudent.TabIndex = 138;
            this.chkStudent.Text = "WRT Student";
            this.chkStudent.UseVisualStyleBackColor = true;
            this.chkStudent.CheckedChanged += new System.EventHandler(this.chkStudent_CheckedChanged);
            // 
            // chkFather
            // 
            this.chkFather.AutoSize = true;
            this.chkFather.Location = new System.Drawing.Point(7, 80);
            this.chkFather.Name = "chkFather";
            this.chkFather.Size = new System.Drawing.Size(98, 23);
            this.chkFather.TabIndex = 139;
            this.chkFather.Text = "WRT Father";
            this.chkFather.UseVisualStyleBackColor = true;
            this.chkFather.CheckedChanged += new System.EventHandler(this.chkFather_CheckedChanged);
            // 
            // pnlFather
            // 
            this.pnlFather.Controls.Add(this.txtFatherPhone);
            this.pnlFather.Controls.Add(this.label2);
            this.pnlFather.Controls.Add(this.btnLoad2);
            this.pnlFather.Location = new System.Drawing.Point(3, 111);
            this.pnlFather.Name = "pnlFather";
            this.pnlFather.Size = new System.Drawing.Size(254, 390);
            this.pnlFather.TabIndex = 137;
            // 
            // txtFatherPhone
            // 
            this.txtFatherPhone.Location = new System.Drawing.Point(3, 29);
            this.txtFatherPhone.Name = "txtFatherPhone";
            this.txtFatherPhone.Size = new System.Drawing.Size(247, 25);
            this.txtFatherPhone.TabIndex = 142;
            this.txtFatherPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtFatherPhone_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 141;
            this.label2.Text = "Father\'s Phone";
            // 
            // btnLoad2
            // 
            this.btnLoad2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLoad2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad2.Location = new System.Drawing.Point(5, 60);
            this.btnLoad2.Name = "btnLoad2";
            this.btnLoad2.Size = new System.Drawing.Size(245, 38);
            this.btnLoad2.TabIndex = 138;
            this.btnLoad2.Text = "LOAD VOUCHERS";
            this.btnLoad2.UseVisualStyleBackColor = false;
            this.btnLoad2.Click += new System.EventHandler(this.btnLoad2_Click);
            // 
            // FeeVoucherReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 749);
            this.Name = "FeeVoucherReportWindow";
            this.Text = "Fee Voucher Report ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FeeVoucherReportWindow_FormClosing);
            this.Load += new System.EventHandler(this.FeeVoucherReportWindow_Load);
            this.LeftPanel.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlStudent.ResumeLayout(false);
            this.pnlStudent.PerformLayout();
            this.pnlFather.ResumeLayout(false);
            this.pnlFather.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLoad;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ddSection;
        private System.Windows.Forms.Label errSection;
        private System.Windows.Forms.DateTimePicker dtSession;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddLevel;
        private System.Windows.Forms.Label errLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddClass;
        private System.Windows.Forms.Label errClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtMonthYear;
        private System.Windows.Forms.Panel pnlStudent;
        private System.Windows.Forms.CheckBox chkFather;
        private System.Windows.Forms.CheckBox chkStudent;
        private System.Windows.Forms.Panel pnlFather;
        private System.Windows.Forms.TextBox txtFatherPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoad2;
    }
}