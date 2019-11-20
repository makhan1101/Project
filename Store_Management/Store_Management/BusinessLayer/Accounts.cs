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
        
        static SqlConnection con = Connection.GetConnection;
        public void InsertAccount(string AccountTitle, string Balance,string HeadAccount)
        { 
            string q = "insert into Accounts(AccountTitle,Balance,HeadAccount) values(@AccountTitle ,@Balance ,@HeadAccount)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@AccountTitle",AccountTitle);
            cmd.Parameters.AddWithValue("@Balance", Balance);
            cmd.Parameters.AddWithValue("@HeadAccount", HeadAccount);
            var result = cmd.ExecuteNonQuery();
        }

        public void EditAccount(string AccountTitle, string Balance ,int AccountID, string HeadAccount)
        {
            string q = "update Accounts set Balance=@Balance , AccountTitle=@AccountTitle ,HeadAccount=@HeadAccount where AccountID=@AccountID";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@AccountTitle", AccountTitle);
            cmd.Parameters.AddWithValue("@Balance", Balance);
            cmd.Parameters.AddWithValue("@HeadAccount", HeadAccount);
            cmd.Parameters.AddWithValue("@AccountID", AccountID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }
        public void EditAccount(string AccountTitle, string Balance)
        {
            string q = "update Accounts set Balance= @Balance where AccountTitle=@AccountTitle ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@AccountTitle", AccountTitle);
            cmd.Parameters.AddWithValue("@Balance", Balance);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }
        public void DeleteAccount(int AccountID)
        {
            string q = "Delete Accounts where AccountID= @AccountID ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@AccountID", AccountID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }

        public DataTable GetAllAccounts()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Accounts", con);
            DataTable dlbl = new DataTable();
            sqlda.Fill(dlbl);
            return dlbl;
        }
        public DataTable fillcombo()
        {
            SqlCommand cmd = new SqlCommand("select * from Accounts", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable Search(string AccountTitle)
        {
            string q ="select * from Accounts where AccountTitle=@AccountTitle";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@AccountTitle", AccountTitle);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
