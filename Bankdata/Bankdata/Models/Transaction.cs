namespace Bankdata.Models
{
    public class Transaction
    {
        public DateTime? Created { get; set; }
        public int ReceiverID { get; set; }
        public int AccountID { get; set; }
        public int Amount { get; set; } = 0;
    }
}
