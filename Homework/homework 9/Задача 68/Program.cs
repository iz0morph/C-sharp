int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    else
    {
        Console.WriteLine("Одно или два из введенных значений отрицательны");
        return 0;
    }
}
Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Результат вычисления функции Аккермана А({m},{n}) = ");
Console.WriteLine(Akkerman(m, n));