using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Design_Pattern
{
   public class Product2 : ICloneable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public object Clone()
        {
            Product2 product2_1 = new Product2();
            product2_1.Name = Name;
            product2_1.Price = Price;
            return product2_1;
        }
    }
}
