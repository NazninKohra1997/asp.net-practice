using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;
using System.Xml.Linq;

namespace Assignment_01_nestingObject
{
    public class SimpleMapper
    {
        public void Copy(object source, object destination)
        {
             Type type1 = source.GetType();


             ConstructorInfo[] info1 = type1.GetConstructors();


             Console.WriteLine("All constructors are shown below");

             for (int i = 0; i < info1.Length; i++)
                 Console.WriteLine(info1[i]);

             Type type2 = destination.GetType();


             ConstructorInfo[] info2 = type1.GetConstructors();


             Console.WriteLine("All constructors are shown below");

             for (int i = 0; i < info2.Length; i++)

                 Console.WriteLine(info2[i]);



     

            
        }
        }
}
