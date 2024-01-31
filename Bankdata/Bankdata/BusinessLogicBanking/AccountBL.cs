using Bankdata.Models;
using Bankdata.Repository;

namespace Bankdata.BusinessLogicBanking
{
    public class AccountBL : IAccountBL
    {
        private readonly IRepository<Account> _Accountrepository;

        public AccountBL(IRepository<Account> AccountRepository)
        {
            _Accountrepository = AccountRepository;
        }
        public List<Account> GetAccounts()
        {
            var ListOfAccounts = _Accountrepository.GetAll().ToList();
            return ListOfAccounts;
        }

        public Account GetAccount(int id)
        {
            return _Accountrepository.GetByID(id) ?? new Account();
        }

        public bool UpdateAccount(int id)
        {
            var account = new Account();
            return true;
        }

        public void CreateAccount(Account acc)
        {
            _Accountrepository.Create(acc);
        }

        public bool DeleteAccount(int id)
        {
            var account = _Accountrepository.GetByID(id);
            if(account != null)
            {
                return _Accountrepository.Delete(account);
            }
            return false;
        }
    }
}
