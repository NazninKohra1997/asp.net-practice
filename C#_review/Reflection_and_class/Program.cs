using Reflection_and_class;
using System.Reflection;

Course course = new Course(101, "C#", new List<Topic> { new Topic { Id =102, Name = "Reflection" },
                                                        new Topic {Id = 103, Name = "Delegate"}
                                                      } ) ;



Type t = course.GetType();

var property = t.GetProperties(BindingFlags.Instance | BindingFlags.Public);

foreach(var p in property)
{
    Console.WriteLine( p.GetValue(course) );
}