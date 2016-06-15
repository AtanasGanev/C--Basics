using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter value for n:");
            int userN = int.Parse(Console.ReadLine());
            int[] num = new int[userN];
            int randomNumber = 1;
            int countNumbers = 0;
            Random randomN = new Random();
            for (int i = 0; i < userN; i++)
            {
                randomNumber = randomN.Next(1, userN + 1);
                num[i] = randomNumber;
            }
            for (int i = 0; i < userN; i++)
            {
                for (int j = i + 1; j < userN; j++)
                {
                    if (num[i] == num[j])
                    {
                        num[j] = 0;
                    }
                }
            }
            for (int i = 0; i < userN; i++)
            {
                randomNumber = randomN.Next(1, userN + 1);
                if (num[i] == 0)
                {
                    i--;
                }
                for (int j = 0; j < userN; j++)
                {
                    if (num[j] == randomNumber)
                    {
                        randomNumber = randomN.Next(1, userN + 1);
                        countNumbers = 0;
                        j--;
                    }
                    else
                    {
                        countNumbers++;
                    }
                }
                if (countNumbers == userN)
                {
                    countNumbers = 0;
                    for (i = 0; i < userN; i++)
                    {
                        if (num[i] == 0)
                        {
                            num[i] = randomNumber;
                            break;
                        }
                    }
                }
            }
            foreach (var item in num)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }