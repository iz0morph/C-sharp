void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-50, 50);
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

int[,] SortArray(int[,] arr)
{
    int a = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {

            if (arr[i, j] < arr[i, j + 1])
            {
                a = arr[i, j];
                arr[i, j] = arr[i, j + 1];
                arr[i, j + 1] = a;
                j = -1;
            }

        }
    }
    return arr;
}


Console.Write("Введите кол-во строк матрицы - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов матрицы - ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[m, n];

FillArray(table);
Console.WriteLine("Исходный массив:");
PrintArray(table);
Console.WriteLine("Новый массив:");
PrintArray(SortArray(table));