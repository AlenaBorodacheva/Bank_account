namespace Bank
{
    class Account
    {
        private static decimal _accountNumber;
        private double _balance;
        private BankAccountType _accountType;

        public Account()
        {
            _accountNumber = CreateAccountNumber();
        }

        public Account(double balance) : this()
        {
            _balance = balance;
        }

        public Account(BankAccountType accountType) : this()
        {
            _accountType = accountType;
        }

        public Account(double balance, BankAccountType accountType) : this()
        {
            _balance = balance;
            _accountType = accountType;
        }

        public decimal ReadAccountNumber()
        {
            return _accountNumber;
        }

        public double ReadBalance()
        {
            return _balance;
        }

        public BankAccountType ReadBankAccountType()
        {
            return _accountType;
        }   

        private decimal CreateAccountNumber()
        {
            if (_accountNumber == 0)
            {
                return _accountNumber = 40800000000000000000M;
            }
            _accountNumber++;
            return _accountNumber;
        }
    }
}
