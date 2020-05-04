// Написать метод, возвращающий минимальное из трех чисел.

using System;

namespace GetMinimum
{
    class Program
    {
        static int GetMin(int a, int b, int c)
        {
            int min = a < b ? a : b;
            min = min < c ? min : c;
            return min;
        }

        static int GetNumber(string query)
        {
            Console.Write(query);
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int a = GetNumber("Введите первое число: ");
            int b = GetNumber("Введите второе число: ");
            int c = GetNumber("Введите третье число: ");
            Console.WriteLine($"Минимальное из них: {GetMin(a, b, c)}");
            Console.Read();
        }
    }
}
