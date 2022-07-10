// Объявление переменных
// int a,b=0;
// double c;
// string s;
/* Многострочный комментарий
int a=2,b=3; // Операция присваивания
int s=a+b;
Console.WriteLine(a+"+"+b+"="+s); // склеивание строк
Console.WriteLine("{0}+{1}={2}",a,b,s); // строка форматирования
Console.WriteLine("{2}+{1}={0}",s,b,a);
Console.WriteLine($"{a}+{b}={s}"); // строка интерполяции
*/

// Вывести квадрат числа (Ввести с клавиатуры целое число и вывести квадрат этого числа на экран)

/*
int a;
int b;
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
b=a*a;
System.Console.WriteLine($"{a}^2={b}");
*/
// Для не целого числа
double a;
double b;
string? s;
s=Console.ReadLine();
a=Convert.ToDouble(s);
b=a*a;
System.Console.WriteLine($"{a}^2={b}");