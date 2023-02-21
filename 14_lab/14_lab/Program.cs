using System;

namespace _14_lab
{
    interface IFigure
    {
        void printArea();
        double getArea();
    }

    interface IRhomb : IFigure
    {
        double A { get; set; }
        double B { get; set; }
    }

    public class Rhomb : IRhomb, IFigure

    {
        private double a;
        private double b;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }
        
        public Rhomb ()
        {

            A = 1;
            B = 1;
        }

        public Rhomb(double a, double b)
        {

            A = a;
            B = b;
        }

        public double getArea()

        {
            return (A * B)/2;

        }

        public void printArea()
        {
            Console.WriteLine(value: $"The area of the diamond is {getArea()}");
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            IRhomb[] diamonds = new Rhomb[]
        {
            new Rhomb(4, 5),
            new Rhomb(3, 6),
            new Rhomb(2, 8)
        };

            // Sort diamonds by area
            Array.Sort(diamonds, (d1, d2) => d1.getArea().CompareTo(d2.getArea()));

            // Print areas of sorted diamonds
            foreach (var diamond in diamonds)
            {
                diamond.printArea();
            }
        }
    }
}
