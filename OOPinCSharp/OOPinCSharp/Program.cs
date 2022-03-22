using System;

namespace OOPinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            account.SetNumber(1);
            account.SetBalance(1000);
            account.SetType(1);

            Console.WriteLine(account.GetInfo());

            Console.ReadKey();
        }
    }
}
