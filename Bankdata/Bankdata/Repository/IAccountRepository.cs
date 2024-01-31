using Bankdata.Models;

namespace Bankdata.Repository
{
    public interface IAccountRepository<Account>
    {
        Account? GetByID(int id);
        IEnumerable<Account> GetAll();
        bool Add(Account entity);
        bool Delete(Account entity);
        void Update(Account entity);
    }
}
