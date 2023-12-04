using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_Example
{
    internal class Book: IComparable<Book>
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public int CompareTo(Book bookToCompare)
        {
            if(this.Price > bookToCompare.Price)
                return 1;

            else if(this.Price < bookToCompare.Price)
                return -1;

            else
                return 0;
        }
    }
}
