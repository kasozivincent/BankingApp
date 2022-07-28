using Model;

namespace Domain.Accounts
{
    public class InterestCheckingAccount : CheckingAccount
    {
        public InterestCheckingAccount(int accountNumber, IStatus status) : base(accountNumber, status){}

       
        public override object Clone()
             => new InterestCheckingAccount(this.AccountNumber, this.Status){Balance = this.Balance, Status = this.Status};

        protected override string GetAccountType()
            => "InterestingCheckingAccount";

        protected override double GetInterestRate()
            => 0.01;

    }
}