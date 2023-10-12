using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_class_list_02
{
    public class WaterBottle
    {
        public int Id { get; private set; }
        public string Name { get; private set; }


        public WaterBottle(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
