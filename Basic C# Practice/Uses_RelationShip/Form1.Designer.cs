namespace Uses_RelationShip
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
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerEmailTextBox = new System.Windows.Forms.TextBox();
            this.accountNumbertextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.customerSaveButton = new System.Windows.Forms.Button();
            this.customerInfoListBox = new System.Windows.Forms.ListBox();
            this.showDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(153, 84);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(211, 22);
            this.customerNameTextBox.TabIndex = 0;
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Location = new System.Drawing.Point(153, 131);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.Size = new System.Drawing.Size(211, 22);
            this.customerEmailTextBox.TabIndex = 0;
            // 
            // accountNumbertextBox
            // 
            this.accountNumbertextBox.Location = new System.Drawing.Point(153, 180);
            this.accountNumbertextBox.Name = "accountNumbertextBox";
            this.accountNumbertextBox.Size = new System.Drawing.Size(211, 22);
            this.accountNumbertextBox.TabIndex = 0;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(153, 320);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(211, 22);
            this.amountTextBox.TabIndex = 0;
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Location = new System.Drawing.Point(153, 232);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(211, 24);
            this.accountTypeComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "AccountNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "BDT";
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(153, 367);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 3;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(289, 367);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 3;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // customerSaveButton
            // 
            this.customerSaveButton.Location = new System.Drawing.Point(289, 269);
            this.customerSaveButton.Name = "customerSaveButton";
            this.customerSaveButton.Size = new System.Drawing.Size(75, 23);
            this.customerSaveButton.TabIndex = 3;
            this.customerSaveButton.Text = "Save";
            this.customerSaveButton.UseVisualStyleBackColor = true;
            this.customerSaveButton.Click += new System.EventHandler(this.customerSaveButton_Click);
            // 
            // customerInfoListBox
            // 
            this.customerInfoListBox.FormattingEnabled = true;
            this.customerInfoListBox.ItemHeight = 16;
            this.customerInfoListBox.Location = new System.Drawing.Point(444, 84);
            this.customerInfoListBox.Name = "customerInfoListBox";
            this.customerInfoListBox.Size = new System.Drawing.Size(344, 196);
            this.customerInfoListBox.TabIndex = 4;
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Location = new System.Drawing.Point(519, 286);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Size = new System.Drawing.Size(164, 23);
            this.showDetailsButton.TabIndex = 5;
            this.showDetailsButton.Text = "Show Details";
            this.showDetailsButton.UseVisualStyleBackColor = true;
            this.showDetailsButton.Click += new System.EventHandler(this.showDetailsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showDetailsButton);
            this.Controls.Add(this.customerInfoListBox);
            this.Controls.Add(this.customerSaveButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountTypeComboBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.accountNumbertextBox);
            this.Controls.Add(this.customerEmailTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.TextBox accountNumbertextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button customerSaveButton;
        private System.Windows.Forms.ListBox customerInfoListBox;
        private System.Windows.Forms.Button showDetailsButton;
    }
}

