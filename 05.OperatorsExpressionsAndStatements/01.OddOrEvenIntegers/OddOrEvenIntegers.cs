using System;
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter n for number: ");
            int randomNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Odd?");
            if (randomNumber % 2 == 0)
            {
                Console.WriteLine("false");
            }
            else 
            {
                Console.WriteLine("true");
            }
        }
    }