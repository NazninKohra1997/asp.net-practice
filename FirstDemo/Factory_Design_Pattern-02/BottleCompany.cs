using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern_02
{
    public abstract class BottleCompany
    {
        public abstract IBottle Produce(int size, string color);
    }
}
