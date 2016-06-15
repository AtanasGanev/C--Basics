using System;
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Enter your birth date: ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            int age = today.Year - birthDay.Year;
            if ((birthDay.Month <= today.Month && birthDay.Day <= today.Day) ^ (birthDay.Month < today.Month && birthDay.Day > today.Day))
            {
                Console.WriteLine("You are {0} years old.", age);
                Console.WriteLine("After 10 years you will be {0} years old", age + 10);
            }
            else
            {
                Console.WriteLine("You are {0} years old.", age - 1);
                Console.WriteLine("After 10 years you will be {0} years old", age + 9);
            }

        }
    }