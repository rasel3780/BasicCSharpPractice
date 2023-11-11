using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedTypeExample2
{
    internal class Laptop
    {
        public int ram;
        public int core;

        public bool CheckCompatibility()
        {
            if(ram >=8 && core>=5 )
            {
                return true;
            }
            return false;
        }
    }
}
