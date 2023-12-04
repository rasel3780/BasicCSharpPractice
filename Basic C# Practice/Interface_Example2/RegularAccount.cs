using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example2
{
    internal class RegularAccount : IBankAccount
    {
        public double ServiceCharge { get; set; }
        public string AccountNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
