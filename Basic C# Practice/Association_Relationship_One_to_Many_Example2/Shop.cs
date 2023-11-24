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

        public List<Product> ProductList {  get; set; }
        
        public Shop() 
        {
            ProductList = new List<Product>();
        }

        public bool SameProductCode(string productCode)
        {
            foreach (Product product in ProductList)
            {
                if(product.Code == productCode)
                {
                    return true;
                }
            }
            return false;
        }
        public void UpdateQuantity(string productCode, int quantity)
        {
            foreach(Product product in ProductList)
            {
                if(productCode == product.Code)
                {
                    product.Quantity += quantity;
                }
            }
        }

    }
}
