using Model;

namespace Domain.Accounts
{
    public class RegularCheckingAccount : CheckingAccount
    {
        public RegularCheckingAccount(int accountNumber, IStatus status) : base(accountNumber, status){}

        public override object Clone()
            => new RegularCheckingAccount(this.AccountNumber, this.Status){Balance = this.Balance, Status = this.Status};

        protected override string GetAccountType()
            => "RegularCheckingAccount";

        protected override double GetInterestRate()
            => 0.0;

    }
}