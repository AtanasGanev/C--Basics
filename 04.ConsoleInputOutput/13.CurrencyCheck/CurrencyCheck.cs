using System;
    class CurrencyCheck
    {
        static void Main()
        {
            int rub = int.Parse(Console.ReadLine());
            int usd = int.Parse(Console.ReadLine());
            int eur = int.Parse(Console.ReadLine());
            int bgOption1 = int.Parse(Console.ReadLine());
            int bgOption2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" ");
            //Console.WriteLine("{0:0.00}", rub);
            //Console.WriteLine("{0:0.00}", usd);
            //Console.WriteLine("{0:0.00}", eur);
            //Console.WriteLine("{0:0.00}", bgOption1);
            //Console.WriteLine("{0:0.00}", bgOption2);

            double rubToBGN = (rub / 100.0) * 3.5;
            double usdToBGN = usd * 1.5;
            double eurToBGN = eur * 1.95;
            double BgShop1 = bgOption1 / 2.0;
            double BgShop2 = bgOption2;

            //NOTE! If you want to see the convertion of the currencies in BGN to understant which shop exactly sells the cheepest,uncomment the below comments

            //Console.WriteLine(" ");
            //Console.WriteLine("{0:0.00}", rubToBGN);
            //Console.WriteLine("{0:0.00}", usdToBGN);
            //Console.WriteLine("{0:0.00}", eurToBGN);
            //Console.WriteLine("{0:0.00}", BgShop1);
            //Console.WriteLine("{0:0.00}", BgShop2);

            double cheapest = 0.0;

            cheapest = Math.Min(Math.Min(Math.Min(Math.Min(rubToBGN, usdToBGN), eurToBGN), BgShop1), BgShop2);

            Console.WriteLine("{0:0.00}", cheapest);

            cheapest = Math.Min(rubToBGN, usdToBGN);
            if (rubToBGN < usdToBGN)
            {
                if (rubToBGN < eurToBGN)
                {
                    if (rubToBGN < BgShop1)
                    {
                        if (rubToBGN < BgShop2)
                        {
                            cheapest = rubToBGN;
                        }
                    }
                }

            }
            if (usdToBGN < rubToBGN)
            {
                if (usdToBGN < eurToBGN)
                {
                    if (usdToBGN < BgShop1)
                    {
                        if (usdToBGN < BgShop2)
                        {
                            cheapest = usdToBGN;
                        }
                    }
                }

            }
        }
    }