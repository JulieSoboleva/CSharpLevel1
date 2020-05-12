/* 5.*а) Реализовать библиотеку с классом для работы с двумерным массивом. 
       Реализовать конструктор, заполняющий массив случайными числами. 
       Создать методы, которые возвращают сумму всех элементов массива, 
       сумму всех элементов массива больше заданного, 
       свойство, возвращающее минимальный элемент массива, 
       свойство, возвращающее максимальный элемент массива, 
       метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
    **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    **в) Обработать возможные исключительные ситуации при работе с файлами.
 */

using System;
using Array2DLib;

namespace Array2DTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Array2D arr = new Array2D(3, 5, 1, 100);
            arr.Print();
            Console.WriteLine("\nСумма всех элементов массива = " + arr.Sum());
            int limit = 5;
            Console.WriteLine($"\nСумма всех элементов массива больше {limit} = " + arr.SumMoreThan(limit));
            Console.WriteLine("\nМинимальный элемент массива = " + arr.Min);
            Console.WriteLine("\nМаксимальный элемент массива = " + arr.Max);
            int row, column;
            Console.WriteLine("\nПозиция максимального элемента в массиве (" + arr.MaxPosition(out row, out column) + "): строка " + row + ", столбец " + column);
            
            Console.WriteLine();
            string path = @"../../array2d.txt";
            try
            {
                arr.ArrayToFile(path);
                arr = new Array2D(path);
                arr.Print();
            }
            catch (Exception exn)
            {
                Console.WriteLine(exn.Message);
            }
            Console.ReadLine();
        }
    }
}
