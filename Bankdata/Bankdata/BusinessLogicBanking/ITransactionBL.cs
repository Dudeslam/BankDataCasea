using Bankdata.DTO;
namespace Bankdata.BusinessLogicBanking
{
    public interface ITransactionBL
    {
        public TransactionDTO? GetTransaction(int transID);

        public bool Transfer(TransactionDTO transaction);

        public List<int> GetAllTransaction(int accID);

        public bool UpdateTransaction(int transID, double sum);
    }
}
