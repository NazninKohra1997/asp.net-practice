using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_nestingObject
{
    public class Laptop
    {
        public string Name { get; private set; }
        public List<Motherboard> Motherboards {  get; private set; }

        public Laptop(string name, List<Motherboard> motherboards) {
            Name = name;
            Motherboards = motherboards;
        }

    }
    
}
