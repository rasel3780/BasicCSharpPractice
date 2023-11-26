namespace Association_Relationship_Many_To_Many
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.courseTitleTextBox = new System.Windows.Forms.TextBox();
            this.studentRegNoTextBox = new System.Windows.Forms.TextBox();
            this.studentContactNoTextBox = new System.Windows.Forms.TextBox();
            this.studentEmailTextBox = new System.Windows.Forms.TextBox();
            this.studentAddButton = new System.Windows.Forms.Button();
            this.BeginnerRadioButton = new System.Windows.Forms.RadioButton();
            this.intermediateRadioButton = new System.Windows.Forms.RadioButton();
            this.advanceRadioButton = new System.Windows.Forms.RadioButton();
            this.courseDurationTextBox = new System.Windows.Forms.TextBox();
            this.courseAddButton = new System.Windows.Forms.Button();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.selectStudentComboBox = new System.Windows.Forms.ComboBox();
            this.showEnrolledCourseButton = new System.Windows.Forms.Button();
            this.enrollButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.enrolledCourselistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.studentAddButton);
            this.groupBox1.Controls.Add(this.studentEmailTextBox);
            this.groupBox1.Controls.Add(this.studentContactNoTextBox);
            this.groupBox1.Controls.Add(this.studentNameTextBox);
            this.groupBox1.Controls.Add(this.studentRegNoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(109, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Student Info";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.courseAddButton);
            this.groupBox2.Controls.Add(this.advanceRadioButton);
            this.groupBox2.Controls.Add(this.intermediateRadioButton);
            this.groupBox2.Controls.Add(this.BeginnerRadioButton);
            this.groupBox2.Controls.Add(this.courseDurationTextBox);
            this.groupBox2.Controls.Add(this.courseTitleTextBox);
            this.groupBox2.Location = new System.Drawing.Point(109, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 258);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Course Info";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.enrollButton);
            this.groupBox3.Controls.Add(this.courseComboBox);
            this.groupBox3.Controls.Add(this.studentComboBox);
            this.groupBox3.Location = new System.Drawing.Point(659, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 205);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enroll in a course";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.enrolledCourselistBox);
            this.groupBox4.Controls.Add(this.showEnrolledCourseButton);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.selectStudentComboBox);
            this.groupBox4.Location = new System.Drawing.Point(659, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(488, 299);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "View Enrolled Courses";
            // 
            // courseTitleTextBox
            // 
            this.courseTitleTextBox.Location = new System.Drawing.Point(163, 35);
            this.courseTitleTextBox.Name = "courseTitleTextBox";
            this.courseTitleTextBox.Size = new System.Drawing.Size(228, 22);
            this.courseTitleTextBox.TabIndex = 0;
            // 
            // studentRegNoTextBox
            // 
            this.studentRegNoTextBox.Location = new System.Drawing.Point(171, 65);
            this.studentRegNoTextBox.Name = "studentRegNoTextBox";
            this.studentRegNoTextBox.Size = new System.Drawing.Size(220, 22);
            this.studentRegNoTextBox.TabIndex = 0;
            // 
            // studentContactNoTextBox
            // 
            this.studentContactNoTextBox.Location = new System.Drawing.Point(171, 104);
            this.studentContactNoTextBox.Name = "studentContactNoTextBox";
            this.studentContactNoTextBox.Size = new System.Drawing.Size(220, 22);
            this.studentContactNoTextBox.TabIndex = 0;
            // 
            // studentEmailTextBox
            // 
            this.studentEmailTextBox.Location = new System.Drawing.Point(171, 144);
            this.studentEmailTextBox.Name = "studentEmailTextBox";
            this.studentEmailTextBox.Size = new System.Drawing.Size(220, 22);
            this.studentEmailTextBox.TabIndex = 0;
            // 
            // studentAddButton
            // 
            this.studentAddButton.Location = new System.Drawing.Point(316, 182);
            this.studentAddButton.Name = "studentAddButton";
            this.studentAddButton.Size = new System.Drawing.Size(75, 23);
            this.studentAddButton.TabIndex = 1;
            this.studentAddButton.Text = "Add";
            this.studentAddButton.UseVisualStyleBackColor = true;
            // 
            // BeginnerRadioButton
            // 
            this.BeginnerRadioButton.AutoSize = true;
            this.BeginnerRadioButton.Location = new System.Drawing.Point(291, 74);
            this.BeginnerRadioButton.Name = "BeginnerRadioButton";
            this.BeginnerRadioButton.Size = new System.Drawing.Size(82, 20);
            this.BeginnerRadioButton.TabIndex = 1;
            this.BeginnerRadioButton.TabStop = true;
            this.BeginnerRadioButton.Text = "Beginner";
            this.BeginnerRadioButton.UseVisualStyleBackColor = true;
            // 
            // intermediateRadioButton
            // 
            this.intermediateRadioButton.AutoSize = true;
            this.intermediateRadioButton.Location = new System.Drawing.Point(291, 109);
            this.intermediateRadioButton.Name = "intermediateRadioButton";
            this.intermediateRadioButton.Size = new System.Drawing.Size(102, 20);
            this.intermediateRadioButton.TabIndex = 1;
            this.intermediateRadioButton.TabStop = true;
            this.intermediateRadioButton.Text = "Intermediate";
            this.intermediateRadioButton.UseVisualStyleBackColor = true;
            // 
            // advanceRadioButton
            // 
            this.advanceRadioButton.AutoSize = true;
            this.advanceRadioButton.Location = new System.Drawing.Point(291, 141);
            this.advanceRadioButton.Name = "advanceRadioButton";
            this.advanceRadioButton.Size = new System.Drawing.Size(82, 20);
            this.advanceRadioButton.TabIndex = 1;
            this.advanceRadioButton.TabStop = true;
            this.advanceRadioButton.Text = "Advance";
            this.advanceRadioButton.UseVisualStyleBackColor = true;
            // 
            // courseDurationTextBox
            // 
            this.courseDurationTextBox.Location = new System.Drawing.Point(163, 181);
            this.courseDurationTextBox.Name = "courseDurationTextBox";
            this.courseDurationTextBox.Size = new System.Drawing.Size(228, 22);
            this.courseDurationTextBox.TabIndex = 0;
            // 
            // courseAddButton
            // 
            this.courseAddButton.Location = new System.Drawing.Point(316, 218);
            this.courseAddButton.Name = "courseAddButton";
            this.courseAddButton.Size = new System.Drawing.Size(75, 23);
            this.courseAddButton.TabIndex = 1;
            this.courseAddButton.Text = "Add";
            this.courseAddButton.UseVisualStyleBackColor = true;
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(238, 33);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(217, 24);
            this.studentComboBox.TabIndex = 0;
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(238, 83);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(217, 24);
            this.courseComboBox.TabIndex = 0;
            // 
            // selectStudentComboBox
            // 
            this.selectStudentComboBox.FormattingEnabled = true;
            this.selectStudentComboBox.Location = new System.Drawing.Point(238, 27);
            this.selectStudentComboBox.Name = "selectStudentComboBox";
            this.selectStudentComboBox.Size = new System.Drawing.Size(217, 24);
            this.selectStudentComboBox.TabIndex = 0;
            // 
            // showEnrolledCourseButton
            // 
            this.showEnrolledCourseButton.Location = new System.Drawing.Point(280, 61);
            this.showEnrolledCourseButton.Name = "showEnrolledCourseButton";
            this.showEnrolledCourseButton.Size = new System.Drawing.Size(175, 23);
            this.showEnrolledCourseButton.TabIndex = 1;
            this.showEnrolledCourseButton.Text = "Show enrolled Courses";
            this.showEnrolledCourseButton.UseVisualStyleBackColor = true;
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(363, 165);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(75, 23);
            this.enrollButton.TabIndex = 1;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // enrolledCourselistBox
            // 
            this.enrolledCourselistBox.FormattingEnabled = true;
            this.enrolledCourselistBox.ItemHeight = 16;
            this.enrolledCourselistBox.Location = new System.Drawing.Point(6, 99);
            this.enrolledCourselistBox.Name = "enrolledCourselistBox";
            this.enrolledCourselistBox.Size = new System.Drawing.Size(476, 196);
            this.enrolledCourselistBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(171, 29);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(220, 22);
            this.studentNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reg. No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Duration in hour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Select Student";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Select Course";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Select Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(135, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Select Student";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 645);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox studentEmailTextBox;
        private System.Windows.Forms.TextBox studentContactNoTextBox;
        private System.Windows.Forms.TextBox studentRegNoTextBox;
        private System.Windows.Forms.TextBox courseTitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button studentAddButton;
        private System.Windows.Forms.Button courseAddButton;
        private System.Windows.Forms.RadioButton advanceRadioButton;
        private System.Windows.Forms.RadioButton intermediateRadioButton;
        private System.Windows.Forms.RadioButton BeginnerRadioButton;
        private System.Windows.Forms.TextBox courseDurationTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.ListBox enrolledCourselistBox;
        private System.Windows.Forms.Button showEnrolledCourseButton;
        private System.Windows.Forms.ComboBox selectStudentComboBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

