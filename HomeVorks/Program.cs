﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Задача 1(10). Получение второй цифры числа.");

int Vvod (string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(System.Console.ReadLine());
    return num;
}

int SecondRank(int num1) // getting the second digit in a number (получение второй цифры в числе)
{
    int num2 = num1 / 10 % 10;
    return num2;
}

bool ThreeDigitVerification (int num4) // checking a number for three digits (проверка числа на трехзначность)
{
      if (num4 < 100 || num4 > 1000) return false;
      else return true;
}

int number1 = Vvod("Введите трехзначное число: ");
if (ThreeDigitVerification (number1))
     System.Console.WriteLine($"Вторая цифра вашего числа: {SecondRank(number1)}");
else System.Console.WriteLine("Извините, вы ввели неправильное число");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Задача 2(13). Вывод третьей цифры числа.");

int ThirdRank (int num3) // getting the third digit in a number (получение третьей цифры в числе)
{
      while (num3 > 999) num3 /= 10; // reducing the number to three digits (редуцируем число до трехзначного)
      return num3 %= 10;
}

int num5 = Vvod("Введите число: ");
if (num5 > 99) System.Console.WriteLine($"Третья цифра: {ThirdRank(num5)}");
else System.Console.WriteLine("В вашем числе нет третьей цифры");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Задача 3(15). Определение уикэнда по номеру дня недели.");

void CheckForWeekend(int num6)
{
     if (num6 >= 1 && num6 <= 7)
     {
          if(num6 == 7 || num6 == 6) System.Console.WriteLine("Это выходной день.");
          else System.Console.WriteLine("Нет. Это не выходной день.");
     }
     else System.Console.WriteLine("Извините, вы ввели неправильную цифру.");
}

int num7 = Vvod ("Введите номер дня недели от 1 до 7: ");
CheckForWeekend(num7);


/ Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
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