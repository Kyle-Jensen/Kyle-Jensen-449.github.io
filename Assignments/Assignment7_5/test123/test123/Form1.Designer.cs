namespace test123
{
    partial class worldSeriesChampions
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
            this.Clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamslistBox
            // 
            this.teamslistBox.FormattingEnabled = true;
            this.teamslistBox.Location = new System.Drawing.Point(12, 22);
            this.teamslistBox.Name = "teamslistBox";
            this.teamslistBox.Size = new System.Drawing.Size(118, 381);
            this.teamslistBox.TabIndex = 0;
            this.teamslistBox.SelectedIndexChanged += new System.EventHandler(this.teamsListbox_SelectedIndexChanged);
            // 
            // winnersLabel
            // 
            this.winnersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winnersLabel.Location = new System.Drawing.Point(136, 204);
            this.winnersLabel.Name = "winnersLabel";
            this.winnersLabel.Size = new System.Drawing.Size(280, 25);
            this.winnersLabel.TabIndex = 1;
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(229, 242);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(75, 23);
            this.Clearbutton.TabIndex = 2;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // worldSeriesChampions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 424);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.winnersLabel);
            this.Controls.Add(this.teamslistBox);
            this.Name = "worldSeriesChampions";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox teamslistBox;
        private System.Windows.Forms.Label winnersLabel;
        private System.Windows.Forms.Button Clearbutton;
    }
}

