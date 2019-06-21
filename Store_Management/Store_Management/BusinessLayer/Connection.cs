using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Store_Management.BusinessLayer
{
    public class Connection
    {
        private static SqlConnection _connection;
        string connectionString = "Data Source=DESKTOP-P21QVG6\\SQLEXPRESS;Initial Catalog=Store;Integrated Security=True";        
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
