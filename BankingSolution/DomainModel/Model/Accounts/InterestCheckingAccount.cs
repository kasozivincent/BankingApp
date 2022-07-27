namespace Domain.Accounts
{
    public class InterestCheckingAccount : CheckingAccount
    {
        public InterestCheckingAccount(int accountNumber) : base(accountNumber){}

       
        public override object Clone()
             => new InterestCheckingAccount(this.AccountNumber){Balance = this.Balance, Status = this.Status};

        protected override string GetAccountType()
            => "InterestingCheckingAccount";

        protected override double GetInterestRate()
            => 0.01;

    }
}