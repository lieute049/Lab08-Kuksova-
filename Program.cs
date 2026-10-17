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
Console.WriteLine(Factorial(5));
for (int i = 2; i <= 50; i++)
    if (IsPrime(i)) Console.Write($"{i}");
Console.WriteLine();
static long Factorial(int c)
{
    long r = 1;
    for (int i = 2; i <= c; i++) r *= i;
    return r;
}
static bool IsPrime(int c)
{
    if (c<2) return false;
    for (int i = 2; i * i <= c; i ++)
        if (c % i == 0) return false;
    return true; 
}
//6
int a1 = ReadPositive("number 1:");
int a2 = ReadPositive("number 2:");
Console.WriteLine($"summa: {a1+a2}");
static int ReadPositive (string message)
{
    int n ;
    do 
    {
        Console.Write(message);
        n = Convert.ToInt32(Console.ReadLine());
    } while(n<=0);
    return n;
}
//Итоговая задача. «Меню-калькулятор»
int choice;
do
{
    Console.WriteLine("1 - summa");
    Console.WriteLine("2 maximum");
    Console.WriteLine("3 factorial");
    Console.WriteLine("4 exit");
    Console.Write("choice is: ");
    choice = Convert.ToInt32(Console.ReadLine());
    switch(choice)
    {
        case 1:
            int x = ReadPositive("a: ");
            int y = ReadPositive("b: ");
            Console.WriteLine($"summa: {x + y}");
            break;
        case 2:
            Console.WriteLine($"maximum: {Max(ReadPositive("a: "), ReadPositive("b: "))}");
            break;
        case 3:
            Console.WriteLine($"factorial: {factorial(ReadPositive("n: "))}");
            break;
        case 4:
        default:
            Console.WriteLine("takogo net")
            break;
    }
} while (choice != 4);





