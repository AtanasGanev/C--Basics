using System;
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter value for n where (1 ≤ n ≤ 20):");
            int userN = int.Parse(Console.ReadLine());
            int countCol = 1;
            if (userN < 1 || userN > 20)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            for (int i = 1; i <= userN; i++)
            {
                for (int j = i; j < 2 * userN; j++)
                {
                    if (countCol <= userN)
                    {
                        Console.Write("{0} ", j);
                        countCol++;
                    }
                }
                Console.WriteLine();
                countCol = 1;
            }
        }
    }