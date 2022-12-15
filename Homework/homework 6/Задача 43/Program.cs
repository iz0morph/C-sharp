Console.Write("Введите значение k1 - ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b1 - ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2 - ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2 - ");
int b2 = Convert.ToInt32(Console.ReadLine());

int[] arr = { k1, b1, k2, b2 };

void intersectPoint(int[] n)
{
    double mainDeterm = -k1 + k2;
    double det1 = -(-b1 + b2);
    double det2 = -(k1 * b2 - k2 * b1);
    if (mainDeterm == 0 && det1 == 0 && det2 == 0) Console.WriteLine("Прямые совпадают");
    else if (mainDeterm == 0) Console.WriteLine("Прямые параллельны");
    else
    {
        double x = det1 / mainDeterm;
        double y = det2 / mainDeterm;
        Console.WriteLine($"Координаты точки пересечения: ({x};{y})");
    }
}

intersectPoint(arr);