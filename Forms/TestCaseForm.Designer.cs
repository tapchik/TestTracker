
namespace TestTracker.Forms
{
    partial class TestCaseForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPassed = new System.Windows.Forms.Button();
            this.buttonBlocked = new System.Windows.Forms.Button();
            this.checkedListOfSteps = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxForExpectedResult = new System.Windows.Forms.GroupBox();
            this.labelExpectedResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxForExpectedResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkedListOfSteps, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxForExpectedResult, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(425, 572);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonPassed, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonBlocked, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(79, 501);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(266, 68);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonPassed
            // 
            this.buttonPassed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPassed.BackColor = System.Drawing.Color.LightGreen;
            this.buttonPassed.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonPassed.Location = new System.Drawing.Point(149, 19);
            this.buttonPassed.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonPassed.Name = "buttonPassed";
            this.buttonPassed.Size = new System.Drawing.Size(101, 29);
            this.buttonPassed.TabIndex = 1;
            this.buttonPassed.Text = "Passed";
            this.buttonPassed.UseVisualStyleBackColor = false;
            this.buttonPassed.Click += new System.EventHandler(this.buttonPassed_Click);
            // 
            // buttonBlocked
            // 
            this.buttonBlocked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBlocked.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonBlocked.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonBlocked.Location = new System.Drawing.Point(16, 19);
            this.buttonBlocked.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonBlocked.Name = "buttonBlocked";
            this.buttonBlocked.Size = new System.Drawing.Size(101, 29);
            this.buttonBlocked.TabIndex = 0;
            this.buttonBlocked.Text = "Blocked";
            this.buttonBlocked.UseVisualStyleBackColor = false;
            this.buttonBlocked.Click += new System.EventHandler(this.buttonBlocked_Click);
            // 
            // checkedListOfSteps
            // 
            this.checkedListOfSteps.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListOfSteps.CheckOnClick = true;
            this.checkedListOfSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListOfSteps.FormattingEnabled = true;
            this.checkedListOfSteps.Location = new System.Drawing.Point(5, 52);
            this.checkedListOfSteps.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.checkedListOfSteps.Name = "checkedListOfSteps";
            this.checkedListOfSteps.Size = new System.Drawing.Size(415, 394);
            this.checkedListOfSteps.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 43);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Testcase";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Location = new System.Drawing.Point(3, 19);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(46, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "label1";
            // 
            // groupBoxForExpectedResult
            // 
            this.groupBoxForExpectedResult.Controls.Add(this.labelExpectedResult);
            this.groupBoxForExpectedResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxForExpectedResult.Location = new System.Drawing.Point(3, 452);
            this.groupBoxForExpectedResult.Name = "groupBoxForExpectedResult";
            this.groupBoxForExpectedResult.Size = new System.Drawing.Size(419, 43);
            this.groupBoxForExpectedResult.TabIndex = 5;
            this.groupBoxForExpectedResult.TabStop = false;
            this.groupBoxForExpectedResult.Text = "Expected result";
            // 
            // labelExpectedResult
            // 
            this.labelExpectedResult.AutoSize = true;
            this.labelExpectedResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelExpectedResult.Location = new System.Drawing.Point(3, 19);
            this.labelExpectedResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelExpectedResult.Name = "labelExpectedResult";
            this.labelExpectedResult.Size = new System.Drawing.Size(46, 17);
            this.labelExpectedResult.TabIndex = 0;
            this.labelExpectedResult.Text = "label1";
            // 
            // TestCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 572);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximumSize = new System.Drawing.Size(700, 650);
            this.MinimumSize = new System.Drawing.Size(314, 422);
            this.Name = "TestCaseForm";
            this.Text = "Passing testcase";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxForExpectedResult.ResumeLayout(false);
            this.groupBoxForExpectedResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelExpectedResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonBlocked;
        private System.Windows.Forms.Button buttonPassed;
        private System.Windows.Forms.CheckedListBox checkedListOfSteps;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxForExpectedResult;
    }
}