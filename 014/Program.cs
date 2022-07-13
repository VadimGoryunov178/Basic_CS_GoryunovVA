// С клавиатуры вводятся два числа a и b. 
//Выяснить, кратно ли число a числу b, если нет, 
//вывести остаток от деления a на b.

Console.WriteLine("Введите два числа");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int c=a/b;
if(c%2==0)
{
    Console.WriteLine("Числа кратны");
}
else
{
    Console.WriteLine($"Остаток от деления = {a/b} ");
}

