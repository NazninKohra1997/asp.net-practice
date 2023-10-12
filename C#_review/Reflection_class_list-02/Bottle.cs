using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_class_list_02
{
    public class Bottle
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public List<WaterBottle> WaterBottles { get; private set; }

        public Bottle(int id, string name, List<WaterBottle> waterBottles)
        {
            Id = id;
            Name = name;
            WaterBottles = waterBottles;
        }
    }
}
