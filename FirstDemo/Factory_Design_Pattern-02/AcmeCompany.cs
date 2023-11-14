using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern_02
{
    public class AcmeCompany : BottleCompany
    {
        public override IBottle Produce(int size, string color)
        {
            return new Acme() { Size = size, Color = color };
        }
    }

}
