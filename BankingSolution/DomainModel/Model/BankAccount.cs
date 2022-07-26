namespace Domain
{
    public enum Status
    {
        Domestic, Foreign
    }

    public class BankAccount
    {
        public int AccountNumber { get; init; }
        public int Balance { get; set; }
        public Status Status { get; set; }
        
        public BankAccount(int accountNumber)
            => this.AccountNumber = accountNumber;
    }
}