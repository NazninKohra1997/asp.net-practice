using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_nestingObject
{
   public class RAM
    {
        public int[] Capacity { get; private set; }
        
        public RAM(int[] capacity) { 
            Capacity = capacity;
        }
        
    }
}
