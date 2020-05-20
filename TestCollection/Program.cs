/* Переделать программу Пример использования коллекций для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
в) отсортировать список по возрасту студента;
г) *отсортировать список по курсу и возрасту студента;
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestCollection
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;

        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }

    class Program
    {
        static int SortByFirstName(Student st1, Student st2)
        {
            return string.Compare(st1.firstName, st2.firstName);
        }

        static int SortByAge(Student st1, Student st2)
        {
            if (st1.age == st2.age)
                return 0;
            return (st1.age < st2.age) ? -1 : 1;
        }

        static int SortByCourseAndAge(Student st1, Student st2)
        {
            if (st1.course == st2.course)
                return SortByAge(st1, st2);
            return (st1.course < st2.course) ? -1 : 1;
        }

        static Dictionary<int, int> AgeCounter(List<Student> list, int course)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].course != course)
                    continue;

                if (dict.ContainsKey(list[i].age))
                    dict[list[i].age]++;
                else
                    dict.Add(list[i].age, 1);
            }
            return dict;
        }

        static void PrintDictionary(Dictionary<int, int> dict)
        {
            var sortedDict = dict.OrderBy(key => key.Key);
            foreach (KeyValuePair<int, int> i in sortedDict)
                Console.WriteLine(i.Key + "-летних студентов " + i.Value);
        }

        static void Main(string[] args)
        {
            int bakalavr = 0;
            int course5 = 0;
            int course6 = 0;
            List<Student> list = new List<Student>(); 
            //DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("..//..//students_0.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    int course = int.Parse(s[6]);
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), course, int.Parse(s[7]), s[8]));
                    switch (course)
                    {
                        case 5:
                            course5++;
                            break;
                        case 6:
                            course6++;
                            break;
                        default:
                            bakalavr++;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) 
                        return;
                }
            }
            sr.Close();
            //list.Sort(SortByFirstName);
            //list.Sort(SortByAge);
            list.Sort(SortByCourseAndAge);
            foreach (var v in list)
                Console.WriteLine(v.firstName + ", курс " + v.course + ", возраст " + v.age);

            Console.WriteLine("\nВсего студентов:" + list.Count);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            Console.WriteLine("Учащихся 5 курсов:{0}", course5);
            Console.WriteLine("Учащихся 6 курсов:{0}", course6);
            Console.WriteLine("Магистров:{0}", course5 + course6);
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine($"\nНа {i} курсе:");
                PrintDictionary(AgeCounter(list, i));
            }
            //Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }
}
