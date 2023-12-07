using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_test
{
   public class RAM
    {
        public int[] Capacity { get; private set; }
        
        public RAM(int[] capacity) { 
            Capacity = capacity;
        }
        
    }
}
