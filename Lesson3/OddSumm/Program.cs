// а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
//    Требуется подсчитать сумму всех нечетных положительных чисел. 
//    Сами числа и сумму вывести на экран, используя tryParse;
// б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
//    При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;

using System;

namespace OddSumm
{
    class Program
    {
        static bool IsOdd(int number) => number % 2 != 0;

        static int GetNumber()
        {
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
                return number;
            throw new Exception("Ошибка! Введено не число");
        }

        static void Main(string[] args)
        {
            int summ = 0;
            int current = 2;
            Console.WriteLine("Вводите целые положительные числа.\nДля окончания подсчёта суммы нечётных чисел введите 0.");
            do
            {
                try
                {
                    current = GetNumber();
                    if (IsOdd(current) && current > 0)
                        summ += current;
                }
                catch (Exception exn)
                {
                    Console.WriteLine(exn.Message);
                    Console.WriteLine("Вводите целые положительные числа");
                }
            }
            while (current != 0);

            Console.WriteLine($"Сумма нечётных чисел = {summ}");
            Console.ReadLine();
        }
    }
}
