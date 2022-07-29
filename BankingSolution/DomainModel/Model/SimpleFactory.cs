using Domain.Accounts;
using Model;

namespace Domain
{
    public static class AccountFactory
    {
        public static BankAccount CreateAccount(int accountType, int accountNumber, IStatus status)
        {
            if(accountType == 1)
                return new SavingsAccount(accountNumber, status);
            else if(accountType == 2)
                return new RegularCheckingAccount(accountNumber, status);
            else
                return new InterestCheckingAccount(accountNumber, status);
        }
    }
}