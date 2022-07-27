namespace Domain.Accounts
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(int accountNumber) : base(accountNumber){}
       
        public override void AddInterest()
            => Balance += (int) (Balance * _rate);

        public override object Clone()
            => new SavingsAccount(this.AccountNumber){Balance = this.Balance, Status = this.Status};

        public override bool hasEnoughCollateral(int loanAmount)
            => Balance >= loanAmount / 2;

        public override string ToString()
            => $"(Savings Account) Account No: {AccountNumber} Balance: {Balance} Status: {Status}";
        
    }
}