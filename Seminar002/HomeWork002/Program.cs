﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void FindTD (int n1)
{
   while (n1 >= 999)
   {
    n1/=10;
   }
   if (n1 < 100 && n1 > -100)
   {
    Console.WriteLine("Отсутствует третье число");
   }
    else 
    {n1 = n1 % 10;
    Console.WriteLine($"Третье число: {Math.Abs(n1)}");
    }
}

Console.Write("Введите число: ");
FindTD(int.Parse(Console.ReadLine() ?? "0"));