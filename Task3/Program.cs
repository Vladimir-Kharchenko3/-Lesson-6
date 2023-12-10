// Задайте произвольную строку. Выясните, является ли она палиндромом.


using System;

class Program
{
    static void Main()
    {
        // Задаем произвольную строку
        string inputString = "A man, a plan, a canal, Panama";

        // Проверяем, является ли строка палиндромом
        bool isPalindrome = IsPalindrome(inputString);

        // Выводим результат
        if (isPalindrome)
        {
            Console.WriteLine("Строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом.");
        }
    }

    static bool IsPalindrome(string input)
    {
        // Удаляем из строки все символы, не являющиеся буквами
        string cleanedString = new string(input
            .ToLower()
            .ToCharArray()
            .Where(c => Char.IsLetter(c))
            .ToArray());

        // Сравниваем очищенную строку с ее инвертированной копией
        return cleanedString == new string(cleanedString.Reverse().ToArray());
    }
}
