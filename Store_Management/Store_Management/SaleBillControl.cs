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
    public partial class SaleBillControl : UserControl
    {
       static public string Date { get; set; }
       static public string Party { get; set; }
       static public string Total { get; set; }
       static public string type { get; set; }
       static public int id { get; set; }
        SaleBill sale = new SaleBill();
        Journal Journal = new Journal();
        private static SaleBillControl _Insatance;

        public static SaleBillControl Instance
        {
            get
            {
                if (_Insatance == null)
                {
                    _Insatance = new SaleBillControl();
                }
                return (_Insatance);
            }
        }
        public SaleBillControl(int i)
        {
        }

        private SaleBillControl()
        {
            InitializeComponent();
            initialize();
            refreshdata();
            Before_dp.Enabled = false;
            After_dp.Enabled = false;
        }
        public void refreshdata()
        {
            DataRow dr;
            DataTable dt = Journal.fillcombo();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "All"};
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
            dataGridView1.Columns[0].DefaultCellStyle.Format = "dd-MM-yyyy";
            //dataGridView1.DataSource = acc.GetAllAccounts();
        }
        public void view1()
        {
            DataTable dt = new DataTable();
            dt = sale.GetAllBills("SaleBill");

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = Convert.ToDateTime(item[0].ToString());
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
            }

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
            //DataTable dt = new DataTable();
            //dt = sale.GetAllBills("SaleBill");

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dta.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = Convert.ToDateTime(item[0].ToString());
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                Party  = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               Date = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                type = "Edit";
                Add_SaleBill a = new Add_SaleBill();
                a.Text = "Edit";
                a.ShowDialog();
                initialize();
            }
            if (e.ColumnIndex == 5)
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    sale.DeleteBill(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
                }
                initialize();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            type = "Add";
            Add_SaleBill a = new Add_SaleBill();
            a.ShowDialog();
            initialize();
            refreshdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //if (Title_CB.Text != "Date" && string.IsNullOrWhiteSpace(SearchtextBox.Text) != true)
            //{
            //    DataTable dta = sale.Search(Title_CB.Text, SearchtextBox.Text, null);
            //    initialize(dta);
            //}
            //else if (Title_CB.Text == "Date" && Before_c.Checked == true)
            //{
            //    DataTable dta = sale.Search("Before", "Date", Search_dateTimePicker.Text);
            //    initialize(dta);
            //}
            //else if (Title_CB.Text == "Date" && After_c.Checked == true)
            //{
            //    DataTable dta = sale.Search("After", "Date", Search_dateTimePicker.Text);
            //    initialize(dta);
            //}
            //else if (string.IsNullOrWhiteSpace(SearchtextBox.Text) == true)
            //{
            //    initialize();
            //}
        }

        private void Title_CB_TextChanged(object sender, EventArgs e)
        {
            //if (Title_CB.Text == "Date")
            //{
            //    SearchtextBox.Visible = false;
            //    Search_dateTimePicker.Visible = true;
            //    Before_c.Visible = true;
            //    After_c.Visible = true;
            //}
            //else
            //{
            //    SearchtextBox.Visible = true;
            //    Search_dateTimePicker.Visible = false;
            //    Before_c.Visible = false;
            //    After_c.Visible = false;
            //}
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (AccountTitle_CB.Text == "All" && Before_c.Checked == false && After_c.Checked == false)
            {
                DataTable dta = sale.Search("0", "0", null, Convert.ToDateTime(After_dp.Text));
                initialize(dta);
            }
            else if (AccountTitle_CB.Text != "All" && Before_c.Checked == false && After_c.Checked == false)
            {
                DataTable dta = sale.Search("0", AccountTitle_CB.Text, null, Convert.ToDateTime(After_dp.Text));
                initialize(dta);
            }
            else if (AccountTitle_CB.Text == "All" && Before_c.Checked == true && After_c.Checked == true)
            {
                DataTable dta = sale.Search("Date", "Date", Before_dp.Text, Convert.ToDateTime(After_dp.Text));
                initialize(dta);
            }
            else if (AccountTitle_CB.Text == "All" && Before_c.Checked == true && After_c.Checked == false)
            {
                DataTable dta = sale.Search("Before", "Date", Before_dp.Text, Convert.ToDateTime(After_dp.Text));
                initialize(dta);
            }
            else if (AccountTitle_CB.Text == "All" && Before_c.Checked == false && After_c.Checked == true)
            {
                DataTable dta = sale.Search("After", "Date", null, Convert.ToDateTime(After_dp.Text));
                initialize(dta);
            }
            else if (AccountTitle_CB.Text != "All" && Before_c.Checked == true && After_c.Checked == true)
            {
                DataTable dta = sale.Search("DateFull", AccountTitle_CB.Text, Before_dp.Text, Convert.ToDateTime(After_dp.Text));
                initialize(dta);
            }
            else if (AccountTitle_CB.Text != "All" && Before_c.Checked == true && After_c.Checked == false)
            {
                DataTable dta = sale.Search("DateBefore", AccountTitle_CB.Text, Before_dp.Text, Convert.ToDateTime(After_dp.Text));
                initialize(dta);
            }
            else if (AccountTitle_CB.Text != "All" && Before_c.Checked == false && After_c.Checked == true)
            {
                DataTable dta = sale.Search("DateAfter", AccountTitle_CB.Text, null, Convert.ToDateTime(After_dp.Text));
                initialize(dta);
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

        private void AccountTitle_CB_Click(object sender, EventArgs e)
        {
            refreshdata();
        }
    }
}
