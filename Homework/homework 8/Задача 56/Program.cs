void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 20);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindMinRow(int[,] arr)
{
    int summ = 0;
    int[] row = new int[arr.GetLength(0)];
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ += arr[i, j];
        }
        row[index] = summ;
        Console.WriteLine($"Сумма элементов {index} строки: {summ}");
        summ = 0;
        index++;
    }
    int indexOfMin = 0;
    for (index = 0; index < row.Length-1; index++)
    {
        if (row[indexOfMin] > row[index])
        {
            indexOfMin = index;
        }
    }
    Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {indexOfMin}");
}

Console.Write("Введите кол-во строк матрицы - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов матрицы - ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[m, n];

FillArray(table);
Console.WriteLine("Исходный массив:");
PrintArray(table);
FindMinRow(table);
