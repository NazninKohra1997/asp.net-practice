using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Open_Closed_Principal_
{
    public class Circle : Shape
    {
        public string name = "Circle";
        public string Color { get; private set; }

        public Circle(string color)
        {
            Color = color;
        }

        public override void Draw()
        {
            Console.WriteLine($"I'm {name}. Give me {Color} color.");
        }
    }
}
