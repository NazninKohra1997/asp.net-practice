using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern.BMW
{
    public class BMWFactory : CarFactory
    {
        public override ITire CreateTire(string color)
        {
            return new Tire() { Color = color };
        }

        public override IEngine CreateEngine(double power)
        {
            return new Engine() { Power = power };
        }

        public override IHeadLight CreateHeadLight(int number)
        {
            return new HeadLight() { Number = number };
        }

        
    }
}
