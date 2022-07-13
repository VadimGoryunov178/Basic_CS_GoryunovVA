// По двум заданным числам проверять является ли 
//одно квадратом другого. Используйте подпрограмму.

bool Check(int a, int b)
{
    return a*a==b || b*b==a;
}
int a=4;
int b=9;
if(Check(a,b))
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}

/*
// Основная программа
Sum(2,4);
int s=Sum(2,4); // Вызов подпрограммы
Console.WriteLine(s);
Pause();


// Сумма двух чисел (подпрограмма)
int Sum (int a, int b)
{
    // Тело подпрограммы
    return a+b;
}

void Pause()
{
    Console.ReadKey();
}
*/