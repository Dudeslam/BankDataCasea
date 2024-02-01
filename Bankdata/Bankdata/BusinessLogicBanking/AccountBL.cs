using Bankdata.Mappers;
using Bankdata.DTO;
using Bankdata.Models;
using Bankdata.Repository;

namespace Bankdata.BusinessLogicBanking
{
    public class AccountBL : IAccountBL
    {
        private AccountMapper accMapper = new AccountMapper();
        private readonly IAccountRepository<Account> _Accountrepository;
        
        public AccountBL(IAccountRepository<Account> AccountRepository)
        {
            _Accountrepository = AccountRepository;
        }
        public List<AccountDTO> GetAccounts()
        {
            List<AccountDTO> accounts = new List<AccountDTO>();
            _Accountrepository.GetAll().ToList().ForEach(x => accounts.Add(new AccountDTO(x.AccountID, x.FirstName, x.SurName, x.Balance)));
            return accounts;
        }

        public AccountDTO? GetAccount(int id)
        {
            var accData = _Accountrepository.GetByID(id);
            return accData != null ? AccountMapper.ToDTO(accData) : null;
        }

        public bool UpdateAccount(int id, double sum)
        {
            var accData = _Accountrepository.GetByID(id);
            accData.Balance += sum;
            _Accountrepository.Update(accData);
            return true;
        }

        public bool CreateAccount(AccountDTO acc)
        {
            return _Accountrepository.Add(AccountMapper.ToAccount(acc));
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
