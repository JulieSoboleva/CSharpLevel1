using System;
using System.IO;

namespace ArrayLib
{
    public static class MyArray
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
}
