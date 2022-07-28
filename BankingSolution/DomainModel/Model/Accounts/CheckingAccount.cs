using Model;

namespace Domain.Accounts
{
    public abstract class CheckingAccount : BankAccount
    {
        public CheckingAccount(int accountNumber, IStatus status) : base(accountNumber, status) {}

        protected override double GetRatio()
            => 2.0 / 3.0;
    }
}