using Prac_Delegate;

Sort<Student> sort = new Sort<Student>();

Student[] student = new Student[]
{
    new Student("Raisa",20),
    new Student("Hafsa",30),
    new Student("Jk",26)
};

var students = sort.BubbleSort(student,Compare);

foreach (var s in students)
{
    Console.WriteLine($"Name = {s.Name}, Age = {s.Age} ");
}

bool Compare(Student x, Student y)
{
    if(x.Name == y.Name)
    {
        return x.Age < y.Age;
    }
    else
    {
        return x.Name.CompareTo(y.Name) < 0;
    }
}