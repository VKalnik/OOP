using System;

namespace OOPinCSharp
{
    class BankAccount
    {
        private static ulong UnicNumber { get; set; }
        private ulong Number { get; }
        private decimal Balance { get; set; }
        public int Type { get; set; }

        public BankAccount()
        {
            UnicNumber++;
            Number = UnicNumber;
        }

        public BankAccount(decimal balance)
        {
            UnicNumber++;
            Number = UnicNumber;
            Balance = balance;
        }
        public BankAccount(int type)
        {
            UnicNumber++;
            Number = UnicNumber;
            Type = type;
        }

        public BankAccount(decimal balance, int type)
        {
            UnicNumber++;
            Number = UnicNumber;
            Balance = balance;
            Type = type;
        }

        public string GetInfo()
        {
            return ToString();
        }

        public void Put(decimal sum)
        {
            Balance += sum;
        }

        public void Withdraw(decimal sum)
        {
            if (sum <= Balance)
            {
                Balance -= sum;
            }
            else
            {
                Console.WriteLine("Баланс на счёте не достаточен для списания запрошенной суммы!");
            }
        }

        public override string ToString() => $"Номер счёта: {Number:D20} \nБаланс: {Balance} \nТип счёта: {Type}\n";
    }
}
