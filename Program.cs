//1
PrintHeader("otshet");
PrintHeader("itogi");
static void PrintLine()
{
    Console.WriteLine("^*_*^");
}
static void PrintHeader(string title)
{
    PrintLine();
    Console.WriteLine(title);
    PrintLine();
}
//2.1
Console.WriteLine(Max(3,7));
Console.WriteLine(Max(10,2));
Console.WriteLine(Max(-5,-1));
static int Max(int a, int b)
{
    return a > b ? a : b;
}
//2.2
Console.WriteLine(IsEven(4));
Console.WriteLine(IsEven(7));
Console.WriteLine(IsEven(0));
static bool IsEven(int a)
{
    return a % 2 == 0;
}
//3
int[] arr = { 120, 45, 300, 80, 15, 210 };
Console.WriteLine(Average(arr));
Console.WriteLine(CountGreater(arr, 100));
static double Average(int[] a)
{
    int s = 0;
    foreach (int x in a) s += x;
    return (double)s / a.Lenght;
}
static int CountGreater(int[] a, int limit)
{
    int c = 0;
    foreach(int x in a)
        if (x > limit) c++;
    return c;
}
//4
Console.WriteLine($"{0} C = {ToFahrenheit(0)} F");
Console.WriteLine($"{100} C = {ToFahrenheit(100)} F");
Console.WriteLine($"{27} C = {ToFahrenheit(37)} F");
static double ToFahrenheit(double a)
{
    return a * 9 / 5 +32;
}
//5







git init -b main
git add .
git commit -m "comm2"
git push