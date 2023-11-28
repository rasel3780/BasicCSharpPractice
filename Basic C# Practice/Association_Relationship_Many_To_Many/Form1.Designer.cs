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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentAddButton = new System.Windows.Forms.Button();
            this.studentEmailTextBox = new System.Windows.Forms.TextBox();
            this.studentContactNoTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentRegNoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.courseAddButton = new System.Windows.Forms.Button();
            this.advanceRadioButton = new System.Windows.Forms.RadioButton();
            this.intermediateRadioButton = new System.Windows.Forms.RadioButton();
            this.BeginnerRadioButton = new System.Windows.Forms.RadioButton();
            this.courseDurationTextBox = new System.Windows.Forms.TextBox();
            this.courseTitleTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.showNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.enrollmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enrollButton = new System.Windows.Forms.Button();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.enrolledCourselistBox = new System.Windows.Forms.ListBox();
            this.showEnrolledCourseButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.selectStudentComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.departmentNameTextBox = new System.Windows.Forms.TextBox();
            this.departmentCodeTextBox = new System.Windows.Forms.TextBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.courseDepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.departmentComboBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.studentAddButton);
            this.groupBox1.Controls.Add(this.studentEmailTextBox);
            this.groupBox1.Controls.Add(this.studentContactNoTextBox);
            this.groupBox1.Controls.Add(this.studentNameTextBox);
            this.groupBox1.Controls.Add(this.studentRegNoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(284, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Student Info";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact No";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // studentAddButton
            // 
            this.studentAddButton.Location = new System.Drawing.Point(316, 226);
            this.studentAddButton.Name = "studentAddButton";
            this.studentAddButton.Size = new System.Drawing.Size(75, 23);
            this.studentAddButton.TabIndex = 1;
            this.studentAddButton.Text = "Add";
            this.studentAddButton.UseVisualStyleBackColor = true;
            this.studentAddButton.Click += new System.EventHandler(this.studentAddButton_Click);
            // 
            // studentEmailTextBox
            // 
            this.studentEmailTextBox.Location = new System.Drawing.Point(171, 144);
            this.studentEmailTextBox.Name = "studentEmailTextBox";
            this.studentEmailTextBox.Size = new System.Drawing.Size(220, 22);
            this.studentEmailTextBox.TabIndex = 0;
            // 
            // studentContactNoTextBox
            // 
            this.studentContactNoTextBox.Location = new System.Drawing.Point(171, 104);
            this.studentContactNoTextBox.Name = "studentContactNoTextBox";
            this.studentContactNoTextBox.Size = new System.Drawing.Size(220, 22);
            this.studentContactNoTextBox.TabIndex = 0;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(171, 29);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(220, 22);
            this.studentNameTextBox.TabIndex = 0;
            // 
            // studentRegNoTextBox
            // 
            this.studentRegNoTextBox.Location = new System.Drawing.Point(171, 65);
            this.studentRegNoTextBox.Name = "studentRegNoTextBox";
            this.studentRegNoTextBox.Size = new System.Drawing.Size(220, 22);
            this.studentRegNoTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.courseDepartmentComboBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.courseAddButton);
            this.groupBox2.Controls.Add(this.advanceRadioButton);
            this.groupBox2.Controls.Add(this.intermediateRadioButton);
            this.groupBox2.Controls.Add(this.BeginnerRadioButton);
            this.groupBox2.Controls.Add(this.courseDurationTextBox);
            this.groupBox2.Controls.Add(this.courseTitleTextBox);
            this.groupBox2.Location = new System.Drawing.Point(284, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 287);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Course Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Duration in hour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Title";
            // 
            // courseAddButton
            // 
            this.courseAddButton.Location = new System.Drawing.Point(324, 258);
            this.courseAddButton.Name = "courseAddButton";
            this.courseAddButton.Size = new System.Drawing.Size(75, 23);
            this.courseAddButton.TabIndex = 1;
            this.courseAddButton.Text = "Add";
            this.courseAddButton.UseVisualStyleBackColor = true;
            this.courseAddButton.Click += new System.EventHandler(this.courseAddButton_Click);
            // 
            // advanceRadioButton
            // 
            this.advanceRadioButton.AutoSize = true;
            this.advanceRadioButton.Location = new System.Drawing.Point(291, 174);
            this.advanceRadioButton.Name = "advanceRadioButton";
            this.advanceRadioButton.Size = new System.Drawing.Size(82, 20);
            this.advanceRadioButton.TabIndex = 1;
            this.advanceRadioButton.TabStop = true;
            this.advanceRadioButton.Text = "Advance";
            this.advanceRadioButton.UseVisualStyleBackColor = true;
            // 
            // intermediateRadioButton
            // 
            this.intermediateRadioButton.AutoSize = true;
            this.intermediateRadioButton.Location = new System.Drawing.Point(291, 142);
            this.intermediateRadioButton.Name = "intermediateRadioButton";
            this.intermediateRadioButton.Size = new System.Drawing.Size(102, 20);
            this.intermediateRadioButton.TabIndex = 1;
            this.intermediateRadioButton.TabStop = true;
            this.intermediateRadioButton.Text = "Intermediate";
            this.intermediateRadioButton.UseVisualStyleBackColor = true;
            // 
            // BeginnerRadioButton
            // 
            this.BeginnerRadioButton.AutoSize = true;
            this.BeginnerRadioButton.Location = new System.Drawing.Point(291, 107);
            this.BeginnerRadioButton.Name = "BeginnerRadioButton";
            this.BeginnerRadioButton.Size = new System.Drawing.Size(82, 20);
            this.BeginnerRadioButton.TabIndex = 1;
            this.BeginnerRadioButton.TabStop = true;
            this.BeginnerRadioButton.Text = "Beginner";
            this.BeginnerRadioButton.UseVisualStyleBackColor = true;
            // 
            // courseDurationTextBox
            // 
            this.courseDurationTextBox.Location = new System.Drawing.Point(163, 214);
            this.courseDurationTextBox.Name = "courseDurationTextBox";
            this.courseDurationTextBox.Size = new System.Drawing.Size(228, 22);
            this.courseDurationTextBox.TabIndex = 0;
            // 
            // courseTitleTextBox
            // 
            this.courseTitleTextBox.Location = new System.Drawing.Point(163, 73);
            this.courseTitleTextBox.Name = "courseTitleTextBox";
            this.courseTitleTextBox.Size = new System.Drawing.Size(228, 22);
            this.courseTitleTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.showNameTextBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.enrollmentDateTimePicker);
            this.groupBox3.Controls.Add(this.enrollButton);
            this.groupBox3.Controls.Add(this.courseComboBox);
            this.groupBox3.Controls.Add(this.studentComboBox);
            this.groupBox3.Location = new System.Drawing.Point(719, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 237);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enroll in a course";
            // 
            // showNameTextBox
            // 
            this.showNameTextBox.Location = new System.Drawing.Point(130, 71);
            this.showNameTextBox.Name = "showNameTextBox";
            this.showNameTextBox.ReadOnly = true;
            this.showNameTextBox.Size = new System.Drawing.Size(217, 22);
            this.showNameTextBox.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Select Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Select Course";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Select Student";
            // 
            // enrollmentDateTimePicker
            // 
            this.enrollmentDateTimePicker.Location = new System.Drawing.Point(130, 147);
            this.enrollmentDateTimePicker.Name = "enrollmentDateTimePicker";
            this.enrollmentDateTimePicker.Size = new System.Drawing.Size(217, 22);
            this.enrollmentDateTimePicker.TabIndex = 2;
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(130, 195);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(75, 23);
            this.enrollButton.TabIndex = 1;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(130, 106);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(217, 24);
            this.courseComboBox.TabIndex = 0;
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(130, 33);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(217, 24);
            this.studentComboBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.enrolledCourselistBox);
            this.groupBox4.Controls.Add(this.showEnrolledCourseButton);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.selectStudentComboBox);
            this.groupBox4.Location = new System.Drawing.Point(719, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(486, 265);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "View Enrolled Courses";
            // 
            // enrolledCourselistBox
            // 
            this.enrolledCourselistBox.FormattingEnabled = true;
            this.enrolledCourselistBox.ItemHeight = 16;
            this.enrolledCourselistBox.Location = new System.Drawing.Point(6, 90);
            this.enrolledCourselistBox.Name = "enrolledCourselistBox";
            this.enrolledCourselistBox.Size = new System.Drawing.Size(474, 164);
            this.enrolledCourselistBox.TabIndex = 2;
            // 
            // showEnrolledCourseButton
            // 
            this.showEnrolledCourseButton.Location = new System.Drawing.Point(280, 61);
            this.showEnrolledCourseButton.Name = "showEnrolledCourseButton";
            this.showEnrolledCourseButton.Size = new System.Drawing.Size(175, 23);
            this.showEnrolledCourseButton.TabIndex = 1;
            this.showEnrolledCourseButton.Text = "Show enrolled Courses";
            this.showEnrolledCourseButton.UseVisualStyleBackColor = true;
            this.showEnrolledCourseButton.Click += new System.EventHandler(this.showEnrolledCourseButton_Click);
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
            // selectStudentComboBox
            // 
            this.selectStudentComboBox.FormattingEnabled = true;
            this.selectStudentComboBox.Location = new System.Drawing.Point(238, 27);
            this.selectStudentComboBox.Name = "selectStudentComboBox";
            this.selectStudentComboBox.Size = new System.Drawing.Size(217, 24);
            this.selectStudentComboBox.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Controls.Add(this.addDepartmentButton);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.departmentNameTextBox);
            this.groupBox5.Controls.Add(this.departmentCodeTextBox);
            this.groupBox5.Location = new System.Drawing.Point(15, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 159);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Department Info";
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.Location = new System.Drawing.Point(167, 130);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(75, 23);
            this.addDepartmentButton.TabIndex = 2;
            this.addDepartmentButton.Text = "Add";
            this.addDepartmentButton.UseVisualStyleBackColor = true;
            this.addDepartmentButton.Click += new System.EventHandler(this.addDepartmentButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Code";
            // 
            // departmentNameTextBox
            // 
            this.departmentNameTextBox.Location = new System.Drawing.Point(52, 94);
            this.departmentNameTextBox.Name = "departmentNameTextBox";
            this.departmentNameTextBox.Size = new System.Drawing.Size(190, 22);
            this.departmentNameTextBox.TabIndex = 0;
            // 
            // departmentCodeTextBox
            // 
            this.departmentCodeTextBox.Location = new System.Drawing.Point(52, 45);
            this.departmentCodeTextBox.Name = "departmentCodeTextBox";
            this.departmentCodeTextBox.Size = new System.Drawing.Size(190, 22);
            this.departmentCodeTextBox.TabIndex = 0;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(171, 187);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(220, 24);
            this.departmentComboBox.TabIndex = 4;
            // 
            // courseDepartmentComboBox
            // 
            this.courseDepartmentComboBox.FormattingEnabled = true;
            this.courseDepartmentComboBox.Location = new System.Drawing.Point(163, 32);
            this.courseDepartmentComboBox.Name = "courseDepartmentComboBox";
            this.courseDepartmentComboBox.Size = new System.Drawing.Size(228, 24);
            this.courseDepartmentComboBox.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Select department";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Select department";
            this.label14.Click += new System.EventHandler(this.label15_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1236, 645);
            this.Controls.Add(this.groupBox5);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker enrollmentDateTimePicker;
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button addDepartmentButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox departmentNameTextBox;
        private System.Windows.Forms.TextBox departmentCodeTextBox;
        private System.Windows.Forms.TextBox showNameTextBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.ComboBox courseDepartmentComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

