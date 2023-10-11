//For finding types

using prac_01;
using System.Reflection;



Assembly assembly = Assembly.GetExecutingAssembly();

foreach(var t in assembly.GetTypes())
{
    Console.WriteLine(t.FullName);
}
Console.WriteLine();


//for finding methods

foreach(var t in assembly.GetTypes())
{
    if(t.Name == "Program")
    {
        var method = t.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

        foreach(var m in method)
        {
            Console.WriteLine(m.Name);
        }
    }
}
Console.WriteLine();


//Reflection for non-generic property in class

Bottle bottle = new Bottle(101, "WaterBottle", new List<WaterBottle> { new WaterBottle { Id = 10,Name="My Bottle"},
    new WaterBottle{ Id = 20, Name = "BB"} });


Type type = bottle.GetType();


var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

foreach(var property in properties)
{
    Console.WriteLine(property.GetValue(bottle));
}

