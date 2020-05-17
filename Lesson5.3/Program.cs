/* * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    Например:
    badc являются перестановкой abcd.
*/

using System;
using System.Collections.Generic;

namespace Lesson5
{
    class Program
    {
        static bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            foreach (char c in str2)
                if (!Contains(c, str1))
                    return false;

            Dictionary<char, int> letterCountsInStr1 = GetLetterAndThemCount(str1);
            Dictionary<char, int> letterCountsInStr2 = GetLetterAndThemCount(str2);
            foreach (KeyValuePair<char, int> pair in letterCountsInStr2)
                if (pair.Value != letterCountsInStr1[pair.Key])
                    return false;

            return true;
        }

        static bool Contains(char ch, string str)
        {
            foreach (char c in str)
                if (c == ch)
                    return true;
            return false;
        }

        static Dictionary<char, int> GetLetterAndThemCount(string str)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (char c in str)
                if (result.ContainsKey(c))
                    result[c]++;
                else
                    result.Add(c, 1);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            string str2 = Console.ReadLine();
            Console.WriteLine("\nСтроки " + (IsAnagram(str1.ToLower(), str2.ToLower()) ? "являются" : "не являются") + " анаграммой");
            Console.ReadLine();
        }
    }
}
