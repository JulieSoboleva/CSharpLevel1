// Дописать структуру Complex, добавив метод вычитания комплексных чисел. 
// Продемонстрировать работу структуры;

using System;

namespace StructComplex
{
    struct Complex
    {
        double re;
        double im;

        public Complex(double _re, double _im)
        {
            re = _re;
            im = _im;
        }

        public Complex Plus(Complex x)
        {
            return new Complex(re + x.re, im + x.im);
        }

        public Complex Minus(Complex x)
        {
            return new Complex(re - x.re, im - x.im);
        }

        public Complex Multi(Complex x)
        {
            return new Complex(re * x.re - im * x.im, re * x.im + im * x.re);
        }

        public string ToString()
        {
            return "(" + re + "+" + im + "i)";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(8, 3);
            Complex complex2 = new Complex(6, 2);

            Console.WriteLine(complex1.ToString() + " + " + complex2.ToString() + " = " + complex1.Plus(complex2).ToString());
            Console.WriteLine(complex1.ToString() + " - " + complex2.ToString() + " = " + complex1.Minus(complex2).ToString());
            Console.WriteLine(complex1.ToString() + " * " + complex2.ToString() + " = " + complex1.Multi(complex2).ToString());
            Console.ReadLine();
        }
    }
}
