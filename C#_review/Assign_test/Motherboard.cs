using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_test
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
