List<string> nameList = new List<string>();

nameList.Add("Rasel");
nameList.Add("Kibria");
nameList.Add("Rahib");
nameList.Add("Kibria");
nameList.Add("Asif");
nameList.Add("Pranto");
nameList.Add("Sajib");

static void printName(List<string> names)
{
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
    Console.WriteLine();
}

printName(nameList);

nameList.Remove("Kibria");
printName(nameList);

nameList[3] = "kawser";
printName(nameList);