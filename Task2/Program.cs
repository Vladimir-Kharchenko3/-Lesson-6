//  Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку,
//   в которой все заглавные буквы заменены на строчные.


using System;

class Program
{
    static void Main()
    {
        // Задаем строку с латинскими буквами в обоих регистрах
        string originalString = "Hello World";

        // Формируем новую строку, заменяя заглавные буквы на строчные
        string modifiedString = ConvertToUpper(originalString);

        // Выводим результат
        Console.WriteLine(modifiedString);
    }

    static string ConvertToUpper(string inputString)
    {
        char[] charArray = inputString.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            // Если символ является заглавной буквой, заменяем его на строчную
            if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
        }

        // Возвращаем новую строку
        return new string(charArray);
    }
}
