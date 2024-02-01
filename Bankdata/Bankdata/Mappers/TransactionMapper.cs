using Bankdata.DTO;
using Bankdata.Models;

namespace Bankdata.Mappers
{
    public class TransactionMapper
    {
        public TransactionMapper() { }

        public static TransactionDTO toDTO (Transactions trans)
        {
            return new TransactionDTO()
            {
                TransactionID = trans.TransactionID,
                ProviderId = trans.ProviderID,
                ReceiverId = trans.ReceiverID,
                TransferSum = trans.Amount,
                DateTime = trans.Modified,
            };
        }

        public static Transactions ToTransaction(TransactionDTO trans)
        {
            return new Transactions()
            {
                TransactionID = trans.TransactionID,
                ProviderID = trans.ProviderId,
                ReceiverID = trans.ReceiverId,
                Amount = trans.TransferSum,
                Modified = trans.DateTime,
            };
        }
    }
}
