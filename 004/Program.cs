// По заданному с клавиатуры номеру дня недели 
// вывести его название
// 1 способ
/*
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("ERROR"); break;
}
*/
// 2 способ

Console.Write("Введите число: ");
//int dayOfWeek; //camelCase
//int DaeOfcase; // PasсalCase (название методов подимен классов)
double a = Convert.ToInt32(Console.ReadLine());
//dayOfWeek=int.Parse(Console.ReadLine());
if(a==1) Console.WriteLine("Пн");
if(a==2) Console.WriteLine("Вт");
if(a==3) Console.WriteLine("Ср");
if(a==4) Console.WriteLine("Чт");
if(a==5) Console.WriteLine("Пт");
if(a==6) Console.WriteLine("Сб");
if(a==7) Console.WriteLine("Вс");
else 
{
    Console.WriteLine("Такого дня не существует");
}


