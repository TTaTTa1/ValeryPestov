// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
using System;
using System.Linq;

class Program
{
    static string[] CreateArray()
    {
        Console.Write("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[size];
        for (int i = 0; i < size; i += 1)
        {
            Console.Write($"Введите {i + 1} элемент массива: ");
#pragma warning disable CS8601 // Possible null reference assignment.
            array[i] = Console.ReadLine(); // Чтение ввода пользователя и присваивание значения элементу массива.
#pragma warning restore CS8601 // Possible null reference assignment.
        }
        return array; // Возвращение заполненного массива.
    }

    static void ShowArray(string[] array)
    {
        for (int i = 0; i < array.Length; i += 1)
            Console.Write(array[i] + " "); // Вывод элементов массива на консоль.
        Console.WriteLine();
    }

    static string[] ResultArray(string[] array)
    {
        int c = 0;
        int j = 0;
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i].Length <= 3) c += 1; // Подсчет количества элементов, длина которых меньше или равна 3 символам.
        }
        string?[] arrayRes = Enumerable.Repeat<string?>(null, c).ToArray(); // Создание массива с заданным количеством элементов и значениями null.
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i].Length <= 3)
            {
                arrayRes[j] = array[i]; // Присваивание элементов массива arrayRes значениями из массива array, если их длина меньше или равна 3 символам.
                j += 1;
            }
        }
        return Array.ConvertAll(arrayRes, x => x ?? string.Empty); // Преобразование массива string?[] в массив string[] и замена null на пустые строки.
    }

    static void Main()
    {
        string[] arrayFact = CreateArray(); // Создание массива с помощью метода CreateArray.
        Console.WriteLine();
        Console.WriteLine("Созданный массив:");
        ShowArray(arrayFact); // Вывод созданного массива на консоль.
        Console.WriteLine();
        string[] arrayRes = ResultArray(arrayFact); // Создание нового массива с помощью метода ResultArray.
        Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");
        ShowArray(arrayRes); // Вывод нового массива на консоль.
    }
}