using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei_project.DataBase
{
    class BaseDataBaseConnection
    {
        protected BaseDataBaseConnection() { }
        private string connectionString
        {
            //adatbázis szerver
            get { return "Data Source=donfamilia.tk;User Id=W1O67X;Password=killmepls;"; }
            //eke adatbázis
            //get { return "Data Source=193.225.33.71;User Id=W1O67X;Password=szelektcsillag;"; }
        }
        protected OracleConnection getConnection()
        {
            OracleConnection connection = new OracleConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
