/* 2. Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)**Добавьте обработку ситуации отсутствия файла на диске.
*/

using System;
using System.IO;

namespace StaticArray
{
    static class MyArray
    {
        static public int[] FormArray(int n, int min, int max)
        {
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(min, max);
            return arr;
        }

        static public int[] FormArray(string fileName)
        {
            if (!File.Exists(fileName))
                throw new Exception("Файл не найден.");

            int[] arr;
            using (StreamReader sr = new StreamReader(fileName))
            {
                //  Считываем количество элементов массива
                int N = int.Parse(sr.ReadLine());
                arr = new int[N];
                //  Считываем массив
                for (int i = 0; i < N; i++)
                    arr[i] = int.Parse(sr.ReadLine());
            }
            return arr;
        }

        static public void PrintArray(int[] arr)
        {
            string s = "";
            foreach (int v in arr)
                s += v + " ";
            Console.WriteLine(s);
        }

        static public int CountOfPairs(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (CheckCondition(arr[i], arr[i + 1]))
                    count++;
            }
            return count;
        }

        static bool CheckCondition(int a, int b)
        {
            return (a % 3 == 0 && b % 3 != 0) || (a % 3 != 0 && b % 3 == 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = MyArray.FormArray(20, -10000, 10001);
            MyArray.PrintArray(a);
            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3, = {MyArray.CountOfPairs(a)}");

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
