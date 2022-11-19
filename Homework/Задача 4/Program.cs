Console.Write("Введите первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число - ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a>b)
{
    max=a;
}
    else
    {
         max=b;
    }
   
if (c>max) max=c;
Console.WriteLine($"Максимальное число - {max}");