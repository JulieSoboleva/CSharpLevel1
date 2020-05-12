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
using System.IO;

namespace Array2DLib
{
    public class Array2D
    {
        readonly int[,] arr;
        
        /// <summary>
        /// Свойство, возвращающее минимальный элемент массива
        /// </summary>
        public int Min 
        {
            get
            {
                int min = int.MaxValue;
                for (int i = 0; i < arr.GetLength(0); i++)
                    for (int j = 0; j < arr.GetLength(1); j++)
                        if (arr[i, j] < min)
                            min = arr[i, j];
                return min;
            }
        }

        /// <summary>
        /// Свойство, возвращающее максимальный элемент массива
        /// </summary>
        public int Max
        {
            get
            {
                int max = int.MinValue;
                for (int i = 0; i < arr.GetLength(0); i++)
                    for (int j = 0; j < arr.GetLength(1); j++)
                        if (arr[i, j] > max)
                            max = arr[i, j];
                return max;
            }
        }

        /// <summary>
        /// Конструктор массива
        /// </summary>
        /// <param name="n">количество строк</param>
        /// <param name="m">количество столбцов</param>
        /// <param name="min">минимальное значение</param>
        /// <param name="max">максимальное значение</param>
        public Array2D(int n, int m, int min, int max)
        {
            arr = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    arr[i, j] = rnd.Next(min, max+1);
        }

        /// <summary>
        /// Конструктор массива, загружающий данные из файла
        /// </summary>
        /// <param name="filename">путь к файлу</param>
        public Array2D(string filename)
        {
            try
            { 
                arr = FromStringArray(File.ReadAllLines(filename));
            }
            catch (Exception exn)
            {
                throw new Exception("Ошибка чтения массива Array2D из файла.\n" + exn.Message, exn);
            }
        }

        /// <summary>
        /// Метод преобразования массива Array2D в массив строк
        /// </summary>
        /// <returns></returns>
        public string[] ToStringArray()
        {
            string[] strArr = new string[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                string s = "";
                for (int j = 0; j < arr.GetLength(1); j++)
                    s += arr[i, j] + " ";
                strArr[i] = s;
            }
            return strArr;
        }

        /// <summary>
        /// Метод преобразования массива строк в двумерный массив
        /// </summary>
        /// <param name="strArr">строки формата "число число число ..."</param>
        /// <returns>двумерный массив int[,]</returns>
        public int[,] FromStringArray(string[] strArr)
        {
            int[,] result = null;
            for (int i = 0; i < strArr.Length; i++)
            {
                string[] sCells = strArr[i].Split(' ');
                if (result == null)
                    result = new int[strArr.Length, sCells.Length - 1];
                for (int j = 0; j < sCells.Length; j++)
                {
                    if (string.IsNullOrEmpty(sCells[j]))
                        continue;

                    int cell;
                    if (!int.TryParse(sCells[j], out cell))
                        throw new Exception($"Элемент массива в позиции [{i}][{j}] не преобразуется в целое число");
                    result[i, j] = cell;
                }
            }
            return result;
        }

        /// <summary>
        /// Запись массива в файл
        /// </summary>
        /// <param name="path">путь к файлу</param>
        public void ArrayToFile(string path)
        {
            try 
            {
                File.WriteAllLines(path, ToStringArray());
            }
            catch (Exception exn)
            {
                throw new Exception("Ошибка записи массива Array2D в файл.\n" + exn.Message, exn);
            }
        }

        /// <summary>
        /// Вывод на экран
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0,4}", arr[i, j]);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Сумма всех элементов массива
        /// </summary>
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    sum += arr[i, j];
            return sum;
        }

        /// <summary>
        /// Сумма всех элементов массива больше заданного
        /// </summary>
        public int SumMoreThan(int limit)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if(arr[i, j] > limit)
                        sum += arr[i, j];
            return sum;
        }

        /// <summary>
        /// Позиция (строка, столбец) максимального элемента в массиве
        /// </summary>
        /// <param name="row">индекс строки</param>
        /// <param name="col">индекс столбца</param>
        /// <returns>значение максимального элемента</returns>
        public int MaxPosition(out int row, out int col)
        {
            row = -1;
            col = -1;
            int max = int.MinValue;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        row = i;
                        col = j;
                    }
            return max;
        }
    }
}
