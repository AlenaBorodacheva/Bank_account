namespace Bank
{
    class Account
    {
        private static decimal _lastAccountNumber;
        private decimal _accountNumber;
        private decimal _balance;
        private BankAccountType _accountType;

        public decimal AccountNumber 
        {
            get 
            { return _accountNumber; }
            private set
            { _accountNumber = value; } 
        }
        public decimal Balance
        {
            get
            { return _balance; }
            private set
            { _balance = value; }
        }
        public BankAccountType AccountType
        {
            get
            { return _accountType; }
            private set
            { _accountType = value; }
        }


        public Account()
        {
            CreateAccountNumber();
        }

        public Account(decimal balance) : this()
        {
            _balance = balance;
        }

        public Account(BankAccountType accountType) : this()
        {
            _accountType = accountType;
        }

        public Account(decimal balance, BankAccountType accountType) : this()
        {
            _balance = balance;
            _accountType = accountType;
        }

        private void CreateAccountNumber()
        {
            if (_lastAccountNumber == 0)
            {
                _lastAccountNumber = 40800000000000000000M;               
            }
            else
            {
                _lastAccountNumber++;
            }           
            _accountNumber = _lastAccountNumber;
        }

        public Result Withdraw(decimal money)
        {
            try
            {
                _balance += money;
                return Result.Success;
            }
            catch
            {
                return Result.Unsuccess;
            }
        }

        public Result Deposit(decimal money)
        {
            if(_balance >= money)
            {
                _balance  -= money;
                return Result.Success;
            }
            return Result.Unsuccess;
        }

        public Result GetMoneyFrom(Account account, decimal money)
        {
            if(account._balance >= money && account._accountNumber != _accountNumber)
            {
                account._balance -= money;
                _balance += money;
                return Result.Success;
            }
            return Result.Unsuccess;
        }
    }
}
