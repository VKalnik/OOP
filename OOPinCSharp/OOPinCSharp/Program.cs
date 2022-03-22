using System;

namespace OOPinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            var account2 = new BankAccount();

            account.SetBalance(1000);
            account.SetType(1);

            Console.WriteLine(account.GetInfo());
            Console.WriteLine();
            Console.WriteLine(account2.GetInfo());

            Console.ReadKey();
        }
    }
}
