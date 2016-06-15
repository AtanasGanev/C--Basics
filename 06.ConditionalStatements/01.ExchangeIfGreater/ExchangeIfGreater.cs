using System;
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.WriteLine("a:");
            double numberA = double.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            double numberB = double.Parse(Console.ReadLine());
            if (numberB < numberA)
            {
                Console.WriteLine("result: {0} {1}", numberB, numberA);
            }
            else
            {
                Console.WriteLine("result: {0} {1}", numberA, numberB);
            }
        }
    }