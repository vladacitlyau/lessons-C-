using System;

namespace Profile
{
    class Program
    {
        static double index (double height, double mass)
        {
            double ind = mass/(height*height);
            return ind;
        }
        static double distance(double x1, double x2, double y1, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Это проект Влады Цитляу");
            Console.Write("Введите Ваши фамилию и имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Ваш город проживания: ");
            string city = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите Ваш рост в метрах: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Введите Вашу массу в килограммах: ");
            double mass = double.Parse(Console.ReadLine());
            Console.WriteLine("Информация о Вас:");
            Console.WriteLine("Вас зовут " + name + ". Вам " + age + " лет. Ваш рост составляет " + height + " метра, а масса " + mass + " кг.");
            Console.WriteLine("Ваш индекс массы тела составляет: " + index(height, mass).ToString("0.00"));
            
            Console.WriteLine("Для вычисления расстояния между двумя точками введите последовательно значения их координат х1, х2, у1 и у2:");
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Расстояние между двумя точками равно " + distance(x1, x2, y1, y2).ToString("0.00"));

            Console.WriteLine("Вас зовут " + name + ". Вы проживаете в городе " + city + ".");

            Console.ReadLine();
        }
    }
}
