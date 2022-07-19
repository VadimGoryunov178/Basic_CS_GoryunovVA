// Задать массив, заполнить случайными положительными 
//трёхзначными числами. Показать количество нечетных\четных 
//чисел
int N=8;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(99,1000);

int evenNum=0;
for(int i=0;i<a.Length;i++)
{
    if (a[i]%2==0)
    {
        evenNum++;
    }
}
int oddNum=0;
for(int i=0;i<a.Length;i++)
{
    if (a[i]%2>0)
    {
        oddNum++;
    }
}
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
//System.Console.WriteLine();
System.Console.WriteLine($"\nКоличество четных:{evenNum}");
System.Console.WriteLine($"Количество не четных:{oddNum}");
