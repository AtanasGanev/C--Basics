using System;
class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Enter n for Number:");
        int randomNumber = int.Parse(Console.ReadLine());
        if (randomNumber <= 4)
        {
            Console.WriteLine("false");
        }
        else if ((randomNumber % 7 == 0) && (randomNumber % 5 == 0))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}