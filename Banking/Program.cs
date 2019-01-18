using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount account = new CheckingAccount();

            Console.WriteLine("Welcome to WeCanBankIT!");
            Console.WriteLine("Your account has $" + account.Balance + ".");

            Console.WriteLine("Press RETURN to exit.");
            Console.ReadLine();

        }
    }
}
