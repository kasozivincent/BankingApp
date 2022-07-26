namespace Domain
{
    public class Bank
    {
        private Dictionary<int, int> _accounts = new Dictionary<int, int>();
        private double _rate = 0.01;
        private int _accountNumber = 0;

        public int CreateNewAccount()
        {
            _accountNumber++;
            _accounts.Add(_accountNumber, 0);
            return _accountNumber;
        }

        public int GetBalance(int accountNumber)
            => _accounts[accountNumber];

        public void DepositMoney(int accountNumber, int amount)
        {
            int currentBalance = _accounts[accountNumber];
            _accounts[accountNumber] = currentBalance + amount;
        }

    }
}