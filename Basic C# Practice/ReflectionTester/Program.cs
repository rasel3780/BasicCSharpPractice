


using System.Reflection;

string path = @"E:\C# & .NET\BasicCSharpPractice\Basic C# Practice\ReflectionLib\bin\Debug\net8.0\ReflectionLib.dll";

Assembly assembly = Assembly.LoadFile(path);

Type[] types = assembly.GetTypes();

foreach(var type in assembly.GetTypes())
{
    Type t = type.GetInterface("IModule");

    if(t != null)
    {
        Console.WriteLine(type.Name);
    }
}

string input = Console.ReadLine();

foreach(var t in types)
{
    if(t.Name == input)
    {
        MethodInfo method = t.GetMethod("Start");
        ConstructorInfo constructor = t.GetConstructor(new Type[] { });
        object o = constructor.Invoke(new object[] { });
        method.Invoke(o, new object[] { });
    }

}