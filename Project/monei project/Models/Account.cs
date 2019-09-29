using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei_project.Models
{
    class Account
    {
        private string accountName, currency, createDate;
        private double ammount = 0;
        private int accountId, ownerId;

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public int OwnerId
        {
            get { return ownerId; }
            set { ownerId = value; }
        }
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }
        public double Ammount
        {
            get { return ammount; }
            set { ammount = value; }
        }
        public string CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        public Account(int accountId, int userId, string accountName, string currency, double ammount)
        {
            AccountId = accountId;
            OwnerId = userId;
            AccountName = accountName;
            Currency = currency;
            Ammount = ammount;
        }
        public Account(int userId, string accountName, string currency)
        {
            OwnerId = userId;
            AccountName = accountName; 
            Currency = currency;        }

        public Account() { }
    }
}
