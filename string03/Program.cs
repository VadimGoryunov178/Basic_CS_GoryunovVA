// С клавиатуры вводится строка разделенная точкой. /
//Подсчитать количество символов до точки
using System;
Console.WriteLine("Введите строку с точкой");
    string s = Console.ReadLine();
    int i = s.IndexOf('.');
 
    Console.WriteLine($"До точки {i} символов");