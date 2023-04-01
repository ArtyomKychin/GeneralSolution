using System;

namespace HomeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pi = 3.1415922653;
            double pi = Math.PI;
            //Console.WriteLine(Pi);
            Console.WriteLine("input radius");
            String radius = Console.ReadLine();
            double radiusConverted = Convert.ToDouble(radius);
            double result = pi * Math.Pow(radiusConverted, 2);
            Console.WriteLine(result);
            //double pishort = Math.Round (pi, 5);
            //Console.WriteLine("Pi is: " + pi);

        }
    }
}