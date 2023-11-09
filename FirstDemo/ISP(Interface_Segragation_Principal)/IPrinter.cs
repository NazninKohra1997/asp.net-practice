using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Interface_Segragation_Principal_
{
   public interface IPrinter   //the interfaces are broken into smallest and they are reusable. so it is ISP
    {
        public void Print(string text);
    }
}
