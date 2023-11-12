int a = 10;
int b = 20;

SwapNum(ref a, ref b);
Console.WriteLine(a);
Console.WriteLine(b);

static void SwapNum(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}