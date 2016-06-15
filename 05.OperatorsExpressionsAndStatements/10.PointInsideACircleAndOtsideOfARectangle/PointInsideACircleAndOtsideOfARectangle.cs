using System;
    class PointInsideACircleAndOtsideOfARectangle
    {
        static void Main()
        {
            double x, y;
            double radius = 1.5;
            double coordinateX = 1;
            double coordinateY = 1;
            Console.Write("Please enter point x = ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("Please enter point y = ");
            y = Double.Parse(Console.ReadLine());
            bool insideK = ((x - coordinateX) * (x - coordinateX)) + ((y - coordinateY) * (y - coordinateY)) <= (radius * radius);
            bool rectXout = (x >= 6) && (x <= 2);
            bool rectYout = (y >= -1) && (y <= 1);
            if ((rectXout == false && rectYout == false) && insideK == true)
            {
                Console.WriteLine("inside circle-K & outside of rectangle-R: yes");
            }
            else
            {
                Console.WriteLine("inside circle-K & outside of rectangle-R: no");
            }
        }
    }