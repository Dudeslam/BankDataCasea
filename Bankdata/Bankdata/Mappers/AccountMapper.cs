using Bankdata.DTO;
using Bankdata.Models;
namespace Bankdata.Mappers
{
    public class AccountMapper
    {
        public AccountMapper() { }
        public static AccountDTO ToDTO(Account account)
        {
            return new AccountDTO
            {
                AccountID = account.AccountID,
                Balance = account.Balance,
                FirstName = account.FirstName,
                SurName = account.SurName,
            };
        }

        public static Account ToAccount(AccountDTO account)
        {
            return new Account
            {
                AccountID = account.AccountID,
                Balance = account.Balance,
                FirstName = account.FirstName,
                SurName = account.SurName,
            };
        }
    }
}
