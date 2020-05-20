/* Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
 а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
    Использовать массив(или список) делегатов, в котором хранятся различные функции.
 б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.
    Пусть она возвращает минимум через параметр(с использованием модификатора out). */

using System;
using System.IO;

namespace MinFunction
{
    public delegate double Func(double x);

    class Program
    {
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static void SaveFunc(string fileName, Func func, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(func(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            long N = fs.Length / sizeof(double);
            double d;
            double[] arrD = new double[N];
            for (int i = 0; i < N; i++)
            {
                d = bw.ReadDouble();
                if (d < min) 
                    min = d;
                arrD[i] = d;
            }
            bw.Close();
            fs.Close();
            return arrD;
        }

        static bool GetPositiveNumber(string query, int maxValue, out int n)
        {
            Console.WriteLine(query);
            if (!int.TryParse(Console.ReadLine(), out n))
                return false;
            return n > 0 && n <= maxValue;
        }

        static bool GetDouble(string query, out double n)
        {
            Console.Write(query);
            return double.TryParse(Console.ReadLine(), out n);
        }

        static string ToString(double[] arr)
        {
            string s = "";
            foreach (double d in arr)
                s += d + ", ";
            return s;
        }

        static void Main(string[] args)
        {
            int i;
            while (!GetPositiveNumber("Выберите функцию из списка и введите её номер:\n1) y = sin(x)\n2) y = cos(x)\n3) y = x^2 - 50*x + 10\n4) y = x^3\n5) y = 2*x - 5", 5, out i));
            Func[] functions = new Func[5] { (x) => { return Math.Sin(x); }, (x) => { return Math.Cos(x); }, F, (x) => { return x * x * x; }, (x) => { return 2 * x - 5; }};
            double a;
            while (!GetDouble("Введите нижнюю границу аргумента области определения min  > ", out a));
            double b;
            while (!GetDouble("Введите верхнюю границу аргумента области определения min > ", out b)) ;
            double h;
            while (!GetDouble("Введите величину шага > ", out h)) ;
            SaveFunc("..//..//data.bin", functions[--i], a, b, h);
            double minF;
            double[] allF = Load("..//..//data.bin", out minF);
            Console.WriteLine("Минимальное значение функции на заданном отрезке: " + minF);
            Console.WriteLine($"\nВсе значения функции на отрезке [{a}, {b}] с шагом {h}:\n" + ToString(allF));
            Console.ReadKey();
        }
    }
}
