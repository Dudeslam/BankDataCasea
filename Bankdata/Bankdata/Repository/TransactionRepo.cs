using Bankdata.Models;
using Microsoft.EntityFrameworkCore;

namespace Bankdata.Repository
{
    public class TransactionRepo<T> : ITransactionRepository<Transaction> where T : class
    {
        private readonly DbContext _context = null!;
        private readonly DbSet<Transaction> _dbSet = null!;
        public bool Add(Transaction entity)
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

        public IEnumerable<Transaction> GetAll(int id)
        {
            var TransactionList = _dbSet.ToList();

            return TransactionList.Where(x => x.TransactionID == id);
        }

        public Transaction? GetById(int id)
        {
            return _dbSet.FirstOrDefault(x => x.TransactionID == id);
        }

        public bool Update(Transaction entity)
        {
            try
            {
                var transaction = _dbSet.FirstOrDefault(x => x.TransactionID == entity.TransactionID);
                if (transaction != null)
                {
                    transaction.Amount = entity.Amount;
                    transaction.ReceiverID = entity.ReceiverID;
                    transaction.Modified = DateTime.UtcNow;

                }
                _context.SaveChanges();
                return true;
            }
            catch 
            {
                return false; 
            }
        }
    }
}
