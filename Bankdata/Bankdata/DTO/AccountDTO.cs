namespace Bankdata.DTO
{
    public class AccountDTO
    {
        public int AccountID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string SurName { get; set; } = string.Empty;

        public double Balance { get; set; } = 0;
    }
}
