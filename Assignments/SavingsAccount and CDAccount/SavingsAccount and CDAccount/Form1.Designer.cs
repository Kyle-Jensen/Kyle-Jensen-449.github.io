namespace SavingsAccount_and_CDAccount
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createObjectButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inputMaturityDateLabel = new System.Windows.Forms.Label();
            this.inputBalanceLabel = new System.Windows.Forms.Label();
            this.inputInterestRatelLabel = new System.Windows.Forms.Label();
            this.inputAccountNumberLabel = new System.Windows.Forms.Label();
            this.outputMaturityDateLabel = new System.Windows.Forms.Label();
            this.outputBalanceLabel = new System.Windows.Forms.Label();
            this.outoutInterestRateLabel = new System.Windows.Forms.Label();
            this.outputAccountNumberLabel = new System.Windows.Forms.Label();
            this.maturityDateTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.maturityDateLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maturityDateTextBox);
            this.groupBox1.Controls.Add(this.balanceTextBox);
            this.groupBox1.Controls.Add(this.interestRateTextBox);
            this.groupBox1.Controls.Add(this.accountNumberTextBox);
            this.groupBox1.Controls.Add(this.inputMaturityDateLabel);
            this.groupBox1.Controls.Add(this.inputAccountNumberLabel);
            this.groupBox1.Controls.Add(this.inputBalanceLabel);
            this.groupBox1.Controls.Add(this.inputInterestRatelLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter CD Account Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maturityDateLabel);
            this.groupBox2.Controls.Add(this.balanceLabel);
            this.groupBox2.Controls.Add(this.interestRateLabel);
            this.groupBox2.Controls.Add(this.accountNumberLabel);
            this.groupBox2.Controls.Add(this.outputMaturityDateLabel);
            this.groupBox2.Controls.Add(this.outputAccountNumberLabel);
            this.groupBox2.Controls.Add(this.outputBalanceLabel);
            this.groupBox2.Controls.Add(this.outoutInterestRateLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Object Properties";
            // 
            // createObjectButton
            // 
            this.createObjectButton.Location = new System.Drawing.Point(41, 342);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(75, 43);
            this.createObjectButton.TabIndex = 0;
            this.createObjectButton.Text = "Create Object";
            this.createObjectButton.UseVisualStyleBackColor = true;
            this.createObjectButton.Click += new System.EventHandler(this.createObjectButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // inputMaturityDateLabel
            // 
            this.inputMaturityDateLabel.AutoSize = true;
            this.inputMaturityDateLabel.Location = new System.Drawing.Point(31, 110);
            this.inputMaturityDateLabel.Name = "inputMaturityDateLabel";
            this.inputMaturityDateLabel.Size = new System.Drawing.Size(73, 13);
            this.inputMaturityDateLabel.TabIndex = 7;
            this.inputMaturityDateLabel.Text = "Maturity Date:";
            // 
            // inputBalanceLabel
            // 
            this.inputBalanceLabel.AutoSize = true;
            this.inputBalanceLabel.Location = new System.Drawing.Point(55, 84);
            this.inputBalanceLabel.Name = "inputBalanceLabel";
            this.inputBalanceLabel.Size = new System.Drawing.Size(49, 13);
            this.inputBalanceLabel.TabIndex = 6;
            this.inputBalanceLabel.Text = "Balance:";
            // 
            // inputInterestRatelLabel
            // 
            this.inputInterestRatelLabel.AutoSize = true;
            this.inputInterestRatelLabel.Location = new System.Drawing.Point(33, 58);
            this.inputInterestRatelLabel.Name = "inputInterestRatelLabel";
            this.inputInterestRatelLabel.Size = new System.Drawing.Size(71, 13);
            this.inputInterestRatelLabel.TabIndex = 5;
            this.inputInterestRatelLabel.Text = "Interest Rate:";
            // 
            // inputAccountNumberLabel
            // 
            this.inputAccountNumberLabel.AutoSize = true;
            this.inputAccountNumberLabel.Location = new System.Drawing.Point(14, 32);
            this.inputAccountNumberLabel.Name = "inputAccountNumberLabel";
            this.inputAccountNumberLabel.Size = new System.Drawing.Size(90, 13);
            this.inputAccountNumberLabel.TabIndex = 4;
            this.inputAccountNumberLabel.Text = "Account Number:";
            // 
            // outputMaturityDateLabel
            // 
            this.outputMaturityDateLabel.AutoSize = true;
            this.outputMaturityDateLabel.Location = new System.Drawing.Point(31, 110);
            this.outputMaturityDateLabel.Name = "outputMaturityDateLabel";
            this.outputMaturityDateLabel.Size = new System.Drawing.Size(73, 13);
            this.outputMaturityDateLabel.TabIndex = 22;
            this.outputMaturityDateLabel.Text = "Maturity Date:";
            // 
            // outputBalanceLabel
            // 
            this.outputBalanceLabel.AutoSize = true;
            this.outputBalanceLabel.Location = new System.Drawing.Point(55, 84);
            this.outputBalanceLabel.Name = "outputBalanceLabel";
            this.outputBalanceLabel.Size = new System.Drawing.Size(49, 13);
            this.outputBalanceLabel.TabIndex = 21;
            this.outputBalanceLabel.Text = "Balance:";
            // 
            // outoutInterestRateLabel
            // 
            this.outoutInterestRateLabel.AutoSize = true;
            this.outoutInterestRateLabel.Location = new System.Drawing.Point(33, 58);
            this.outoutInterestRateLabel.Name = "outoutInterestRateLabel";
            this.outoutInterestRateLabel.Size = new System.Drawing.Size(71, 13);
            this.outoutInterestRateLabel.TabIndex = 20;
            this.outoutInterestRateLabel.Text = "Interest Rate:";
            // 
            // outputAccountNumberLabel
            // 
            this.outputAccountNumberLabel.AutoSize = true;
            this.outputAccountNumberLabel.Location = new System.Drawing.Point(14, 32);
            this.outputAccountNumberLabel.Name = "outputAccountNumberLabel";
            this.outputAccountNumberLabel.Size = new System.Drawing.Size(90, 13);
            this.outputAccountNumberLabel.TabIndex = 19;
            this.outputAccountNumberLabel.Text = "Account Number:";
            // 
            // maturityDateTextBox
            // 
            this.maturityDateTextBox.Location = new System.Drawing.Point(109, 110);
            this.maturityDateTextBox.Name = "maturityDateTextBox";
            this.maturityDateTextBox.Size = new System.Drawing.Size(122, 20);
            this.maturityDateTextBox.TabIndex = 12;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(110, 84);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(122, 20);
            this.balanceTextBox.TabIndex = 11;
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(110, 58);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(122, 20);
            this.interestRateTextBox.TabIndex = 10;
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(110, 32);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(122, 20);
            this.accountNumberTextBox.TabIndex = 9;
            // 
            // maturityDateLabel
            // 
            this.maturityDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maturityDateLabel.Location = new System.Drawing.Point(109, 105);
            this.maturityDateLabel.Name = "maturityDateLabel";
            this.maturityDateLabel.Size = new System.Drawing.Size(122, 23);
            this.maturityDateLabel.TabIndex = 26;
            this.maturityDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balanceLabel
            // 
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Location = new System.Drawing.Point(109, 79);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(122, 23);
            this.balanceLabel.TabIndex = 25;
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interestRateLabel.Location = new System.Drawing.Point(109, 53);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(122, 23);
            this.interestRateLabel.TabIndex = 24;
            this.interestRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountNumberLabel.Location = new System.Drawing.Point(109, 27);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(122, 23);
            this.accountNumberLabel.TabIndex = 23;
            this.accountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 398);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox maturityDateTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label inputMaturityDateLabel;
        private System.Windows.Forms.Label inputAccountNumberLabel;
        private System.Windows.Forms.Label inputBalanceLabel;
        private System.Windows.Forms.Label inputInterestRatelLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label outputMaturityDateLabel;
        private System.Windows.Forms.Label outputAccountNumberLabel;
        private System.Windows.Forms.Label outputBalanceLabel;
        private System.Windows.Forms.Label outoutInterestRateLabel;
        private System.Windows.Forms.Button createObjectButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label maturityDateLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label accountNumberLabel;
    }
}

