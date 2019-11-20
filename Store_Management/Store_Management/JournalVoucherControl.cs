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
using System.Globalization;

namespace Store_Management
{
    public partial class JournalVoucherControl : UserControl
    {
        
        public static string type { get; set; }
        public static int JournalID { get; set; }
        public static int VoucherID { get; set; }
        public static int VoucherIndex { get; set; }
        public static string AccountTitle { get; set; }
        public static string Description { get; set; }
        public static string CR { get; set; }
        public static decimal DR { get; set; }
        public static bool Check { get; set; }
        Journal Journal = new Journal();
        private static JournalVoucherControl _Insatance;

        public static JournalVoucherControl Instance
        {
            get
            {
                if (_Insatance == null)
                {
                    _Insatance = new JournalVoucherControl();
                }
                return (_Insatance);
            }
            
        }
        
       
        private JournalVoucherControl()
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
            dataGridView1.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd";
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

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        public void view1()
        {
            DataTable dt = new DataTable();
            dt = Journal.GetAllJournal(3);

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

        private void Save_button_Click(object sender, EventArgs e)
        {
            type = "Add";
            ADD_JOURNAL aj = new ADD_JOURNAL();

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
                ADD_JOURNAL aj = new ADD_JOURNAL();
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

        private void JournalVoucherControl_Load(object sender, EventArgs e)
        {
        }

        private void Title_CB_TextChanged(object sender, EventArgs e)
        {
            //if (Title_CB.Text == "Date")
            //{
            //    SearchtextBox.Visible = false;
            //    Before_dp.Visible = true;
            //    Before_c.Visible = true;
            //    After_c.Visible = true;
            //}
            //else
            //{
            //    SearchtextBox.Visible = true;
            //    Before_dp.Visible = false;
            //    Before_c.Visible = false;
            //    After_c.Visible = false;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AccountTitle_CB.Text=="All" && Before_c.Checked==false && After_c.Checked==false)
            {
                DataTable dta= Journal.Search("0", "0", null, null,3);
                initialize(dta);
            }
            else if (AccountTitle_CB.Text != "All" && Before_c.Checked == false && After_c.Checked == false)
            {
                DataTable dta = Journal.Search("0", AccountTitle_CB.Text, null, null, 3);
                initialize(dta);
            }
            else if (AccountTitle_CB.Text == "All" && Before_c.Checked == true && After_c.Checked == true)
            {
                DataTable dta = Journal.Search("DateFull", "Date", Before_dp.Text, After_dp.Text, 3);
                initialize(dta);
            }
            else if (AccountTitle_CB.Text == "All" && Before_c.Checked == true && After_c.Checked == false)
            {
                DataTable dta = Journal.Search("Before", "Date", Before_dp.Text, null, 3);
                initialize(dta);
            }
            else if (AccountTitle_CB.Text == "All" && Before_c.Checked == false && After_c.Checked == true)
            {
                DataTable dta = Journal.Search("After", "Date", null, After_dp.Text, 3);
                initialize(dta);
            }
            else if (AccountTitle_CB.Text != "All" && Before_c.Checked == true && After_c.Checked == true)
            {
                DataTable dta = Journal.Search("DateFull", AccountTitle_CB.Text, Before_dp.Text, After_dp.Text, 3);
                initialize(dta);
            }
            else if (AccountTitle_CB.Text != "All" && Before_c.Checked == true && After_c.Checked == false)
            {
                DataTable dta = Journal.Search("DateBefore", AccountTitle_CB.Text, Before_dp.Text, null, 3);
                initialize(dta);
            }
            else if (AccountTitle_CB.Text != "All" && Before_c.Checked == false && After_c.Checked == true)
            {
                DataTable dta = Journal.Search("DateAfter", AccountTitle_CB.Text, null, After_dp.Text, 3);
                initialize(dta);
            }
        }

        private void Before_c_CheckedChanged(object sender, EventArgs e)
        {
            if (Before_c.Checked==true)
            {
                Before_dp.Enabled= true;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void After_dp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Before_dp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AccountTitle_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AccountTitle_CB_Click(object sender, EventArgs e)
        {
            refreshdata();
        }
        public override void Refresh()
        {
            base.Refresh();
            initialize();
        }
    }
}
