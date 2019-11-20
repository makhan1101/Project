using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Store_Management.BusinessLayer;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Store_Management
{
    public partial class Account : UserControl
    {
        public static string type { get; set; }
        public static int AccountID { get; set; }
        public static string AccountTitle { get; set; }
        public static string HeadAccount { get; set; }
        public static string Balance { get; set; }
        Accounts acc = new Accounts();
        private static Account _Insatance;
        public static Account Instance
        {

            get
            {
                if (_Insatance == null)
                {
                    _Insatance = new Account();
                    
                }
                return (_Insatance);
            }

        }
        public Account(int i)
        {
        }

        private Account()
        {
            InitializeComponent();
            initialize();
            refreshdata();
        }
        public void refreshdata()
        {
            DataRow dr;
            DataTable dt = acc.fillcombo();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "All" };
            dt.Rows.InsertAt(dr, 0);

            AccountTitle_CB.ValueMember = "AccountID";

            AccountTitle_CB.DisplayMember = "AccountTitle";
            AccountTitle_CB.DataSource = dt;

        }
        public void initialize()
        {
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoResizeColumns();
            view1();
           
            //dataGridView1.DataSource = acc.GetAllAccounts();
        }
        public void initialize(DataTable dt)
        {
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoResizeColumns();
            view1(dt);
        }
        public void view1(DataTable dta)
        {
            //dt = new DataTable();

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dta.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["AccountTitle"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Balance"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["HeadAccount"].ToString();
            }
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            //acc.InsertAccount(AccountTitle_TextBox.Text, Balance_TextBox.Text);

            initialize();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            //acc.DeleteAccount(AccountTitle_TextBox.Text);

            initialize();
        }

    private void Update_button_Click(object sender, EventArgs e)
        {
           // acc.EditAccount(AccountTitle_TextBox.Text, Balance_TextBox.Text);

            initialize();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
        public DataSet FetchDataFromGrid()
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();


            foreach (DataGridViewRow item in this.dataGridView1.Rows)
            {

                DataRow dr = dt.NewRow();

                if (item.DataBoundItem != null)
                {
                    dr = (DataRow)((DataRowView)item.DataBoundItem).Row;
                    dt.ImportRow(dr);
                }
            }

            ds.Tables.Add(dt);
            return ds;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void Save_button_Click_1(object sender, EventArgs e)
        {
            type = "Add";
            Add a = new Add();

            a.Text = "Add";
            a.ShowDialog();
            initialize();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                AccountTitle = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Balance = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                AccountID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                HeadAccount= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                type  = "Edit";
                Add a = new Add();
                a.Text = "Edit";
                a.ShowDialog();
                initialize();
            }
            if (e.ColumnIndex==5)
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    acc.DeleteAccount(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                }
                initialize();
            }
        }
        public void view1()
        {
            DataTable dt = new DataTable();
            dt = acc.GetAllAccounts();

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["AccountTitle"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Balance"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["HeadAccount"].ToString();
            }
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }

        private void ControlPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Title_CB_Click(object sender, EventArgs e)
        {
            //if (Title_CB.Text=="Date")
            //{
            //    Before_c.Visible = true;
            //    After_c.Visible = true;
            //}
            //else
            //{
            //    Before_c.Visible = false;
            //    After_c.Visible = false;
            //}
        }

        private void Title_CB_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AccountTitle_CB.Text!= "All")
            {
                DataTable dta = acc.Search(AccountTitle_CB.Text);
                initialize(dta);
            }
            else
            {
                initialize();
            }
        }

        private void AccountTitle_CB_Click(object sender, EventArgs e)
        {
            refreshdata();
        }
    }
}
