namespace OOPinCSharp
{
    class BankAccount
    {
        private static ulong UnicNumber { get; set; }
        private ulong Number { get; }
        public decimal Balance { get; set; }
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

        public override string ToString() => $"Номер счёта: {Number:D20} \nБаланс: {Balance} \nТип счёта: {Type}";
    }
}
