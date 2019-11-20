using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management.BusinessLayer
{
    class SaleBill
    {
        static SqlConnection con = Connection.GetConnection;
        public int InsertBill(string Date, string Party,string Total)
        {
            int id=0;
            string q = "insert into SaleBill(Date,Party,Total) values(@Date,@Party,@Total); SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Date",Date);
            cmd.Parameters.AddWithValue("@Party", Party);
            cmd.Parameters.AddWithValue("@Total", Total);
            id = Convert.ToInt16(cmd.ExecuteScalar());
            return id;
        }
        public void InsertBill( int SaleBillID, string Item,int Quantity,int Rate,int Amount)
        {
            string q = "insert into SaleBillDetail(SaleBillID,Item,Quantity,Rate,Amount) values( @SaleBillID , @Item , @Quantity , @Rate , @Amount )";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@SaleBillID", SaleBillID);
            cmd.Parameters.AddWithValue("@Item", Item);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Rate", Rate);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.ExecuteNonQuery();
        }
        public void EditBill(int SaleBillID, string Item,int Quantity,int Rate,int Amount)
        {
            string q = "update SaleBillDetail set Quantity= @Quantity , Rate=@Rate ,Amount= @Amount where SaleBillID= @SaleBillID and Item= @Item";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@SaleBillID", SaleBillID);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Item", Item);
            cmd.Parameters.AddWithValue("@Rate", Rate);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }
        public void EditBill(int SaleBillID, string  Date, string Party, string Total)
        {
            string q = "update SaleBill set Date= @Date , Party= @Party , Total= @Total where [SaleBillID]= @SaleBillID ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@SaleBillID", SaleBillID);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Party", Party);
            cmd.Parameters.AddWithValue("@Total", Total);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }
        public void DeleteBill(int SaleBillID)
        {
            string q = "Delete SaleBill where SaleBillID= @SaleBillID ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@SaleBillID", SaleBillID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }
        public void DeleteBill(int SaleBillID,string Item)
        {
            string q = "Delete SaleBillDetail where SaleBillID= @SaleBillID ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@SaleBillID", SaleBillID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }

        public DataTable GetAllBills(string Name)
        {
            string q = "SELECT * FROM "+Name;
            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable GetAllBills(string Name,int Id)
        {
            string q = "SELECT * FROM  "+Name+" Where SaleBillID= @Id";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public int GetValue(string Party, string Name)
        {
            int Balance = 0;
            SqlCommand cmd = new SqlCommand("SELECT "+Name+"  FROM SaleBill WHERE Party= @Party ", con);
            cmd.Parameters.AddWithValue("@Party", Party);
            Balance = Convert.ToInt16(cmd.ExecuteScalar());
            return Balance;
        }
        public DataTable Search(string Title, string name, string BeforeDate, DateTime AfterDate)
        {
            DateTime d1 = Convert.ToDateTime(BeforeDate);
            //DateTime d2 = Convert.ToDateTime(AfterDate);
            IFormatProvider culture = new CultureInfo("en-US", true);
            SqlCommand cmd = new SqlCommand("USP_Search", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Title", Title));
            cmd.Parameters.Add(new SqlParameter("@name", name));
            cmd.Parameters.Add(new SqlParameter("@BeforeDate", d1.ToString("yyyy-MM-dd")));
            cmd.Parameters.Add(new SqlParameter("@AfterDate", AfterDate.ToString("yyyy-MM-dd")));
            SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            return dt;
        }
    }
}
