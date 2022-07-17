// Обмен переменными двух значений
/*
int a =1;
int b =2;
Console.WriteLine($"a={a} b={b}"); // вывести чему равно a и b
// чтобы поменять местами на выходе значение а и b 
// нужно ввести третью переменную
int t=a;
a=b;
b=t;
Console.WriteLine($"a={a} b={b}");
*/
/*
void Swap(int a,int b) // подпрограмма передача по значению поэтому не меняет местами
{
    int t=a;
    a=b;
    b=t;  
}
int a =1;
int b =2;
Console.WriteLine($"a={a} b={b}");
Swap(a,b);
Console.WriteLine($"a={a} b={b}");
*/
/*
void Swap(ref int a,ref int b) // reference передача по ссылке поэтому не меняет местами
{
    int t=a;
    a=b;
    b=t;  
}
int a =1;
int b =2;
Console.WriteLine($"a={a} b={b}");
Swap(ref a,ref b);
Console.WriteLine($"a={a} b={b}");
*/

void Calculate(int a,int b, out int sum, out int sub) 
{
    sum = a+b;
    sub=a-b; 
}
int sum, sub;
Calculate(2,2, out sum, out sub);