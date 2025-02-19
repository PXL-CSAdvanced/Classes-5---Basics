using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsApp
{
    public class Transaction
    {
        private double amount;
        public double Amount
        {
            get { return amount; }
            set { amount = Math.Round(value, 2); }
        }

        public Transaction(double amount)
        {
            Amount = amount;
        }
    }
}
