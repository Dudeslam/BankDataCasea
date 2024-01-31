namespace Bankdata.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime Modified { get; set; }
        public int ReceiverID { get; set; }
        public int AccountID { get; set; }
        public double Amount { get; set; } = 0;
        public int TransactionID { get; set; }
    }
}
