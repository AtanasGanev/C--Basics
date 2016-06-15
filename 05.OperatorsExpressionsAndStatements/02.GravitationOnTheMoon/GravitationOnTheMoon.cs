using System;
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.WriteLine("Enter your weight:");
            double weight = double.Parse(Console.ReadLine());
            double moonWeight = weight * 0.17;
            Console.WriteLine("weight on moon: {0}", moonWeight);
        }
    }