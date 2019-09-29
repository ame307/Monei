using monei_project.DataBase;
using monei_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei_project.Operations
{
    class UserHandler
    {
        public string userName{ get; set; }
        private bool getUser = false;
        private bool getAccounts = false;
        private User user;
        private Account account;
        private List<Transaction> transaction;

        public UserHandler(string userName)
        {
            this.userName = userName;            
        }

        private void GetUser()
        {
            UserManager um = new UserManager();
            User user = um.getUserByName(userName);
            getUser = true;
        }

        private void GetAccounts()
        {
            if(!getUser)
            {
                throw new Exception("Először futtatnod kell a GetUser metódust!");
            }
            else
            {
                AccountManager am = new AccountManager();
                account = am.getAccounts(user)[0];
            }         
        }

        private void GetTransactions()
        {
            if(!getUser || !getAccounts)
            {
                throw new Exception("Először futtatnod kell a GetUser és GetAccounts metódusokat!");
            }
            else
            {
                TransactionManager tm = new TransactionManager();
                transaction = tm.getTransactions(account);

            }
        }


    }
}
