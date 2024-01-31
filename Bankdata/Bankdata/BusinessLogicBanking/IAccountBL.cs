using Bankdata.Models;

namespace Bankdata.BusinessLogicBanking
{
    public interface IAccountBL
    {

        public List<Account> GetAccounts();

        public Account GetAccount(int id);

        public bool UpdateAccount(int id);

        public bool DeleteAccount(int id);

        public void CreateAccount(Account acc);
    }
}
