namespace Weather
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.FahrenheitToCelsiusButton = new System.Windows.Forms.Button();
            this.CelsiusToFahrenheitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(344, 112);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(179, 22);
            this.inputTextBox.TabIndex = 0;
            // 
            // FahrenheitToCelsiusButton
            // 
            this.FahrenheitToCelsiusButton.Location = new System.Drawing.Point(344, 159);
            this.FahrenheitToCelsiusButton.Name = "FahrenheitToCelsiusButton";
            this.FahrenheitToCelsiusButton.Size = new System.Drawing.Size(179, 23);
            this.FahrenheitToCelsiusButton.TabIndex = 1;
            this.FahrenheitToCelsiusButton.Text = "Fahrenheit To Celsius";
            this.FahrenheitToCelsiusButton.UseVisualStyleBackColor = true;
            this.FahrenheitToCelsiusButton.Click += new System.EventHandler(this.FahrenheitToCelsiusButton_Click);
            // 
            // CelsiusToFahrenheitButton
            // 
            this.CelsiusToFahrenheitButton.Location = new System.Drawing.Point(344, 205);
            this.CelsiusToFahrenheitButton.Name = "CelsiusToFahrenheitButton";
            this.CelsiusToFahrenheitButton.Size = new System.Drawing.Size(179, 23);
            this.CelsiusToFahrenheitButton.TabIndex = 1;
            this.CelsiusToFahrenheitButton.Text = "Celsius To Fahrenheit";
            this.CelsiusToFahrenheitButton.UseVisualStyleBackColor = true;
            this.CelsiusToFahrenheitButton.Click += new System.EventHandler(this.CelsiusToFahrenheitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CelsiusToFahrenheitButton);
            this.Controls.Add(this.FahrenheitToCelsiusButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button FahrenheitToCelsiusButton;
        private System.Windows.Forms.Button CelsiusToFahrenheitButton;
        private System.Windows.Forms.Label label1;
    }
}

