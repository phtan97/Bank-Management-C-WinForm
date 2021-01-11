using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BankManagement
{
    public class DTO_Connect
    {
        private static string server;
        private static string db;

        public static string Server
        {
            get
            {
                return server;
            }

            set
            {
                server = value;
            }
        }

        public static string Db
        {
            get
            {
                return db;
            }

            set
            {
                db = value;
            }
        }

        public DTO_Connect() { }
        public DTO_Connect(string Server, string Db)
        {
            DTO_Connect.Server = Server;
            DTO_Connect.Db = Db;
        }
    }
}
