using Model;

namespace Domain.Accounts
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(int accountNumber, IStatus status) : base(accountNumber, status){}
       
        public override object Clone()
            => new SavingsAccount(this.AccountNumber, this.Status){Balance = this.Balance, Status = this.Status};

        protected override string GetAccountType()
            => "SavingsAccount";

        protected override double GetInterestRate()
            => 0.01;

        protected override double GetRatio()
            => 1.0/2;
    }
}