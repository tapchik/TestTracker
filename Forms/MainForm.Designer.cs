namespace TestTracker
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Авторизация под пользователем");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Авторизация под админом");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Авторизация", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Один");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Второй");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Третий");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Каталог", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBulkEdit = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.groupBoxAllTestSuites = new System.Windows.Forms.GroupBox();
            this.treeViewOfTestSuites = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTitleOfTC = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxIdeaOfTC = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxExpectedResultOfTC = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRunId = new System.Windows.Forms.TextBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxAllTestSuites.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxAllTestSuites, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 433);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btnBulkEdit, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnReports, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(64, 376);
            this.tableLayoutPanel3.MinimumSize = new System.Drawing.Size(200, 54);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(205, 54);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // btnBulkEdit
            // 
            this.btnBulkEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBulkEdit.Location = new System.Drawing.Point(13, 12);
            this.btnBulkEdit.Name = "btnBulkEdit";
            this.btnBulkEdit.Size = new System.Drawing.Size(75, 29);
            this.btnBulkEdit.TabIndex = 1;
            this.btnBulkEdit.Text = "Bulk edit";
            this.btnBulkEdit.UseVisualStyleBackColor = true;
            this.btnBulkEdit.Click += new System.EventHandler(this.btnBulkEdit_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.Location = new System.Drawing.Point(111, 12);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(85, 29);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports...";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // groupBoxAllTestSuites
            // 
            this.groupBoxAllTestSuites.Controls.Add(this.treeViewOfTestSuites);
            this.groupBoxAllTestSuites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAllTestSuites.Location = new System.Drawing.Point(8, 7);
            this.groupBoxAllTestSuites.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxAllTestSuites.Name = "groupBoxAllTestSuites";
            this.groupBoxAllTestSuites.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel1.SetRowSpan(this.groupBoxAllTestSuites, 4);
            this.groupBoxAllTestSuites.Size = new System.Drawing.Size(318, 359);
            this.groupBoxAllTestSuites.TabIndex = 1;
            this.groupBoxAllTestSuites.TabStop = false;
            this.groupBoxAllTestSuites.Text = "Test cases";
            // 
            // treeViewOfTestSuites
            // 
            this.treeViewOfTestSuites.BackColor = System.Drawing.SystemColors.Control;
            this.treeViewOfTestSuites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewOfTestSuites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewOfTestSuites.Location = new System.Drawing.Point(8, 23);
            this.treeViewOfTestSuites.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewOfTestSuites.Name = "treeViewOfTestSuites";
            treeNode8.Name = "Node2";
            treeNode8.Text = "Авторизация под пользователем";
            treeNode9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            treeNode9.Name = "Node3";
            treeNode9.Text = "Авторизация под админом";
            treeNode10.Name = "Node0";
            treeNode10.Text = "Авторизация";
            treeNode11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            treeNode11.Name = "Node0";
            treeNode11.Text = "Один";
            treeNode12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            treeNode12.Name = "Node1";
            treeNode12.Text = "Второй";
            treeNode13.Name = "Node2";
            treeNode13.Text = "Третий";
            treeNode14.Name = "Node1";
            treeNode14.Text = "Каталог";
            this.treeViewOfTestSuites.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode14});
            this.treeViewOfTestSuites.Size = new System.Drawing.Size(302, 329);
            this.treeViewOfTestSuites.TabIndex = 0;
            this.treeViewOfTestSuites.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewOfTestSuites_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTitleOfTC);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(337, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Title";
            // 
            // textBoxTitleOfTC
            // 
            this.textBoxTitleOfTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTitleOfTC.Location = new System.Drawing.Point(3, 19);
            this.textBoxTitleOfTC.Name = "textBoxTitleOfTC";
            this.textBoxTitleOfTC.ReadOnly = true;
            this.textBoxTitleOfTC.Size = new System.Drawing.Size(491, 23);
            this.textBoxTitleOfTC.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxIdeaOfTC);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(337, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 114);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Idea";
            // 
            // textBoxIdeaOfTC
            // 
            this.textBoxIdeaOfTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIdeaOfTC.Location = new System.Drawing.Point(3, 19);
            this.textBoxIdeaOfTC.Multiline = true;
            this.textBoxIdeaOfTC.Name = "textBoxIdeaOfTC";
            this.textBoxIdeaOfTC.ReadOnly = true;
            this.textBoxIdeaOfTC.Size = new System.Drawing.Size(491, 92);
            this.textBoxIdeaOfTC.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxExpectedResultOfTC);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(337, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 114);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Expected result";
            // 
            // textBoxExpectedResultOfTC
            // 
            this.textBoxExpectedResultOfTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExpectedResultOfTC.Location = new System.Drawing.Point(3, 19);
            this.textBoxExpectedResultOfTC.Multiline = true;
            this.textBoxExpectedResultOfTC.Name = "textBoxExpectedResultOfTC";
            this.textBoxExpectedResultOfTC.ReadOnly = true;
            this.textBoxExpectedResultOfTC.Size = new System.Drawing.Size(491, 92);
            this.textBoxExpectedResultOfTC.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxRunId, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonLogOut, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonRun, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxLogin, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(414, 376);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(343, 54);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // textBoxRunId
            // 
            this.textBoxRunId.Location = new System.Drawing.Point(53, 30);
            this.textBoxRunId.Name = "textBoxRunId";
            this.textBoxRunId.ReadOnly = true;
            this.textBoxRunId.Size = new System.Drawing.Size(80, 23);
            this.textBoxRunId.TabIndex = 3;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogOut.Location = new System.Drawing.Point(158, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.tableLayoutPanel2.SetRowSpan(this.buttonLogOut, 2);
            this.buttonLogOut.Size = new System.Drawing.Size(75, 29);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRun.Location = new System.Drawing.Point(256, 12);
            this.buttonRun.Name = "buttonRun";
            this.tableLayoutPanel2.SetRowSpan(this.buttonRun, 2);
            this.buttonRun.Size = new System.Drawing.Size(75, 29);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(53, 3);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.ReadOnly = true;
            this.textBoxLogin.Size = new System.Drawing.Size(80, 23);
            this.textBoxLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "run id";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Test Tracker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBoxAllTestSuites.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxAllTestSuites;
        private System.Windows.Forms.TreeView treeViewOfTestSuites;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxIdeaOfTC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textBoxTitleOfTC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxExpectedResultOfTC;
        private System.Windows.Forms.TextBox textBoxRunId;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnBulkEdit;
        private System.Windows.Forms.Button btnReports;
    }
}

