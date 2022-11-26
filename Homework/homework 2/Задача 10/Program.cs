Console.Write("Введите трехзначное число - ");
int a = Convert.ToInt32(Console.ReadLine());
if (a<1000 && a>99) //Проверка, что введенное число удовлетворяет условию задачи
{
    int num1 = (a/10)%10;
    Console.WriteLine(num1);
}
else Console.WriteLine("Введенное число не трехзначное");