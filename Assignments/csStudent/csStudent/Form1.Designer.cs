namespace csStudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.requiredHoursLabel = new System.Windows.Forms.Label();
            this.softwareEngineeringRadioButton = new System.Windows.Forms.RadioButton();
            this.infoSystemsRadioButton = new System.Windows.Forms.RadioButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.outputRequiredHoursLabel = new System.Windows.Forms.Label();
            this.inputAcademicTrackLabel = new System.Windows.Forms.Label();
            this.inputIDlLabel = new System.Windows.Forms.Label();
            this.inputNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.getHoursButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.softwareEngineeringRadioButton);
            this.groupBox1.Controls.Add(this.requiredHoursLabel);
            this.groupBox1.Controls.Add(this.infoSystemsRadioButton);
            this.groupBox1.Controls.Add(this.inputNameLabel);
            this.groupBox1.Controls.Add(this.inputIDlLabel);
            this.groupBox1.Controls.Add(this.inputAcademicTrackLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.outputRequiredHoursLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // requiredHoursLabel
            // 
            this.requiredHoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requiredHoursLabel.Location = new System.Drawing.Point(101, 155);
            this.requiredHoursLabel.Name = "requiredHoursLabel";
            this.requiredHoursLabel.Size = new System.Drawing.Size(154, 23);
            this.requiredHoursLabel.TabIndex = 19;
            this.requiredHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // softwareEngineeringRadioButton
            // 
            this.softwareEngineeringRadioButton.AutoSize = true;
            this.softwareEngineeringRadioButton.Location = new System.Drawing.Point(104, 126);
            this.softwareEngineeringRadioButton.Name = "softwareEngineeringRadioButton";
            this.softwareEngineeringRadioButton.Size = new System.Drawing.Size(126, 17);
            this.softwareEngineeringRadioButton.TabIndex = 18;
            this.softwareEngineeringRadioButton.TabStop = true;
            this.softwareEngineeringRadioButton.Text = "Software Engineering";
            this.softwareEngineeringRadioButton.UseVisualStyleBackColor = true;
            // 
            // infoSystemsRadioButton
            // 
            this.infoSystemsRadioButton.AutoSize = true;
            this.infoSystemsRadioButton.Checked = true;
            this.infoSystemsRadioButton.Location = new System.Drawing.Point(104, 103);
            this.infoSystemsRadioButton.Name = "infoSystemsRadioButton";
            this.infoSystemsRadioButton.Size = new System.Drawing.Size(119, 17);
            this.infoSystemsRadioButton.TabIndex = 17;
            this.infoSystemsRadioButton.TabStop = true;
            this.infoSystemsRadioButton.Text = "Information Systems";
            this.infoSystemsRadioButton.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(104, 62);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(151, 20);
            this.idTextBox.TabIndex = 16;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(104, 36);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(151, 20);
            this.nameTextBox.TabIndex = 15;
            // 
            // outputRequiredHoursLabel
            // 
            this.outputRequiredHoursLabel.AutoSize = true;
            this.outputRequiredHoursLabel.Location = new System.Drawing.Point(14, 156);
            this.outputRequiredHoursLabel.Name = "outputRequiredHoursLabel";
            this.outputRequiredHoursLabel.Size = new System.Drawing.Size(84, 13);
            this.outputRequiredHoursLabel.TabIndex = 14;
            this.outputRequiredHoursLabel.Text = "Required Hours:";
            // 
            // inputAcademicTrackLabel
            // 
            this.inputAcademicTrackLabel.AutoSize = true;
            this.inputAcademicTrackLabel.Location = new System.Drawing.Point(10, 107);
            this.inputAcademicTrackLabel.Name = "inputAcademicTrackLabel";
            this.inputAcademicTrackLabel.Size = new System.Drawing.Size(88, 13);
            this.inputAcademicTrackLabel.TabIndex = 13;
            this.inputAcademicTrackLabel.Text = "Academic Track:";
            // 
            // inputIDlLabel
            // 
            this.inputIDlLabel.AutoSize = true;
            this.inputIDlLabel.Location = new System.Drawing.Point(37, 62);
            this.inputIDlLabel.Name = "inputIDlLabel";
            this.inputIDlLabel.Size = new System.Drawing.Size(61, 13);
            this.inputIDlLabel.TabIndex = 12;
            this.inputIDlLabel.Text = "ID Number:";
            // 
            // inputNameLabel
            // 
            this.inputNameLabel.AutoSize = true;
            this.inputNameLabel.Location = new System.Drawing.Point(60, 36);
            this.inputNameLabel.Name = "inputNameLabel";
            this.inputNameLabel.Size = new System.Drawing.Size(38, 13);
            this.inputNameLabel.TabIndex = 11;
            this.inputNameLabel.Text = "Name:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(182, 229);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 47);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // getHoursButton
            // 
            this.getHoursButton.Location = new System.Drawing.Point(91, 229);
            this.getHoursButton.Name = "getHoursButton";
            this.getHoursButton.Size = new System.Drawing.Size(85, 47);
            this.getHoursButton.TabIndex = 20;
            this.getHoursButton.Text = "Get Required Hours";
            this.getHoursButton.UseVisualStyleBackColor = true;
            this.getHoursButton.Click += new System.EventHandler(this.getHoursButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 298);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getHoursButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Student Data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton softwareEngineeringRadioButton;
        private System.Windows.Forms.Label requiredHoursLabel;
        private System.Windows.Forms.RadioButton infoSystemsRadioButton;
        private System.Windows.Forms.Label inputNameLabel;
        private System.Windows.Forms.Label inputIDlLabel;
        private System.Windows.Forms.Label inputAcademicTrackLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label outputRequiredHoursLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button getHoursButton;
    }
}

