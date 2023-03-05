using System;

namespace _16._1
{
    class Program
    {

        public delegate double Function(double x);

        public static double F_1(double x)
        {
            return 1 / (Math.Sqrt(Math.Abs(x)));

        }

        public static double F_2(double x)
        {
            return 1 / (Math.Pow (x, 2)+1); 

        }

        public static double F_3(double x)
        {
            return Math.Log(x);

        }

        static double Integrate(double lower, double upper, Function func)
        {
            double integral = 0;
            int segments = 1000; // кількість сегментів
            double dx = (upper - lower) / segments; // розмір кожного сегмента
            for (int i = 0; i < segments; i++)
            {
                double x1 = lower + i * dx; // початкова точка сегмента
                double x2 = lower + (i + 1) * dx; // кінцева точка сегмента
                double y1 = func(x1); // значення функції на початковій точці
                double y2 = func(x2); // значення функції на кінцевій точці
                double segmentArea = (y1 + y2) * dx / 2; // площа трапеції, що складає сегмент
                integral += segmentArea; // додавання площі сегмента до інтегралу
            }
            return integral;

        }   

        static void Main(string[] args)
        {
            Console.WriteLine($"Результат iнтегрування 1 функцiї:   { Integrate(1, 2, F_1) }");
            Console.WriteLine($"Результат iнтегрування 2 функцiї:   { Integrate(1, 2, F_2) }");
            Console.WriteLine($"Результат iнтегрування 3 функцiї:   { Integrate(1, 2, F_3) }");
            Console.ReadKey();
        }
    }
}
