﻿// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Task 64. Write a program that outputs all natural numbers in the range from N to 1.");

void SeriesNumbers(int number)
{
    if (number == 1) 
    {
        Console.Write($"{number}, ");
        return;
    }
    Console.Write($"{number}, ");
    SeriesNumbers(number - 1);
}

Console.WriteLine("Input N: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {num1} -> ");
SeriesNumbers(num1);
Console.WriteLine();
