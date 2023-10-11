using Action;
using System.Xml.Serialization;

Printer printer = new Printer();
printer.Print(Foo);


void Foo(string x)
{
    Console.WriteLine(x); 

}