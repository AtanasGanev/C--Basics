using System;
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.WriteLine("a:");
            double numberA = double.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            double numberB = double.Parse(Console.ReadLine());
            Console.WriteLine("c:");
            double numberC = double.Parse(Console.ReadLine());
            Console.WriteLine("bigest: ");
            if ((numberA >= numberB) && (numberA >= numberC))
            {
                Console.WriteLine(numberA);
            }
            else if ((numberA <= numberB) && (numberB >= numberC))
            {
                Console.WriteLine(numberB);
            }
            else
            {
                Console.WriteLine(numberC);
            }
        }
    }