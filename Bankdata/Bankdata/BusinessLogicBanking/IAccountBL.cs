using Bankdata.DTO;
using Bankdata.Models;

namespace Bankdata.BusinessLogicBanking
{
    public interface IAccountBL
    {

        public List<AccountDTO> GetAccounts();

        public AccountDTO? GetAccount(int id);

        public bool UpdateAccount(int id);

        public bool DeleteAccount(int id);

        public bool CreateAccount(AccountDTO acc);
    }
}
