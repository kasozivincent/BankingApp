namespace Domain.Accounts
{
    public class RegularCheckingAccount : CheckingAccount
    {
        public RegularCheckingAccount(int accountNumber) : base(accountNumber){}

        public override object Clone()
            => new RegularCheckingAccount(this.AccountNumber){Balance = this.Balance, Status = this.Status};

        protected override string GetAccountType()
            => "RegularCheckingAccount";

        protected override double GetInterestRate()
            => 0.0;

    }
}