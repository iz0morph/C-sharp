int PrintNumbers(int first, int end)
{
    if (end == 0)
    {
        return 0;
    }
    else
    {
        Console.Write(end + " ");
        return PrintNumbers(first, end - 1);
    }
}


Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
PrintNumbers(1, x);
Console.WriteLine();
