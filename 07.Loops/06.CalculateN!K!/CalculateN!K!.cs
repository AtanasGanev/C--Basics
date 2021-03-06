﻿using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter 2 values for n and k where (1 < k < n < 100)");
            Console.Write("n=");
            int userN = int.Parse(Console.ReadLine());
            Console.Write("k=");
            int userK = int.Parse(Console.ReadLine());
            if (userK <= 1 || userK > userN || userN <= 1 || userN >= 100 || userK >= 100)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            int factorialN = 1;
            int factorialK = 1;
            for (int i = 1; i <= userN; i++)
            {
                factorialN *= i;
                if (i <= userK)
                {
                    factorialK *= i;
                }
            }
            Console.WriteLine("{0}", factorialN / factorialK);
        }    
    }