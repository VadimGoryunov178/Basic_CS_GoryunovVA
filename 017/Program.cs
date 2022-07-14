// Дано число обозначающее день недели. 
// Выяснить является номер дня недели выходным

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1: Console.WriteLine("Понедельник - Будни"); break;
    case 2: Console.WriteLine("Вторник - Будни"); break;
    case 3: Console.WriteLine("Среда - Будни"); break;
    case 4: Console.WriteLine("Четверг - Будни"); break;
    case 5: Console.WriteLine("Пятница - Будни"); break;
    case 6: Console.WriteLine("Суббота  - Выходной"); break;
    case 7: Console.WriteLine("Воскресенье - Выходной"); break;
    default: Console.WriteLine("ERROR"); break;
}