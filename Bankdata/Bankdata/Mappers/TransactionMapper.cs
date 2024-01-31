using Bankdata.DTO;
using Bankdata.Models;

namespace Bankdata.Mappers
{
    public class TransactionMapper
    {
        public TransactionMapper() { }

        public static TransactionDTO toDTO (Transaction trans)
        {
            return new TransactionDTO()
            {
                TransactionID = trans.TransactionID,
                ProviderId = trans.AccountID,
                ReceiverId = trans.ReceiverID,
                TransferSum = trans.Amount,
                DateTime = trans.Modified,
            };
        }

        public static Transaction ToTransaction(TransactionDTO trans)
        {
            return new Transaction()
            {
                TransactionID = trans.TransactionID,
                AccountID = trans.ProviderId,
                ReceiverID = trans.ReceiverId,
                Amount = trans.TransferSum,
                Modified = trans.DateTime,
            };
        }
    }
}
