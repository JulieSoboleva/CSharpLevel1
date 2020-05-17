/* *Задача ЕГЭ. */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Student
    {
        readonly string name;
        readonly string surname;
        readonly int[] marks;
        public readonly decimal averageMark;

        public Student(string str)
        {
            string[] student = str.Split(' ');
            surname = student[0];
            name = student[1];
            marks = new int[3] { int.Parse(student[2]), int.Parse(student[3]), int.Parse(student[4]) };
            decimal temp = 0;
            foreach (int item in marks)
                temp += item;
            averageMark = Math.Round(temp/marks.Length, MidpointRounding.AwayFromZero);
        }

        public void Print()
        {
            Console.Write(surname + " " + name + " ");
            foreach (int point in marks)
                Console.Write(point + " ");
            Console.WriteLine("- средний балл = " + averageMark);
        }

        public void PrintOnlyName()
        {
            Console.WriteLine(surname + " " + name);
        }

        public static decimal GetMinMark(Student[] students)
        {
            decimal min = decimal.MaxValue;
            foreach (Student s in students)
                if (s.averageMark < min)
                    min = s.averageMark;
            return min;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] data = File.ReadAllLines("..//..//9В.txt", Encoding.GetEncoding("windows-1251"));
            int N = int.Parse(data[0]);
            Student[] group = new Student[N];
            for (int i = 1; i <= N; i++)
                group[i - 1] = new Student(data[i]);
            Console.WriteLine("Журнал класса:");
            foreach (Student st in group)
                st.Print();

            decimal minMark = Student.GetMinMark(group);
            Console.WriteLine($"\nУченики, набравшие наименьший средний балл ({minMark}):");
            foreach (Student s in group)
                if (s.averageMark == minMark)
                    s.PrintOnlyName();

            Console.ReadLine();
        }
    }
}
