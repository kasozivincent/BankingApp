using System.Text;

namespace Domain
{
    public class Bank
    {
        private Dictionary<int, BankAccount> _accounts = new Dictionary<int, BankAccount>();
        private double _rate = 0.01;
        private int _accountNumber = 0;

        public int CreateNewAccount(Status status)
        {
            _accountNumber++;
            BankAccount bankAccount = new BankAccount(_accountNumber);
            bankAccount.Status = status;
            _accounts.Add(_accountNumber, bankAccount);
            return _accountNumber;
        }

        public int GetBalance(int accountNumber)
            => _accounts[accountNumber].Balance;

        public int DepositMoney(int accountNumber, int amount)
        {
            int currentBalance = _accounts[accountNumber].Balance;
            _accounts[accountNumber].Balance = currentBalance + amount;
            return _accounts[accountNumber].Balance;
        }

        public bool ApplyForLoan(int accountNumber, int loanAmount)
        {
            int currentBalance = _accounts[accountNumber].Balance;
            return currentBalance >= loanAmount/2;
        }

        public void SetStatus(int accountNumber, Status status)
            => _accounts[accountNumber].Status = status;
        public string DisplayAccountDetails()
        {
            StringBuilder builder = new StringBuilder();
            var accountNumbers = _accounts.Keys;
            foreach(int accountNumber in accountNumbers)
                builder.AppendLine($"Account Number: {accountNumber} Account Balance: {_accounts[accountNumber]}");
            return builder.ToString();
        }

        public void CalculateInterest()
        {
            var accountNumbers = _accounts.Keys;
            foreach(var accountNumber in accountNumbers)
            {
                int balance = _accounts[accountNumber].Balance;
                _accounts[accountNumber].Balance = (int)(balance * (1 + _rate));
            }
        }

    }
}