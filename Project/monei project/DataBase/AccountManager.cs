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
    class AccountManager : BaseDataBaseConnection
    {
        public void createNewAccount(Account account)
        {
            OracleConnection connection = getConnection();
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = connection;
            oracleCommand.CommandText = "Insert_User";
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.Parameters.Add("p_AccountName", OracleDbType.Varchar2).Value = account.AccountName;
            oracleCommand.Parameters.Add("p_Username", OracleDbType.Varchar2).Value = account.OwnerId;
            oracleCommand.Parameters.Add("p_Ammount", OracleDbType.Varchar2).Value = account.Ammount;
            oracleCommand.Parameters.Add("p_Currency", OracleDbType.Varchar2).Value = account.Currency;
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
    }
}