using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern_02
{
    public interface IBottle
    {
        public int Size { get; set; }
        public string Color { get; set; }
    }
}
