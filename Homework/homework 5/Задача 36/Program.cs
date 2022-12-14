void FillArray(int[] col, int n)
{
    for (int index = 0; index < n; index++)
    {
        col[index] = new Random().Next(-100, 101);
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

void Summ(int[] col, int n)
{
    int sum = 0;
    for (int index = 1; index < n; index += 2)
    {
        sum = sum + col[index];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных индексах - {sum}");
}
Summ(array, x);