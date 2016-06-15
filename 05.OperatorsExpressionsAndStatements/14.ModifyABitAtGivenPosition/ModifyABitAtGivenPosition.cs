using System;
    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter value for N(number): ");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("binary representation of N: ");
            Console.WriteLine(Convert.ToString(userNumber, 2).PadLeft(16, '0'));
            Console.WriteLine("Enter value for P(position): ");
            int userPosition = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for V(value =1; 0): ");
            int userValue = int.Parse(Console.ReadLine());
            int mask = 1 << userPosition;
            int convertNumber = 0;
            if (userValue == 1)
            {
                convertNumber = userNumber | mask;
            }
            else
            {
                convertNumber = userNumber ^ mask;
            }
            Console.WriteLine("binary result: ");
            Console.WriteLine(Convert.ToString(convertNumber, 2).PadLeft(16, '0'));
            Console.WriteLine("result: {0}",convertNumber);
        }
    }