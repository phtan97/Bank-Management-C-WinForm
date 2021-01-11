using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BankManagement;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace DAL_BankManagement
{
    public class DAL_Connect : DTO_Connect
    {
        protected static SqlConnection _conn;
        protected static string _connStr;
        public DAL_Connect()
        {
            _conn = new SqlConnection(_connStr);
        }
        public string Connection(string server, string db)
        {
            _connStr = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", server, db);
            return _connStr;
        }
    }
}
