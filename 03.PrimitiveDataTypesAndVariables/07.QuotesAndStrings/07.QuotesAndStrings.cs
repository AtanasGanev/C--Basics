using System;
    class QuotesAndStrings
    {
        static void Main(string[] args)
        {
            string quote1 = "The \"use\" of quotations causes difficulties";
            string quote2 = @"The ""use"" of quotations causes difficulties";
            Console.WriteLine(quote1);
            Console.WriteLine(quote2);
        }
    }