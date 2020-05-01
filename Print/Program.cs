//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организуйте в центре экрана
//в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
//Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

using System;

namespace Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваши имя, фамилию и город проживания > ");
            Print(Console.ReadLine(), Console.WindowWidth / 2, Console.WindowHeight / 2, ConsoleColor.Green);
            Pause();
        }

        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static void Print(string msg, ConsoleColor foregroundcolor)
        {
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }
        
        static void Print(string msg, int x, int y, ConsoleColor foregroundcolor)
        {
            Console.SetCursorPosition(x, y); 
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }

        static void Pause() 
        {
            Console.ReadKey();
        }

        static void Pause(string msg) 
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
