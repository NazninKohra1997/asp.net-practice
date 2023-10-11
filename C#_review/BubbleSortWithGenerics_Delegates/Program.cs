using BubbleSortWithGenerics_Delegates;

Person[] person = new Person[]{
    new Person() {Name = "Raisa", Age = 18},
    new Person() {Name = "Raina", Age = 15},
    new Person() {Name = "Jhora", Age = 26}
  };

Sort<Person> sort = new Sort<Person>();

var num = sort.BubbleSort(person,Compare);

foreach(var item in num)
{
    Console.WriteLine($"Name = {item.Name}, Age = {item.Age}");
}

bool Compare(Person p1, Person p2)
{
    if(p1.Name != p2.Name)
    {
        return p1.Age>p2.Age;
    }
    else
    {
        return p1.Name.CompareTo(p2.Name) < 0;
    }
}