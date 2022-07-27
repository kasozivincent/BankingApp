namespace Domain.Accounts
{
    public abstract class CheckingAccount : BankAccount
    {
        public CheckingAccount(int accountNumber) : base(accountNumber) {}


        protected override double GetRatio()
            => 2.0 / 3.0;
    }
}