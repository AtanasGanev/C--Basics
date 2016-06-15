using System;
    class Program
    {
        static void Main()
        {
            Console.Write("n=");
            int userN = int.Parse(Console.ReadLine());
            Console.Write("x=");
            int userX = int.Parse(Console.ReadLine());
            int factorial = 1;
            double sum = 1;
            for (int i = 1; i <= userN; i++)
            {
                factorial *= i;
                sum += (factorial / Math.Pow(userX, i));
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }