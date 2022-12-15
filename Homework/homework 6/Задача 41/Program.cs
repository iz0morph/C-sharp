
Console.Write("Введите числа - ");
string x = Console.ReadLine();
string[] nums = x.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
int[] array = nums.Select(Int32.Parse).ToArray();

void Count(int[] col)
{
    int counter = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] > 0) counter++;
    }
    Console.WriteLine($"Количество чисел больше 0 - {counter}");
}

Count(array);