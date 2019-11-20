using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store_Management.BusinessLayer;

namespace Store_Management
{
    public partial class Add_SaleBill : Form
    {
        string t = "Add";
        SaleBill sale = new SaleBill();
        Journal journal = new Journal();
        Item it = new Item();
        int id = 0;
        int eid = 0;
        decimal Quantity1;
        public Add_SaleBill()
        {
            InitializeComponent();
            refreshdata1();
            refreshdata2(null);
            refreshdata3();
            if (SaleBillControl.type=="Edit")
            {
                this.eid=SaleBillControl.id;
                this.Party_CB.Text = SaleBillControl.Party;
                this.dateTimePicker1.Text = SaleBillControl.Date;
            }
            Quantity_tb.Text = "0";
            Rate_tb.Text = "0";
            initialize();
        }
        public void refreshdata1()
        {
            DataRow dr;
            DataTable dt = journal.fillcombo();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select--" };
            dt.Rows.InsertAt(dr, 0);

            Party_CB.ValueMember = "AccountID";
            Party_CB.DisplayMember = "AccountTitle";
            Party_CB.DataSource = dt;

        }
        public void refreshdata2(string Location)
        {
            if (!Item_CB.Items.Contains("--Select--"))
            {
                Item_CB.Items.Add("--Select--");
            }
            Item_CB.SelectedIndex = 0;
            if(Location!=null)
            {
                DataTable dt = it.fillcombo1();
                foreach (DataRow ddr in dt.Rows)
                {
                    if (!Item_CB.Items.Contains(ddr["Item"].ToString()))
                    {
                        Item_CB.Items.Add(ddr["Item"].ToString());
                    }
                }
            }
        }
        public void refreshdata3()
        {
            Location_CB.Items.Add("--Select--");
            DataTable dt = it.fillcombo();
            foreach (DataRow ddr in dt.Rows)
            {
                if (!Location_CB.Items.Contains(ddr["Location"].ToString()))
                {
                    Location_CB.Items.Add(ddr["Location"].ToString());
                }
            }
            Location_CB.SelectedIndex = 0;
            //dr = dt.NewRow();
            //dr.ItemArray = new object[] { 0, "--Select--" };
            //dt.Rows.InsertAt(dr, 0);
            //Location_CB.Items.Contains();
            //Location_CB.ValueMember = "ItemID";
            //Location_CB.DisplayMember = "Location";
            //Location_CB.DataSource = dt;
            //refreshdata2(Location_CB.Text);
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
            dt = sale.GetAllBills("SaleBillDetail", eid);

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {

                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
            }

        }
        public bool varify()
        {
            Quantity1 = it.GetValue(Item_CB.Text, "Quantity");
            decimal Quantity2 = Convert.ToDecimal(Quantity_tb.Text);
            if (string.IsNullOrEmpty(Party_CB.Text))
            {
                MessageBox.Show("Select Party");
                return false;
            }
            if (string.IsNullOrEmpty(Item_CB.Text))
            {
                MessageBox.Show("Select Item name");
                return false;
            }
            else if (string.IsNullOrEmpty(Quantity_tb.Text))
            {
                MessageBox.Show("Enter Quantity ");
                return false;
            }
            else if (Quantity1 < Quantity2)
            {
                MessageBox.Show(" Quantity in limit");
                return false;
            }
            else if (string.IsNullOrEmpty(Rate_tb.Text))
            {
                MessageBox.Show("Enter Rate");
                return false;
            }
            return true;
        }
        public bool varify(int id)
        {
            if (string.IsNullOrEmpty(Party_CB.Text))
            {
                MessageBox.Show("Select Party");
                return false;
            }
            
            return true;
        }
        private void Add_SaleBill_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (varify(0) == true)
            {
                if (SaleBillControl.type == "Add")
                {
                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                    }
                    int SaleBillID = sale.InsertBill(dateTimePicker1.Text, Party_CB.Text, sum.ToString());

                    if (SaleBillID > 0)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                        {
                            sale.InsertBill(SaleBillID, dataGridView1.Rows[i].Cells[2].Value.ToString(),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value),
                               Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
                            it.InsertItem(dataGridView1.Text, dataGridView1.Rows[i].Cells[2].Value.ToString(), Location_CB.Text, "Sale",
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));
                        }

                    }
                    this.Close();
                }
                else if (SaleBillControl.type == "Edit")
                {
                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                    }
                    sale.EditBill(eid,dateTimePicker1.Text, Party_CB.Text, sum.ToString());
                    sale.DeleteBill(eid,null);
                    if (eid > 0)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                        {
                            sale.InsertBill(eid, dataGridView1.Rows[i].Cells[2].Value.ToString(),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value),
                               Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
                        }

                    }
                    this.Close();
                }
            }
        }

        private void Item_CB_TextChanged(object sender, EventArgs e)
        {
          // Rate_tb.Text = it.GetValue(Item_CB.Text,"Rate").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (varify() == true)
            {
                if (t == "Add")
                {
                    it.EditItem(Item_CB.Text, (Quantity1 - Convert.ToDecimal(Quantity_tb.Text)));
                    int total = Convert.ToInt16(Quantity_tb.Text) * Convert.ToInt16(Rate_tb.Text);
                    dataGridView1.Rows.Add(0,0, Item_CB.Text, Convert.ToInt16(Quantity_tb.Text), Convert.ToInt16(Rate_tb.Text), total);
                    //sale.InsertBill(id, Item_CB.Text, Convert.ToInt16(Quantity_tb.Text), Convert.ToInt16(Rate_tb.Text), total);
                    //initialize();
                    //Quantity_tb.Text = null;
                    //Rate_tb.Text = null;
                }
                else if (t == "Edit")
                {
                    it.EditItem(Item_CB.Text, (Quantity1 + Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value.ToString())));
                    it.EditItem(Item_CB.Text, (Quantity1 - Convert.ToDecimal(Quantity_tb.Text)));
                    int total = Convert.ToInt16(Quantity_tb.Text) * Convert.ToInt16(Rate_tb.Text);
                    dataGridView1.Rows.Add(0, 0, Item_CB.Text, Convert.ToInt16(Quantity_tb.Text), Convert.ToInt16(Rate_tb.Text), total);
                    button2.Text = "Add";
                    t = "Add";
                    dataGridView1.Rows.RemoveAt(id);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                t = "Edit";
                id = Convert.ToInt16(dataGridView1.SelectedRows[0].Index);
                Item_CB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Quantity_tb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Rate_tb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                button2.Text = "Edit";
            }
            if (e.ColumnIndex == 7)
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    Quantity1 = it.GetValue(dataGridView1.CurrentRow.Cells[2].Value.ToString(), "Quantity");
                    it.EditItem(dataGridView1.CurrentRow.Cells[2].Value.ToString(), (Quantity1 + Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value.ToString())));
                    dataGridView1.Rows.RemoveAt(Convert.ToInt16(dataGridView1.SelectedRows[0].Index));
                    //it.EditItem(Item_CB.Text, (Quantity1 - Convert.ToDecimal(Quantity_tb.Text)));
                }
            }
        }

        private void Quantity_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rate_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Party_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Item_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Location_CB_TextChanged(object sender, EventArgs e)
        {
            refreshdata2(Location_CB.Text);
        }
    }
}
