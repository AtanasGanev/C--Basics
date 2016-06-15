using System;
    class PrintASequence
    {
        static void Main()
        {
            int n;
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    n = i;
                }
                else
                {
                    n = i * (-1);
                }
                Console.WriteLine(n);
            }
        }
    }