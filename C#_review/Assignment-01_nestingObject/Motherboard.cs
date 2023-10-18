using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_nestingObject
{
   public class Motherboard
    {
        public List<RAM> RAMs { get; private set; }
        public List<CPU> CPUs { get; private set; }

        public Motherboard(List<RAM> rAMs, List<CPU> cPUs)
        {
            RAMs = rAMs;
            CPUs = cPUs;
        }
    }
}
