/* 4. Реализовать метод проверки логина и пароля. 
   На вход подаётся логин и пароль. 
   На выходе истина, если прошёл авторизацию, и ложь, если не прошёл 
   (Логин: root, Password: GeekBrains). 
   Используя метод проверки логина и пароля, написать программу: 
   пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
   С помощью цикла do while ограничить ввод пароля тремя попытками.

   Логины и пароли считать из файла в массив. 
   Создайте структуру Account, содержащую Login и Password.
*/

using System;
using System.IO;

namespace Account
{
    struct Account
    {
        string login;
        string password;

        public Account(string _login, string _password)
        {
            login = _login;
            password = _password;
        }
        
        public void Print()
        {
            Console.WriteLine(login + " - " + password);
        }

        static public bool operator ==(Account x, Account y) => x.login == y.login && x.password == y.password;
        static public bool operator !=(Account x, Account y) => !(x==y);

    }

    class AccountsArray
    {
        readonly Account[] arr;
        
        public Account this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public AccountsArray (string fileName)
        {
            string[] logins = File.ReadAllLines(fileName);
            arr = new Account[logins.Length];
            for (int i = 0; i < logins.Length; i++)
            {
                string[] temp = logins[i].Split('-');
                arr[i] = new Account(temp[0].Trim(), temp[1].Trim());
            }
        }

        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i].Print();
        }

        public bool CheckLoginPassword(string userLogin, string userPassword)
        {
            Account user = new Account(userLogin, userPassword);
            return Contains(user);
        }

        public bool Contains(Account x)
        {
            foreach (Account a in arr)
                if (a == x)
                    return true;
            return false;
        }
    }

    class Program
    {
        static string GetAnswer(string query)
        {
            Console.Write(query);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string path = "..//..//logins.txt";
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл с логинами и паролями по заданному пути не найден");
                return;
            }
            
            AccountsArray arr = new AccountsArray(path);
            //arr.Print();
            
            int time = 3;
            bool condition;
            Console.WriteLine("У Вас есть три попытки.");
            do
            {
                condition = arr.CheckLoginPassword(GetAnswer("Введите логин > "), GetAnswer("Введите пароль > "));
                Console.WriteLine(condition ? "Верно" : "Не верно");
                if (!condition)
                    Console.WriteLine($"Осталось попыток: {--time}");
            }
            while (!condition && time > 0);

            Console.ReadLine();
        }
    }
}
