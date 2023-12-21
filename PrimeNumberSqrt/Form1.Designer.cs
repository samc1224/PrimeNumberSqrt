namespace PrimeNumberSqrt
{
    partial class Form1
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
            this.CheckNumber = new System.Windows.Forms.Button();
            this.EnterNumber = new System.Windows.Forms.TextBox();
            this.AnalysisTimes = new System.Windows.Forms.TextBox();
            this.LogRTBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearField = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoCBox = new System.Windows.Forms.CheckBox();
            this.YesCBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckNumber
            // 
            this.CheckNumber.Location = new System.Drawing.Point(172, 97);
            this.CheckNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.Size = new System.Drawing.Size(80, 45);
            this.CheckNumber.TabIndex = 0;
            this.CheckNumber.Text = "Check Number";
            this.CheckNumber.UseVisualStyleBackColor = true;
            this.CheckNumber.Click += new System.EventHandler(this.CheckNumber_Click);
            // 
            // EnterNumber
            // 
            this.EnterNumber.Location = new System.Drawing.Point(16, 33);
            this.EnterNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EnterNumber.MaxLength = 9;
            this.EnterNumber.Name = "EnterNumber";
            this.EnterNumber.Size = new System.Drawing.Size(125, 25);
            this.EnterNumber.TabIndex = 1;
            // 
            // AnalysisTimes
            // 
            this.AnalysisTimes.Location = new System.Drawing.Point(16, 116);
            this.AnalysisTimes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AnalysisTimes.Name = "AnalysisTimes";
            this.AnalysisTimes.ReadOnly = true;
            this.AnalysisTimes.Size = new System.Drawing.Size(125, 25);
            this.AnalysisTimes.TabIndex = 2;
            // 
            // LogRTBox
            // 
            this.LogRTBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogRTBox.Location = new System.Drawing.Point(7, 155);
            this.LogRTBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogRTBox.Name = "LogRTBox";
            this.LogRTBox.ReadOnly = true;
            this.LogRTBox.Size = new System.Drawing.Size(357, 174);
            this.LogRTBox.TabIndex = 89;
            this.LogRTBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 90;
            this.label1.Text = "Enter Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 91;
            this.label2.Text = "Analysis Times:";
            // 
            // ClearField
            // 
            this.ClearField.Location = new System.Drawing.Point(273, 97);
            this.ClearField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearField.Name = "ClearField";
            this.ClearField.Size = new System.Drawing.Size(75, 45);
            this.ClearField.TabIndex = 92;
            this.ClearField.Text = "Clear Field";
            this.ClearField.UseVisualStyleBackColor = true;
            this.ClearField.Click += new System.EventHandler(this.ClearField_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoCBox);
            this.groupBox1.Controls.Add(this.YesCBox);
            this.groupBox1.Location = new System.Drawing.Point(172, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(176, 52);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Is prime number?";
            // 
            // NoCBox
            // 
            this.NoCBox.AutoSize = true;
            this.NoCBox.Location = new System.Drawing.Point(101, 22);
            this.NoCBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NoCBox.Name = "NoCBox";
            this.NoCBox.Size = new System.Drawing.Size(46, 19);
            this.NoCBox.TabIndex = 1;
            this.NoCBox.Text = "No";
            this.NoCBox.UseVisualStyleBackColor = true;
            // 
            // YesCBox
            // 
            this.YesCBox.AutoSize = true;
            this.YesCBox.Location = new System.Drawing.Point(21, 22);
            this.YesCBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.YesCBox.Name = "YesCBox";
            this.YesCBox.Size = new System.Drawing.Size(50, 19);
            this.YesCBox.TabIndex = 0;
            this.YesCBox.Text = "Yes";
            this.YesCBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 94;
            this.label3.Text = "(Max: 999999999)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 340);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClearField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogRTBox);
            this.Controls.Add(this.AnalysisTimes);
            this.Controls.Add(this.EnterNumber);
            this.Controls.Add(this.CheckNumber);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Prime Number Check";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckNumber;
        private System.Windows.Forms.TextBox EnterNumber;
        private System.Windows.Forms.TextBox AnalysisTimes;
        private System.Windows.Forms.RichTextBox LogRTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox NoCBox;
        private System.Windows.Forms.CheckBox YesCBox;
        private System.Windows.Forms.Label label3;
    }
}

