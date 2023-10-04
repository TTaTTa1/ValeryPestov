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
