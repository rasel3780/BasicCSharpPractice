using System.Data;

static void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b; 
    b = temp;
}

int a = 5;
int b = 10;
Console.WriteLine(a + "," + b);

Swap(ref a, ref b);
Console.WriteLine(a + "," + b);

string firstName = "Rasel";
string lastName = "Kibria";
Console.WriteLine(firstName + " " + lastName);

Swap(ref firstName, ref lastName);
Console.WriteLine(firstName + " " + lastName);
