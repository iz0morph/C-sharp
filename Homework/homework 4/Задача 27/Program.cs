void sum(int a)
{
    int b = 0;
    int c = 0;
    while (a != 0)
    {
        c = a % 10;
        b = b + c;
        a = a / 10;
    }
    Console.WriteLine(b);
}
Console.WriteLine("Введите число - ");
int x = Convert.ToInt32(Console.ReadLine());
sum(x);
