using System;
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter number a: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b: ");
            double secondNumber = double.Parse(Console.ReadLine());
            double compare = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("greater: {0} ",compare);
        }
    }