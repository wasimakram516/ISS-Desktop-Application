namespace ISS
{
    partial class StaffLetters
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.errCNIC = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.chkExperience = new System.Windows.Forms.CheckBox();
            this.chkAppointment = new System.Windows.Forms.CheckBox();
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
            this.pnlDetails.Controls.Add(this.chkAppointment);
            this.pnlDetails.Controls.Add(this.chkExperience);
            this.pnlDetails.Controls.Add(this.btnLoad);
            this.pnlDetails.Controls.Add(this.txtCNIC);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.errCNIC);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter CNIC";
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(4, 91);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(250, 25);
            this.txtCNIC.TabIndex = 0;
            this.txtCNIC.TextChanged += new System.EventHandler(this.txtCNIC_TextChanged);
            this.txtCNIC.Validating += new System.ComponentModel.CancelEventHandler(this.txtCNIC_Validating);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(4, 181);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(250, 38);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "LOAD";
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
            this.crystalReportViewer1.TabIndex = 4;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // errCNIC
            // 
            this.errCNIC.AutoSize = true;
            this.errCNIC.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errCNIC.Location = new System.Drawing.Point(234, 69);
            this.errCNIC.Name = "errCNIC";
            this.errCNIC.Size = new System.Drawing.Size(20, 28);
            this.errCNIC.TabIndex = 3;
            this.errCNIC.Text = "*";
            this.errCNIC.Visible = false;
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
            this.btnBack.TabIndex = 17;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chkExperience
            // 
            this.chkExperience.AutoSize = true;
            this.chkExperience.Location = new System.Drawing.Point(13, 123);
            this.chkExperience.Name = "chkExperience";
            this.chkExperience.Size = new System.Drawing.Size(132, 23);
            this.chkExperience.TabIndex = 1;
            this.chkExperience.Text = "Experience Letter";
            this.chkExperience.UseVisualStyleBackColor = true;
            this.chkExperience.CheckedChanged += new System.EventHandler(this.chkExperience_CheckedChanged);
            // 
            // chkAppointment
            // 
            this.chkAppointment.AutoSize = true;
            this.chkAppointment.Location = new System.Drawing.Point(13, 152);
            this.chkAppointment.Name = "chkAppointment";
            this.chkAppointment.Size = new System.Drawing.Size(149, 23);
            this.chkAppointment.TabIndex = 2;
            this.chkAppointment.Text = "Appointment Letter";
            this.chkAppointment.UseVisualStyleBackColor = true;
            this.chkAppointment.CheckedChanged += new System.EventHandler(this.chkAppointment_CheckedChanged);
            // 
            // StaffLetters
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 749);
            this.Name = "StaffLetters";
            this.Text = "Staff Letters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExperienceLetters_FormClosing);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtCNIC;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label errCNIC;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chkAppointment;
        private System.Windows.Forms.CheckBox chkExperience;
    }
}