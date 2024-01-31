namespace Bankdata.Models
{
    public class Account
    {

        public int AccountID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string SurName {  get; set; } = string.Empty;

        public double Balance { get; set; } = 0;


        public Account(int id, string fName, string sName, double balance)
        {
            AccountID = id;
            FirstName = fName;
            SurName = sName;
            Balance = balance;
        }
        public Account() { }

    }
}
