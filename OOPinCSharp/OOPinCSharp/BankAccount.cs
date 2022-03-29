using System;

namespace OOPinCSharp
{
    class BankAccount
    {
        private static ulong UnicNumber { get; set; }

        private ulong Number { get; }

        private decimal Balance { get; set; }

        private AccauntType Type { get; set; }

        internal enum AccauntType
        {
            debet,
            deposit,
            credit
        }
        
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
        public BankAccount(AccauntType type)
        {
            UnicNumber++;
            Number = UnicNumber;
            Type = type;
        }

        public BankAccount(decimal balance, AccauntType type)
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

        public void Transfer(BankAccount account, decimal sum)
        {
            account.Withdraw(sum);
            Put(sum);
        }

        public override string ToString() => $"Номер счёта: {Number:D20} \nБаланс: {Balance} \nТип счёта: {Type}\n";
    }
}
