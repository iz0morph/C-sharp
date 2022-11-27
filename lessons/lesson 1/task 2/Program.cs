Console.Write("Введите число - ");
int a=Convert.ToInt32(Console.ReadLine());
int b=(-a);
string c=Convert.ToString(b);
while(b<=a)
{
Console.Write($"{c}, ");
b=b+1;
c=Convert.ToString(b);
}