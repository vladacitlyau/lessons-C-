using System;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Урок 4. Решение подготовила Цитляу Влада.\n");
            Console.WriteLine("Задача 1. Массив из 20 элементов");
            Array myArray1 = new Array(20);
            myArray1.Print();
            Console.WriteLine("Количество пар, делящихся на 3 = " + myArray1.Pair_to_N(3));
            Console.WriteLine("\nЗадача 3. Массив из 15 элементов с шагом 2");
            Array myArray2 = new Array(15, 0, 2);
            myArray2.Print();
            Console.WriteLine("Сумма: " + myArray2.Sum);
            myArray2.Inverse();
            Console.Write("Инверсия: ");
            myArray2.Print();
            myArray2.Multi(5);
            Console.Write("Умножаем на 5: ");
            myArray2.Print();
            Console.WriteLine("Количество максимальных элементов в массиве: " + myArray2.MaxCount);

            Console.ReadLine();
        }
    }


    class Array
    {
        int[] a;
        Random rnd = new Random();
        public Array(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(-10000, 10000);
        }
        public Array(int n, int start, int step)
        {
            a = new int[n];
            for(int i=0; i<n; i++)
            {
                a[i] = start + step * i;
            }
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                for(int i =0;i<a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }
        public void Inverse()
        {
            for(int i=0; i<a.Length; i++)
            {
                a[i] *= -1;
            }
        }
        public void Multi(int x)
        {
            for (int i=0; i<a.Length; i++)
            {
                a[i] *= x;
            }
        }
        public int MaxCount
        {
            get
            {
                int max = a[0];
                int count = 1;
                for(int i=1; i<a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                        count = 1;
                    }
                    else if (a[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public void Print()
        {
            for(int i=0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
        }
        public int Pair_to_N(int n)
        {
            int count = 0;
            for(int i = 0; i < a.Length - 1; i++)
            {
                if((a[i]%n==0) || (a[i + 1] % n == 0))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
