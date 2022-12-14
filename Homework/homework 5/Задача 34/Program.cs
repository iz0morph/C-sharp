void FillArray(int[] col, int n)
{
    for (int index = 0; index < n; index++)
    {
        col[index] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] col, int n)
{
    for (int position = 0; position < n - 1; position++)
    {
        Console.Write(col[position] + "; ");
    }
    Console.WriteLine(col[n - 1] + ".");
}

Console.Write("Введите кол-во элементов массива - ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];
FillArray(array, x);
Console.Write("Исходный массив: ");
PrintArray(array, x);

void Meter(int[] col, int n)
{
    int count = 0;
    for (int index = 0; index < n; index++)
    {
        if (col[index] % 2 == 0) count += 1;
    }
    Console.WriteLine($"Количество четных чисел в массиве - {count}");
}
Meter(array, x);