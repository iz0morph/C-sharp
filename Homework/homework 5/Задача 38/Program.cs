void FillArray(double[] col, int n)
{
    for (int index = 0; index < n; index++)
    {
        col[index] = Convert.ToDouble(new Random().Next(-10000, 10001) / 100.0); ;
    }
}
void PrintArray(double[] col, int n)
{
    for (int position = 0; position < n - 1; position++)
    {
        Console.Write(col[position] + "; ");
    }
    Console.WriteLine(col[n - 1] + ".");
}

Console.Write("Введите кол-во элементов массива - ");
int x = Convert.ToInt32(Console.ReadLine());
double[] array = new double[x];
FillArray(array, x);
Console.Write("Исходный массив: ");
PrintArray(array, x);

double FindMin(double[] col, int n)
{
    double minNumber = col[0];
    for (int i = 1; i < n; i++)
    {
        if (col[i] < minNumber) minNumber = col[i];
    }
    Console.WriteLine($"Минимальное число массива: {minNumber}");
    return minNumber;
}

double FindMax(double[] col, int n)
{
    double maxNumber = col[0];
    for (int i = 1; i < n; i++)
    {
        if (col[i] > maxNumber) maxNumber = col[i];
    }
    Console.WriteLine($"Максимальное число массива: {maxNumber}");
    return maxNumber;
}


void Diff(double max, double min)
{
    double difference = max - min;
    Console.WriteLine($"Разность между макс. и мин. числом массива: {difference}");
}

//FindMin(array, x);
//FindMax(array, x);
Diff(FindMax(array, x), FindMin(array, x));