using System;

namespace OOPinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(2000, 2);
            
            Console.WriteLine(account.GetInfo());

            account.Put(100);

            Console.WriteLine(account.GetInfo());

            account.Withdraw(500);

            Console.WriteLine(account.GetInfo());

            account.Withdraw(1000000);

            Console.WriteLine(account.GetInfo());
            
            Console.ReadKey();
        }
    }
}
