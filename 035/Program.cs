﻿//Написать программу замены элементов массива 
//на противоположные

int N=8;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
{
    a[i]=random.Next(-9,10);
}
int opposite=0;
for(int i=0;i<a.Length;i++)
opposite = a[i]*(-1);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
System.Console.WriteLine($"\nПротивоположно:{opposite}");
  
