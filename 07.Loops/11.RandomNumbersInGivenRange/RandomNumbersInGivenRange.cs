using System;
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.WriteLine("Enter values for n, min and max, where (min ≤ max) :");
            Console.Write("n="); 
            int userN = int.Parse(Console.ReadLine());
            Console.Write("min="); 
            int userMin = int.Parse(Console.ReadLine());
            Console.Write("max="); 
            int userMax = int.Parse(Console.ReadLine());
            if (userMin > userMax)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            Random randomN = new Random();
            for (int i = 0; i < userN; i++)
            {
                int randomNumber = randomN.Next(userMin, userMax + 1);
                Console.Write("{0} ", randomNumber);
            }
            Console.WriteLine();
        }
    }