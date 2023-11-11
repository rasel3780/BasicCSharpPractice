using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDefinedTypeExample
{
    public partial class Form1 : Form
    {
        Employee employee = new Employee();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            employee.Name = nameTextBox.Text;
            employee.Id = IdTextBox.Text;
            employee.Salary = Convert.ToDouble(salaryTextBox.Text);

            nameTextBox.Text = "";
            IdTextBox.Text = "";
            salaryTextBox.Text = "";
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = employee.Name;
            IdTextBox.Text = employee.Id;
            salaryTextBox.Text = employee.Salary.ToString();
        }
    }
}
