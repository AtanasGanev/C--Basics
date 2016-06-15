using System;
    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter four-digit number: ");
            string number;
            number = Console.ReadLine();
            int sum;
            int firstDigit = int.Parse(number[0].ToString());
            int secondDigit = int.Parse(number[1].ToString());
            int thirdDigit = int.Parse(number[2].ToString());
            int fourthDigit = int.Parse(number[3].ToString());
            sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
            Console.WriteLine("sum ofthe digits: {0}", sum);
            Console.WriteLine("reversed: {3}{2}{1}{0}", firstDigit, secondDigit, thirdDigit, fourthDigit);
            Console.WriteLine("last digit in front: {3}{0}{1}{2}", firstDigit, secondDigit, thirdDigit, fourthDigit);
            Console.WriteLine("second and third digits exchanged: {0}{2}{1}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        }
    }