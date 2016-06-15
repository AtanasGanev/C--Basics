using System;
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:\na={0}\nb={1}",a , b);
            int a2 = a;
            a = b;
            b = a2;
            Console.WriteLine("After:\na={0}\nb={1}", a, b);
        }
    }