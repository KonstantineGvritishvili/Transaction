using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction
{
    public class Transaction
    {
        public double Amount { get; set; }
        public int UserId { get; set; }
        public DateTime TransactionDate { get; set; }

        public Transaction(double amount, int userId)
        {
            Amount = amount;
            UserId = userId;
            TransactionDate = DateTime.Now;
        }
    }

    public static class FileManager
    {
        public static void LogTransactionToFile(Transaction transaction)
        {
            string log = $"Amount: {transaction.Amount}, UserId: {transaction.UserId}, Date: {transaction.TransactionDate}";
            File.AppendAllText("transactions.log", log + Environment.NewLine);
        }
    }
}
