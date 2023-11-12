internal class Program
{
    private static void Main(string[] args)
    {
        //value type
        int p = 100;
        int q = p;
        p = 300;

        Console.WriteLine(p);
        Console.WriteLine(q);

        //reference type
        Student s1 = new Student();
        s1.name = "Rasel";
        s1.cgpa = 3.59;

        Student s2 = s1;

        Console.WriteLine(s2.name);
        Console.WriteLine(s2.cgpa);

        s2.name = "Kibria";
        s2.cgpa = 3.50;

        Console.WriteLine(s1.name);
        Console.WriteLine(s1.cgpa);
    }
}


class Student
{
    public string name;
    public double cgpa;
}