void FillArray(int[] collection, int n)
{
    int index=0;
    while (index<n)
    {
        collection [index]=new Random().Next();
        index++;
    }
}
void PrintArray(int[] col, int n)
{
    int count=n;
    int position=0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
Console.Write("Введите кол-во элементов массива - ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];
FillArray(array, x);
PrintArray(array, x);