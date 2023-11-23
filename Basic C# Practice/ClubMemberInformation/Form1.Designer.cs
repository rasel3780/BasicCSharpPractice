namespace ClubMemberInformation
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.monthlyFeeRadioButton = new System.Windows.Forms.RadioButton();
            this.yearlyFeeRadioButton = new System.Windows.Forms.RadioButton();
            this.lifetimeFeeRadioButton = new System.Windows.Forms.RadioButton();
            this.paymentCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(375, 125);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(230, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(375, 168);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(230, 22);
            this.contactTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Membership type";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(371, 367);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(484, 367);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // monthlyFeeRadioButton
            // 
            this.monthlyFeeRadioButton.AutoSize = true;
            this.monthlyFeeRadioButton.Location = new System.Drawing.Point(484, 256);
            this.monthlyFeeRadioButton.Name = "monthlyFeeRadioButton";
            this.monthlyFeeRadioButton.Size = new System.Drawing.Size(74, 20);
            this.monthlyFeeRadioButton.TabIndex = 3;
            this.monthlyFeeRadioButton.TabStop = true;
            this.monthlyFeeRadioButton.Text = "Monthly";
            this.monthlyFeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // yearlyFeeRadioButton
            // 
            this.yearlyFeeRadioButton.AutoSize = true;
            this.yearlyFeeRadioButton.Location = new System.Drawing.Point(484, 283);
            this.yearlyFeeRadioButton.Name = "yearlyFeeRadioButton";
            this.yearlyFeeRadioButton.Size = new System.Drawing.Size(67, 20);
            this.yearlyFeeRadioButton.TabIndex = 4;
            this.yearlyFeeRadioButton.TabStop = true;
            this.yearlyFeeRadioButton.Text = "Yearly";
            this.yearlyFeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // lifetimeFeeRadioButton
            // 
            this.lifetimeFeeRadioButton.AutoSize = true;
            this.lifetimeFeeRadioButton.Location = new System.Drawing.Point(484, 309);
            this.lifetimeFeeRadioButton.Name = "lifetimeFeeRadioButton";
            this.lifetimeFeeRadioButton.Size = new System.Drawing.Size(74, 20);
            this.lifetimeFeeRadioButton.TabIndex = 5;
            this.lifetimeFeeRadioButton.TabStop = true;
            this.lifetimeFeeRadioButton.Text = "Lifetime";
            this.lifetimeFeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // paymentCheckBox
            // 
            this.paymentCheckBox.AutoSize = true;
            this.paymentCheckBox.Location = new System.Drawing.Point(375, 208);
            this.paymentCheckBox.Name = "paymentCheckBox";
            this.paymentCheckBox.Size = new System.Drawing.Size(184, 20);
            this.paymentCheckBox.TabIndex = 6;
            this.paymentCheckBox.Text = "Has paid membership fee";
            this.paymentCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paymentCheckBox);
            this.Controls.Add(this.lifetimeFeeRadioButton);
            this.Controls.Add(this.yearlyFeeRadioButton);
            this.Controls.Add(this.monthlyFeeRadioButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.RadioButton monthlyFeeRadioButton;
        private System.Windows.Forms.RadioButton yearlyFeeRadioButton;
        private System.Windows.Forms.RadioButton lifetimeFeeRadioButton;
        private System.Windows.Forms.CheckBox paymentCheckBox;
    }
}

