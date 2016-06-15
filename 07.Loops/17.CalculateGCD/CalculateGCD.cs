using System;
    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("a:");
            int userA = int.Parse(Console.ReadLine());
            Console.Write("b:");
            int userB = int.Parse(Console.ReadLine());
            int quotient = 0;
            int remainder = 1;
            while (remainder != 0)
            {
                remainder = userA % userB;
                quotient = userA / userB;
                userA = userB;
                userB = remainder;
            }
            Console.WriteLine(userA);
        }
    }