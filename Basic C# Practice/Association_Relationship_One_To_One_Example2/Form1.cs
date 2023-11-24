using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Association_Relationship_One_To_One_Example2
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
        Employee anEmployee = new Employee();
        Salary empSalary = new Salary();
        private void saveButton_Click(object sender, EventArgs e)
        {
            anEmployee.Id = idTextBox.Text;
            anEmployee.Name = nameTextBox.Text;
            anEmployee.Email = emailTextBox.Text;
            empSalary.Basic = Convert.ToDouble(basicTextBox.Text);
            empSalary.Medical = Convert.ToDouble(medicalTextBox.Text);
            empSalary.Conveyance = Convert.ToDouble(conveyanceTextBox.Text);
            anEmployee.EmpSalary = empSalary;
            MessageBox.Show("Employee Information Added");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            double basic = anEmployee.EmpSalary.Basic;
            showIdTextBox.Text = anEmployee.Id;
            showNameTextBox.Text = anEmployee.Name;
            showEmailTextBox.Text = anEmployee.Email;
            
            showBasicTextBox.Text = basic.ToString();
            
            double medicalPercentage = anEmployee.EmpSalary.Medical;
            double medicalAmount = (medicalPercentage * basic) / 100;

            showMedicalTextBox.Text = medicalAmount.ToString();

            double conveyancePercentage = anEmployee.EmpSalary.Conveyance;
            double conveyanceAmount = (conveyancePercentage * basic) / 100;

            showConveyanceTextBox.Text = conveyanceAmount.ToString();

            double total = basic+medicalAmount+conveyanceAmount;
            showTotalTextBox.Text = total.ToString();
        }
    }
}
