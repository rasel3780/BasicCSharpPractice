using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uses_RelationShip
{
    internal class CurrencyConverter
    {
        public double ValueOfOneUSDInBDT { get; set; }

        public double ConvertToUSD(double amountInBDT)
        {
            ValueOfOneUSDInBDT = 110;
            return amountInBDT / ValueOfOneUSDInBDT; 
        }
    }
}
