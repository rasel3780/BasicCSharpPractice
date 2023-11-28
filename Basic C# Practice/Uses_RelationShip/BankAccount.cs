using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uses_RelationShip
{
    internal class BankAccount
    {
        public string AccountNo { get; set; }
        public string AccountType { get; set; }
        public double BalanceInBDT { get; set; }
        public Customer AccountCustomer { get; set; }

        public void Deposit(double amountInBDT)
        {
            BalanceInBDT += amountInBDT;
        }

        public void Withdraw(double amountInBDT)
        {
            BalanceInBDT -= amountInBDT;
        }

        public double GetBalanceInUSD(double amountInBDT)
        {
            CurrencyConverter converter = new CurrencyConverter();
            return converter.ConvertToUSD(amountInBDT);
        }
    }
}
