using System;
    class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
            Console.WriteLine("a:");
            double numberA = double.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            double numberB = double.Parse(Console.ReadLine());
            Console.WriteLine("c:");
            double numberC = double.Parse(Console.ReadLine());
            if ((numberA > numberB) && (numberA > numberC))
            {
                if (numberB >= numberC)
                {
                    Console.WriteLine("{0} {1} {2}", numberA, numberB, numberC);
                }
                else if (numberB <= numberC)
                {
                    Console.WriteLine("{0} {1} {2}", numberA, numberC, numberB);
                }
            }
            else if ((numberB > numberA) && (numberB > numberC))
            {
                if (numberA >= numberC)
                {
                    Console.WriteLine("{0} {1} {2}", numberB, numberA, numberC);
                }
                if (numberA <= numberC)
                {
                    Console.WriteLine("{0} {1} {2}", numberB, numberC, numberA);
                }
            }
            else if ((numberC > numberA) && (numberC > numberB))
            {
                if (numberA >= numberB)
                {
                    Console.WriteLine("{0} {1} {2}", numberC, numberA, numberB);
                }
                else if (numberA <= numberB)
                {
                    Console.WriteLine("{0} {1} {2}", numberC, numberB, numberA);
                }
            }
            else if (numberA == numberB)
            {
                if (numberC >= numberB)
                {
                    Console.WriteLine("{0} {1} {2}", numberC, numberB, numberA);
                }
                else if (numberC <= numberB)
                {
                    Console.WriteLine("{0} {1} {2}", numberA, numberB, numberC);
                }
            }
            else if (numberA == numberC)
            {
                if (numberB >= numberC)
                {
                    Console.WriteLine("{0} {1} {2}", numberB, numberC, numberA);
                }
                else if (numberB <= numberC)
                {
                    Console.WriteLine("{0} {1} {2}", numberA, numberC, numberB);
                }
            }
            else if (numberB == numberC)
            {
                if (numberA >= numberC)
                {
                    Console.WriteLine("{0} {1} {2}", numberA, numberC, numberB);
                }
                else if (numberA <= numberC)
                {
                    Console.WriteLine("{0} {1} {2}", numberB, numberC, numberA);
                }
            }
        }
    }