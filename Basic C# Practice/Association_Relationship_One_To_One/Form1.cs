using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Association_Relationship_One_To_One
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

        private void Form1_Load(object sender, EventArgs e)
        {
            typeComboBox.Items.Add("Current Account");
            typeComboBox.Items.Add("Fixed Deposit Account");
            typeComboBox.Items.Add("Student Account");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        BankAccount aBankAccount = new BankAccount();

        private void saveButton_Click(object sender, EventArgs e)
        {
            aBankAccount.AccountNumber = accountNumberTextBox.Text;
            aBankAccount.Type = typeComboBox.Text;
            
            Customer aCustomer = new Customer();
            aCustomer.Name = customerNameTextBox.Text;
            aCustomer.Email = emailTextBox.Text;

            aBankAccount.AccountCustomer = aCustomer;

            MessageBox.Show("Account has been Created");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            aBankAccount.Diposit(Convert.ToDouble(amountTextBox.Text));
            MessageBox.Show("success");
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            aBankAccount.Withdraw(Convert.ToDouble(amountTextBox.Text));
            MessageBox.Show("success");
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            showAccountNumberTextBox.Text = aBankAccount.AccountNumber;
            showBalanceTextBox.Text = aBankAccount.Balance.ToString();
            showCustomerNameTextBox.Text = aBankAccount.AccountCustomer.Name;
            showEmailTextBox.Text = aBankAccount.AccountCustomer.Email;
            showTypeTextBox.Text = aBankAccount.Type.ToString();
        }
    }
}
