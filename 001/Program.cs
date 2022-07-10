// Объявление переменных
// int a,b=0;
// double c;
// string s;
int a=2,b=3;
int s=a+b;
Console.WriteLine(a+"+"+b+"="+s); // склеивание строк
Console.WriteLine("{0}+{1}={2}",a,b,s); // строка форматирования
Console.WriteLine("{2}+{1}={0}",s,b,a);
Console.WriteLine($"{a}+{b}={s}"); // строка интерполяции
