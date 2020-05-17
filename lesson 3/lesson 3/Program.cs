using System;

namespace lesson_3
{
    
    struct Complex
    {
        public double im;
        public double re;
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Урок 3. Решение Цитляу Влады");
            
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());

            Console.WriteLine("2. Программа подсчета суммы нечетных чисел");
            int sum = 0;
            string x;
            do
            {
                Console.Write("Введите число: ");
                x = Console.ReadLine();
                if (int.TryParse(x, out int i))
                {
                    if (i == 0)
                        break;
                    if (i % 2 != 0 & i > 0)
                    {
                        sum = sum + i;
                    }
                }
                else
                    Console.WriteLine("Введенная строка не является числом.");
            } while (!false);
            Console.WriteLine("Сумма чисел равна {0}", sum);

            Console.ReadLine();
        }
    }
}
