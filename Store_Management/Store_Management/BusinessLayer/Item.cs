using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management.BusinessLayer
{
    class Item
    {
        static SqlConnection con = Connection.GetConnection;
        public void InsertItem(int ItemID,int Quantity,int LocationID)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM Stock WHERE LocationID = @LocationID and ItemID=@ItemID", con);
            cmmd.Parameters.AddWithValue("@LocationID", LocationID);
            cmmd.Parameters.AddWithValue("@ItemID", ItemID);
            SqlDataAdapter da = new SqlDataAdapter(cmmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i>0)
            {
                string q = "update Stock set Quantity= @Quantity where ItemID=@ItemID and LocationID=@LocationID ";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@ItemID", ItemID);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                cmd.Parameters.AddWithValue("@LocationID", LocationID);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string q = "insert into Stock (ItemID,Quantity,LocationID) values( @ItemID , @Quantity , @LocationID )";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@ItemID", ItemID);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                cmd.Parameters.AddWithValue("@LocationID", LocationID);
                cmd.ExecuteNonQuery();
            }
        }
        
        public void InsertItem(string Date, string Item,string Location ,string Type, int Quantity )
        {
            string q = "insert into Stock_adjustment(Date,Item,Location,Type,Quantity)" +
                " values( @Date, @Item,@Location , @Type, @Quantity )";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Item", Item);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Location", Location);
            cmd.Parameters.AddWithValue("@Type", Type);
            cmd.ExecuteNonQuery();
        }
        public void InsertItem( string Item, decimal Rate)
        {
            string q = "insert into Items(Item,Rate)" +
                " values(@Item,@Rate)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Item", Item);
            cmd.Parameters.AddWithValue("@Rate", Rate);
            cmd.ExecuteNonQuery();
        }
        public void EditItem(int ID,string Date, string Item, string Location, string Type, int Quantity)
        {
            string q = "update Stock_Adjustment set Item= @Item , Quantity= @Quantity , Location= @Location ,Type=@Type, Date=@Date where ID=@ID ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Item", Item);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Location", Location);
            cmd.Parameters.AddWithValue("@Type", Type);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
        }
        public void EditItem(int ItemID ,string Item, int Quantity,string Location)
        {
            string q = "update Items set Item= @Item , Quantity= @Quantity , Location=@Location where ItemID= @ItemID ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Item", Item);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Location", Location);
            cmd.Parameters.AddWithValue("@ItemID", ItemID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }
        public void EditItem(string Item, decimal Quantity)
        {
            string q = "update Items set  Quantity='" + Quantity + "' where Item='" + Item + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Item", Item);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }
        public void EditItem(int ItemID, string Item, decimal Rate)
        {
            string q = "update Items set  Rate='" + Rate + "' where ItemID='" + ItemID + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@ItemID", ItemID);
            cmd.Parameters.AddWithValue("@Rate", Rate);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }
        public void EditItem(string Item, decimal Quantity, string Location)
        {
            string q = "update Items set  Quantity='" + Quantity + "' where Item='" + Item + "'and Location='"+Location+"' ";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }
        public void DeleteItem(int ItemID)
        {
            string q = "Delete Items where ItemID= @ItemID ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@ItemID", ItemID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }
        public void DeleteAdjustment(int ID)
        {
            string q = "Delete Stock_Adjustment where ID= @ID ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.ExecuteNonQuery();
        }

        public DataTable GetAllItems()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Items", con);
            DataTable dlbl = new DataTable();
            sqlda.Fill(dlbl);
            return dlbl;
        }
        public DataTable GetAllItem()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select Items.Item, [Location].Location, Stock.Quantity from Items, [Location], Stock " +
                "where Items.ItemID = Stock.ItemId and Stock.LocationId = [Location].LocationId", con);
            DataTable dlbl = new DataTable();
            sqlda.Fill(dlbl);
            return dlbl;
        }
        public DataTable GetAllAdjusment()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Stock_Adjustment", con);
            DataTable dlbl = new DataTable();
            sqlda.Fill(dlbl);
            return dlbl;
        }
        public DataTable Search(string Name)
        {
            string q = "select * from Items where Item= @Name ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Name", Name);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable fillcombo()
        {
            SqlCommand cmd = new SqlCommand("select * from Location", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable fillcombo1( )
        {
            SqlCommand cmd = new SqlCommand("select * from Items", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public decimal GetValue(string Item,string Name)
        {
            decimal Balance = 0;
            SqlCommand cmd = new SqlCommand("SELECT "+Name+" FROM Items WHERE Item= @Item ", con);
            cmd.Parameters.AddWithValue("@Item", Item);
            Balance = Convert.ToDecimal(cmd.ExecuteScalar());
            return Balance;
        }
        public int GetValueForAdjustment(string MovementType,string Name)
        {
            int Balance = 0;
            SqlCommand cmd = new SqlCommand("SELECT " + Name + " FROM Movement_Type WHERE MovementType=@MovementType ", con);
            cmd.Parameters.AddWithValue("@MovementType",MovementType);
            Balance = Convert.ToInt16(cmd.ExecuteScalar());
            return Balance;
        }
        public int GetValueForStock(int ItemID,string Name,int Location)
        {
            int Balance = 0;
            SqlCommand cmd = new SqlCommand("SELECT " + Name + " FROM Stock WHERE ItemID=@ItemID and LocationID=@LocationID ", con);
            cmd.Parameters.AddWithValue("@ItemID",ItemID );
            cmd.Parameters.AddWithValue("@LocationID",Location);
            Balance = Convert.ToInt16(cmd.ExecuteScalar());
            return Balance;
        }
        public int GetRate(string Item)
        {
            int Balance = 0;
            SqlCommand cmd = new SqlCommand("SELECT Rate FROM Items WHERE Item=@Item ", con);
            cmd.Parameters.AddWithValue("@Item", Item);
            Balance = Convert.ToInt16(cmd.ExecuteScalar());
            return Balance;

        }
    }
}
