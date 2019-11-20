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
    public partial class DebitControl : UserControl
    {
        public static string type { get; set; }
        public static int JournalID { get; set; }
        public static string AccountTitle { get; set; }
        public static int VoucherID { get; set; }
        public static int VoucherIndex { get; set; }
        public static string Description { get; set; }
        public static string CR { get; set; }
        public static decimal DR { get; set; }
        Journal Journal = new Journal();
        private static DebitControl _Insatance;

        public static DebitControl Instance
        {
            get
            {
                if (_Insatance == null)
                {
                    _Insatance = new DebitControl();
                }
                return (_Insatance);
            }
        }
        public DebitControl(int i)
        {
        }
        private DebitControl()
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
            dr.ItemArray = new object[] { 0, "All" };
            dt.Rows.InsertAt(dr, 0);
            AccountTitle_CB.ValueMember = "AccountID";
            AccountTitle_CB.DisplayMember = "AccountTitle";
            AccountTitle_CB.DataSource = dt;
        }
        public void initialize()
        {
            
            view1();
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd";
            Before_dp.Enabled = false;
            After_dp.Enabled = false;
            //dataGridView1.DataSource = acc.GetAllAccounts();
        }
        public void view1()
        {
            DataTable dt = new DataTable();
            dt = Journal.GetAllJournal(1);

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = Convert.ToDateTime(item[0].ToString());
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
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
            //dt = new DataTable();

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dta.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = Convert.ToDateTime(item[0].ToString());
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
            }
        }
        private void DebitControl_Load(object sender, EventArgs e)
        {
            initialize();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {

        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            type = "Add";
            add_Debit aj = new add_Debit();

            aj.Text = "Add";
            aj.ShowDialog();
            initialize();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            JournalID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[1].Value);
            AccountTitle = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            VoucherID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[3].Value);
            VoucherIndex = Convert.ToInt16(dataGridView1.CurrentRow.Cells[4].Value);
            CR = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            DR = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            Description = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            if (e.ColumnIndex == 9)
            {
                type = "Edit";
                add_Debit aj = new add_Debit();
                aj.Text = "Edit";
                aj.ShowDialog();
                initialize();
            }
            if (e.ColumnIndex == 10)
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    Journal.DeleteJournal(Convert.ToInt16(dataGridView1.CurrentRow.Cells[3].Value));
                }
                initialize();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (Title_CB.Text != "Date" && string.IsNullOrWhiteSpace(SearchtextBox.Text) != true)
            //{
            //    DataTable dta = Journal.Search(Title_CB.Text, SearchtextBox.Text, null);
            //    initialize(dta);
            //}
            //else if (Title_CB.Text == "Date" && Before_c.Checked == true)
            //{
            //    DataTable dta = Journal.Search("Before", "Date", Search_dateTimePicker.Text);
            //    initialize(dta);
            //}
            //else if (Title_CB.Text == "Date" && After_c.Checked == true)
            //{
            //    DataTable dta = Journal.Search("After", "Date", Search_dateTimePicker.Text);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (AccountTitle_CB.Text == "All" && Before_c.Checked == false && After_c.Checked == false)
            {
                DataTable dta = Journal.Search("0", "0", null, null, 1);
                initialize(dta);
            }
            else if (AccountTitle_CB.Text != "All" && Before_c.Checked == false && After_c.Checked == false)
            {
                DataTable dta = Journal.Search("0", AccountTitle_CB.Text, null, null, 1);
                initialize(dta);
            }
            else if (AccountTitle_CB.Text == "All" && Before_c.Checked == true && After_c.Checked == true)
            {
                DataTable dta = Journal.Search("DateFull", "Date", Before_dp.Text, After_dp.Text, 1);
                initialize(dta);
            }
            else if (AccountTitle_CB.Text == "All" && Before_c.Checked == true && After_c.Checked == false)
            {
                DataTable dta = Journal.Search("Before", "Date", Before_dp.Text, null, 1);
                initialize(dta);
            }
            else if (AccountTitle_CB.Text == "All" && Before_c.Checked == false && After_c.Checked == true)
            {
                DataTable dta = Journal.Search("After", "Date", null, After_dp.Text, 1);
                initialize(dta);
            }
            else if (AccountTitle_CB.Text != "All" && Before_c.Checked == true && After_c.Checked == true)
            {
                DataTable dta = Journal.Search("DateFull", AccountTitle_CB.Text, Before_dp.Text, After_dp.Text, 1);
                initialize(dta);
            }
            else if (AccountTitle_CB.Text != "All" && Before_c.Checked == true && After_c.Checked == false)
            {
                DataTable dta = Journal.Search("DateBefore", AccountTitle_CB.Text, Before_dp.Text, null, 1);
                initialize(dta);
            }
            else if (AccountTitle_CB.Text != "All" && Before_c.Checked == false && After_c.Checked == true)
            {
                DataTable dta = Journal.Search("DateAfter", AccountTitle_CB.Text, null, After_dp.Text, 1);
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

        private void DebitControl_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("got focus");
        }

        private void DebitControl_Validated(object sender, EventArgs e)
        {
            //MessageBox.Show("validated");
        }

        public override void Refresh()
        {
            base.Refresh();
            initialize();
        }
    }
}
