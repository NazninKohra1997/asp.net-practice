using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Open_Closed_Principal_
{
   public class Triangle : Shape
    {
        public string name = "Triangle";
        public string Color { get; private set; }

        public Triangle(string color) {
            Color = color;
        }

        public override void Draw()
        {
            Console.WriteLine($"I'm {name}. Give me {Color} color.");
        }
    }
}
