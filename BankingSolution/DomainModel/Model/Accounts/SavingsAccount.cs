namespace Domain.Accounts
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(int accountNumber) : base(accountNumber){}
       
        public override object Clone()
            => new SavingsAccount(this.AccountNumber){Balance = this.Balance, Status = this.Status};

        protected override string GetAccountType()
            => "SavingsAccount";

        protected override double GetInterestRate()
            => 0.01;

        protected override double GetRatio()
            => 1.0/2;
    }
}