using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_Delegate
{
    public class Student
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Student(string Name, int Age) { 
            this.Name = Name;
            this.Age = Age;
        }
    }
}
