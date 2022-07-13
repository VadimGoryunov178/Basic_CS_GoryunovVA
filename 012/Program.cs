// С клавиатуры вводится целое число из  диапазона  [10, 99]. 
// Показать наибольшую цифру числа

int a;
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
int d1=a/10;
int d2=a%10;
int m=Math.Max(d1,d2);
Console.WriteLine(m);