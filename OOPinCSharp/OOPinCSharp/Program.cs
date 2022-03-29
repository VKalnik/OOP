using System;
using System.Text;

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

            accont2.Transfer(account, 500);

            Console.WriteLine(account.GetInfo());

            Console.WriteLine(accont2.GetInfo());


            Console.WriteLine(Reverse("abcde12345"));

            var file = new Files();

            var list = file.ReadEmailFromFile("test.txt");

            file.WriteFile("emails_test.txt", list);

            Console.ReadKey();
        }

        public static string Reverse(string s)
        {
            var res = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; --i)
            {
                res.Append(s[i]);
            }
            return res.ToString();
        }

    }
}
