Console.Write("Введите число - ");
int a = Convert.ToInt32(Console.ReadLine());
while (a<2)
{
    Console.Write("Введите ПОЛОЖИТЕЛЬНОЕ число >1 - ");
    a = Convert.ToInt32(Console.ReadLine());
}
for (int b=1; b<=a; b++)
    {
        Console.WriteLine($"Куб числа {b} = {Math.Pow(b,3)}");
    }