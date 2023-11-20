using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double firstNumber = 0;
        private double secondNumber = 0;
        private double result = 0;

        Calculator calculator = new Calculator();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            result = calculator.Add(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            result = calculator.Sub(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            result = calculator.Mul(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            result = calculator.Div(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();

        }
    }
}
