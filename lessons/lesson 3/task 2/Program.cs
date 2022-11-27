Console.WriteLine("Введите координату x первой точки:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки:");
int y2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));

Console.WriteLine(result);