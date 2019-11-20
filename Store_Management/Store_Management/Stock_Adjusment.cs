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
    public partial class Stock_Adjusment : UserControl
    {
        Journal j = new Journal();
        public static string type { get; set; }
        public static string Date { get; set; }
        public static int ID { get; set; }
        public static string Item { get; set; }
        public static string Loc { get; set; }
        public static int Quantity { get; set; }
        public static string Type { get; set; }
        public static bool Check { get; set; }
        Item i = new Item();
        private static Stock_Adjusment _Insatance;

        public static Stock_Adjusment Instance
        {
            get
            {
                if (_Insatance == null)
                {
                    _Insatance = new Stock_Adjusment();
                }
                return (_Insatance);
            }

        }
        private Stock_Adjusment()
        {
            InitializeComponent();
            refreshdata();
            initialize();
            Before_dp.Enabled = false;
            After_dp.Enabled = false;
        }
        public void refreshdata()
        {
            DataRow dr;
            DataTable dt = j.fillcombo();
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
            dataGridView1.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd";
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
                dataGridView1.Rows[n].Cells[1].Value = Convert.ToDateTime(item[1].ToString());
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
            }
        }
        public void view1()
        {
            DataTable dt = new DataTable();
            dt = i.GetAllAdjusment();

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = Convert.ToDateTime(item[1].ToString());
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
            }

        }
        private void Stock_Adjusment_Load(object sender, EventArgs e)
        {

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            type = "Add";
            Add_StockAdjusment aj = new Add_StockAdjusment();

            aj.Text = "Add";
            aj.ShowDialog();
            initialize();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            Date = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Item = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Loc = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Quantity = Convert.ToInt16(dataGridView1.CurrentRow.Cells[4].Value);
            Type = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            if (e.ColumnIndex == 6)
            {
                type = "Edit";
                Add_StockAdjusment aj = new Add_StockAdjusment();
                aj.Text = "Edit";
                aj.ShowDialog();
                initialize();
            }
            if (e.ColumnIndex == 7)
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    i.DeleteAdjustment(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                }
                initialize();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (AccountTitle_CB.Text == "All" && Before_c.Checked == false && After_c.Checked == false)
            //{
            //    DataTable dta = Journal.Search("0", "0", null, null, 3);
            //    initialize(dta);
            //}
            //else if (AccountTitle_CB.Text != "All" && Before_c.Checked == false && After_c.Checked == false)
            //{
            //    DataTable dta = Journal.Search("0", AccountTitle_CB.Text, null, null, 3);
            //    initialize(dta);
            //}
            //else if (AccountTitle_CB.Text == "All" && Before_c.Checked == true && After_c.Checked == true)
            //{
            //    DataTable dta = Journal.Search("DateFull", "Date", Before_dp.Text, After_dp.Text, 3);
            //    initialize(dta);
            //}
            //else if (AccountTitle_CB.Text == "All" && Before_c.Checked == true && After_c.Checked == false)
            //{
            //    DataTable dta = Journal.Search("Before", "Date", Before_dp.Text, null, 3);
            //    initialize(dta);
            //}
            //else if (AccountTitle_CB.Text == "All" && Before_c.Checked == false && After_c.Checked == true)
            //{
            //    DataTable dta = Journal.Search("After", "Date", null, After_dp.Text, 3);
            //    initialize(dta);
            //}
            //else if (AccountTitle_CB.Text != "All" && Before_c.Checked == true && After_c.Checked == true)
            //{
            //    DataTable dta = Journal.Search("DateFull", AccountTitle_CB.Text, Before_dp.Text, After_dp.Text, 3);
            //    initialize(dta);
            //}
            //else if (AccountTitle_CB.Text != "All" && Before_c.Checked == true && After_c.Checked == false)
            //{
            //    DataTable dta = Journal.Search("DateBefore", AccountTitle_CB.Text, Before_dp.Text, null, 3);
            //    initialize(dta);
            //}
            //else if (AccountTitle_CB.Text != "All" && Before_c.Checked == false && After_c.Checked == true)
            //{
            //    DataTable dta = Journal.Search("DateAfter", AccountTitle_CB.Text, null, After_dp.Text, 3);
            //    initialize(dta);
            //}
        }

        private void After_c_CheckedChanged(object sender, EventArgs e)
        {
            if (After_c.Checked == true)
            {
                After_dp.Enabled = true;
            }
            else
            {
                After_dp.Enabled = false;
            }
        }

        private void Before_c_CheckedChanged(object sender, EventArgs e)
        {
            if (Before_c.Checked == true)
            {
                Before_dp.Enabled = true;
            }
            else
            {
                Before_dp.Enabled = false;
            }
        }

        private void AccountTitle_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AccountTitle_CB_Click(object sender, EventArgs e)
        {
            //refreshdata();
        }
    }
}
