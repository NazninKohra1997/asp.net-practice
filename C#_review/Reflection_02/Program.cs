using System.Reflection;

Assembly assembly = Assembly.GetExecutingAssembly();

foreach(var t in assembly.GetTypes())
{
    if(t.Name == "Program")
    {
        var method = t.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

        foreach(var m in method)
        {
            Console.WriteLine(m);
        }
    }
}