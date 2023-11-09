using Prototype_Design_Pattern;

//for Product class
Product product1 = new Product();
product1.Name = "Soap";
product1.Price = 100;

Product product2 = product1.Copy();



Console.WriteLine(product2.Name);
Console.WriteLine(product2.Price);

if(product2 != product1)
{
    Console.WriteLine("instances are different");
}


Console.WriteLine();


//for Product2 class
Product2 productt = new Product2();

productt.Name = "Lux";
productt.Price = 30;

Product2 producttt = (Product2)productt.Clone();

Console.WriteLine(productt.Name);
Console.WriteLine(productt.Price);

if(productt != producttt)
{
    Console.WriteLine("instances are different");
}