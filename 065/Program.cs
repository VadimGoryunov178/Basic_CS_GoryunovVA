//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке 
//от M до N.

int n, m, s=0;
Console.Write("Введи первое число: ");
n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи последнее число: ");
m = Convert.ToInt16(Console.ReadLine());
for (int i = n; i <= m; i++)
    s += i;
Console.Write("Сумма чисел в заданном промежутке= ");
Console.WriteLine(s);