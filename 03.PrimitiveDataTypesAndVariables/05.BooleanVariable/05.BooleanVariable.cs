using System;
    class BooleanVariable
    {
        static void Main()
        {
            bool isFemale;
            Console.WriteLine("What is your gender (type\"male\"or\"female\"):");
            string gender = Console.ReadLine();
            if (gender == "female")
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }
            Console.WriteLine("Are you female:" + isFemale);
        }
    }