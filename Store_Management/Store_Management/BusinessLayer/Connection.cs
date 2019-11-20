using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace Store_Management.BusinessLayer
{
    public class Connection
    {
        private static SqlConnection _connection;
        public static string connectionString = @"Data Source=DESKTOP-QPV5LDM;Initial Catalog=F:\MQPASTA\PROJECT-MASTER\STORE_MANAGEMENT\STORE_MANAGEMENT\DATABASE\INVENTORYSYSTEM.MDF;Integrated Security=True";     
        private Connection()
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }
        public static SqlConnection GetConnection
        {
            get
            {
                Connection con = new Connection();
                
                return _connection;
            }
        }
    }
}
