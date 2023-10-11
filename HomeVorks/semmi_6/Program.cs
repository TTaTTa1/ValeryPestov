﻿// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Task 41: The user enters M numbers from the keyboard.\n"
+"Count how many numbers greater than 0 the user entered.");
int[] EnterMultNumbers(string message)
{
    Console.Write(message);
    string[] input = Console.ReadLine().Split(' ');
    int M = input.Length;
    Console.WriteLine($"You enter {M} numbers");
    int[] numbers = new int[M];
    for (int i = 0; i < M; i++)
    {
        numbers[i] = Convert.ToInt32(input[i]);
    }
    return numbers;
}

int SumPositive (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] myArray = EnterMultNumbers($"Enter a few numbers separated by a space: ");
Console.WriteLine($"You enter {SumPositive(myArray)} numbers > 0");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Task 43: Write a program that finds the intersection point of two straight\n"
+"lines given by the equations y = k1 * x + b1, y = k2 * x + b2;\n"
+"the values b1, k1, b2 and k2 are set by the user.");

void IntersectionPoint (double b1, double k1, double b2, double k2)
{
    if (k1 == k2) Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> прямые не пересекаются.");
    else
    {
        double x = (b2 - b1)/(k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x:F1}; {y:f1}) с округлением до десятых");
    }
}

Console.Write("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint (b1, k1, b2, k2);