using System;
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.WriteLine("a:");
            double numberA = double.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            double numberB = double.Parse(Console.ReadLine());
            Console.WriteLine("c:");
            double numberC = double.Parse(Console.ReadLine());
            Console.WriteLine("d:");
            double numberD = double.Parse(Console.ReadLine());
            Console.WriteLine("e:");
            double numberE = double.Parse(Console.ReadLine());
            Console.WriteLine("bigest: ");
            if ((numberA >= numberB) && (numberA >= numberC) && (numberA >= numberD) && (numberA >= numberE))
            {
                Console.WriteLine(numberA);
            }
            else if ((numberA <= numberB) && (numberB >= numberC) && (numberB >= numberD) && (numberB >= numberE))
            {
                Console.WriteLine(numberB);
            }
            else if ((numberA <= numberC) && (numberB <= numberC) && (numberC >= numberD) && (numberC >= numberE))
            {
                Console.WriteLine(numberC);
            }
            else if ((numberA <= numberD) && (numberB <= numberD) && (numberC <= numberD) && (numberD >= numberE))
            {
                Console.WriteLine(numberD);
            }
            else
            {
                Console.WriteLine(numberE);
            }
        }
    }