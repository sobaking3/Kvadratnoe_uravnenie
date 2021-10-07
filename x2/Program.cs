using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace x2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Reshenie(1, 8, 0).raschet();
        }
    }
    class Reshenie
    {
        private double a;
        private double b;
        private double c;
        private double D;
        private double x1;
        private double x2;
        public Reshenie(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void raschet()
        {
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Корней нет");
                Console.ReadKey();
            }
        }
    }
}