namespace ISS
{
    partial class Sample
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTopUser = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LeftPanel.Controls.Add(this.pnlDetails);
            this.LeftPanel.Controls.Add(this.panel3);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.ForeColor = System.Drawing.Color.White;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(260, 811);
            this.LeftPanel.TabIndex = 0;
            // 
            // pnlDetails
            // 
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetails.Location = new System.Drawing.Point(0, 50);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(260, 761);
            this.pnlDetails.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 50);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 50);
            this.label4.TabIndex = 11;
            this.label4.Text = "Welcome,";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.White;
            this.RightPanel.Controls.Add(this.panel6);
            this.RightPanel.Controls.Add(this.panel4);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(260, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(844, 811);
            this.RightPanel.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 50);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(844, 761);
            this.panel6.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblTopUser);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(844, 50);
            this.panel4.TabIndex = 0;
            // 
            // lblTopUser
            // 
            this.lblTopUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTopUser.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopUser.Location = new System.Drawing.Point(0, 0);
            this.lblTopUser.Name = "lblTopUser";
            this.lblTopUser.Size = new System.Drawing.Size(461, 50);
            this.lblTopUser.TabIndex = 12;
            this.lblTopUser.Text = "User";
            this.lblTopUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 811);
            this.ControlBox = false;
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sample_Load);
            this.LeftPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel LeftPanel;
        public System.Windows.Forms.Panel pnlDetails;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel RightPanel;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblTopUser;
    }
}

