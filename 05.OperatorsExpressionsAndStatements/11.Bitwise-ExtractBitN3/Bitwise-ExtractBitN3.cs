using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter value for N: ");
            uint userNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine("binary representation: ");
            Console.WriteLine(Convert.ToString(userNumber, 2).PadLeft(16, '0'));
            uint shiftNumber = userNumber >> 3;
            uint extract = shiftNumber & 0000000000000001;
            Console.WriteLine("bit # 3: ");
            Console.WriteLine(extract);
        }
    }