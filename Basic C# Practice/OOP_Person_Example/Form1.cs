using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Person_Example
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
            Person person = new Person();
            person.firtName = firstNameTxtBox.Text;
            person.middleName = middlesNameTxtBox.Text;
            person.lastName = lastNameTxtBox.Text;

            fullNameTxtBox.Text = person.GetFullName();
            revFullNameTxtBox.Text = person.GetReverseFullName();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
