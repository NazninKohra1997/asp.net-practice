using Abstract_Factory_Design_Pattern.BMW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern
{
    public abstract class CarFactory
    {
        public abstract ITire CreateTire(string color);
        public abstract IEngine CreateEngine(double power);
        public abstract IHeadLight CreateHeadLight(int number);
       
    }
}
