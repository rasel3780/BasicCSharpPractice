using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Bank_Account_Example
{
    internal class BankAccount
    {
        public string accountNumber;
        public string holderName;
        public double balance;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount) 
        {
            balance -= amount;
        }
    }
}
