using Bankdata.DTO;

namespace Bankdata.Repository
{
    public interface IAccountRepository<AccountDTO>
    {
        AccountDTO GetByID(int id);
        IEnumerable<AccountDTO> GetAll();
        void Add(AccountDTO entity);
        bool Delete(AccountDTO entity);
        void Update(AccountDTO entity);
        void Create(AccountDTO entity);
    }
}
