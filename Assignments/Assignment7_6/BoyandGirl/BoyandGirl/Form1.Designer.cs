﻿namespace BoyandGirl
{
    partial class boyAndGirlForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.girlTextbox = new System.Windows.Forms.TextBox();
            this.boyTextbox = new System.Windows.Forms.TextBox();
            this.boyGirlLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boy\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Girl\'s Name";
            // 
            // girlTextbox
            // 
            this.girlTextbox.Location = new System.Drawing.Point(170, 48);
            this.girlTextbox.Name = "girlTextbox";
            this.girlTextbox.Size = new System.Drawing.Size(140, 20);
            this.girlTextbox.TabIndex = 2;
            // 
            // boyTextbox
            // 
            this.boyTextbox.Location = new System.Drawing.Point(24, 48);
            this.boyTextbox.Name = "boyTextbox";
            this.boyTextbox.Size = new System.Drawing.Size(140, 20);
            this.boyTextbox.TabIndex = 3;
            // 
            // boyGirlLabel
            // 
            this.boyGirlLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boyGirlLabel.Location = new System.Drawing.Point(30, 89);
            this.boyGirlLabel.Name = "boyGirlLabel";
            this.boyGirlLabel.Size = new System.Drawing.Size(280, 36);
            this.boyGirlLabel.TabIndex = 4;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(77, 183);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 5;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(170, 183);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // boyAndGirlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 232);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.boyGirlLabel);
            this.Controls.Add(this.boyTextbox);
            this.Controls.Add(this.girlTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "boyAndGirlForm";
            this.Text = "Boy and Girl";
            this.Load += new System.EventHandler(this.boyAndGirlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox girlTextbox;
        private System.Windows.Forms.TextBox boyTextbox;
        private System.Windows.Forms.Label boyGirlLabel;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button clearButton;
    }
}

