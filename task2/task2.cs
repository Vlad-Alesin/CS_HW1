Console.WriteLine("введите 2 числа");
int a = int.Parse(Console.ReadLine()??"");
int b = int.Parse(Console.ReadLine()??"");

if (a>b)
{
    Console.WriteLine($"max = {a}");
}
else 
{
    Console.WriteLine($"max = {b}");
}