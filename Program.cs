﻿/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.WriteLine("введите число N");
int userNumber = Convert.ToInt32(Console.ReadLine());
printRage(userNumber);

void printRage(int N)
{
    if (N == 0)
    {
        return;
    }
    printRage(N - 1);
    Console.Write($"{N},  ");
}