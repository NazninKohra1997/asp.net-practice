using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Open_Closed_Principal_
{
   public abstract class Shape           //no need to modify this class for other usage. so it's OCP
    {
        public abstract void Draw();
    }
}
