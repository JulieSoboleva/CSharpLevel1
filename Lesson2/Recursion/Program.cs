// a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
// б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

using System;

namespace Recursion
{
    class Program
    {
        static int GetNumber(string query)
        {
            Console.Write(query);
            return int.Parse(Console.ReadLine());
        }

        static void Loop(int a, int b)
        {
            Console.Write("{0,4} ", a);
            if (a < b)
                Loop(a + 1, b);
        }

        static int LoopSumm(int a, int b)
        {
            if (a <= b)
            {
                int res = a + LoopSumm(a + 1, b);
                Console.Write("{0,4} ", res);
                return res;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            int A = GetNumber("Введите меньшее число: ");
            int B = GetNumber("Введите большее число: ");

            Loop(A, B);
            Console.WriteLine("\n");
            LoopSumm(A, B);
            Console.Read();
        }
    }
}
