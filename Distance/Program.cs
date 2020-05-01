//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
//Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
//б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

using System;

namespace Distance
{
    class Point
    {
        readonly double X;
        readonly double Y;

        public Point(string strPoint)
        {
            strPoint = strPoint.Trim();
            string[] xy = strPoint.Split(',');
            X = double.Parse(xy[0]);
            Y = double.Parse(xy[1]);
        }

        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
    }
    class Program
    {
        private 
        static void Main(string[] args)
        {
            Console.Write("Введите координаты первой точки в формате X, Y > ");
            Point pnt1 = new Point(Console.ReadLine());
            Console.Write("Введите координаты второй точки в формате X, Y > ");
            Point pnt2 = new Point(Console.ReadLine());
            Console.WriteLine("\nРасстояние между точками = {0:f2}", Point.Distance(pnt1, pnt2));
            Console.Read();
        }
    }
}
