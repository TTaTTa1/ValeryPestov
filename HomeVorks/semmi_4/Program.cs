﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int EnteringNumber (string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Degree (int num, int exponent)
{
    if (exponent == 0) return 1;
    else if (exponent == 1) return num;
    else
    {
        int result = num;
        for (int i =2; i <= exponent; i++) result *= num;
        return result;
    }
}

Console.WriteLine("Task 25: Write a loop that takes two numbers (A and B) as input\n"
+"and raises the number A to the natural power of B.");
int num1 = EnteringNumber("Enter a number: ");
int num2 = EnteringNumber("Enter a power: ");
if (num2 < 0) Console.WriteLine("This program does not calculate negative exponents");
else Console.WriteLine($"{num1}, {num2} -> {Degree(num1, num2)}");
Console.WriteLine();

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits (int number)
{
    number = Math.Abs(number);
    int result = number % 10;
    while (number / 10 > 0)
    {
        number /= 10;
        result += number % 10;
    }
    return result;
}

Console.WriteLine("Task 27: Write a program that accepts a number as input\n"
+"and outputs the sum of digits in the number.");
int num3 = EnteringNumber("Enter a number: ");
Console.WriteLine($"{num3} -> {SumOfDigits(num3)}");
Console.WriteLine();