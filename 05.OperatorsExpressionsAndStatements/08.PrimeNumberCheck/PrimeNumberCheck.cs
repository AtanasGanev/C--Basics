using System;
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter n for Number: ");
            int numberN = int.Parse(Console.ReadLine());
            if (numberN > 100)
            {
                Console.WriteLine("Invalid input! (n<=100)");
            }
            if (numberN < 3)
            {
                if (numberN == 2)
                {
                    Console.WriteLine("Prime? true");
                }
                else
                {
                    Console.WriteLine("Prime? false");
                }
            }
            else
            {
                if (numberN % 2 == 0)
                {
                    Console.WriteLine("Prime? false");
                }
                else
                {
                    int divisor;
                    for (divisor = 3; numberN % divisor != 0; divisor += 2) ;
                    if (divisor == numberN)
                    {
                        Console.WriteLine("Prime? true");
                    }
                    else
                    {
                        Console.WriteLine("Prime? false");    
                    }
                }
            }
        }
    }