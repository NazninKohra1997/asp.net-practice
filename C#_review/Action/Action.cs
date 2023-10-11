using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action
{
    public class Printer
    {
        public void Print(Action<string> Output) {
            string a = "My name is khan!";
            Output(a);
        }
    }
}
