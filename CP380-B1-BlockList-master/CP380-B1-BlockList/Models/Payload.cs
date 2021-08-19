
namespace CP380_B1_BlockList.Models
{
    public enum TransactionTypes
    {
        BUY, SELL, GRANT
    }

    public class Payload
    {
        public string User { get; set; }
        public TransactionTypes TransactionType { get; set; }
        public int Amount  { get; set; }
        public string Item { get; set; }

        public Payload(string usr, TransactionTypes trans_Type, int amnt, string itm)
        {
            User = usr;
            TransactionType = trans_Type;
            Amount = amnt;
            Item = itm;
        }
    }
}

