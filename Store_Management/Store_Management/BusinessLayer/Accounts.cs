using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Data;

namespace Store_Management.BusinessLayer
{
    public class Accounts
    {
        static SqlConnection con=Connection.GetConnection;
        public void InsertAccount(string AccountTitle,string Balance)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Accounts(AccountTitle,Balance) values('" + AccountTitle + "','" + Balance + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditAccount(string AccountTitle, string Balance)
        {
            string q = "update Accounts set Balance='" + Balance + "'where AccountTitle='" + AccountTitle + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            sda.SelectCommand.ExecuteNonQuery();
        }

        public void DeleteAccount(string AccountTitle)
        {
            string q = "Delete Accounts where AccountTitle='" + AccountTitle + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            sda.SelectCommand.ExecuteNonQuery();
        }

        public DataTable GetAllAccounts()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Accounts", con);
            DataTable dlbl = new DataTable();
            sqlda.Fill(dlbl);
            return dlbl;
        }
    }
}
