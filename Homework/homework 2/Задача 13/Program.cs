Console.Write("Введите любое число - ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>99)
{
    while (a>999)
    {
        a = a/10;
    }
    int num = a%10;
    Console.WriteLine($"Третья цифра - {num}");
}
else Console.WriteLine("Третьей цифры нет");