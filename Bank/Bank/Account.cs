namespace Bank
{
    class Account
    {
        private static decimal _accountNumber;
        private double _balance;
        private BankAccountType _accountType;

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

        public void WriteBalance(double balance)
        {
            _balance = balance;
        }

        public void WriteBankAccountType(BankAccountType accountType)
        {
            _accountType = accountType;
        }

        public decimal CreateAccountNumber()
        {
            if(_accountNumber == 0)
            {
                return _accountNumber = 40800000000000000000M;
            }
            return _accountNumber++;
        }
    }
}
