using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
   public class Balance
    {
        string customername;
        double _balance;

        public Balance( string customername1, double bal)
        {
            customername = customername1;
            _balance = bal;

        }
public double bal { get { return _balance; } }

        public void Debit(double amount)
        {
            if (_balance == 0)
                throw new Exception("balance=0");
            if (amount <= 0 || amount > _balance)
                throw new ArgumentOutOfRangeException("amount<=0 r amount>balance");
            _balance -= amount;

        }
        public void Credit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException("amount<=0");
            _balance += amount;

        }
    }
}
