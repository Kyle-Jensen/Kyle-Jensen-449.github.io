namespace bBall
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
            this.teamslistBox = new System.Windows.Forms.ListBox();
            this.winnersLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamslistBox
            // 
            this.teamslistBox.FormattingEnabled = true;
            this.teamslistBox.Location = new System.Drawing.Point(12, 12);
            this.teamslistBox.Name = "teamslistBox";
            this.teamslistBox.Size = new System.Drawing.Size(104, 420);
            this.teamslistBox.TabIndex = 0;
            // 
            // winnersLabel
            // 
            this.winnersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winnersLabel.Location = new System.Drawing.Point(122, 193);
            this.winnersLabel.Name = "winnersLabel";
            this.winnersLabel.Size = new System.Drawing.Size(286, 23);
            this.winnersLabel.TabIndex = 1;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(228, 231);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.winnersLabel);
            this.Controls.Add(this.teamslistBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox teamslistBox;
        private System.Windows.Forms.Label winnersLabel;
        private System.Windows.Forms.Button ClearButton;
    }
}

