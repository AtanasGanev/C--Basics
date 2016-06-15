using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Company Name: ");
            string companyName = Console.ReadLine();
            if (companyName == "")
            {
                companyName = "(missing company name)";
            }
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            if (companyAddress == "")
            {
                companyAddress = "(missing company address)";
            }
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            if (phoneNumber == "")
            {
                phoneNumber = "(no phone)";
            }
            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();
            if (faxNumber == "")
            {
                faxNumber = "(no fax)";
            }
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            if (webSite == "")
            {
                webSite = "(no web site)";
            }
            Console.Write("Manager first name:");
            string managerFirstName = Console.ReadLine();
            if (managerFirstName == "")
            {
                managerFirstName = "(missing manager first name)";
            }
            Console.Write("Manager last name:");
            string managerLastName = Console.ReadLine();
            if (managerLastName == "")
            {
                managerLastName = "(missing manager last name)";
            }
            Console.Write("Manager age:");
            string managerAge = Console.ReadLine();
            if (managerAge == "")
            {
                managerAge = "(no age)";
            }
            Console.Write("Manager phone:");
            string managerPhone = Console.ReadLine();
            if (managerPhone == "")
            {
                managerPhone = "(no manager phone)";
            }
            Console.WriteLine("{0} \n{1} \n{2} \n{3} \n{4} \n{5} {6} (age:{7},tel. {8})", companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }