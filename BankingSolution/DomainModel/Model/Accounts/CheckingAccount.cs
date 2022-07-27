namespace Domain.Accounts
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(int accountNumber) : base(accountNumber) {}

        public override void AddInterest()
        {}

        public override object Clone()
            => new CheckingAccount(this.AccountNumber){Balance = this.Balance, Status = this.Status};

        public override bool hasEnoughCollateral(int loanAmount)
            =>  Balance >= 2 * loanAmount / 3;

        public override string ToString()
            => $"(Checking Account) Account No: {AccountNumber} Balance: {Balance} Status: {Status}";
    }
}