using BuubleSort_and_Delegate;

Sort sort = new Sort();

var numbers = sort.BubbleSort(new int[] { 44, 60, 9, 30 }, Compare);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}


bool Compare(int a, int b)
{
    return a>b;
}