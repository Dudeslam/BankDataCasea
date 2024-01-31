namespace Bankdata.DTO
{
    public class TransactionDTO
    {
        public int ProviderId { get; set; }
        public int ReceiverId { get; set; }

        public int TransactionID { get; set; }
        public double TransferSum { get; set; }
        public DateTime DateTime { get; set; }

        public TransactionDTO() { }
        
        public TransactionDTO(int accId, int transId,  double transferSum, DateTime date)
        {
            ProviderId = accId;
            ReceiverId = transId;
            TransactionID = transId;
            TransferSum = transferSum;
            DateTime = date;
        }

    }
}
