void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
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

int[,] matrixXmatrix(int[,] arr, int[,] arr1)
{
    int[,] result = new int[arr.GetLength(0), arr1.GetLength(1)];
    int summ = 0;
    if (arr.GetLength(1) == arr1.GetLength(0))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                for (int a = 0; a < arr.GetLength(1); a++)
                {
                    summ += arr[i, a] * arr1[a, j];
                }
                result[i, j] = summ;
                summ = 0;
            }
        }
    }
    return result;
}

void PrintArray1(int[,] arr, int[,] arr1, int[,] arr2)
{
    if (arr.GetLength(1) == arr1.GetLength(0))
    {
        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                Console.Write($"{arr2[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    else Console.WriteLine("Матрицы не согласованные. Умножение невозможно");
}

Console.Write("Введите кол-во строк первой матрицы - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов первой матрицы - ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во строк второй матрицы - ");
int v = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов второй матрицы - ");
int w = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[m, n];
int[,] table1 = new int[v, w];

FillArray(table);
FillArray(table1);
Console.WriteLine("Матрица 1:");
PrintArray(table);
Console.WriteLine("Матрица 2:");
PrintArray(table1);
Console.WriteLine("Результат умножение матрицы 1 на матрицу 2:");
matrixXmatrix(table, table1);
PrintArray1(table, table1, matrixXmatrix(table, table1));