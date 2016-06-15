using System;
    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            Console.Write("n=");
            int userN = int.Parse(Console.ReadLine());
            if (userN <= 0)
            {
                Console.WriteLine("Invalid input! \nEnter positive value for n!");
            }
            for (int i = 0; i <= userN; i++)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                Console.Write(i + " ");       
            } 
        }
    }