using System;
    class BeerTime
    {
        static void Main()
        {
            Console.WriteLine("Enter time (format hh:mm tt):");
            string strBeerTime = Console.ReadLine();
            DateTime beerTime = DateTime.Parse(strBeerTime);
            DateTime startDrink = DateTime.Parse(s: "01:00 PM");
            DateTime stopDrink = DateTime.Parse(s: "02:59 AM");
            if (beerTime >= startDrink || beerTime <= stopDrink)
            {
                Console.WriteLine("result: beer time");
            }
            else if (beerTime <= startDrink || beerTime >= stopDrink)
            {
                Console.WriteLine("result: non-beer time");
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        }
    }