Console.Write("Введите кол-во строк матрицы - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов матрицы - ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] table = new double[m, n];

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToDouble(new Random().Next(-10000, 10001) / 100.0);;
        }
    }
}


void PrintArray(double[,] arr)
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

FillArray(table);
Console.WriteLine("Исходный массив:");
PrintArray(table);