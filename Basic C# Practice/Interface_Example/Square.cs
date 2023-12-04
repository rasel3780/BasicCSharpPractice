using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    internal class Square : IDrawble
    {
        public void Draw()
        {
            Console.WriteLine("A square is drawn");
        }

        public void ReDraw()
        {
            Console.WriteLine("A square is re-drawn");
        }
    }
}
