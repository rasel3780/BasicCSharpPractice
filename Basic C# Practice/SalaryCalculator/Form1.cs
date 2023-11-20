using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
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

        private void showButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.employeeName = empNameTextBox.Text;
            employee.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            employee.houseRentPercentage = Convert.ToDouble(houseRentTextBox.Text);
            employee.medicalAllowancePercentage = Convert.ToDouble(medicalAllowanceTextBox.Text);

            MessageBox.Show(employee.employeeName + "\n" + employee.GetTotalSallary());
        }
    }
}
