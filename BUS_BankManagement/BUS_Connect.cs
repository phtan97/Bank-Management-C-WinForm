using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_BankManagement;
using DTO_BankManagement;
using System.Data.SqlClient;

namespace BUS_BankManagement
{
    public class BUS_Connect
    {
        DAL_Connect dal;
         public string Connect(string server, string db)
        {
            dal = new DAL_Connect();
            return dal.Connection(server, db);
        }
    }
}
