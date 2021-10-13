namespace Bank
{
    class Account
    {
        private string _accountNumber;
        private double _balance;
        private BankAccountType _accountType;

        public string ReadAccountNumber()
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

        public void WriteAccountNumber(string accountNumber)
        {
            _accountNumber = accountNumber;
        }

        public void WriteBalance(double balance)
        {
            _balance = balance;
        }

        public void WriteBankAccountType(BankAccountType accountType)
        {
            _accountType = accountType;
        }
    }
}
