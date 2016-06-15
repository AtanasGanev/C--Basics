using System;
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.WriteLine("Enter n for Number: ");
            int number = int.Parse(Console.ReadLine());
            int thirdDigit = (number / 100) % 10;
            Console.WriteLine("Third digit 7?");
            if (thirdDigit == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }