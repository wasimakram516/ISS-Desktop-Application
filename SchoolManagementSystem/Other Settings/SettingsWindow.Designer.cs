namespace ISS
{
    partial class SettingsWindow
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.errPassword = new System.Windows.Forms.Label();
            this.errUsername = new System.Windows.Forms.Label();
            this.errDatabase = new System.Windows.Forms.Label();
            this.errDataSource = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(260, 749);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.checkBox1);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.txtPassword);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.txtUsername);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.txtDatabase);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.btnSave);
            this.pnlDetails.Controls.Add(this.txtDataSource);
            this.pnlDetails.Controls.Add(this.errPassword);
            this.pnlDetails.Controls.Add(this.errUsername);
            this.pnlDetails.Controls.Add(this.errDatabase);
            this.pnlDetails.Controls.Add(this.errDataSource);
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
            this.panel6.Size = new System.Drawing.Size(844, 699);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Text = " , ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 457);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 23);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Integrated Security";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(9, 423);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(242, 25);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(9, 372);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(242, 25);
            this.txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Database Name";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(9, 320);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(242, 25);
            this.txtDatabase.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Server Name";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(9, 485);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(242, 51);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(9, 269);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(242, 25);
            this.txtDataSource.TabIndex = 0;
            // 
            // errPassword
            // 
            this.errPassword.AutoSize = true;
            this.errPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPassword.Location = new System.Drawing.Point(231, 403);
            this.errPassword.Name = "errPassword";
            this.errPassword.Size = new System.Drawing.Size(20, 28);
            this.errPassword.TabIndex = 37;
            this.errPassword.Text = "*";
            this.errPassword.Visible = false;
            // 
            // errUsername
            // 
            this.errUsername.AutoSize = true;
            this.errUsername.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errUsername.Location = new System.Drawing.Point(231, 352);
            this.errUsername.Name = "errUsername";
            this.errUsername.Size = new System.Drawing.Size(20, 28);
            this.errUsername.TabIndex = 36;
            this.errUsername.Text = "*";
            this.errUsername.Visible = false;
            // 
            // errDatabase
            // 
            this.errDatabase.AutoSize = true;
            this.errDatabase.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDatabase.Location = new System.Drawing.Point(231, 300);
            this.errDatabase.Name = "errDatabase";
            this.errDatabase.Size = new System.Drawing.Size(20, 28);
            this.errDatabase.TabIndex = 35;
            this.errDatabase.Text = "*";
            this.errDatabase.Visible = false;
            // 
            // errDataSource
            // 
            this.errDataSource.AutoSize = true;
            this.errDataSource.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDataSource.Location = new System.Drawing.Point(231, 249);
            this.errDataSource.Name = "errDataSource";
            this.errDataSource.Size = new System.Drawing.Size(20, 28);
            this.errDataSource.TabIndex = 34;
            this.errDataSource.Text = "*";
            this.errDataSource.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::ISS.Properties.Resources.back_wite;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 50);
            this.btnBack.TabIndex = 16;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 749);
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.LeftPanel.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.Label errPassword;
        private System.Windows.Forms.Label errUsername;
        private System.Windows.Forms.Label errDatabase;
        private System.Windows.Forms.Label errDataSource;
        private System.Windows.Forms.Button btnBack;
    }
}