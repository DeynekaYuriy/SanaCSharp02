﻿int value;
Console.Write("Enter value a[0;9]: ");
while (!int.TryParse(Console.ReadLine(), out value) || value < 0 || value > 9)
{
    Console.Write("Invalid value, Try again: ");
}
switch (value)
{
    case 0: Console.Write("Нуль"); break;
    case 1: Console.Write("Один"); break;
    case 2: Console.Write("Два"); break;
    case 3: Console.Write("Три"); break;
    case 4: Console.Write("Чотири"); break;
    case 5: Console.Write("П'ять"); break;
    case 6: Console.Write("Шість"); break;
    case 7: Console.Write("Сім"); break;
    case 8: Console.Write("Вісім"); break;
    case 9: Console.Write("Дев'ять"); break;
}