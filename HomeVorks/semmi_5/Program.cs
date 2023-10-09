﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Task 34: Set an array filled with random positive three-digit numbers.\n" 
+"Write a program that will show the number of even numbers in the array.");

int[] CreateRandomArray1(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

void PrintArray1(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("] -> ");
}

int CounterEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Input array size: ");
int size1 = Convert.ToInt32(Console.ReadLine());
int[] myArray1 = CreateRandomArray1(size1);
PrintArray1(myArray1);
Console.WriteLine(CounterEvenNumbers(myArray1));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("Task 36: Set a one-dimensional array filled with random numbers.\n" 
+"Find the sum of the elements standing in odd positions.");

int[] CreateRandomArray2(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

int SumEvenPozition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2) sum += array[i];
    return sum;
}

Console.WriteLine("Input array size: ");
int size2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array minimal value: ");
int minValue2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array maximal value: ");
int maxValue2 = Convert.ToInt32(Console.ReadLine());

int[] myArray2 = CreateRandomArray2(size2, minValue2, maxValue2);
PrintArray1(myArray2);
Console.WriteLine(SumEvenPozition(myArray2));

