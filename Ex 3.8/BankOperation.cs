namespace Ex2
{
    public class BankOperation : IComparable
    {
        public DateTime DateTime { get; }
        public int MoneyAmount { get; }
        public string OperationType { get; }
        public int CurrentBalance { get; set; }

        public BankOperation(DateTime time, int moneyAmount, string operationType)
        {
            DateTime = time;
            MoneyAmount = moneyAmount;
            OperationType = operationType;
        }

        public int CompareTo(object x)
        {
            BankOperation a = (BankOperation)x;
            return this.DateTime.CompareTo(a.DateTime);
        }
    }
}
