namespace ISS
{
    partial class Login
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.errUsername = new System.Windows.Forms.Label();
            this.errPassword = new System.Windows.Forms.Label();
            this.ddCampus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errCampus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LeftPanel.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(260, 651);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.ddCampus);
            this.pnlDetails.Controls.Add(this.label11);
            this.pnlDetails.Controls.Add(this.errCampus);
            this.pnlDetails.Controls.Add(this.btnLogin);
            this.pnlDetails.Controls.Add(this.txtPassword);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.txtUsername);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.errPassword);
            this.pnlDetails.Controls.Add(this.errUsername);
            this.pnlDetails.Location = new System.Drawing.Point(0, 37);
            this.pnlDetails.Size = new System.Drawing.Size(260, 614);
            // 
            // panel3
            // 
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Size = new System.Drawing.Size(260, 37);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(768, 651);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Size = new System.Drawing.Size(768, 601);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(768, 50);
            // 
            // label4
            // 
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Size = new System.Drawing.Size(99, 37);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 267);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(242, 25);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 315);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(242, 25);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(12, 346);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(242, 43);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // errUsername
            // 
            this.errUsername.AutoSize = true;
            this.errUsername.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errUsername.Location = new System.Drawing.Point(234, 245);
            this.errUsername.Name = "errUsername";
            this.errUsername.Size = new System.Drawing.Size(20, 28);
            this.errUsername.TabIndex = 13;
            this.errUsername.Text = "*";
            this.errUsername.Visible = false;
            // 
            // errPassword
            // 
            this.errPassword.AutoSize = true;
            this.errPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPassword.Location = new System.Drawing.Point(234, 295);
            this.errPassword.Name = "errPassword";
            this.errPassword.Size = new System.Drawing.Size(20, 28);
            this.errPassword.TabIndex = 14;
            this.errPassword.Text = "*";
            this.errPassword.Visible = false;
            // 
            // ddCampus
            // 
            this.ddCampus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddCampus.FormattingEnabled = true;
            this.ddCampus.Location = new System.Drawing.Point(12, 217);
            this.ddCampus.Name = "ddCampus";
            this.ddCampus.Size = new System.Drawing.Size(242, 25);
            this.ddCampus.TabIndex = 39;
            this.ddCampus.SelectedIndexChanged += new System.EventHandler(this.ddCampus_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 19);
            this.label11.TabIndex = 40;
            this.label11.Text = "Campus Name";
            // 
            // errCampus
            // 
            this.errCampus.AutoSize = true;
            this.errCampus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errCampus.Location = new System.Drawing.Point(234, 195);
            this.errCampus.Name = "errCampus";
            this.errCampus.Size = new System.Drawing.Size(20, 28);
            this.errCampus.TabIndex = 41;
            this.errCampus.Text = "*";
            this.errCampus.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(768, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "Developed By: WASIM AKRAM (MCS)\r\n For Contact: 0302-7018278 | Mr.saim516@gmail.co" +
    "m";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ISS.Properties.Resources.ULM;
            this.pictureBox1.Location = new System.Drawing.Point(186, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 651);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.LeftPanel.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label errPassword;
        private System.Windows.Forms.Label errUsername;
        private System.Windows.Forms.ComboBox ddCampus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label errCampus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}