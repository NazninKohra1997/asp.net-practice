using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Design_Pattern
{
   public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }


        public Product Copy()
        {
            Product product = new Product();
            product.Name = Name;
            product.Price = Price;
            return product;
        }
    }
}
