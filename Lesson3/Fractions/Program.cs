//  *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
//  Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
//  Написать программу, демонстрирующую все разработанные элементы класса. 
//  ** Добавить проверку, чтобы знаменатель не равнялся 0. 
//  Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
//  Добавить упрощение дробей.

using System;

namespace Fractions
{
    class Fraction
    {
        int numerator;      // числитель дроби
        int denominator;    // знаменатель дроби

        public Fraction(int _numerator, int _denominator)
        {
            numerator = _numerator;
            if (_denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0");
            denominator = _denominator;
        }

        /// <summary>
        /// Наименьшее общее кратное для знаменателей дробей
        /// </summary>
        public int NOK(Fraction x)
        {
            for (int i = 0; i < (denominator * x.denominator + 1); i++)
            {
                if (i % x.denominator == 0 && i % denominator == 0)
                {
                    if (i != 0)
                        return i;
                }
            }
            return denominator;
        }

        /// <summary>
        /// Наибольший общий делитель для числителя и знаменателя дроби
        /// </summary>
        public int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        /// <summary>
        /// Упрощение дроби
        /// </summary>
        public Fraction Simplify()
        {
            int nod = NOD(numerator, denominator);
            return new Fraction(numerator / nod, denominator / nod);
        }

        public Fraction Plus(Fraction x)
        {
            int nok = NOK(x);
            return new Fraction(numerator * nok/denominator + x.numerator * nok/x.denominator, nok);
        }

        public Fraction Minus(Fraction x)
        {
            int nok = NOK(x);
            return new Fraction(numerator * nok / denominator - x.numerator * nok / x.denominator, nok);
        }

        public Fraction Multi(Fraction x)
        {
            return new Fraction(numerator * x.numerator, denominator * x.denominator);
        }

        public Fraction Division(Fraction x)
        {
            return Multi(new Fraction(x.denominator, x.numerator));
        }

        public bool IsWhole (out int whole)
        {
            if (numerator % denominator == 0)
            {
                whole = numerator / denominator;
                return true;
            }
            whole = 0;
            return false;
        }

        public string ToString()
        {
            return (denominator < 0) ? "-" + numerator + "/" + (-denominator) : numerator + "/" + denominator;
        }
    }

    class Program
    {
        static int GetNumber(string query)
        {
            Console.Write(query);
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            try
            {
                int num = GetNumber("Введите числитель первой дроби: ");
                int denom = GetNumber("Введите знаменатель первой дроби: ");
                Fraction f1 = new Fraction(num, denom);
                num = GetNumber("Введите числитель второй дроби: ");
                denom = GetNumber("Введите знаменатель второй дроби: ");
                Fraction f2 = new Fraction(num, denom);

                int whole;
                Fraction result = f1.Plus(f2).Simplify();
                Console.WriteLine(f1.ToString() + " + " + f2.ToString() + " = " + (result.IsWhole(out whole) ? whole.ToString() : result.ToString()));
                result = f1.Minus(f2).Simplify();
                Console.WriteLine(f1.ToString() + " - " + f2.ToString() + " = " + (result.IsWhole(out whole) ? whole.ToString() : result.ToString()));
                result = f1.Multi(f2).Simplify();
                Console.WriteLine(f1.ToString() + " * " + f2.ToString() + " = " + (result.IsWhole(out whole) ? whole.ToString() : result.ToString()));
                result = f1.Division(f2).Simplify();
                Console.WriteLine(f1.ToString() + " : " + f2.ToString() + " = " + (result.IsWhole(out whole) ? whole.ToString() : result.ToString()));
            }
            catch (Exception exn)
            {
                Console.WriteLine(exn.Message);
            }
            Console.ReadLine();
        }
    }
}
