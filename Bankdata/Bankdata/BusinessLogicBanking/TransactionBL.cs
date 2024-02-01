using Bankdata.DTO;
using Bankdata.Mappers;
using Bankdata.Models;
using Bankdata.Repository;
using Humanizer;

namespace Bankdata.BusinessLogicBanking
{

    public class TransactionBL : ITransactionBL
    {
        private TransactionMapper transMapper = new TransactionMapper();
        private readonly ITransactionRepository<Transactions> _TransactionRepository;

        public TransactionBL(ITransactionRepository<Transactions> TransactionRepository)
        {
            _TransactionRepository = TransactionRepository;
        }

        public List<int> GetAllTransaction(int accID)
        {
            List<int> result = new List<int>();
            _TransactionRepository.GetAll(accID).ToList().ForEach(x => result.Add(x.TransactionID));
            return result;
        }

        public TransactionDTO? GetTransaction(int transID)
        {
            var transData = _TransactionRepository.GetById(transID);
            return transData != null ? TransactionMapper.toDTO(transData) : null;
        }

        public bool Transfer(TransactionDTO dto)
        {
            Transactions newTransfer = new Transactions()
            {
                ProviderID = dto.ProviderId,
                ReceiverID = dto.ReceiverId,
                Amount = dto.TransferSum,
                Modified = dto.DateTime,
            };

            return _TransactionRepository.Add(newTransfer);
        }

        public bool UpdateTransaction(int transID, double sum)
        {
            var transaction = _TransactionRepository.GetById(transID);
            if (transaction != null)
            {
                transaction.Modified = DateTime.UtcNow;
                transaction.Amount = sum;

                return _TransactionRepository.Update(transaction);
            }

            return false;
        }
    }
}
