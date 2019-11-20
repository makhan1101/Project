using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Store_Management.BusinessLayer;
using System.Globalization;

namespace Store_Management.BusinessLayer
{
    class Journal
    {
        static SqlConnection con = Connection.GetConnection;
        public int InsertVoucher(string Date)
        {
            int id = 0;
            string q = "insert into VoucherDetail(Date) values(@Date); SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Date", Date);
            id = Convert.ToInt16(cmd.ExecuteScalar());
            return id;
        }
        public void InsertJournal(int VoucherID,int VoucherIndex,int VoucherType,string AccountTitle, string Description,decimal DR,decimal CR,string Date)
        {
            string q = "insert into Journal(VoucherID,VoucherIndex,VoucherType,AccountTitle,Description,DR,CR,Date) values(@VoucherID,@VoucherIndex,@VoucherType" +
                ", @AccountTitle , @Description , @DR , @CR , @Date )";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@AccountTitle",AccountTitle);
            cmd.Parameters.AddWithValue("@VoucherID", VoucherID);
            cmd.Parameters.AddWithValue("@VoucherIndex", VoucherIndex);
            cmd.Parameters.AddWithValue("@VoucherType", VoucherType);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@DR", DR);
            cmd.Parameters.AddWithValue("@CR", CR);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.ExecuteNonQuery();
        }
        public void EditJournal(int VoucherID,int VoucherIndex, int VoucherType,string AccountTitle, string Description, decimal DR, decimal CR,string Date)
        {
            string q = "update Journal set VoucherType=@VoucherType, AccountTitle= @AccountTitle , @Description= @Description,CR= @CR , DR= @DR ,Date= @Date" +
                " where VoucherIndex=@VoucherIndex " +
                " and VoucherID=@VoucherID ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@AccountTitle", AccountTitle);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@DR", DR);
            cmd.Parameters.AddWithValue("@CR", CR);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@VoucherID", VoucherID);
            cmd.Parameters.AddWithValue("@VoucherIndex", VoucherIndex);
            cmd.Parameters.AddWithValue("@VoucherType", VoucherType);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }

        public void DeleteJournal(int VoucherID)
        {
            string q = "Delete Journal where VoucherID=@VoucherID ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@VoucherID", VoucherID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }

        public DataTable GetAllJournal(int id)
        {
            string q = "SELECT * FROM Journal where VoucherType=@id";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dlbl = new DataTable();
            sda.Fill(dlbl);
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
        public DataTable fillcombo1()
        {
            SqlCommand cmd = new SqlCommand("select * from Accounts where HeadAccount!='none'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable fillcombo2()
        {
            SqlCommand cmd = new SqlCommand("select * from Accounts where HeadAccount='Banks' or HeadAccount='Cash' ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public decimal GetValue(string AccountTitle)
        {
            decimal Balance = 0;
            SqlCommand cmd = new SqlCommand("SELECT Balance FROM Accounts WHERE AccountTitle= @AccountTitle ", con);
            cmd.Parameters.AddWithValue("@AccountTitle", AccountTitle);
            Balance = Convert.ToDecimal(cmd.ExecuteScalar());
            return Balance;

        }
        public string GetValue(int VoucherID,int VoucherIndex,string name)
        {
            string Balance = "";
            SqlCommand cmd = new SqlCommand("SELECT "+name+" FROM Journal WHERE VoucherID=@VoucherID and VoucherIndex=@VoucherIndex ", con);
            cmd.Parameters.AddWithValue("@VoucherID",VoucherID );
            cmd.Parameters.AddWithValue("@VoucherIndex", VoucherIndex);
            Balance = Convert.ToString(cmd.ExecuteScalar());
            return Balance;

        }
        public DataTable Search(string Title,string name,string BeforeDate,string AfterDate,int id)
        {
            IFormatProvider culture = new CultureInfo("en-US", true);
            SqlCommand cmd = new SqlCommand("USP_SearchJournal", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Title", Title));
            cmd.Parameters.Add(new SqlParameter("@name", name));
            cmd.Parameters.Add(new SqlParameter("@BeforeDate", BeforeDate));
            cmd.Parameters.Add(new SqlParameter("@AfterDate", AfterDate));
            cmd.Parameters.Add(new SqlParameter("@id", id));
            SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            return dt;
        }
    }
}
