﻿using System;
namespace _08.NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.WriteLine("Enter N,where N is [1..N]");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}