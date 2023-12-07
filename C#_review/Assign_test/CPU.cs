using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_test
{
    public class CPU
    {
        public string[] Component { get; private set; }

        public CPU(string[] component)
        {
            Component = component;
        }
    }
}
