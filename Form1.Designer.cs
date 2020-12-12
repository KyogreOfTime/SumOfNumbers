
namespace SumOfNumbers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DescriptLabel1 = new System.Windows.Forms.Label();
            this.DescriptLabel2 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SumButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DescriptLabel1
            // 
            this.DescriptLabel1.AutoSize = true;
            this.DescriptLabel1.Location = new System.Drawing.Point(129, 40);
            this.DescriptLabel1.Name = "DescriptLabel1";
            this.DescriptLabel1.Size = new System.Drawing.Size(282, 20);
            this.DescriptLabel1.TabIndex = 0;
            this.DescriptLabel1.Text = "Enter Numbers (separated with commas):";
            // 
            // DescriptLabel2
            // 
            this.DescriptLabel2.AutoSize = true;
            this.DescriptLabel2.Location = new System.Drawing.Point(12, 203);
            this.DescriptLabel2.Name = "DescriptLabel2";
            this.DescriptLabel2.Size = new System.Drawing.Size(287, 20);
            this.DescriptLabel2.TabIndex = 1;
            this.DescriptLabel2.Text = "Sum of Entered (non-repeating) Numbers:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultLabel.Location = new System.Drawing.Point(332, 203);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(188, 25);
            this.ResultLabel.TabIndex = 2;
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(211, 134);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(94, 29);
            this.SumButton.TabIndex = 3;
            this.SumButton.Text = "Calculate";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(198, 83);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(125, 27);
            this.InputTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 246);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.DescriptLabel2);
            this.Controls.Add(this.DescriptLabel1);
            this.Name = "Form1";
            this.Text = "Sum of all given numbers, without repeats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescriptLabel1;
        private System.Windows.Forms.Label DescriptLabel2;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.TextBox InputTextBox;
    }
}

