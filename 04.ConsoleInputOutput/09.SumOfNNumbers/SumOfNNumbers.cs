using System;
    class SumOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter how many numbers are there for summation,and then enter them: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i <n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine("{0}", sum);
        }
    }