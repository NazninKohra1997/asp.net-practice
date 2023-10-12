using Reflection_class_list_02;
using System.Reflection;
using System.Collections;


Bottle bottle = new Bottle(1, "WaterBotle", new List<WaterBottle>() {new WaterBottle(101,"Pran"),
                                                                     new WaterBottle(102,"Acme")});

Type t = typeof(Bottle);

var properties = t.GetProperties(BindingFlags.Instance | BindingFlags.Public);

foreach(var property in properties)
{
    if (property.PropertyType.GetInterfaces().Contains(typeof(IEnumerable)))
    {
        var PropertyItem = (IEnumerable)property.GetValue(bottle);

        foreach (var items in PropertyItem)
        {
            Type p = items.GetType();
            var values = p.GetProperties(BindingFlags.Instance | BindingFlags.Public);

            foreach (var value in values)
            {
                Console.WriteLine(value.GetValue(items));
            }
        }
        Console.WriteLine();
    }


    else
    {
        Console.WriteLine(property.GetValue(bottle));
        Console.WriteLine();
    }
}