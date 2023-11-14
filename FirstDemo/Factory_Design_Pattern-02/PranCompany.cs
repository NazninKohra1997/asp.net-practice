using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern_02
{
    public class PranCompany : BottleCompany
    {
        public override IBottle Produce(int size, string color)
        {
            return new Pran() { Size = size,Color = color};
        }
    }
}
