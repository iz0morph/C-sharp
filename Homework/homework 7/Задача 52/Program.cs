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

double[] AverageInColumn(int[,] arr)
{
    double summInColumn = 0;
    double[] result = new double[arr.GetLength(1)];
    int a = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            summInColumn += arr[i, j];
        }
        result[a] = Math.Round((summInColumn / arr.GetLength(1)), 2);
        a++;
        summInColumn = 0;
    }
    return result;
}

void PrintAverageInColumn(double[] arr)
{
    Console.WriteLine("Cреднее арифметическое элементов в каждом столбце:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
    Console.WriteLine();
}

Console.Write("Введите кол-во строк матрицы - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов матрицы - ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[m, n];

FillArray(table);
Console.WriteLine("Исходный массив:");
PrintArray(table);
AverageInColumn(table);
PrintAverageInColumn(AverageInColumn(table));
