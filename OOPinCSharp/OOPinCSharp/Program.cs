using System;

namespace OOPinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            account.Balance = 10000;
            account.Type = 10;
            
            var account2 = new BankAccount(2000, 2);
            
            Console.WriteLine(account.GetInfo());
            Console.WriteLine();
            Console.WriteLine(account2.GetInfo());

            Console.ReadKey();
        }
    }
}
