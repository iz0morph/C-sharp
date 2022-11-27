Console.Write("Введите координаты точки - ");
int x = Convert.ToInt32(Console.ReadLine());

int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0) Console.Write("Первая четверть");
else 

    if (x<0 && y>0) Console.Write("Вторая");

else if (x<0 && y<0) Console.Write("Третья");
else if (x>0 && y<0) Console.Write("Четвертая");
else if (x==0 || y==0) Console.Write("Ошибка");
