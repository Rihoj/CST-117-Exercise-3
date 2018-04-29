namespace CST_117_Exercise_3
{
    partial class marsConversionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(marsConversionForm));
            this.earthWeightLabel = new System.Windows.Forms.Label();
            this.marsWeightLabel = new System.Windows.Forms.Label();
            this.earthWeightTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // earthWeightLabel
            // 
            this.earthWeightLabel.AutoSize = true;
            this.earthWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earthWeightLabel.Location = new System.Drawing.Point(12, 45);
            this.earthWeightLabel.Name = "earthWeightLabel";
            this.earthWeightLabel.Size = new System.Drawing.Size(272, 25);
            this.earthWeightLabel.TabIndex = 0;
            this.earthWeightLabel.Text = "Enter your weight on Earth:";
            // 
            // marsWeightLabel
            // 
            this.marsWeightLabel.AutoSize = true;
            this.marsWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marsWeightLabel.Location = new System.Drawing.Point(12, 119);
            this.marsWeightLabel.Name = "marsWeightLabel";
            this.marsWeightLabel.Size = new System.Drawing.Size(191, 25);
            this.marsWeightLabel.TabIndex = 1;
            this.marsWeightLabel.Text = "Your mars weight: ";
            // 
            // earthWeightTextBox
            // 
            this.earthWeightTextBox.Location = new System.Drawing.Point(291, 49);
            this.earthWeightTextBox.Name = "earthWeightTextBox";
            this.earthWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.earthWeightTextBox.TabIndex = 2;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(157, 205);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(118, 51);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // marsConversionForm
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 311);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.earthWeightTextBox);
            this.Controls.Add(this.marsWeightLabel);
            this.Controls.Add(this.earthWeightLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(460, 350);
            this.Name = "marsConversionForm";
            this.Text = "Mars Weight Conversion";
            this.Load += new System.EventHandler(this.marsConversionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label earthWeightLabel;
        private System.Windows.Forms.Label marsWeightLabel;
        private System.Windows.Forms.TextBox earthWeightTextBox;
        private System.Windows.Forms.Button convertButton;
    }
}

