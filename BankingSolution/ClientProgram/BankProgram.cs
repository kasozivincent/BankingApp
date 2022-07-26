using System.Text;
using static System.Console;
namespace ClientProgram
{
    public class BankProgram
    {
        //class fields
        private Dictionary<int, int> _accounts = new Dictionary<int, int>();
        private double _rate = 0.01;
        private int _accountNumber = 1;
        private bool _isdone = default;

        public void Run()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("0 ---> Quit");
            builder.AppendLine("1 ----> Create New Account");
            builder.AppendLine("2 ------> Select Account");
            builder.AppendLine("3 ----> Deposit Money");
            builder.AppendLine("4 -----> Apply for loan");
            builder.AppendLine("5 ------> Display Account Details");
            builder.AppendLine("6 -----> Calculate Interest");
            
            string menuMessage = builder.ToString();
            while(!_isdone)
            {
                WriteLine(menuMessage);
                Write("Enter your choice >> ");
                int choice = int.Parse(Console.ReadLine());
                ProcessCommand(choice);
            }
        }

        private void ProcessCommand(int choice)
        {
            if(choice == 0)
                Quit();
            else if(choice == 1)
                CreateNewAccount();
            else if(choice == 2)
                SelectAccount();
            else if(choice == 3)
                DepositMoney();
            else if(choice == 4)
                ApplyForLoan();
            else if(choice == 5)
                DisplayAccountDetails();
            else if(choice == 6)
                CalculateInterest();
            else
                Console.WriteLine("Invalid Choice");
        }

        private void Quit() 
        {
            _isdone = true;
            WriteLine("Thanks for using our services");
        }

        private  void CreateNewAccount()
        {
            _accounts.Add(_accountNumber, 0);
            WriteLine($"Your account number is {_accountNumber}");
            _accountNumber++;
        }

        private void SelectAccount()
        {
            Write("Insert account number >> ");
            int accountNumber = int.Parse(ReadLine());
            WriteLine($"Account Number : {accountNumber} Account Balance: {_accounts[accountNumber]}");
        }

        private void DepositMoney()
        {
            Write("Insert account number >> ");
            int accountNumber = int.Parse(ReadLine());

            Write("Insert amount >> ");
            int amount = int.Parse(ReadLine());

            int currentBalance = _accounts[accountNumber];
            _accounts.Add(accountNumber, currentBalance + amount);

            WriteLine($"Your account balance is {_accounts[accountNumber]}");
        }

        private void ApplyForLoan()
        {
             Write("Insert account number >> ");
            int accountNumber = int.Parse(ReadLine());

            Write("Insert loan amount >> ");
            int loanAmount = int.Parse(ReadLine());

            int balance = _accounts[accountNumber];
            if(balance >= loanAmount/2)
                WriteLine("Loan approved");
            else
                WriteLine("Loan Denied!!!");
        }

        private void DisplayAccountDetails()
        {
            var accountNumbers = _accounts.Keys;
            foreach(int accountNumber in accountNumbers)
                WriteLine($"Account Number: {accountNumber} Balance: {_accounts[accountNumber]}");
        }

        private void CalculateInterest()
        {
            var accountNumbers = _accounts.Keys;
            foreach(var accountNumber in accountNumbers)
            {
                int balance = _accounts[accountNumber];
                _accounts[accountNumber] = (int)(balance * (1 + _rate));
            }
        }
    }
}