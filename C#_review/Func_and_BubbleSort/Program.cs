using Func_and_BubbleSort;

WaterBottle[] waterBottle = new WaterBottle[]
{
    new WaterBottle("Pran",500),
    new WaterBottle("Acme",1000)
};

Sort<WaterBottle> sort = new Sort<WaterBottle>();

var Bottle = sort.BubbleSort(waterBottle,Compare);

foreach(var bot in Bottle)
{
    Console.WriteLine($"Name = {bot.Name}, Amount = {bot.Amount}");
}

bool Compare(WaterBottle bottle1, WaterBottle bottle2)
{
    if (bottle1 != bottle2)
    {
        return bottle1.Amount >bottle2.Amount;
    }
    else
    {
        return bottle1.Name.CompareTo(bottle2.Name)>0;
    }
}