//  *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
// Хорошим называется число, которое делится на сумму своих цифр. 
// Реализовать подсчет времени выполнения программы, используя структуру DateTime.

using System;

namespace GoodNumbersCounter
{
    class Program
    {
        static int GetDigitCount(int number)
        {
            int counter = 0;
            while (number != 0)
            {
                counter++;
                number /= 10;
            }
            return counter;
        }

        static bool IsGood(int number)
        {
            int count = GetDigitCount(number);
            return number % count == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Идёт подсчёт количества \"хороших\" чисел в диапазоне от 1 до 1 000 000 000.\nОриентировочно, время ожидания не превысит двух минут...");
            DateTime start = DateTime.Now;
            int goodCounter = 0;
            for (int i = 1; i < 1000000000; i++)
                if (IsGood(i))
                    goodCounter++;
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Количество \"хороших\" чисел в диапазоне от 1 до 1 000 000 000: {goodCounter}");
            Console.WriteLine($"Время выполнения программы: {finish - start}");
            Console.Read();
        }
    }
}
