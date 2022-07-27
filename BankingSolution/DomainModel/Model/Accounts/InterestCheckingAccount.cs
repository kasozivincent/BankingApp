namespace Domain.Accounts
{
    public class InterestCheckingAccount : CheckingAccount
    {
        public InterestCheckingAccount(int accountNumber) : base(accountNumber){}

        public override void AddInterest()
        {
            throw new NotImplementedException();
        }

        public override object Clone()
             => new InterestCheckingAccount(this.AccountNumber){Balance = this.Balance, Status = this.Status};

        public override string ToString()
            => $"(InterestChecking Account) Account No: {AccountNumber} Balance: {Balance} Status: {Status}";
    }
}