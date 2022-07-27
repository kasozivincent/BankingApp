namespace Domain.Accounts
{
    public abstract class CheckingAccount : BankAccount
    {
        public CheckingAccount(int accountNumber) : base(accountNumber) {}

        public override void AddInterest()
        {}


        public override bool hasEnoughCollateral(int loanAmount)
            =>  Balance >= 2 * loanAmount / 3;

    }
}