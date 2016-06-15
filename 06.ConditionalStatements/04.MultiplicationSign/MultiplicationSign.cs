using System;
    class MultiplicationSign
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("a:{0} b:{1} c{2}",a ,b ,c);
            if ((a > 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0) || (a < 0 && b < 0 && c > 0) )
            {
                Console.WriteLine("result: +");
            }
            else if ((a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0) || (a < 0 && b < 0 && c < 0))
            {
                Console.WriteLine("result: -");
            }
            else
            {
                Console.WriteLine("result: 0");
            }
        }
    }
