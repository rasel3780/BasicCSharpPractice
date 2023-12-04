using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    internal class Rectangle : IDrawble
    {
        public void Draw()
        {
            Console.WriteLine("A rectangle shape is drawn");
        }

        public void Redraw()
        {

        }
    }
}
