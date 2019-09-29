using monei_project.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace monei_project.DataBase
{
    class TransactionManager : BaseDataBaseConnection
    {
        public void createNewTransaction(Transaction transaction)
        {
            OracleConnection connection = getConnection();
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = connection;
            if (transaction.UserNote != "" && transaction.UserNote != null)
            {
                oracleCommand.CommandText = "Insert_Transaction_With_Note";
                oracleCommand.Parameters.Add("p_UserNote", OracleDbType.Varchar2).Value = transaction.UserNote;
            }
            else
                oracleCommand.CommandText = "Insert_Transaction";
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.Parameters.Add("p_AccountId", OracleDbType.Varchar2).Value = transaction.AccountId;
            oracleCommand.Parameters.Add("p_UserId", OracleDbType.Varchar2).Value = transaction.UserId;
            oracleCommand.Parameters.Add("p_TransactionName", OracleDbType.Varchar2).Value = transaction.TransactionName;
            oracleCommand.Parameters.Add("p_Crediting", OracleDbType.Varchar2).Value = transaction.Crediting;
            oracleCommand.BindByName = true;
            oracleCommand.ExecuteNonQuery();
            connection.Close();
        }
        public List<Account> getAccounts(User user)
        {
            OracleConnection connection = getConnection();
            List<Account> list = new List<Account>();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT * FROM monei_account WHERE userid = {user.Id}";
            command.Connection = connection;


            try
            {
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Account account = new Account();
                    account.AccountId = int.Parse(reader["accountid"].ToString());
                    account.AccountName = reader["accountname"].ToString();
                    account.OwnerId = int.Parse(reader["userid"].ToString());
                    account.Ammount = Convert.ToDouble(reader["amount"].ToString());
                    account.Currency = reader["currency"].ToString();
                    //account.Creatdate = reader["creatdate"].ToString();
                    list.Add(account);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
                MessageBox.Show("Exception Source: " + ex.Source);
            }

            connection.Close();
            return list;
        }
        public List<Transaction> getTransactions(Account account)
        {
            List<Transaction> transactions = new List<Transaction>();
            OracleConnection connection = getConnection();
            List<Account> list = new List<Account>();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT * FROM monei_transaction WHERE accountid = {account.AccountId}";
            command.Connection = connection;
            try
            {
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Transaction transaction = new Transaction();
                    transaction.TransactionId = int.Parse(reader["transactionid"].ToString());
                    transaction.AccountId = int.Parse(reader["accountid"].ToString());
                    transaction.UserId = int.Parse(reader["userid"].ToString());
                    transaction.TransactionName = reader["transactionname"].ToString();
                    transaction.Crediting = Convert.ToDouble(reader["crediting"].ToString());
                    transaction.UserNote = reader["usernote"].ToString();
                    transaction.TransactionDate = Convert.ToDateTime(reader["transactiondate"]).ToString();
                    transactions.Add(transaction);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
                MessageBox.Show("Exception Source: " + ex.Source);
            }

            connection.Close();
            return transactions;
        }
    }
}
