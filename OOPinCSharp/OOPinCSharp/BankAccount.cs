namespace OOPinCSharp
{
    class BankAccount
    {
        private static ulong _unicNumber;
        private readonly ulong _number;
        private decimal _balance;
        private int _type;

        public BankAccount()
        {
            _unicNumber++;
            _number = _unicNumber;
        }

        public string GetInfo()
        {
            return ToString();
        }

        public void SetBalance(decimal balance)
        {
            _balance = balance;
        }
        public void SetType(int type)
        {
            _type = type;
        }

        public override string ToString() => $"Номер счёта: {_number:D20} \nБаланс: {_balance} \nТип счёта: {_type}";
    }
}
