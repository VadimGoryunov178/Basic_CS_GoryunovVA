// Определить номер четверти плоскости, в которой находится
// точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
/* 1 способ 
Console.WriteLine("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());
if ((x==0 || y==0))
{
    Console.WriteLine("Точка лежит на оси");
} 
if ((x > 0) && (y > 0))
{
    Console.WriteLine("I четверть");
}
if ((x < 0) && (y > 0))
{
    Console.WriteLine("II четверть");
}
if ((x < 0) && (y < 0))
{
    Console.WriteLine("III четверть");
}
if ((x > 0) && (y < 0))
{
    Console.WriteLine("IV четверть");
}
*/
int Number(double x, double y)
{
if ((x > 0) && (y > 0)) return 1;
if ((x < 0) && (y > 0)) return 2;
if ((x < 0) && (y < 0)) return 3;
if ((x > 0) && (y < 0)) return 4;
return 0;
}
Console.WriteLine("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Number(x,y));