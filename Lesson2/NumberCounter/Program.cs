// Написать метод подсчета количества цифр числа.

using System;

namespace NumberCounter
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

        static void Main(string[] args)
        {
            Console.Write("Введите целое число (Int32): ");
            try
            {
                Console.WriteLine($"Количество цифр в заданном числе: {GetDigitCount(int.Parse(Console.ReadLine()))}");
            }
            catch (Exception exn)
            {
                Console.WriteLine(exn.Message);
            }
            Console.Read();
        }
    }
}
