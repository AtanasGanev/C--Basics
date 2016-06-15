using System;
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter start and end value");
            int startValue = int.Parse(Console.ReadLine());
            int endValue = int.Parse(Console.ReadLine());
            int pValue = 0;
            for (int i = startValue; i <= endValue; i++)
            {
                if (i % 5 == 0)
                {
                    pValue++;
                }
            }
            Console.WriteLine(pValue);
        }
    }