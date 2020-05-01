//Написать программу обмена значениями двух переменных.
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.

using System;

namespace ExchangeOfValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение числа A > ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите значение числа B > ");
            int B = int.Parse(Console.ReadLine());
            int temp = A;
            A = B;
            B = temp;
            Console.WriteLine($"Меняем значения переменных местами. Теперь A = {A}, B = {B}");
            A = A + B;
            B = A - B;
            A = A - B;
            Console.WriteLine($"И снова меняем их местами A = {A}, B = {B}");
            Console.Read();
        }
    }
}
