using Bankdata.DTO;

namespace Bankdata.BusinessLogicBanking
{
    public interface IAccountBL
    {

        public List<AccountDTO> GetAccounts();

        public AccountDTO? GetAccount(int id);

        public bool UpdateAccount(int id, double sum);

        public bool DeleteAccount(int id);

        public bool CreateAccount(AccountDTO acc);
    }
}
