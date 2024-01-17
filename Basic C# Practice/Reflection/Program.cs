using Reflection;
using System.Reflection;

string className = Console.ReadLine();
string propertyName = Console.ReadLine();
string propertyValue = Console.ReadLine();

Assembly assembly = Assembly.GetExecutingAssembly();
Type type = assembly.GetType(className);

PropertyInfo property = type.GetProperty(propertyName);
ConstructorInfo constructor = type.GetConstructor(new Type[] { });

object instance = constructor.Invoke(new object[] { });
property.SetValue(instance, propertyValue);

Person person = instance as Person;
Console.WriteLine(person.Name);