// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

using System;

class Program
{
    static void Main()
    {
        // Задаем двумерный массив символов
        char[,] charArray = {
            {'H', 'e', 'l', 'l', 'o'},
            {'W', 'o', 'r', 'l', 'd'}
        };

        // Создаем строку из символов массива
        string resultString = new string(To1DArray(charArray));

        // Выводим результат
        Console.WriteLine(resultString);
    }

    static char[] To1DArray(char[,] charArray)
    {
        int rows = charArray.GetLength(0);
        int cols = charArray.GetLength(1);

        // Создаем одномерный массив символов
        char[] resultArray = new char[rows * cols];

        // Индекс для одномерного массива
        int index = 0;

        // Проходим по всем элементам массива и добавляем их в одномерный массив
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultArray[index++] = charArray[i, j];
            }
        }

        // Возвращаем одномерный массив символов
        return resultArray;
    }
}
