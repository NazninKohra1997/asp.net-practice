using Singleton_Design_Pattern;

Logger logger1 = Logger.CreateLogger();
Logger logger2 = Logger.CreateLogger();


if(logger1 == logger2)           //we have checked if the instances are same it only sends one instance. 
{
    Console.WriteLine("Same instance");
}
