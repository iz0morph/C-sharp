Console.Write("Введите любое целое число - ");
int a = Convert.ToInt32(Console.ReadLine());
int b =Math.Abs(a);
if (b>99)
{
    while (b>999)
    {
        b = b/10;
    }
    int num = b%10;
    Console.WriteLine($"Третья цифра - {num}");
}
else Console.WriteLine("Третьей цифры нет");