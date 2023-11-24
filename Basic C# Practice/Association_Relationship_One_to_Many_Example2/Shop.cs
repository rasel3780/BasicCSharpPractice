using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_Relationship_One_to_Many_Example2
{
    internal class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Product> productList = new List<Product>(); 
    }
}
