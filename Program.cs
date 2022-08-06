using System;
using static System.Console;
Clear();

string[] startArray = { "hello", "2", "world", ":-)" }; // Задаем первоначальный массив из строк.
WriteLine($"Начальный массив: [{String.Join(", ", startArray)}]"); //Печатаем первоначальный массив.
WriteLine($"Окончательный массив: [{String.Join(", ", CreateArray3Symbols(startArray))}]"); //Печатаем окончательный массив.

// Метод, который считает количество элементов в первоначальном массиве, удовлетворяющих условиям задачи.
// Нужен для того, чтобы понять какой длины делать окончальный массив.
int CountElements(string[] array, int symbolsNumber) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= symbolsNumber)
        {
            count++;
        }
    }
    return count;
}

// Метод, который заполняет окончательный массив элементами, удовлетворяющий условиям задачи.
string[] CreateArray3Symbols(string[] array)
{
    int index = 0;
    string[] endArray = new string[CountElements(startArray, 3)]; // Используем метод, для определения длины окончательного массива.
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            endArray[index] = array[i];
            index++;
        }
    }
    return endArray;
}

