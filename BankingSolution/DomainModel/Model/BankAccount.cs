using Model;

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
        public  IStatus Status { get; set; }
        protected double _rate = 0.01;

        public BankAccount(int accountNumber, IStatus status)
        {
            this.AccountNumber = accountNumber;
            this.Status = status;
        }
            

        public void DepositMoney(int amount) 
            => Balance += amount;

        public double Charge()
            => this.Status.Charge();
        
        public int CompareTo(BankAccount? other)
        {
            if(this.Balance == other?.Balance)
                return 0;
            else if(this.Balance > other?.Balance)
                return 1;
            else
                return -1;
        }

        //--------------------------------------------------------------------------------------------------
        public  bool hasEnoughCollateral(int loanAmount)
            => Balance >= loanAmount * GetRatio();

        protected abstract double GetRatio();

        //--------------------------------------------------------------------------------------------------
        public override string ToString()
            => $"({GetAccountType()}) Account No: {AccountNumber} Balance: {Balance} Status: {Status.ToString()}";

        protected abstract string GetAccountType();
        //--------------------------------------------------------------------------------------------------

        public void AddInterest()
            => Balance += (int) (Balance * GetInterestRate());
        protected abstract double GetInterestRate();
         //--------------------------------------------------------------------------------------------------

        public abstract object Clone();
    }
}