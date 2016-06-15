using System;
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter how many of the Fibonacci numbers you want to read:");
            int userInput = int.Parse(Console.ReadLine());
            int firstFibonnacci = 0;
            int secondFibonacci = 1;
            if (userInput == 0)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            else if (userInput == 1)
            {
                Console.WriteLine(0);
                return;
            }
            Console.Write("{0} {1}", firstFibonnacci, secondFibonacci);
            for (int i = 2; i < userInput; i++)
            {
                int nextNumber = firstFibonnacci + secondFibonacci;
                Console.Write(" {0} ", nextNumber);
                firstFibonnacci = secondFibonacci;
                secondFibonacci = nextNumber;
            }
            Console.WriteLine();
        }
    }