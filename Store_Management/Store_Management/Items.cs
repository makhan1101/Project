using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store_Management.BusinessLayer;

namespace Store_Management
{
    public partial class Items : UserControl
    {
        Item it = new Item();
        int id = 0;
        string t;
        private static Items _Insatance;

        public static Items Instance
        {
            get
            {
                if (_Insatance == null)
                {
                    _Insatance = new Items();
                }
                return (_Insatance);
            }
        }
        public Items(int i)
        {
            
        }
        private Items()
        {
            t = "Add";
            InitializeComponent();
            initialize();
        }
        public void initialize()
        {
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoResizeColumns();
            view1();

            //dataGridView1.DataSource = acc.GetAllAccounts();
        }
        public void view1()
        {
            DataTable dt = new DataTable();
            dt = it.GetAllItems();

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
            }

        }
        public bool varify()
        {
            if (string.IsNullOrEmpty(Item_tb.Text))
            {
                MessageBox.Show("Enter Item name");
                return false;
            }
            else if (string.IsNullOrEmpty(Rate_tb.Text))
            {
                MessageBox.Show("Enter Rate");
                return false;
            }
            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                t = "Edit";
                id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Item_tb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Rate_tb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                btn.Text = "Edit";
                initialize();
            }
            if (e.ColumnIndex == 4)
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    it.DeleteItem(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                }
                initialize();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (varify() == true)
            {
                if (t == "Add")
                {
                   it.InsertItem(Item_tb.Text,Convert.ToDecimal(Rate_tb.Text));
                    //if (i==0)
                    //{
                    //    MessageBox.Show("item already exsist");
                    //}
                    initialize();
                    Item_tb.Text = null;
                    Rate_tb.Text = null;
                }
                else if (t == "Edit")
                {
                    int i = Convert.ToInt16(it.GetValue(Item_tb.Text, "Rate"));
                    it.EditItem(id, Item_tb.Text, Convert.ToDecimal(Rate_tb.Text));
                    btn.Text = "Add";
                    t = "Add";
                    Item_tb.Text = null;
                    Rate_tb.Text = null;
                    initialize();
                }
            }
        }
    }
}
