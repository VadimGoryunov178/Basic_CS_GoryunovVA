// С клавиатуры вводится строка разделенная точкой. /
//Подсчитать количество символов до точки
using System;
    string s = Console.ReadLine();
    int i = s.IndexOf('.');
 
    Console.WriteLine($"До точки {i}");
