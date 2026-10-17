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


git init -b main
git add .
git commit -m "comm1"