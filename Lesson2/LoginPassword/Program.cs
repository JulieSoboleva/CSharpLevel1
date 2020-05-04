// Реализовать метод проверки логина и пароля. 
// На вход подается логин и пароль. 
// На выходе истина, если прошел авторизацию, и ложь, если не прошел 
// (Логин: root, Password: GeekBrains). 
// Используя метод проверки логина и пароля, написать программу: 
// пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
// С помощью цикла do while ограничить ввод пароля тремя попытками.

using System;

namespace LoginPassword
{
    class Program
    {
        static string GetAnswer(string query)
        {
            Console.Write(query);
            return Console.ReadLine();
        }

        static bool CheckLoginPassword(string userLogin, string userPassword)
        {
            string login = "root";
            string password = "GeekBrains";
            return userLogin == login && userPassword == password;
        }

        static void Main(string[] args)
        {
            int time = 3;
            bool condition;
            Console.WriteLine("У Вас есть три попытки.");
            do
            {
                condition = CheckLoginPassword(GetAnswer("Введите логин > "), GetAnswer("Введите пароль > "));
                Console.WriteLine(condition ? "Верно" : "Не верно");
                if (!condition)
                    Console.WriteLine($"Осталось попыток: {--time}");
            }
            while (!condition && time > 0);
            Console.Read();
        }
    }
}
