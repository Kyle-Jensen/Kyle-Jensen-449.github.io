namespace Celsius_to_Fahrenheit_Table1
{
    partial class CtF
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
            this.tempOutPutListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tempOutPutListBox
            // 
            this.tempOutPutListBox.FormattingEnabled = true;
            this.tempOutPutListBox.Location = new System.Drawing.Point(0, 0);
            this.tempOutPutListBox.Name = "tempOutPutListBox";
            this.tempOutPutListBox.Size = new System.Drawing.Size(122, 290);
            this.tempOutPutListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 292);
            this.Controls.Add(this.tempOutPutListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox tempOutPutListBox;
    }
}

