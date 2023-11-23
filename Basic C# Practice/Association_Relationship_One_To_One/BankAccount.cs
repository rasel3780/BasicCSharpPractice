using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_Relationship_One_To_One
{
    internal class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public string Type { get; set; }
        public Customer AccountCustomer { get; set; }

        public void Withdraw(double amount)
        {
            Balance-=amount;
        }

        public void Diposit(double amount)
        {
            Balance+=amount;
        }
    }
}
