using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_and_BubbleSort
{
    public class WaterBottle
    {
        public string Name { get; private set; }
        public int Amount {  get; private set; }

        public WaterBottle(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
