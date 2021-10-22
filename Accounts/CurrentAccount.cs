using System;

namespace CSBankingApp.Accounts
{
    public class CurrentAccount : AccountsInfo
    {
        public void register()
        {
            Console.WriteLine("What is your first name? ");
            string nameF = Console.ReadLine();

            Console.WriteLine("What is your last name? ");
            string nameL = Console.ReadLine();

            Console.WriteLine("What is your email? ");
            string email = Console.ReadLine();

            Console.WriteLine("What is your password? ");
            string password = Console.ReadLine();

            Console.WriteLine("What will your pin code be?");
            int pinCode = int.Parse(Console.ReadLine());

            SetNameF = nameF;
            SetNameL = nameL;
            SetEmail = email;
            SetPassword = password;
            SetPinCode = pinCode;
        }

        public void login()
        {
            Console.WriteLine("What is your first name? ");
            Console.WriteLine("What is your last name? ");
            Console.WriteLine("What is your email? ");
            Console.WriteLine("What is your password? ");
            Console.WriteLine("What will your pin code be?");
        }
        
    }
}