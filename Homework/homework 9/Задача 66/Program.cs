int Summ(int first, int end)
{
    if (first > end)
    {
        return 0;
    }
    else
    {
        return first + Summ(first + 1, end);
    }
}

Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write($"Cумма натуральных элементов в промежутке от {x} до {y}: ");
Console.WriteLine(Summ(x, y));