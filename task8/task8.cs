Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine()??"");
int i=2;
while (i<a)
{
   Console.Write($"{i}, "); 
   i += 2;
}
