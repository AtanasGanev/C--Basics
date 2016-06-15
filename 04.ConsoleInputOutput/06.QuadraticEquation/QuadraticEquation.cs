using System;
    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter a, b and c: ");
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double numberC = double.Parse(Console.ReadLine());
            double numberX = Math.Sqrt(Math.Pow(numberB, 2) - 4 * numberA * numberC);
            if (numberX > 0 && numberA != 0)
            {
                Console.WriteLine("x1={0}; x2={1}", (-numberB + numberX) / (2.0 * numberA), (-numberB - numberX) / (2.0 * numberA));
            }
            else if (numberX == 0&&numberA!= 0)
            {
                Console.WriteLine("x1=x2={0}", -numberB / (2.0 * numberA));
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }