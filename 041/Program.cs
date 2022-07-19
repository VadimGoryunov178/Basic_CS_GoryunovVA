// В Указанном массиве вещественных чисел найдите разницу 
//между максимальным и минимальным элементом
int N=8;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(1,136);


int max=0;
for(int i=0;i<a.Length;i++)
{
   if (a[i]>max)
    {
        max= a[i];
    }
}
int min=max;
for(int i=0;i<a.Length;i++)
{
    if (a[i]<min)
    {
        min=a[i];
    }
    
}
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
//System.Console.WriteLine();
System.Console.WriteLine($"\nМаксимальеое число:{max}");
System.Console.WriteLine($"Минимальное число:{min}");
System.Console.WriteLine($"Разница:{max-min}");