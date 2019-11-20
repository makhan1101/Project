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
    class PurchaseBills
    {
        static SqlConnection con = Connection.GetConnection;
        public int InsertBill(string Date, string Party, string Total)
        {
            int id = 0;
            string q = "insert into PurchaseBill(Date,Party,Total) values(@Date,@Party,@Total); SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Party", Party);
            cmd.Parameters.AddWithValue("@Total", Total);
            id = Convert.ToInt16(cmd.ExecuteScalar());
            return id;
        }
        public void InsertBill(int PurchaseBillID, string Item, int Quantity, int Rate, int Amount)
        {
            string q = "insert into PurchaseBillDetail(PurchaseBillID,Item,Quantity,Rate,Amount) values( @PurchaseBillID , @Item , @Quantity , @Rate , @Amount )";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@PurchaseBillID", PurchaseBillID);
            cmd.Parameters.AddWithValue("@Item", Item);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Rate", Rate);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.ExecuteNonQuery();
        }
        public void EditBill(int PurchaseBillID, string Item, int Quantity, int Rate, int Amount)
        {
            string q = "update PurchaseBillDetail set Quantity= @Quantity , Rate=@Rate ,Amount= @Amount where PurchaseBillID= @PurchaseBillID and Item= @Item";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@PurchaseBillID", PurchaseBillID);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Item", Item);
            cmd.Parameters.AddWithValue("@Rate", Rate);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }
        public void EditBill(int PurchaseBillID, string Date, string Party, string Total)
        {
            string q = "update PurchaseBill set Date= @Date , Party= @Party , Total= @Total where [PurchaseBillID]= @PurchaseBillID ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@PurchaseBillID", PurchaseBillID);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Party", Party);
            cmd.Parameters.AddWithValue("@Total", Total);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }
        public void DeleteBill(int PurchaseBillID)
        {
            string q = "Delete PurchaseBill where PurchaseBillID= @PurchaseBillID ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@PurchaseBillID", PurchaseBillID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }
        public void DeleteBill(int PurchaseBillID, string Item)
        {
            string q = "Delete PurchaseBillDetail where PurchaseBillID= @PurchaseBillID ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@PurchaseBillID", PurchaseBillID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }

        public DataTable GetAllBills(string Name)
        {
            string q = "SELECT* FROM "+Name;
            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable GetAllBills(string Name, int Id)
        {
            string q = "SELECT * FROM  "+Name+" Where PurchaseBillID= @Id";
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
            SqlCommand cmd = new SqlCommand("SELECT "+Name+"  FROM PurchaseBill WHERE Party= @Party ", con);
            cmd.Parameters.AddWithValue("@Party", Party);
            Balance = Convert.ToInt16(cmd.ExecuteScalar());
            return Balance;
        }
        public DataTable Search(string Title, string name, string BeforeDate, string AfterDate)
        {
            SqlCommand cmd = new SqlCommand("USP_SearchPurchase", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Title", Title));
            cmd.Parameters.Add(new SqlParameter("@name", name));
            cmd.Parameters.Add(new SqlParameter("@BeforeDate", BeforeDate));
            cmd.Parameters.Add(new SqlParameter("@AfterDate", AfterDate));
            SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            return dt;
        }
    }
}
