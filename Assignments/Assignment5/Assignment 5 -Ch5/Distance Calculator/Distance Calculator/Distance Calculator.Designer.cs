namespace Distance_Calculator
{
    partial class Distance_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hoursTraveledTextBox = new System.Windows.Forms.TextBox();
            this.calcListBox = new System.Windows.Forms.ListBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Speed in MPH:";
            // 
            // vehicleSpeedTextBox
            // 
            this.vehicleSpeedTextBox.Location = new System.Drawing.Point(135, 21);
            this.vehicleSpeedTextBox.Name = "vehicleSpeedTextBox";
            this.vehicleSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleSpeedTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hours Traveled:";
            // 
            // hoursTraveledTextBox
            // 
            this.hoursTraveledTextBox.Location = new System.Drawing.Point(135, 67);
            this.hoursTraveledTextBox.Name = "hoursTraveledTextBox";
            this.hoursTraveledTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursTraveledTextBox.TabIndex = 3;
            // 
            // calcListBox
            // 
            this.calcListBox.FormattingEnabled = true;
            this.calcListBox.Location = new System.Drawing.Point(27, 105);
            this.calcListBox.Name = "calcListBox";
            this.calcListBox.Size = new System.Drawing.Size(257, 147);
            this.calcListBox.TabIndex = 4;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(54, 267);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(160, 267);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Distance_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 311);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.calcListBox);
            this.Controls.Add(this.hoursTraveledTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vehicleSpeedTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Distance_Calculator";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vehicleSpeedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hoursTraveledTextBox;
        private System.Windows.Forms.ListBox calcListBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
    }
}

