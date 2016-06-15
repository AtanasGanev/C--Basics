using System;
    class PointInACircle
    {
        static void Main()
        {
            double coordinateX, coordinateY;
            bool inside;
            int radius = 2;
            Console.Write("Coordinate X: ");
            coordinateX = Double.Parse(Console.ReadLine());
            Console.Write("Coordinate Y: ");
            coordinateY = Double.Parse(Console.ReadLine());
            inside = ((coordinateX * coordinateX) + (coordinateY * coordinateY) <= radius * radius);
            Console.WriteLine("Inside:{0}",inside);
        }
    }