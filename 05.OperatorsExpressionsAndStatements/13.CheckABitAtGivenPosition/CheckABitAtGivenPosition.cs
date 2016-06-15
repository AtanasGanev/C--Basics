using System;
    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter value for N(number): ");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("binary representation of N: ");
            Console.WriteLine(Convert.ToString(userNumber, 2).PadLeft(16, '0'));

            Console.WriteLine("Enter value for P(position): ");
            int userIndexNumber = int.Parse(Console.ReadLine());
            int shiftNumber = userNumber >> userIndexNumber;
            int extract = shiftNumber & 0000000000000001;
            Console.WriteLine("bit @ P==1: ");
            if (extract == 1)
            {
                Console.WriteLine("true");

            }
            else if (extract == 0)
            {
                Console.WriteLine("false");
            }
        }
    }