using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfObject
{
    public partial class Form1 : Form
    {
        List<Employee> employeeList = new List<Employee>();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee(nameTextBox.Text, emailTextBox.Text, contactTextBox.Text);
            employeeList.Add(anEmployee);
            MessageBox.Show("Employee information has been added");
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string allInformation = "";
            
            foreach(Employee employee in employeeList) {
                allInformation += "Name: " + employee.Name + "\tEmail: "+employee.Email + "\tContact: "+employee.ContactNo+"\n";        
            }
            MessageBox.Show(allInformation);
        }
    }
}
