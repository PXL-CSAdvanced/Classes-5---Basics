using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsApp
{
    public class BankAccount
    {
        public Person Owner { get; set; }
        public string AccountNumber { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }

        public double Saldo()
        {
            double saldo = 0;
            foreach (var transaction in Transactions)
            {
                saldo += transaction.Amount;
            }
            return saldo;
        }
    }
}
