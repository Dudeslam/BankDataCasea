using Bankdata.DTO;
using Microsoft.EntityFrameworkCore;

namespace Bankdata.Repository
{
    public class AccountRepo<T> : IAccountRepository<AccountDTO> where T : class
    {
        private readonly IAccountRepository<T> _repository;
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public void Add(AccountDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(AccountDTO entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountDTO> GetAll()
        {
            var accList = _dbSet.ToList();
            IEnumerable<AccountDTO> retList = new List<AccountDTO>();
            foreach (var acc in accList)
            {
                new AccountDTO
                {
                    AccountID = acc.id,
                    Balance = acc.balance,
                    SurName = acc.surName,
                    FirstName = acc.firstName,
                };
            }

            return retList;
        }

        public AccountDTO? GetByID(int id)
        {
            var account = _dbSet.FirstOrDefault(x => x.id == id);
            AccountDTO accDTO = new AccountDTO()
            {
                AccountID = account.AccountID,
                Balance = account.Balance,
                FirstName = account.FirstName,
                SurName = account.SurName
            };

            return accDTO;
        }


        public void Update(AccountDTO entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Create(AccountDTO entity)
        {
            _context.Add(entity);
        }
    }
}
