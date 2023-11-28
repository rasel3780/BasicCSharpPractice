using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uses_RelationShip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            accountTypeComboBox.Items.Add("Fixed");
            accountTypeComboBox.Items.Add("Current");
        }

        BankAccount bankAccount = new BankAccount();
        private void customerSaveButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = customerNameTextBox.Text;
            customer.Email = customerEmailTextBox.Text;
            bankAccount.AccountType = accountTypeComboBox.Text;
            bankAccount.AccountNo = accountNumbertextBox.Text;
            bankAccount.AccountCustomer = customer;
            MessageBox.Show("Bank Account Created Successfully");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            bankAccount.Deposit(amount);
            MessageBox.Show("Deposited");
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            bankAccount.Withdraw(amount);
            MessageBox.Show("Withdrawn");
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {

            string name = "Name:\t" + bankAccount.AccountCustomer.Name;
            string email = "Email:\t" + bankAccount.AccountCustomer.Email;
            string accountNumber = "Account No:\t" + bankAccount.AccountNo;
            string balanceInBDT = "Balance in BDT:\t" + bankAccount.BalanceInBDT;
            string balanceInUSD = "Balance in USD:\t" + bankAccount.GetBalanceInUSD(bankAccount.BalanceInBDT);

            customerInfoListBox.Items.Clear();
            customerInfoListBox.Items.Add(name);
            customerInfoListBox.Items.Add(email);
            customerInfoListBox.Items.Add(accountNumber);
            customerInfoListBox.Items.Add(balanceInBDT);
            customerInfoListBox.Items.Add(balanceInUSD);
        }
    }
}
