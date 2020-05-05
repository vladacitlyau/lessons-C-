using System;

namespace lesson2
{
    class Program
    {
        static void Loop(int first, int last)
        {
            Console.Write("{0,2} ", first);
            if (first < last) Loop(first + 1, last);
        }
        static void Main(string[] args)
        {
                     
            int a, b, c, max;
            Console.WriteLine("Решение домашнего задания к уроку 2. Выполнила Цитляу Влада");
            Console.WriteLine("\n1. Для выбора наибольшего из трех чисел введите их");
            Console.Write("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            c = Convert.ToInt32(Console.ReadLine());
            max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            Console.WriteLine("Наибольшее число {0}", max);

            Console.WriteLine("\n2. Программа подсчета цифр числа");
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            while (num > 0)
            {
                i++;
                num /= 10;
            }
            Console.WriteLine("Количество цифр введенного числа равно: {0}", i);

            Console.WriteLine("\n3. Программа подсчета суммы нечетных чисел");
            Console.Write("Введите числа: ");
            int sum = 0;
            int x = 1;
            while (x != 0)
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 != 0)
                {
                    sum = sum + x;
                }
            }
            Console.WriteLine("Сумма чисел равна {0}", sum);

            Console.WriteLine("\n4. Программа проверки логина и пароля. У Вас 3 попытки");
            int count = 0;
            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();
                count++;
                if (login == "root" || password == "GeekBrains")
                {
                    count = 3;
                    Console.WriteLine("Вы ввели правильный логин и пароль");
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильный логин и/или пароль");
                }
            } while (count < 3);

            Console.WriteLine("5. Программа расчета индекса массы тела");
            Console.Write("Введите свою массу в килограммах: ");
            double mass = double.Parse(Console.ReadLine());
            Console.Write("Введите свой рост в сантиметрах: ");
            double height = double.Parse(Console.ReadLine());
            double index = mass / (height * height * 0.0001);
            Console.WriteLine("Ваш ИМТ равен {0}", index);    //Можно тут как-то округлить?
            
            if (index < 18.5)
            {
                Console.WriteLine("У Вас дефицит массы тела, необходимо набрать вес");
            }
            if (index > 18.5 && index < 25)
            {
                Console.WriteLine("У Вас нормальная масса тела, придерживайтесь её");
            }
            if (index > 25)
            {
                Console.WriteLine("У Вас избыточная масса тела, необходимо сбросить вес");
            }

            Console.WriteLine("7. Рекурсивный метод, который выводит на экран числа от a до b");
            Console.Write("Введите число a: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int last = int.Parse(Console.ReadLine());
            Loop(first, last);

            Console.WriteLine("Для выхода из программы нажмите Enter");
            Console.ReadLine();
        }
    }
}
