// Определить номер четверти плоскости, в которой находится
// точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
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
