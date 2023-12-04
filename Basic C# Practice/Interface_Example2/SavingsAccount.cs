using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example2
{
    internal class SavingsAccount: IBankAccount
    {
        public double IntersentAount { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public void CalculateInterest()
        {

        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
