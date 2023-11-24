using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Association_Relationship_One_to_Many
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
        Department aDepartment = new Department();
        private void studentSaveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = studentNameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.RegNo = regNoTextBox.Text;
            aDepartment.StudentList.Add(aStudent);
            MessageBox.Show("Student has been added");

        }

        private void departmentSaveButton_Click(object sender, EventArgs e)
        {
            aDepartment.DepartmentName = departmentNameTextBox.Text;
            aDepartment.DepartmentCode = departmentCodeTextBox.Text;
            MessageBox.Show("Department has been saved");

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showDeptNameTextBox.Text = aDepartment.DepartmentName;
            showDeptCodeTextBox.Text = aDepartment.DepartmentCode;
            
            int totalStudent = aDepartment.StudentList.Count;
            showNoOfStudentTextBox.Text = totalStudent.ToString();
            
            informationListBox.Items.Clear();

            foreach(Student student in aDepartment.StudentList)
            {
                informationListBox.Items.Add(student.Name+"\t"+student.RegNo);
            }

        }
    }
}
