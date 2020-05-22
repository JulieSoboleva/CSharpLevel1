using System;

namespace GuessingGame
{
    class Guessing
    {
        public int Current { get; private set; }
        public int Count { get; private set; } = 0;
        public int maxCount { get; private set; } = 4;
        public int Number { get; private set; }
        
        public Guessing()
        {
            Number = new Random().Next(1, 101);
            Count = maxCount;
        }

        public string CheckAnswer(int answer, out bool result)
        {
            Count--;
            Current = answer;
            result = true;
            if (Current == Number)
                return "Поздравляю! Вы угадали!";
            result = false;
            return Current < Number ? "Вы ввели слишком маленькое число" : "Вы ввели слишком большое число";
        }

        public bool HasAttempts()
        {
            return Count > 0;
        }
    }
}
