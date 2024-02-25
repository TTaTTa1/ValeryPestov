using System;

class Program
{
    static void Main(string[] args)
    {
        string[] array = CreateArray(); // Вызов функции CreateArray и сохранение результата в переменной array

        // Дальнейший код обработки массива
    }

    static string[] CreateArray()
    {
        // Локальная функция CreateArray, которая возвращает массив строк
        string[] array = new string[5];
        // Здесь можно заполнить массив или выполнить другие операции

        return array; // Возвращаем созданный массив
    }
}