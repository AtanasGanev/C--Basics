using System;
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1: Console.WriteLine("Please enter a ineger: "); 
                    int userInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(userInt + 1);break;
                case 2: Console.WriteLine("Please enter a double: ");
                    double userDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine(userDouble + 1); break;
                case 3: Console.WriteLine("Please enter a string: ");
                    string userString = Console.ReadLine();
                    userString += "*";
                    Console.WriteLine(userString); break;
                default: Console.WriteLine("Invalid input!");break;
            }
        }
    }