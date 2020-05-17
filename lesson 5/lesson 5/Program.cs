using System;
using System.Text.RegularExpressions;
using System.Linq;
using Helper;

namespace lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Урок 5. Решение подготовила Влада Цитляу\n");
            Console.WriteLine("Задача 1. Проверка корректности ввода логина");
            Regex myReg = new Regex(@"[^A-Za-z0-9]");
            Regex letterReg = new Regex(@"[^0-9]");
            string login;
            bool log = false;
            do
            {
                Console.WriteLine("Введите логин от 2 до 10 символов, начинающийся с буквы");
                login = Convert.ToString(Console.ReadLine());
                if (myReg.IsMatch(login) == true)
                {
                    Console.WriteLine("Логин должен содержать только буквы и цифры");
                }
                else if (login.Length < 2 || login.Length > 10)
                {
                    Console.WriteLine("Логин должен содержать от 2 до 10 символов");
                    Console.WriteLine("Ваш логин содержит " + login.Length + " символов");
                }
                else if (letterReg.IsMatch(login.Substring(0, 1)) == false)
                {
                    Console.WriteLine("Логин должен начинаться с буквы");
                }
                else
                {
                    Console.WriteLine("Логин введен верно");
                    log = true;
                }
            }
            while (log == false);


            Console.WriteLine("\nЗадача 2. Обработка текста");
            string str = ConsoleHelper.AskFor("Введите строку: ");
            int length = int.Parse(ConsoleHelper.AskFor("Введите кол-во символов в слове:"));
            var massiv = str.Split(new char[] { ' ', ',', '.', '!', '?', '-' }).Where(x => x.Length == length).ToArray();
            Console.Write("Слова состоящие из {0} букв/ы:", length);
            foreach (var array in massiv)
            {
                Console.Write(" " + array);
            }
            Console.WriteLine("");
            //Удаление слова заканчивающегося на введенную букву
            string[] strletter = str.Split(' ', ',', '.', '!', '?', '-');
            string delete = ConsoleHelper.AskFor("\n Введите букву. Слова оканчивающиеся на данную букву будут удалены.");
            for (int i = 0; i < strletter.Length; i++)
                if (strletter[i].EndsWith(delete))
                    Console.WriteLine(strletter[i]);
            //Самое длинное слово
            string[] longest = str.Split(' ', ',', '.', '!', '?', '-');
            int max = 0;
            string slovo = "";
            for (int i = 0; i < longest.GetLength(0); i++)
            {
                if (longest[i].Length > max)
                {
                    max = longest[i].Length;
                    slovo = longest[i];
                }
            }
            Console.WriteLine("Самое длинное слово {0}", slovo);

            //Самые длинные слова
            var longest_array = str.Split(new char[] { ' ', ',', '.', '!', '?', '-' }).Where(x => x.Length == max).ToArray();
            Console.Write("Самые длинные слова:");
            foreach (var long_letter in longest_array)
            {
                Console.Write(" " + long_letter);
            }

            ConsoleHelper.Pause();

            Console.ReadKey();
        }
    }
}
namespace Helper
{
    public class ConsoleHelper
    {
        public static string AskFor(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        public static void Pause()
        {
            Console.ReadKey();
        }


    }
}
