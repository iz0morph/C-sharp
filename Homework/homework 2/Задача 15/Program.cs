Console.Write("Введите порядковый номер дня недели - ");
int a = Convert.ToInt32 (Console.ReadLine());
if (a==6 || a==7)
{
    Console.WriteLine("Данный день - выходной");
}
else
{
    if (a<6 && a>0) Console.WriteLine("Данный день НЕ выходной");
    else Console.WriteLine("Неверный номер дня недели");
}
