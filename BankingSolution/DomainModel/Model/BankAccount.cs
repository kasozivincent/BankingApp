namespace Domain
{
    public enum Status
    {
        Domestic, Foreign
    }

    public abstract class BankAccount : IComparable<BankAccount>, ICloneable
    {
        public int AccountNumber { get; init; }

        public int Balance { get; set; }
        public Status Status { get; set; }
        protected double _rate = 0.01;

        public BankAccount(int accountNumber)
            => this.AccountNumber = accountNumber;
            

        public void DepositMoney(int amount) 
            => Balance += amount;


        public abstract bool hasEnoughCollateral(int loanAmount);

        public abstract override string ToString();
        public abstract void AddInterest();

        public int CompareTo(BankAccount? other)
        {
            if(this.Balance == other?.Balance)
                return 0;
            else if(this.Balance > other?.Balance)
                return 1;
            else
                return -1;
        }

        public abstract object Clone();
    }
}