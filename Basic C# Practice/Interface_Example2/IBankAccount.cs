using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example2
{
    internal interface IBankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        
        void Deposit(double amount);
        void Withdraw(double amount);
    }
}
