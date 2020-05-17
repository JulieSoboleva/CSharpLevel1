/* Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения,  которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) ***Создать метод, который производит частотный анализ текста. 
В качестве параметра в него передается массив слов и текст, 
в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
Здесь требуется использовать класс Dictionary.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;

namespace Lesson5
{
    static class Message
    {
        /// <summary>
        /// Длина слова
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        private static int WordLength(string str, out string word)
        {
            int length = 0;
            word = "";
            foreach (char c in str)
                if (char.IsLetter(c))
                {
                    length++;
                    word += c;
                }
            return length;
        }

        /// <summary>
        /// Вывести в консоль слова сообщения, содержащие не более заданного количества букв
        /// </summary>
        /// <param name="text">текст</param>
        /// <param name="limit">максимальное количество букв</param>
        public static void PrintWordsNoLongerLimit(string text, int limit)
        {
            string[] words = text.Split(' ');
            Console.WriteLine($"Вывод слов из текста, не длиннее {limit} букв: ");
            foreach (string s in words)
            {
                string word;
                int length = WordLength(s, out word);
                if (length <= limit && length > 0)
                    Console.WriteLine(word + " -> " + length);
            }
        }

        /// <summary>
        /// Удалить из текста все слова, заканчивающиеся заданным символом
        /// </summary>
        /// <param name="text">текст</param>
        /// <param name="symbol">символ</param>
        /// <returns>новый текст</returns>
        public static string DeleteWordsEndedBySymbol(string text, char symbol)
        {
            string resText = "";
            string[] words = text.Split(' ');
            foreach (string s in words)
            {
                string word;
                int len = WordLength(s, out word);
                if (!string.IsNullOrEmpty(word) && word[word.Length-1] != symbol)
                    resText += s + ' ';
            }
            return resText;
        }

        /// <summary>
        /// Найти самое длинное слово сообщения
        /// </summary>
        /// <param name="text">тескт сообщения</param>
        /// <returns>самое длинное слово</returns>
        public static string FindMaxWord(string text)
        {
            string[] words = text.Split(' ');
            string maxWord = "";
            int maxLen = int.MinValue;
            foreach (string s in words)
            {
                string tempWord;
                int length = WordLength(s, out tempWord);
                if (length > maxLen)
                {
                    maxLen = length;
                    maxWord = tempWord;
                }
            }
            return maxWord;
        }

        /// <summary>
        /// Сформировать строку с помощью StringBuilder из слов сообщения, 
        /// длина которых больше заданной минимальной величины
        /// </summary>
        /// <param name="text">текст сообщения</param>
        /// <param name="minLengh">минимальный порог длины слов</param>
        /// <returns>новое сообщение</returns>
        public static StringBuilder FormStringFromLongWodrs(string text, int minLengh)
        {
            StringBuilder result = new StringBuilder(text.Length);
            string[] words = text.Split(' ');
            foreach (string s in words)
            {
                string word;
                int length = WordLength(s, out word);
                if (length > minLengh)
                    result.Append(word + " ");
            }
            return result;
        }

        /// <summary>
        /// Метод, который производит частотный анализ текста
        /// </summary>
        /// <param name="text">текст</param>
        public static void FrequencyAnalysis(string text)
        {
            string[] words = text.Split(' ');
            List<string> list = new List<string>(words.Length);
            foreach (string s in words)
            {
                string word;
                _ = WordLength(s, out word);
                if (!string.IsNullOrEmpty(word))
                    list.Add(word.ToLower());
            }
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (dict.ContainsKey(list[i]))
                    dict[list[i]]++;
                else
                    dict.Add(list[i], 1);
            }

            var sortedDict = from entry in dict orderby entry.Value descending select entry;
            foreach (KeyValuePair<string, int> i in sortedDict)
                Console.WriteLine("\"" + i.Key + "\"" + " встречается " + i.Value + " раз");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Текст:");
            //string poem = " Белеет парус одинокой\n В тумане моря голубом!..\n Что ищет он в стране далекой?\n Что кинул он в краю родном?..\n Играют волны — ветер свищет,\n И мачта гнётся и скрыпит…\n Увы! он счастия не ищет\n И не от счастия бежит!\n Под ним струя светлей лазури,\n Над ним луч солнца золотой…\n А он, мятежный, просит бури,\n Как будто в бурях есть покой!";
            string poem = "— Она несла в руках отвратительные, тревожные жёлтые цветы. Чёрт их знает, как их зовут, но они первые почему-то появляются в Москве. И эти цветы очень отчетливо выделялись на чёрном её весеннем пальто. Она несла жёлтые цветы! Нехороший цвет. Она повернула с Тверской в переулок и тут обернулась. Ну, Тверскую вы знаете? По Тверской шли тысячи людей, но я вам ручаюсь, что увидела она меня одного и поглядела не то что тревожно, а даже как будто болезненно. И меня поразила не столько её красота, сколько необыкновенное, никем не виданное одиночество в глазах! Повинуясь этому жёлтому знаку, я тоже свернул в переулок и пошёл по её следам. Мы шли по кривому, скучному переулку безмолвно, я по одной стороне, а она по другой. И не было, вообразите, в переулке ни души. Я мучился, потому что мне показалось, что с нею необходимо говорить, и тревожился, что я не вымолвлю ни одного слова, а она уйдёт, и я никогда её более не увижу...";
            Console.WriteLine(poem);
            
            Console.WriteLine();
            Message.PrintWordsNoLongerLimit(poem, 4);

            char symbol = 'е'; //'т';
            Console.WriteLine("\nВывод текста без слов, оланчивающихся на букву \"{0}\"", symbol);
            string noPoem = Message.DeleteWordsEndedBySymbol(poem, symbol);
            Console.WriteLine(noPoem);

            Console.WriteLine();
            Console.WriteLine($"Самое длинное слово в тексте: {Message.FindMaxWord(poem)}");

            int limit = 9;
            Console.WriteLine();
            Console.WriteLine($"Текст из слов длиннее {limit} букв:\n{Message.FormStringFromLongWodrs(poem, limit)}");

            Console.WriteLine("\nЧастотный анализ текста:");
            Message.FrequencyAnalysis(poem);

            Console.ReadKey();
        }
    }
}
