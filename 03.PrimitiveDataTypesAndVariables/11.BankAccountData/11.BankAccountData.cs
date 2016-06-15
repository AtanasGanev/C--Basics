using System;
    class BankAccountData
    {
        static void Main()
        { string holderFirstName;
            string holderMiddleName;
            string holderLastName;
            decimal balance;
            string bankName;
            string IBAN;
            long creditCardNumber1;
            long creditCardNumber2;
            long creditCardNumber3;
 
            holderFirstName = "Ivan";
            holderMiddleName = "Georgiev";
            holderLastName = "Dimitrov";
            balance = 10.99M;
            bankName = "KTB";
            IBAN = "BG80BNBG12341234123456";
            creditCardNumber1 = 38520000023237;
            creditCardNumber2 = 5555555555554444;
            creditCardNumber3 = 4012888888881881;
 
            Console.WriteLine("{0} {1} {2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", holderFirstName, holderMiddleName, holderLastName, balance, bankName, IBAN, creditCardNumber1, creditCardNumber2, creditCardNumber3);
        }
    }