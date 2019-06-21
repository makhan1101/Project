using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Management.BusinessLayer;
using System.Data.SqlClient;
using System.Data;

namespace Store_Management.BusinessLayer
{
    class DebitVoucher
    {
        static SqlConnection con = Connection.GetConnection;
        public void Insert(string Date, decimal Amount,decimal Account,string Description)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Journal(Date,Amount,Account,Description) values('" + Date + "','" + Amount + "','" + Account + "','" + Description + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
            }
        }

        
    }
}
