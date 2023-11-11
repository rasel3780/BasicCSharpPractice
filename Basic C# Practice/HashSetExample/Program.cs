HashSet<string> idNumber = new HashSet<string>();

idNumber.Add("18-37797-2");
idNumber.Add("18-37797-2"); //will be ignore since same value
idNumber.Add("18-37798-2");
idNumber.Add("18-37799-2");

foreach (string id in idNumber)
{
    Console.WriteLine(id);
}