using System;
    class SumOf5Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter five numbers for calculation, separated by a space:");
            string[] numbers = new string[5];
            double sum = 0;
            numbers = Console.ReadLine().Split();
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Convert.ToDouble(numbers[i]);
            }
            Console.WriteLine(sum);
        }
    }