using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Bank_Account_Example
{
    public partial class Form1 : Form
    {
        BankAccount aBankAccount;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            aBankAccount = new BankAccount();
            aBankAccount.accountNumber = accountNumberTextBox.Text;
            aBankAccount.holderName = holderNameTextBox.Text;
            MessageBox.Show("Account created successfully");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            aBankAccount.Deposit(amount);
            MessageBox.Show(amount + "taka has been deposited");
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            aBankAccount.Withdraw(amount);
            MessageBox.Show(amount + "taka has been withdrown");
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string info = aBankAccount.accountNumber + "\n" + aBankAccount.holderName + "\n"
                            + aBankAccount.balance;
            MessageBox.Show(info);
        }
    }
}
