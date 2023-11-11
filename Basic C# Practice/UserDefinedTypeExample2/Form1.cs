using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDefinedTypeExample2
{
    public partial class Form1 : Form
    {
        Laptop laptop = new Laptop();
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            brandTextBox.Text = string.Empty;
            ramTextBox.Text = string.Empty;
            processorTextBox.Text = string.Empty;
            showTextBox.Text = string.Empty;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            laptop.core = Convert.ToInt32(processorTextBox.Text);
            laptop.ram = Convert.ToInt32(ramTextBox.Text);
            if(laptop.CheckCompatibility())
            {
                showTextBox.Text = "This laptop is appropriate for programmer";
            }
            else
            {
                showTextBox.Text = "This laptop is not appropriate for programmer";
            }
        }
    }
}
