//3. б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки

using System;
using ArrayLib;

namespace ArrayFromLib
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = MyArray.FormArray(20, -10000, 10001);
            MyArray.PrintArray(a);
            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3, = {MyArray.CountOfPairs(a)}");
            Console.WriteLine("");

            try
            {
                a = MyArray.FormArray("..//..//data.txt");
                MyArray.PrintArray(a);
                Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3, = {MyArray.CountOfPairs(a)}");
            }
            catch (Exception exn)
            {
                Console.WriteLine(exn.Message);
            }
            Console.ReadLine();
        }
    }
}
