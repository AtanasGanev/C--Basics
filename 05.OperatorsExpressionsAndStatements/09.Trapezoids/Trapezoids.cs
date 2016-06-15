using System;
    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Enter a: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter heigh: ");
            double heigh = double.Parse(Console.ReadLine());
            double area = (((sideA + sideB) / 2)) * heigh;
            Console.WriteLine("area: {0}",area);
        }
    }