using System.Collections;

namespace Ex2
{
    class DateTimeComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            BankOperation op1 = (BankOperation)x;
            BankOperation op2 = (BankOperation)y;
            return -(op1.DateTime.CompareTo(op2.DateTime));
        }
    }
}
