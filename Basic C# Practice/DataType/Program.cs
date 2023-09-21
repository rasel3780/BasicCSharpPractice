#region Integer Types
Console.WriteLine($"sbyte range form {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"byte range form {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"short range form {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"ushort range form {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"int range form {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"uint range form {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"long range form {long.MinValue} to {long.MaxValue}");
Console.WriteLine($"ulong range form {ulong.MinValue} to {ulong.MaxValue}");

byte centuries = 20;
ushort years = 2023;
uint days = 73040;
ulong hours = 174542321;

Console.WriteLine($"Centuries {centuries}, Years {years}, Days {days}, Hours {hours}");
Console.WriteLine("-------------------------------------------------------");
#endregion

# region Floating Point Types
Console.WriteLine($"float range form {float.MinValue} to {float.MaxValue}");
Console.WriteLine($"double range form {double.MinValue} to {double.MaxValue}");
Console.WriteLine($"decimal range form {decimal.MinValue} to {decimal.MaxValue}");

float num1 = 0.123456789f;
double num2 = 0.123456789123456789123;
decimal num3 = 0.123456789123456789123456789123456789m;

Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);
Console.WriteLine(0.0f/0.0f);
Console.WriteLine(-0.1f/0.0f);
Console.WriteLine(0.1f / 0.0f);
#endregion