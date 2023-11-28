using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Association_Relationship_Many_To_Many
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        List<Department> departments = new List<Department>();

        private void UpdateDepartmentComboBox()
        {
            departmentComboBox.DataSource = null;
            departmentComboBox.DataSource = departments;
            departmentComboBox.DisplayMember = "Name";

            courseDepartmentComboBox.DataSource = null;
            courseDepartmentComboBox.DataSource= departments;
            courseDepartmentComboBox.DisplayMember="Title";
        }

        private void addDepartmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                Department department = new Department
                {
                    Code = departmentCodeTextBox.Text,
                    Name = departmentNameTextBox.Text.ToUpper(),
                    StudentList = new List<Student>(),
                    CourseList = new List<Course>(),
                    EnrollmentList = new List<Enrollment>()
                };
                departments.Add(department);
                UpdateDepartmentComboBox();
                MessageBox.Show("Department added successfully");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void studentAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student
                {
                    Name = studentNameTextBox.Text,
                    RegNo = studentRegNoTextBox.Text.ToUpper(),
                    ContactNo = studentContactNoTextBox.Text,
                    Email = studentEmailTextBox.Text
                };
                Department selectedDept = departmentComboBox.SelectedItem as Department;
                selectedDept.StudentList.Add(student);

                studentComboBox.DataSource = selectedDept.StudentList;
                studentComboBox.DisplayMember = "Name";

                MessageBox.Show("Student added successfully");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

     

        private void courseAddButton_Click(object sender, EventArgs e)
        {
            string courseLevel = "";
            if (intermediateRadioButton.Checked)
            {
                courseLevel = "Intermediate";
            }
            else if (BeginnerRadioButton.Checked)
            {
                courseLevel = "Beginner";
            }
            else
            {
                courseLevel = "Advance";
            }

            try 
            {
                Course course = new Course
                {
                    Title = courseTitleTextBox.Text,
                    Level = courseLevel,
                    DurationInHour = Convert.ToDouble(courseDurationTextBox.Text)
                };
                Department selectedDepartment = courseDepartmentComboBox.SelectedItem as Department;
                selectedDepartment.CourseList.Add(course);

                UpdateDepartmentComboBox();

                MessageBox.Show("Course added successfully");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            Student selectedStudent = studentComboBox.SelectedItem as Student;
            Course selectedCourse = courseComboBox.SelectedItem as Course;
            DateTime enrollDate = enrollmentDateTimePicker.Value;

            Enrollment enrollment = new Enrollment
            {
                Student = selectedStudent,
                Course = selectedCourse,
                EnrollmentDate = enrollDate
            };   
        }

        private void showEnrolledCourseButton_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
