namespace Bankdata.Models
{
    public class Transactions
    {
        public int TransactionId { get; set; }
        public DateTime Modified { get; set; }
        public int ReceiverID { get; set; }
        public int ProviderID { get; set; }
        public double Amount { get; set; } = 0;
        public int TransactionID { get; set; }
    }
}
