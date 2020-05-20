/* Изменить программу вывода таблицы функции так, 
 * чтобы можно было передавать функции типа double (double, double). 
 * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x). */

using System;

namespace PrintTable
{
    public delegate double Fun(double x);
    public delegate double Func(double a, double x);

    class Program
    {
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static void Table(Func F, double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double Cube(double x)
        {
            return x * x * x;
        }

        public static double AxSquare(double a, double x)
        {
            return a * x * x;
        }

        public static double AsinX(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Таблица функции Cube:");
            Table(Cube, -2, 2);
            Console.WriteLine("Таблица функции Sin:");
            Table(Math.Sin, -2, 2);
            Console.WriteLine("Таблица функции x^2:");
            Table((x) => { return x * x; }, 0, 4);
            int a = 2;
            Console.WriteLine($"Таблица функции {a}*x^2:");
            Table(AxSquare, a, 2, a+4);
            Console.WriteLine($"Таблица функции {++a}*sin(x):");
            Table(AsinX, a, -2, 2);
            Console.ReadKey();
        }
    }
}
