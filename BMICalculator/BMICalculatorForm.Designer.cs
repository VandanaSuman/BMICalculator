namespace BMICalculator
{
    partial class BMICalculatorForm
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
            this.BMICalculatorTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.UnitsGroupBox = new System.Windows.Forms.GroupBox();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.BMICalculatorLabel = new System.Windows.Forms.Label();
            this.UnitsLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.BMICalculatorTableLayoutPanel1.SuspendLayout();
            this.UnitsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalculatorTableLayoutPanel1
            // 
            this.BMICalculatorTableLayoutPanel1.ColumnCount = 2;
            this.BMICalculatorTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMICalculatorTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMICalculatorTableLayoutPanel1.Controls.Add(this.ResetButton, 1, 5);
            this.BMICalculatorTableLayoutPanel1.Controls.Add(this.WeightTextBox, 1, 4);
            this.BMICalculatorTableLayoutPanel1.Controls.Add(this.UnitsGroupBox, 1, 1);
            this.BMICalculatorTableLayoutPanel1.Controls.Add(this.BMICalculatorLabel, 0, 0);
            this.BMICalculatorTableLayoutPanel1.Controls.Add(this.UnitsLabel, 0, 1);
            this.BMICalculatorTableLayoutPanel1.Controls.Add(this.ResultLabel, 0, 6);
            this.BMICalculatorTableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 4);
            this.BMICalculatorTableLayoutPanel1.Controls.Add(this.HeightLabel, 0, 3);
            this.BMICalculatorTableLayoutPanel1.Controls.Add(this.HeightTextBox, 1, 3);
            this.BMICalculatorTableLayoutPanel1.Controls.Add(this.BMITextBox, 1, 6);
            this.BMICalculatorTableLayoutPanel1.Controls.Add(this.CalculateBMIButton, 0, 5);
            this.BMICalculatorTableLayoutPanel1.Location = new System.Drawing.Point(29, 26);
            this.BMICalculatorTableLayoutPanel1.Name = "BMICalculatorTableLayoutPanel1";
            this.BMICalculatorTableLayoutPanel1.RowCount = 7;
            this.BMICalculatorTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.BMICalculatorTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.BMICalculatorTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.BMICalculatorTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.BMICalculatorTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.BMICalculatorTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.BMICalculatorTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.BMICalculatorTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BMICalculatorTableLayoutPanel1.Size = new System.Drawing.Size(247, 390);
            this.BMICalculatorTableLayoutPanel1.TabIndex = 0;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ResetButton.Location = new System.Drawing.Point(126, 278);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(118, 49);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(126, 223);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(118, 38);
            this.WeightTextBox.TabIndex = 9;
            // 
            // UnitsGroupBox
            // 
            this.UnitsGroupBox.Controls.Add(this.MetricRadioButton);
            this.UnitsGroupBox.Controls.Add(this.ImperialRadioButton);
            this.UnitsGroupBox.Location = new System.Drawing.Point(126, 58);
            this.UnitsGroupBox.Name = "UnitsGroupBox";
            this.BMICalculatorTableLayoutPanel1.SetRowSpan(this.UnitsGroupBox, 2);
            this.UnitsGroupBox.Size = new System.Drawing.Size(118, 94);
            this.UnitsGroupBox.TabIndex = 1;
            this.UnitsGroupBox.TabStop = false;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(0, 53);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricRadioButton.TabIndex = 7;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ImperialRadioButton.Location = new System.Drawing.Point(0, 19);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(118, 33);
            this.ImperialRadioButton.TabIndex = 6;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // BMICalculatorLabel
            // 
            this.BMICalculatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculatorLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BMICalculatorTableLayoutPanel1.SetColumnSpan(this.BMICalculatorLabel, 2);
            this.BMICalculatorLabel.Location = new System.Drawing.Point(3, 0);
            this.BMICalculatorLabel.Name = "BMICalculatorLabel";
            this.BMICalculatorLabel.Size = new System.Drawing.Size(241, 55);
            this.BMICalculatorLabel.TabIndex = 0;
            this.BMICalculatorLabel.Text = "BMI Calculator";
            this.BMICalculatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitsLabel
            // 
            this.UnitsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitsLabel.Location = new System.Drawing.Point(3, 55);
            this.UnitsLabel.Name = "UnitsLabel";
            this.BMICalculatorTableLayoutPanel1.SetRowSpan(this.UnitsLabel, 2);
            this.UnitsLabel.Size = new System.Drawing.Size(117, 110);
            this.UnitsLabel.TabIndex = 1;
            this.UnitsLabel.Text = "Units";
            this.UnitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ResultLabel.Location = new System.Drawing.Point(3, 330);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(117, 60);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "My BMI";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.WeightLabel.Location = new System.Drawing.Point(3, 220);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(117, 55);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "My Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.HeightLabel.Location = new System.Drawing.Point(3, 165);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(117, 55);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(126, 168);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(118, 38);
            this.HeightTextBox.TabIndex = 8;
            // 
            // BMITextBox
            // 
            this.BMITextBox.BackColor = System.Drawing.Color.LightGray;
            this.BMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BMITextBox.ForeColor = System.Drawing.Color.Black;
            this.BMITextBox.Location = new System.Drawing.Point(126, 333);
            this.BMITextBox.Multiline = true;
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.ReadOnly = true;
            this.BMITextBox.Size = new System.Drawing.Size(118, 54);
            this.BMITextBox.TabIndex = 10;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateBMIButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 278);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(117, 49);
            this.CalculateBMIButton.TabIndex = 5;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.BMICalculatorTableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.BMICalculatorTableLayoutPanel1.ResumeLayout(false);
            this.BMICalculatorTableLayoutPanel1.PerformLayout();
            this.UnitsGroupBox.ResumeLayout(false);
            this.UnitsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMICalculatorTableLayoutPanel1;
        private System.Windows.Forms.Label BMICalculatorLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label UnitsLabel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox UnitsGroupBox;
    }
}

