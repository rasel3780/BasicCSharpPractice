

Student s1 = new Student();
s1.name = "Rasel";
s1.cgpa = 3.50;

Console.WriteLine("Before Passing");
Console.WriteLine(s1.name);
Console.WriteLine(s1.cgpa);

Console.WriteLine("After method calling");
ChangeTheStudentInfo(s1);
Console.WriteLine(s1.name);
Console.WriteLine(s1.cgpa);

static void ChangeTheStudentInfo(Student student)
{
    student.name = "Kibria";
    student.cgpa = 3.60;
}
class Student
{
    public string name;
    public double cgpa;
}

