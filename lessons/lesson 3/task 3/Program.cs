Console.WriteLine("Число");
int a = Convert.ToInt32(Console.ReadLine());
if (a>0)
{
    for (int b=1; b<=a; b++)
    Console.WriteLine(Math.Pow(b,2));
}