void pow(double a, double b)
{
    double c = 1;
    if (b == 0) Console.WriteLine("Результат возведения в степень - 1");
    else
    {
    if (b>0)    //Возведение числа в положительную степень
     {
    for (int i = 1; i<=b; i++)
    {
        c=c*a;
    }
    }
    else //Возведение числа в отрицательную степень
    {
    for (int i = 1; i<=Math.Abs(b); i++)
    {
        c=c/a;
    }
    }
    Console.WriteLine($"Результат возведения в степень - {c}");
    }   
}
Console.Write("Введите число, которое нужно возвести в степень - ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите степень числа - ");
double y = Convert.ToDouble(Console.ReadLine());
pow(x,y);