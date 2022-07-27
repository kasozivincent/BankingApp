using Domain;
using Domain.Accounts;

namespace ClientProgram
{
    public class StartUp
    {
        public static void Main()
        {
            int accountCounter = 1;
            IDictionary<int, BankAccount> accounts =  new Dictionary<int, BankAccount>();
            Bank bank = new (accounts, accountCounter);
            BankClient program = new (bank);
            program.Run();
        }
    }
}