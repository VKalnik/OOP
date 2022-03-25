using System;

namespace OOPinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(2000, BankAccount.AccauntType.credit);

            var accont2 = new BankAccount();
            
            Console.WriteLine(account.GetInfo());

            account.Put(100);

            Console.WriteLine(account.GetInfo());

            account.Withdraw(500);

            Console.WriteLine(account.GetInfo());

            account.Withdraw(1000000);

            Console.WriteLine(account.GetInfo());

            Console.WriteLine(accont2.GetInfo());

            Console.ReadKey();
        }
    }
}
