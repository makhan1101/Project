using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Store_Management.BusinessLayer;

namespace Store_Management
{
    public partial class Viewer : UserControl
    {
        public static string type { get; set; }
        public static int JournalID { get; set; }
        public static string DRAccountTitle { get; set; }
        public static string CRAccountTitle { get; set; }
        public static string Description { get; set; }
        public static string CR { get; set; }
        public static decimal DR { get; set; }
        Journal Journal = new Journal();
        private static Viewer _Insatance;

        public static Viewer Instance
        {
            get
            {
                if (_Insatance == null)
                {
                    _Insatance = new Viewer();
                }
                return (_Insatance);
            }
        }
        public Viewer(int i)
        {
            
        }
        private Viewer()
        {
            InitializeComponent();
            initialize();
            Before_dp.Enabled = false;
            After_dp.Enabled = false;
            refreshdata();
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
            //view1();
            dataGridView1.DataSource= Journal.GetAllJournal(3);
            dataGridView1.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd";
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
        }
        public void initialize(DataTable dt)
        {
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd";
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Report r = new Report((DataTable)dataGridView1.DataSource);
            r.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (AccountTitle_CB.Text == "All" && Before_c.Checked == false && After_c.Checked == false)
            {
                DataTable dta = Journal.Search("0", "0", null, null,3);
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
