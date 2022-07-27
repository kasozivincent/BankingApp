namespace Domain.Accounts
{
    public class SavingAccount : BankAccount
    {
        public SavingAccount(int accountNumber) : base(accountNumber){}
       
        public override void AddInterest()
            => Balance += (int) (Balance * _rate);

        public override bool hasEnoughCollateral(int loanAmount)
            => Balance >= loanAmount / 2;

        public override string ToString()
            => $"(Savings Account) Account No: {AccountNumber} Balance: {Balance} Status: {Status}";
        
    }
}