/* 1. Дан  целочисленный  массив  из 20 элементов.  
   Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
   Заполнить случайными числами.  
   Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
   В данной задаче под парой подразумевается два подряд идущих элемента массива.
   
   3. а) Дописать класс для работы с одномерным массивом. 
        Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
        Создать свойство Sum, которое возвращает сумму элементов массива, 
        метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  
        метод Multi, умножающий каждый элемент массива на определённое число, 
        свойство MaxCount, возвращающее количество максимальных элементов. 
    б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки (в проекте ArrayFromLib)
    в) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
*/

using System;
using System.Collections.Generic;

namespace ArrayApp
{
    class MyArray
    {
        int[] arr;
        
        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public int Length()
        {
            return arr.Length;
        }

        public MyArray(int n, int min, int max, Random rnd)
        {
            arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(min, max);
        }

        public MyArray(int n, int start, int step)
        {
            arr = new int[n];
            for (int i = 0; i < n; i++, start += step)
                arr[i] = start;
        }

        public MyArray(int[] _arr)
        {
            arr = _arr;
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in arr)
                s += v + " ";
            return s;
        }

        public int CountOfPairs()
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (CheckCondition(arr[i], arr[i + 1]))
                    count++;
            }
            return count;
        }

        public bool CheckCondition(int a, int b)
        {
            return (a % 3 == 0 && b % 3 != 0) || (a % 3 != 0 && b % 3 == 0);
        }

        public int Sum()
        {
            int result = 0;
            foreach (int i in arr)
                result += i;
            return result;
        }

        public int[] Inverse()
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                result[i] = -arr[i];
            return result;
        }

        public int[] Multi(int k)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                result[i] = arr[i] * k;
            return result;
        }

        public int MaxCount(out int max)
        {
            int count = 0;
            max = int.MinValue;
            foreach (int i in arr)
                if (i > max)
                    max = i;
            foreach (int i in arr)
                if (i == max)
                    count++;
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            #region Задание 1
            MyArray a = new MyArray(20, -10000, 10001, rnd);
            Console.WriteLine(a.ToString());
            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3, = {a.CountOfPairs()}");
            #endregion

            #region Задание 3
            a = new MyArray(20, 3, 5);
            Console.WriteLine("\n" + a.ToString());
            Console.WriteLine($"Сумма элементов массива = {a.Sum()}");

            MyArray b = new MyArray(a.Inverse());
            Console.WriteLine("\nИнверсированный массив:\n" + b.ToString());
            Console.WriteLine("Исходный массив:\n" + a.ToString());

            b = new MyArray(a.Multi(2));
            Console.WriteLine("\nМассив с удвоенными элементами:\n" + b.ToString());
            Console.WriteLine("Исходный массив:\n" + a.ToString());

            int maxValue;
            int count = a.MaxCount(out maxValue);
            Console.WriteLine($"\nКоличество максимальных элементов ({maxValue}) = {count}");

            b = new MyArray(20, 0, 6, rnd);
            Console.WriteLine("\n" + b.ToString());
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i=0; i < b.Length(); i++)
            {
                if (dict.ContainsKey(b[i])) 
                    dict[b[i]]++;
                else 
                    dict.Add(b[i], 1);
            }
            foreach (KeyValuePair<int, int> i in dict)
            {
                Console.WriteLine(i.Key + " встречается " + i.Value + " раз");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
