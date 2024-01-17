using Reflection1;
using System.Reflection;

string className = Console.ReadLine();
string propertyName = Console.ReadLine();
string propertyValue = Console.ReadLine();

Assembly assembly = Assembly.GetExecutingAssembly();
Type type = assembly.GetType(className);

PropertyInfo property = type.GetProperty(propertyName);
ConstructorInfo constructor = type.GetConstructor(new Type[] {typeof(int)});

object instance = constructor.Invoke(new object[] {20 });
property.SetValue(instance, propertyValue);

foreach(var p in type.GetProperties(BindingFlags.Instance| BindingFlags.Public | BindingFlags.NonPublic))
{
    Console.WriteLine($"{p.Name}: {p.GetValue(instance)}");
}