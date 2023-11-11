Dictionary<string, double> salary = new Dictionary<string, double>();

salary.Add("emp-001", 5000.00);
salary.Add("emp-002", 5500.00);
salary.Add("emp-003", 5100.00);
salary.Add("emp-004", 5200.00);

string outputFormate = "{0,-10} \t {1, 5}";
Console.WriteLine(string.Format(outputFormate, "Employe code", "Salary"));

foreach (KeyValuePair<string, double> codeSalary in salary)
{
    Console.WriteLine(string.Format(outputFormate, codeSalary.Key, codeSalary.Value));
}
//without formatting
Console.WriteLine();
foreach (KeyValuePair<string, double> codeSalary in salary)
{
    Console.WriteLine(codeSalary);
}