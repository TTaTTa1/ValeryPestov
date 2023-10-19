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

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Task 66. Write a program that finds the sum of natural elements in the range from M to N.");

int SumNumbers(int numN, int numM)
{
    if(numN == numM) return numN;
    else if (numN > numM)
    {
        return numN + SumNumbers(numN - 1, numM);
    }
    else return numM + SumNumbers(numN, numM - 1);
}

Console.WriteLine("Input N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {numM}; N = {numN} -> {SumNumbers(numN, numM)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n)

Console.WriteLine("Task 68. Write a program for calculating the Ackerman function using recursion.");

int Ackermann(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return Ackermann(m - 1, 1);
else return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.WriteLine("Введите значения m и n, где m и n > 0:");
int Ack1 = Convert.ToInt32(Console.ReadLine());
int Ack2 = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(Ack1, Ack2);
Console.WriteLine($"Ackermann({Ack1}, {Ack2}) = {result}");