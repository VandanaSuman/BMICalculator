namespace BMICalculator
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            this.BMIStartFormLabel = new System.Windows.Forms.Label();
            this.StartFormTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BMIStartFormLabel
            // 
            this.BMIStartFormLabel.AutoSize = true;
            this.BMIStartFormLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BMIStartFormLabel.Location = new System.Drawing.Point(52, 186);
            this.BMIStartFormLabel.Name = "BMIStartFormLabel";
            this.BMIStartFormLabel.Size = new System.Drawing.Size(192, 31);
            this.BMIStartFormLabel.TabIndex = 0;
            this.BMIStartFormLabel.Text = "BMI Calculator";
            // 
            // StartFormTimer
            // 
            this.StartFormTimer.Interval = 3000;
            this.StartFormTimer.Tick += new System.EventHandler(this.StartFormTimer_Tick);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMIStartFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BMIStartFormLabel;
        private System.Windows.Forms.Timer StartFormTimer;
    }
}