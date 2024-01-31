using Bankdata.Models;

namespace Bankdata.Repository
{
    public interface ITransactionRepository<Transaction>
    {
        Transaction? GetById(int id);

        IEnumerable<Transaction> GetAll(int id);

        bool Add(Transaction entity);     

        bool Update(Transaction entity);
    }
}
