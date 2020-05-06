namespace LotteryNumberPicker
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
            this.instructLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructLabel
            // 
            this.instructLabel.Location = new System.Drawing.Point(118, 94);
            this.instructLabel.Name = "instructLabel";
            this.instructLabel.Size = new System.Drawing.Size(274, 23);
            this.instructLabel.TabIndex = 0;
            this.instructLabel.Text = "Press the button to generate a set of lottery numbers. ";
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(96, 297);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(319, 96);
            this.outputLabel.TabIndex = 1;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(218, 232);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.instructLabel);
            this.Name = "Form1";
            this.Text = "Lottery Number Picker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button generateButton;
    }
}

