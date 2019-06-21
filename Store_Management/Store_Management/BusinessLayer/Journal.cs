using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Store_Management.BusinessLayer;

namespace Store_Management.BusinessLayer
{
    class Journal
    {
        static SqlConnection con = Connection.GetConnection;
        public void InsertJournal(string Date, int AccountID,string Description,decimal DR,decimal CR,decimal Balance,int TypeID)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Journal(Date,AccountID,Description,DR,CR,Balance,TypeID) values('"+ Date +"','"+AccountID+"','"+Description+"','"+DR+"','"+CR+"','"+Balance+"','"+TypeID+'")";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
            }
        }
        
    }
}
