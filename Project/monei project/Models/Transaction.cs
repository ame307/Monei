using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei_project.Models
{
    class Transaction
    {
        private int transactionId, accountId, userId;
        private string transactionName, userNote, transactionDate;
        private double crediting;

        public int TransactionId
        {
            get { return transactionId; }
            set { transactionId = value; }
        }
        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string TransactionName
        {
            get { return transactionName; }
            set { transactionName = value; }
        }
        public string UserNote
        {
            get { return userNote; }
            set { userNote = value; }
        }
        public double Crediting
        {
            get { return crediting; }
            set { crediting = value; }
        }
        public string TransactionDate
        {
            get { return transactionDate; }
            set { transactionDate = value; }
        }
        public Transaction(int transactionId, int accountId, int userId, string transactionName, string userNote, double crediting)
        {
            TransactionId = transactionId;
            AccountId = accountId;
            UserId = userId;
            TransactionName = transactionName;
            UserNote = userNote;
            Crediting = crediting;
        }
        public Transaction(int transactionId, int accountId, int userId, string transactionName, double crediting)
        {
            TransactionId = transactionId;
            AccountId = accountId;
            UserId = userId;
            TransactionName = transactionName;
            Crediting = crediting;
        }
        public Transaction(int accountId, int userId, string transactionName, double crediting)
        {
            TransactionId = transactionId;
            AccountId = accountId;
            UserId = userId;
            TransactionName = transactionName;
            Crediting = crediting;
        }
        public Transaction()
        {
        }
    }
}
