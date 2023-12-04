using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    public interface IDrawble
    {
        public void Draw();

        public void ReDraw()
        {
            Console.WriteLine("A shape is redrawn");
        }
    }
}
