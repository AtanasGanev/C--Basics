using System;
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.WriteLine("Enter r: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter {0:F2}", 2*Math.PI*radius);
            Console.WriteLine("Area {0:F2}", Math.PI*Math.Pow(radius,2));
        }
    }