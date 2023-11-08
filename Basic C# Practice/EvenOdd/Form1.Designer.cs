namespace EvenOdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num1TxtBox = new System.Windows.Forms.TextBox();
            this.num2TxtBox = new System.Windows.Forms.TextBox();
            this.evenBtn = new System.Windows.Forms.Button();
            this.oddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // num1TxtBox
            // 
            this.num1TxtBox.Location = new System.Drawing.Point(240, 97);
            this.num1TxtBox.Name = "num1TxtBox";
            this.num1TxtBox.Size = new System.Drawing.Size(148, 22);
            this.num1TxtBox.TabIndex = 2;
            // 
            // num2TxtBox
            // 
            this.num2TxtBox.Location = new System.Drawing.Point(240, 142);
            this.num2TxtBox.Name = "num2TxtBox";
            this.num2TxtBox.Size = new System.Drawing.Size(148, 22);
            this.num2TxtBox.TabIndex = 3;
            // 
            // evenBtn
            // 
            this.evenBtn.Location = new System.Drawing.Point(240, 185);
            this.evenBtn.Name = "evenBtn";
            this.evenBtn.Size = new System.Drawing.Size(148, 34);
            this.evenBtn.TabIndex = 4;
            this.evenBtn.Text = "Show Even Number";
            this.evenBtn.UseVisualStyleBackColor = true;
            this.evenBtn.Click += new System.EventHandler(this.evenBtn_Click);
            // 
            // oddBtn
            // 
            this.oddBtn.Location = new System.Drawing.Point(240, 231);
            this.oddBtn.Name = "oddBtn";
            this.oddBtn.Size = new System.Drawing.Size(148, 34);
            this.oddBtn.TabIndex = 5;
            this.oddBtn.Text = "Show odd number";
            this.oddBtn.UseVisualStyleBackColor = true;
            this.oddBtn.Click += new System.EventHandler(this.oddBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oddBtn);
            this.Controls.Add(this.evenBtn);
            this.Controls.Add(this.num2TxtBox);
            this.Controls.Add(this.num1TxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num1TxtBox;
        private System.Windows.Forms.TextBox num2TxtBox;
        private System.Windows.Forms.Button evenBtn;
        private System.Windows.Forms.Button oddBtn;
    }
}

