using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstact_Example
{
    internal abstract class Worker
    {
        public string Name { get; set; }
        public string ContactNo { get; set; }

        public abstract double GetTotalWage();
    }
}
