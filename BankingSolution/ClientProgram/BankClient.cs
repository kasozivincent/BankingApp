using System.Text;
using Domain;
using static System.Console;

namespace ClientProgram
{
    public class BankClient
    {
        private Bank bank = new Bank();
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
            int accountNumber = bank.CreateNewAccount();
            WriteLine($"Your account number is {accountNumber}");
        }

        private void SelectAccount()
        {
            Write("Insert account number >> ");
            int accountNumber = int.Parse(ReadLine());
            int balance = bank.GetBalance(accountNumber);
            WriteLine($"Account Number : {accountNumber} Account Balance: {balance}");
        }

          private void DepositMoney()
        {
            Write("Insert account number >> ");
            int accountNumber = int.Parse(ReadLine());

            Write("Insert amount >> ");
            int amount = int.Parse(ReadLine());

            int newBalance = bank.DepositMoney(accountNumber, amount);

            WriteLine($"Your account balance is {newBalance}");
        }
    }
}