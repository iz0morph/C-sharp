void FillArray(int[,,] arr)
{
    int[] oneRow = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
    for (int i = 0; i < oneRow.Length; i++)
    {
        oneRow[i] = new Random().Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            while (oneRow[j] == oneRow[i])
            {
                oneRow[i] = new Random().Next(10, 100);
                j=0;
            }
        }
    }
    int count=0;
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                arr[x,y,z]=oneRow[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i}; {j}; {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Write("Певрое измерение массива - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе измерение массива - ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье измерение массива - ");
int v = Convert.ToInt32(Console.ReadLine());
int[,,] arr = new int[m, n, v];
FillArray(arr);
Console.WriteLine("Массив:");
PrintArray(arr);

