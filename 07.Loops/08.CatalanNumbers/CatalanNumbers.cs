using System;
using System.Numerics;
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Enter value for n where (1 < n < 100):");
            int userN = int.Parse(Console.ReadLine());
            BigInteger Factorial2N = 1;
            BigInteger FactorialN = 1;
            BigInteger FacturialNPlus1 = 1;
            if (userN == 1 || userN >= 100)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            for (int i = 1; i <= (2 * userN); i++)
            {
                Factorial2N *= i;
                if (i <= userN)
                {
                    FactorialN *= i;
                }
            }
            for (int i = 1; i <= (userN + 1); i++)
            {
                FacturialNPlus1 *= i;
            }
            Console.WriteLine("{0}", Factorial2N / (FactorialN *
            FacturialNPlus1));
        }
    }