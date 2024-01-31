using Bankdata.Models;
using Microsoft.EntityFrameworkCore;

namespace Bankdata.Repository
{
    public class AccountRepo<T> : IAccountRepository<Account> where T : class
    {
        private readonly DbContext _context = null!;
        private readonly DbSet<Account> _dbSet = null!;

        public bool Add(Account entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Account entity)
        {
            try
            {
                _context.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public IEnumerable<Account> GetAll()
        {
            var accList = _dbSet.ToList();
            IEnumerable<Account> retList = new List<Account>();
            foreach (var acc in accList)
            {
                new Account
                {
                    AccountID = acc.AccountID,
                    Balance = acc.Balance,
                    SurName = acc.SurName,
                    FirstName = acc.FirstName,
                };
            }

            return retList;
        }

        public Account? GetByID(int id)
        {
            var account = _dbSet.FirstOrDefault(x => x.AccountID == id);
            return account != null ? new Account()
            {
                AccountID = account.AccountID,
                Balance = account.Balance,
                FirstName = account.FirstName,
                SurName = account.SurName
            } : null;
        }


        public void Update(Account entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
