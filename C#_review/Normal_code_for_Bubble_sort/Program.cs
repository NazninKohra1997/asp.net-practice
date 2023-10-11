using Normal_code_for_Bubble_sort;

BubbleSort sort = new BubbleSort();

var number = sort.Sort(new int[] { 44, 78, 99, 1, 20, 5, 60 });

foreach(var item in number)
{
    Console.WriteLine(item);
}

