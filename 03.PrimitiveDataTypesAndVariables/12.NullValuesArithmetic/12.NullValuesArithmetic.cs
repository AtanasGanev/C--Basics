using System;
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? ineger1 = null;
            double? variableDouble = null;
            Console.WriteLine(ineger1);
            Console.WriteLine(variableDouble);
            Console.WriteLine(ineger1 + 1);
            Console.WriteLine(variableDouble + 1);
            Console.WriteLine(ineger1 + null);
            Console.WriteLine(variableDouble + null);
        }
    }