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