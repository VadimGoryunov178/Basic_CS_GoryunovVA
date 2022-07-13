// Дано число больше 9. Вывести на экран  вторую цифру числа 
// с конца
int a=Convert.ToInt32(Console.ReadLine());
if(a>9)
{ //1234
    int b=a/10;
    int c=b%10;
    System.Console.WriteLine(c);
}
else
{
    Console.WriteLine("Ошибка.Число меньше 9");
}