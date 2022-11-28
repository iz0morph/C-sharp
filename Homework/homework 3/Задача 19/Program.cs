Console.WriteLine("Введите пятизначное число - ");
int a = Convert.ToInt32(Console.ReadLine());
while (a<10000)
{
    Console.WriteLine("Ошибка. Введите пятизначное число - ");
    a = Convert.ToInt32(Console.ReadLine());
}
int[]numbers =new int[5];
int i = 4;
while (i>=0)
{
    numbers[i]=a%10;
    a=a/10;
    i=i-1;    
}
if (numbers[4]==numbers[0] && numbers[3]==numbers[1])
{
    Console.WriteLine("Число является палиндромом");
}
else Console.WriteLine("Число НЕ является палиндромом");