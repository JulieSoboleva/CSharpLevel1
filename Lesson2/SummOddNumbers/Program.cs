// С клавиатуры вводятся числа, пока не будет введен 0. 
// Подсчитать сумму всех нечетных положительных чисел.

using System;

namespace SummOddNumbers
{
    class Program
    {
        static bool IsOdd(int number) => number % 2 != 0;

        static void Main(string[] args)
        {
            int summ = 0;
            Console.WriteLine("Вводите целые положительные числа. Для окончания введите 0."); 
            int current = int.Parse(Console.ReadLine());
            while(current != 0)
            {
                if (IsOdd(current))
                    summ += current;
                current = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Сумма нечётных чисел = {summ}");
            Console.Read();
        }
    }
}
