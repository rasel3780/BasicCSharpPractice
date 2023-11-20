using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class CircleCalculation
    {
        public double radius;
        
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetDiameter()
        {
            return 2 * radius;
        }

        public double GetPerimeter()
        {
            return Math.PI * GetDiameter();
        }
    }
}
