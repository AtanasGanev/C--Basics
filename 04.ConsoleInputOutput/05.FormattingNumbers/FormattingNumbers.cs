using System;
    class FormattingNumbers
    {
        static void Main()
        {
            int numberA = int.Parse(Console.ReadLine());
            if (numberA < 0 || numberA > 500)
            {
                Console.WriteLine("Invalid input! (0 ≤ number ≤ 500), ");
                return;
            }
            float numberB = float.Parse(Console.ReadLine());
            double numberC = double.Parse(Console.ReadLine());
            Console.WriteLine("|{0,-10:X}|{1,-10}|{2,10:F2}|{3,-10:0.000}|", numberA, Convert.ToString(numberA, 2).PadLeft(10, '0'),numberB,numberC);
        }
    }