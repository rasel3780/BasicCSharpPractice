using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstact_Example
{
    internal class TimeBasedWorker : Worker
    {
        public double WorkedHour { get; set; }
        public double AmountPerHour { get; set; }
        
        public override double GetTotalWage()
        {
            return WorkedHour*AmountPerHour;
        }
    }
}
