// а) Написать программу, которая запрашивает массу и рост человека, 
//    вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
// б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

using System;

namespace IMT
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, squaredHeight, weight, I;
            do { Console.Write("Введите ваш рост в метрах > "); }
            while (!double.TryParse(Console.ReadLine(), out height));
            squaredHeight = height * height;

            do { Console.Write("Введите ваш вес в килограммах > "); }
            while (!double.TryParse(Console.ReadLine(), out weight));

            I = weight / squaredHeight;
            if (I <= 18.5)
                Console.WriteLine("Ваш ИМТ = {0:f1}, что говорит о дефиците массы тела!\nДо нормального веса Вам не хватает {1:f1} кг.", I, 18.6 * squaredHeight - weight);
            else if (I > 18.5 && I <= 25)
                Console.WriteLine("Ваш ИМТ = {0:f1}, что соответствует норме!\nДиапазон нормального веса: {1:f1} ... {2:f1} кг.", I, 18.6 * squaredHeight, 25 * squaredHeight);
            else if (I > 25 && I <= 30)
                Console.WriteLine("Ваш ИМТ = {0:f1}, что говорит о наличии избыточной массы тела!\nДо нормального веса Вам необходимо сбросить {1:f1} кг.", I, weight - 25 * squaredHeight);
            else
                Console.WriteLine("Ваш ИМТ = {0:f1}, что говорит об ожирении!\nДля начала Вам необходимо сбросить как минимум {1:f1} кг.", I, weight - 30 * squaredHeight);

            Console.Read();
        }
    }
}
