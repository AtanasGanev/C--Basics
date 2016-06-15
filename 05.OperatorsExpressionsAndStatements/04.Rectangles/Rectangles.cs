using System;
    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Enter width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter heigh:");
            double heigh = double.Parse(Console.ReadLine());
            double perimeter = 2 * (width + heigh);
            double area = width * heigh;
            Console.WriteLine("perimeter: {0}",perimeter);
            Console.WriteLine("area: {0}", area);
        }
    }