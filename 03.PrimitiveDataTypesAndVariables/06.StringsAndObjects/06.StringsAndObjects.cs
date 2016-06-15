using System;
    class StringsAndObjects
    {
        static void Main()
        {
            string firstString = "Hello";
            string secondString = "World";
            object thirdString = firstString + " " + secondString;
            string casting = (string)thirdString;
            Console.WriteLine(casting);
        }
    }