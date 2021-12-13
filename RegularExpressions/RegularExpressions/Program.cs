using System;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: First Name\n2: Last Name\n3: Valid Email\n4: Mobile Number\n5: Password with 8 characters");
            Console.WriteLine("6: Password with Upper case letter\n7: Password with Numbers\n8: Password with Special characters");
            Console.WriteLine("9:Validating all Email samples given");
            Console.WriteLine("Enter Number of the program to execute: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    UC1FirstName name = new UC1FirstName();
                    Console.WriteLine(name.validateFirstName("Eon"));
                    Console.ReadKey();
                    break;
                case 2:
                    UC2LastName name2 = new UC2LastName();
                    Console.WriteLine(name2.validateLastName("Eon Pinto"));
                    Console.ReadKey();
                    break;
                case 3:
                    UC3ValidEmail email = new UC3ValidEmail();
                    Console.WriteLine(email.validateUserEmail("abc.xyz@bl.co.in"));
                    Console.ReadKey();
                    break;
                case 4:
                    UC4MobileNumber number = new UC4MobileNumber();
                    Console.WriteLine(number.validateMobileNumber("91 9874552258"));
                    Console.ReadKey();
                    break;
                case 5:
                    UC5Pswrd8Char password = new UC5Pswrd8Char();
                    Console.WriteLine(password.validate8charpswrd("sacgai7k"));
                    Console.ReadKey();
                    break;
                case 6:
                    UC6Uppercasepswrd rule2 = new UC6Uppercasepswrd();
                    Console.WriteLine(rule2.validateuppercase("Daikffg"));
                    Console.ReadKey();
                    break;
                case 7:
                    UC7Numberpswrd rule3 = new UC7Numberpswrd();
                    Console.WriteLine(rule3.validatenumber("Da678@ikffg"));
                    Console.ReadKey();
                    break;
                case 8:
                    UC8SpclChar rule4 = new UC8SpclChar();
                    Console.WriteLine(rule4.validatesplchar("Da678%ikffg"));
                    Console.ReadKey();
                    break;
                case 9:
                    UC9EmailSamples emailsamples = new UC9EmailSamples();
                    Console.WriteLine(emailsamples.validateUserEmail("abc+100@gmail.com"));
                    Console.ReadKey();
                    break;
            }
            
        }
    }
}
