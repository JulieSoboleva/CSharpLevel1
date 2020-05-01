//Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
//В результате вся информация выводится в одну строчку.
//а) используя склеивание;
//б) используя форматированный вывод;
//в) *используя вывод со знаком $.
//Ввести вес и рост человека.
//Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); 
//где m — масса тела в килограммах, h — рост в метрах

using System;

namespace Questionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя > ");
            string name = Console.ReadLine();
            Console.Write("Введите вашу фамилию > ");
            string surname = Console.ReadLine();
            Console.Write("Введите ваш возраст > ");
            string age = Console.ReadLine();
            
            float height, weight, I;
            do { Console.Write("Введите ваш рост в метрах > "); }
            while (!float.TryParse(Console.ReadLine(), out height));
            
            do { Console.Write("Введите ваш вес в килограммах > "); }
            while (!float.TryParse(Console.ReadLine(), out weight));

            I = weight / (height * height);

            Console.WriteLine("\nВаши данные:\nимя - " + name + ", фамилия - " + surname + ", возраст - " + age + ", рост - " + height + " м, вес - " + weight + " кг,\nИМТ = " + I);
            Console.WriteLine("\nВаши данные:\nимя - {0}, фамилия - {1}, возраст - {2}, рост - {3} м, вес - {4} кг,\nИМТ = {5:f1}", name, surname, age, height, weight, I);
            Console.WriteLine($"\nВаши данные:\nимя - {name}, фамилия - {surname}, возраст - {age}, рост - {height} м, вес - {weight} кг,\nИМТ = {I}");
            Console.Write("\nДля выхода нажмите <Enter>");
            Console.Read();
        }
    }
}
