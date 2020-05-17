/* Создать программу, которая будет проверять корректность ввода логина.
   Корректным логином будет строка от 2 до 10 символов, 
   содержащая только буквы латинского алфавита или цифры, 
   при этом цифра не может быть первой:
    а) без использования регулярных выражений;
    б) с использованием регулярных выражений.
*/

using System;
using System.Text.RegularExpressions;


namespace Lesson5
{
    class Program
    {
        static string GetAnswer(string query)
        {
            Console.Write(query);
            return Console.ReadLine();
        }

        static bool IsLatin(char ch)
        {
            return (ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z');
        }

        static bool IsCorrect(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            if (s.Length < 2 || s.Length > 10)
                return false;

            if (!IsLatin(s[0]))
                return false;

            for (int i=1; i < s.Length; i++)
                if (!char.IsDigit(s[i]) && !IsLatin(s[i]))
                    return false;

            return true;
        }

        static bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            if (s.Length < 2 || s.Length > 10)
                return false;

            return Regex.IsMatch(s, @"^[A-Za-z]+[A-Za-z0-9]*$");
        }

        static void Main(string[] args)
        {
            string s;
            do { s = GetAnswer("Введите логин > "); }
            while (!IsValid(s)); //(!IsCorrect(s));
            Console.WriteLine("Логин корректный.");
            Console.ReadLine();
        }
    }
}
