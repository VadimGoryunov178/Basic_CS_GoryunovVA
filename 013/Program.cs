// Удалить вторую цифру целого числа введенного с клавиатуры.

int a;
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.WriteLine($"{a/10}");
