namespace Domain
{
    public enum Status
    {
        Domestic, Foreign
    }

    public class BankAccount
    {
        public int AccountNumber { get; init; }

        private int type;

        public int Balance { get; set; }
        public Status Status { get; set; }
        private double _rate = 0.01;

        public BankAccount(int accountNumber, int type){
            this.AccountNumber = accountNumber;
            this.type = type;
        }
            

        public void DepositMoney(int amount) 
            => Balance += amount;

        public bool hasEnoughCollateral(int loanAmount){
            if(type == 1)
                return Balance >= loanAmount/2;
            else 
                return Balance >= (2 * loanAmount)/3;
        }
            

        public override string ToString(){
            if(type == 1)
                return $"Saving Account, Account Number: {AccountNumber} Account Balance: {Balance} Account Status: {Status}";
            else 
                return $"Checking Account, Account Number: {AccountNumber} Account Balance: {Balance} Account Status: {Status}";
        }

        public void AddInterest() {
            if(type == 1)
                Balance += (int) (Balance * _rate);
        }
    }
}