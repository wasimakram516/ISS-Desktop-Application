namespace ISS
{
    partial class dbExaminations
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
            this.btnExamDetails = new System.Windows.Forms.Button();
            this.btnExamType = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
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
            this.lblTopUser.Text = " , ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnExamDetails, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExamType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnResults, 2, 0);
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
            // btnExamDetails
            // 
            this.btnExamDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExamDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExamDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamDetails.Image = global::ISS.Properties.Resources.icons8_edit_property_96;
            this.btnExamDetails.Location = new System.Drawing.Point(214, 3);
            this.btnExamDetails.Name = "btnExamDetails";
            this.btnExamDetails.Size = new System.Drawing.Size(205, 190);
            this.btnExamDetails.TabIndex = 4;
            this.btnExamDetails.Text = "EXAM DETAILS";
            this.btnExamDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExamDetails.UseVisualStyleBackColor = true;
            this.btnExamDetails.Click += new System.EventHandler(this.btnExamDetails_Click);
            // 
            // btnExamType
            // 
            this.btnExamType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExamType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExamType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamType.Image = global::ISS.Properties.Resources.icons8_e_learning_961;
            this.btnExamType.Location = new System.Drawing.Point(3, 3);
            this.btnExamType.Name = "btnExamType";
            this.btnExamType.Size = new System.Drawing.Size(205, 190);
            this.btnExamType.TabIndex = 5;
            this.btnExamType.Text = "EXAM TYPES";
            this.btnExamType.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExamType.UseVisualStyleBackColor = true;
            this.btnExamType.Click += new System.EventHandler(this.btnExamType_Click);
            // 
            // btnResults
            // 
            this.btnResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Image = global::ISS.Properties.Resources.icons8_todo_list_96;
            this.btnResults.Location = new System.Drawing.Point(425, 3);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(205, 190);
            this.btnResults.TabIndex = 6;
            this.btnResults.Text = "RESULTS";
            this.btnResults.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
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
            this.btnBack.TabIndex = 16;
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
            this.label1.TabIndex = 2;
            this.label1.Text = "Exams Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbExaminations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 834);
            this.Name = "dbExaminations";
            this.Text = "Examinations Dashboard";
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

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExamDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExamType;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Label label1;
    }
}