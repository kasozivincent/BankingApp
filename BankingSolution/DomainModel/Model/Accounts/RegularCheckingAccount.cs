namespace Domain.Accounts
{
    public class RegularCheckingAccount : CheckingAccount
    {
        public RegularCheckingAccount(int accountNumber) : base(accountNumber){}
        public override void AddInterest(){}

        public override object Clone()
            => new RegularCheckingAccount(this.AccountNumber){Balance = this.Balance, Status = this.Status};

        public override string ToString()
            => $"(RegularCheckingAccount) Account No: {AccountNumber} Balance: {Balance} Status: {Status}";
    }
}