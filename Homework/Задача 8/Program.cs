Console.Write("Введите число - ");
int a = Convert.ToInt32(Console.ReadLine());
int b=2;
string c=Convert.ToString(b);
if (a<0)
{
    Console.WriteLine("Введенное число - отрицательное!!!");
}
else{
    Console.Write($"Список четных чисел от 1 до {a} включительно: ");
    while (b<a)
    {
    Console.Write($"{c}, ");
    b=b+2;
    c=Convert.ToString(b);
    }
    Console.WriteLine(a);
}
