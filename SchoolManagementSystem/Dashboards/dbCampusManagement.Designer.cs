namespace SchoolManagementSystem
{
    partial class dbCampusManagement
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCampuses = new System.Windows.Forms.Button();
            this.btnShifts = new System.Windows.Forms.Button();
            this.btnLevels = new System.Windows.Forms.Button();
            this.btnClasses = new System.Windows.Forms.Button();
            this.btnSections = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnPeriods = new System.Windows.Forms.Button();
            this.btnClassTimings = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(260, 834);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Size = new System.Drawing.Size(260, 784);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.SetChildIndex(this.label4, 0);
            this.panel3.Controls.SetChildIndex(this.btnBack, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(844, 834);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel1);
            this.panel6.Size = new System.Drawing.Size(844, 784);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnCampuses, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnShifts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLevels, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClasses, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSections, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSubject, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPeriods, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClassTimings, 3, 1);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 784);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCampuses
            // 
            this.btnCampuses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCampuses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCampuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCampuses.Image = global::SchoolManagementSystem.Properties.Resources.icons8_school_building_96;
            this.btnCampuses.Location = new System.Drawing.Point(3, 3);
            this.btnCampuses.Name = "btnCampuses";
            this.btnCampuses.Size = new System.Drawing.Size(205, 190);
            this.btnCampuses.TabIndex = 0;
            this.btnCampuses.Text = "CAMPUSES";
            this.btnCampuses.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCampuses.UseVisualStyleBackColor = true;
            this.btnCampuses.Click += new System.EventHandler(this.btnCampuses_Click);
            // 
            // btnShifts
            // 
            this.btnShifts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShifts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShifts.Image = global::SchoolManagementSystem.Properties.Resources.icons8_tenses_96;
            this.btnShifts.Location = new System.Drawing.Point(214, 3);
            this.btnShifts.Name = "btnShifts";
            this.btnShifts.Size = new System.Drawing.Size(205, 190);
            this.btnShifts.TabIndex = 1;
            this.btnShifts.Text = "SHIFTS";
            this.btnShifts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnShifts.UseVisualStyleBackColor = true;
            this.btnShifts.Click += new System.EventHandler(this.btnShifts_Click);
            // 
            // btnLevels
            // 
            this.btnLevels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLevels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevels.Image = global::SchoolManagementSystem.Properties.Resources.icons8_stairs_96;
            this.btnLevels.Location = new System.Drawing.Point(425, 3);
            this.btnLevels.Name = "btnLevels";
            this.btnLevels.Size = new System.Drawing.Size(205, 190);
            this.btnLevels.TabIndex = 2;
            this.btnLevels.Text = "LEVELS";
            this.btnLevels.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLevels.UseVisualStyleBackColor = true;
            this.btnLevels.Click += new System.EventHandler(this.btnLevels_Click);
            // 
            // btnClasses
            // 
            this.btnClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasses.Image = global::SchoolManagementSystem.Properties.Resources.icons8_classroom_96;
            this.btnClasses.Location = new System.Drawing.Point(636, 3);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Size = new System.Drawing.Size(205, 190);
            this.btnClasses.TabIndex = 3;
            this.btnClasses.Text = "CLASSES";
            this.btnClasses.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClasses.UseVisualStyleBackColor = true;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btnSections
            // 
            this.btnSections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSections.Image = global::SchoolManagementSystem.Properties.Resources.icons8_abc_96;
            this.btnSections.Location = new System.Drawing.Point(3, 199);
            this.btnSections.Name = "btnSections";
            this.btnSections.Size = new System.Drawing.Size(205, 190);
            this.btnSections.TabIndex = 5;
            this.btnSections.Text = "SECTIONS";
            this.btnSections.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSections.UseVisualStyleBackColor = true;
            this.btnSections.Click += new System.EventHandler(this.btnSections_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubject.Image = global::SchoolManagementSystem.Properties.Resources.icons8_school_961;
            this.btnSubject.Location = new System.Drawing.Point(214, 199);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(205, 190);
            this.btnSubject.TabIndex = 8;
            this.btnSubject.Text = "SUBJECTS";
            this.btnSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnPeriods
            // 
            this.btnPeriods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeriods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPeriods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriods.Image = global::SchoolManagementSystem.Properties.Resources.icons8_school_961;
            this.btnPeriods.Location = new System.Drawing.Point(425, 199);
            this.btnPeriods.Name = "btnPeriods";
            this.btnPeriods.Size = new System.Drawing.Size(205, 190);
            this.btnPeriods.TabIndex = 6;
            this.btnPeriods.Text = "PERIODS";
            this.btnPeriods.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPeriods.UseVisualStyleBackColor = true;
            this.btnPeriods.Click += new System.EventHandler(this.btnPeriods_Click);
            // 
            // btnClassTimings
            // 
            this.btnClassTimings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassTimings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClassTimings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassTimings.Image = global::SchoolManagementSystem.Properties.Resources.icons8_curriculum_96;
            this.btnClassTimings.Location = new System.Drawing.Point(636, 199);
            this.btnClassTimings.Name = "btnClassTimings";
            this.btnClassTimings.Size = new System.Drawing.Size(205, 190);
            this.btnClassTimings.TabIndex = 7;
            this.btnClassTimings.Text = "CLASS TIMINGS";
            this.btnClassTimings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClassTimings.UseVisualStyleBackColor = true;
            this.btnClassTimings.Click += new System.EventHandler(this.btnClassTimings_Click);
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
            this.btnBack.TabIndex = 13;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 784);
            this.label1.TabIndex = 1;
            this.label1.Text = "Campus Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbCampusManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 834);
            this.Name = "dbCampusManagement";
            this.Text = "Campus Settings Dashboard";
            this.LeftPanel.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCampuses;
        private System.Windows.Forms.Button btnLevels;
        private System.Windows.Forms.Button btnClasses;
        private System.Windows.Forms.Button btnSections;
        private System.Windows.Forms.Button btnPeriods;
        private System.Windows.Forms.Button btnClassTimings;
        private System.Windows.Forms.Button btnShifts;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Label label1;
    }
}