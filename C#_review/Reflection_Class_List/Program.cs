using Reflection_Class_List;
using System.Reflection;
using System.Security.AccessControl;
using System.Collections;


Course course = new Course(1,"Programming", new List<Topic>() {new Topic(101,"C#"), new Topic(102,"C"), 
                                                               new Topic(103,"Python")});
Type t = typeof(Course);

var properties = t.GetProperties(BindingFlags.Instance | BindingFlags.Public);


foreach (var property in properties)
{
    if(property.PropertyType.GetInterfaces().Contains(typeof(IEnumerable)))
        {
        var items = (IEnumerable)property.GetValue(course);
        foreach (var item in items)
        {
            Type p = item.GetType();
            var values = p.GetProperties(BindingFlags.Instance | BindingFlags.Public);

            foreach (var value in values)
            {
                Console.WriteLine(value.GetValue(item));
            }
        }
        Console.WriteLine();

    }

    else 
    {
       Console.WriteLine(property.GetValue(course));
    Console.WriteLine();
       
    }
    
}
