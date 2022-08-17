// Определить являются ли введенные с клавиатуры символы 
//правильно записью целого числа. Вычислить сумму цифр 
//введенного числа

using System;
 
namespace SharpConsole
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Введите символы");
            string num = Console.ReadLine();
            int temp = 0;
            if (!Int32.TryParse(num, out temp))
                Console.WriteLine("Это не является целым числом");
            else {
                int sum = 0;
                foreach (char digit in num)
                    sum += digit - 48;
                    Console.WriteLine("Сумма введеных чисел");
                Console.WriteLine(sum);
            }
        }
    }
}