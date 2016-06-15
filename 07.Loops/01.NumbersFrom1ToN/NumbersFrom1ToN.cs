using System;
    class NumbersFrom1ToN
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
                Console.Write(i +" ");
            }
        }
    }