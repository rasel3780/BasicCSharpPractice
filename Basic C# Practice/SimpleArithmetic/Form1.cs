using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleArithmetic
{
    public partial class Calulator : Form
    {
        private bool addButtonClicked = false;
        private bool subButtonClicked = false;
        private bool mullButtonClicked = false;
        private bool divButtonClicked = false;

        public Calulator()
        {
            InitializeComponent();
        }

        private void Calulator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Calculation()
        {
            try
            {
                double num1 = Convert.ToDouble(number1TxtBox.Text);
                double num2 = Convert.ToDouble(number2TxtBox.Text);
                double res = 0;

                if (addButtonClicked)
                {
                    res = num1 + num2;
                    addButtonClicked = false;
                }
                else if (subButtonClicked)
                {
                    res = num1 - num2;
                    subButtonClicked = false;
                }
                else if (mullButtonClicked)
                {
                    res = num1 * num2;
                    mullButtonClicked = false;
                }
                else if (divButtonClicked)
                {
                    res = num1 / num2;
                    divButtonClicked = false;
                }
                MessageBox.Show(res.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Input can't be empty and must be numeric, please enter number first");
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            addButtonClicked = true;
            Calculation();
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            subButtonClicked = true;
            Calculation();
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            mullButtonClicked = true;
            Calculation();
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            divButtonClicked = true;
            Calculation();
        }
    }
}
