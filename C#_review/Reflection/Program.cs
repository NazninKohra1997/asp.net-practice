//To get types in a file

using System.Reflection;

Assembly assembly  = Assembly.GetExecutingAssembly();

foreach(var t in assembly.GetTypes())
{
    Console.WriteLine(t.FullName);
}