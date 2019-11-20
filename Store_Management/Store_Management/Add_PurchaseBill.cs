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
    public partial class Add_PurchaseBill : Form
    {
        string t = "Add";
        PurchaseBills Purchase = new PurchaseBills();
        Journal journal = new Journal();
        Item it = new Item();
        int id = 0;
        int eid = 0;
        decimal Quantity1;
        public Add_PurchaseBill()
        {
            InitializeComponent();
            refreshdata1();
            refreshdata2();
            refreshdata3();
            if (PurchaseBill.type == "Edit")
            {
                this.eid = PurchaseBill.id;
                this.Party_CB.Text = PurchaseBill.Party;
                this.dateTimePicker1.Text = PurchaseBill.Date;
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
        public void refreshdata2()
        {
            DataRow dr;
            DataTable dt = it.fillcombo1();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "All" };
            dt.Rows.InsertAt(dr, 0);
            Item_CB.ValueMember = "ItemID";
            Item_CB.DisplayMember = "Item";
            Item_CB.DataSource = dt;
        }
        public void refreshdata3()
        {
            DataRow dr;
            DataTable dt = it.fillcombo();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "All" };
            dt.Rows.InsertAt(dr, 0);
            Location_CB.ValueMember = "LocationID";
            Location_CB.DisplayMember = "Location";
            Location_CB.DataSource = dt;
        }
        public void initialize()
        {
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoResizeColumns();
            view1();

        }
        public void view1()
        {
            DataTable dt = new DataTable();
            dt = Purchase.GetAllBills("PurchaseBillDetail", eid);

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

        private void button2_Click(object sender, EventArgs e)
        {
            //if (varify() == true)
            //{
            //    if (t == "Add")
            //    {
            //        it.EditItem(Item_CB.Text, (Quantity1 - Convert.ToDecimal(Quantity_tb.Text)));
            //        int total = Convert.ToInt16(Quantity_tb.Text) * Convert.ToInt16(Rate_tb.Text);
            //        Purchase.InsertBill(id, Item_CB.Text, Convert.ToInt16(Quantity_tb.Text), Convert.ToInt16(Rate_tb.Text), total);
            //        initialize();
            //        Quantity_tb.Text = null;
            //        Rate_tb.Text = null;
            //    }
            //    else if (t == "Edit")
            //    {
            //        it.EditItem(Item_CB.Text, (Quantity1 - Convert.ToDecimal(Quantity_tb.Text)));
            //        int total = Convert.ToInt16(Quantity_tb.Text) * Convert.ToInt16(Rate_tb.Text);
            //        Purchase.EditBill(id, Item_CB.Text, Convert.ToInt16(Quantity_tb.Text), Convert.ToInt16(Rate_tb.Text), total);
            //        button2.Text = "Add";
            //        t = "Add";
            //        Quantity_tb.Text = null;
            //        Rate_tb.Text = null;
            //        initialize();
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (varify(0) == true)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            //    {
            //        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            //    }
            //    Purchase.EditBill(id, Party_CB.Text, sum.ToString());
            //    this.Close();
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 5)
            //{
            //    t = "Edit";
            //    id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //    Item_CB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //    Quantity_tb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //    Rate_tb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //    button2.Text = "Edit";
            //    initialize();
            //}
            //if (e.ColumnIndex == 6)
            //{
            //    if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            //    {
            //        Purchase.DeleteBill(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString()), dataGridView1.CurrentRow.Cells[1].Value.ToString());
            //    }
            //    initialize();
            //}
        }

        private void Item_CB_TextChanged(object sender, EventArgs e)
        {
            Rate_tb.Text = it.GetValue(Item_CB.Text, "Rate").ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //if (varify() == true)
            {
                if (t == "Add")
                {
                    decimal Quantity2 = it.GetValueForStock(Convert.ToInt32(Item_CB.SelectedValue), "Quantity", Convert.ToInt32(Location_CB.SelectedValue));
                    it.InsertItem(Convert.ToInt32(Item_CB.SelectedValue), Convert.ToInt32(Convert.ToInt32(Quantity_tb.Text) + Quantity2), Convert.ToInt32(Location_CB.SelectedValue));
                    //it.InsertItem(dateTimePicker1.Text, Item_CB.Text, Location_CB.Text, , Convert.ToInt16(Quantity_tb.Text));
                    //it.EditItem(Item_CB.SelectedValue, (Quantity1 + Convert.ToDecimal(Quantity_tb.Text)),Loca);
                    int total = Convert.ToInt16(Quantity_tb.Text) * Convert.ToInt16(Rate_tb.Text);
                    dataGridView1.Rows.Add(0, 0, Item_CB.Text, Convert.ToInt16(Quantity_tb.Text), Convert.ToInt16(Rate_tb.Text), total);
                    //Purchase.InsertBill(id, Item_CB.Text, Convert.ToInt16(Quantity_tb.Text), Convert.ToInt16(Rate_tb.Text), total);
                    //initialize();
                    //Quantity_tb.Text = null;
                    //Rate_tb.Text = null;
                }
                else if (t == "Edit")
                {
                    decimal Quantity2 = it.GetValueForStock(Convert.ToInt32(Item_CB.SelectedValue), "Quantity", Convert.ToInt32(Location_CB.SelectedValue));
                    it.InsertItem(Convert.ToInt32(Item_CB.SelectedValue), Convert.ToInt32(Quantity2 - Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value.ToString())), Convert.ToInt32(Location_CB.SelectedValue));
                    Quantity2 = it.GetValueForStock(Convert.ToInt32(Item_CB.SelectedValue), "Quantity", Convert.ToInt32(Location_CB.SelectedValue));
                    it.InsertItem(Convert.ToInt32(Item_CB.SelectedValue), Convert.ToInt32(Quantity2 + Convert.ToDecimal(Quantity_tb.Text)), Convert.ToInt32(Location_CB.SelectedValue));
                    //it.EditItem(Item_CB.Text, (Quantity1 + Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value.ToString())));
                    //it.EditItem(Item_CB.Text, (Quantity1 - Convert.ToDecimal(Quantity_tb.Text)));
                    int total = Convert.ToInt16(Quantity_tb.Text) * Convert.ToInt16(Rate_tb.Text);
                    dataGridView1.Rows.Add(0, 0, Item_CB.Text, Convert.ToInt16(Quantity_tb.Text), Convert.ToInt16(Rate_tb.Text), total);
                    button2.Text = "Add";
                    t = "Add";
                    dataGridView1.Rows.RemoveAt(id);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (varify(0) == true)
            {
                if (PurchaseBill.type == "Add")
                {
                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                    }
                    int PurchaseBillID = Purchase.InsertBill(dateTimePicker1.Text, Party_CB.Text, sum.ToString());

                    if (PurchaseBillID > 0)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                        {
                            Purchase.InsertBill(PurchaseBillID, dataGridView1.Rows[i].Cells[2].Value.ToString(),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value),
                               Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
                            it.InsertItem(dataGridView1.Text, dataGridView1.Rows[i].Cells[2].Value.ToString(), Location_CB.Text, "Purchase",
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));
                        }

                    }
                            this.Close();
                }
                else if (PurchaseBill.type == "Edit")
                {
                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                    }
                    Purchase.EditBill(eid, dateTimePicker1.Text, Party_CB.Text, sum.ToString());
                    Purchase.DeleteBill(eid, null);
                    if (eid > 0)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                        {
                            Purchase.InsertBill(eid, dataGridView1.Rows[i].Cells[2].Value.ToString(),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value),
                               Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
                        }

                    }
                }
                    this.Close();
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
                    //Quantity1 = it.GetValue(dataGridView1.CurrentRow.Cells[2].Value.ToString(), "Quantity");
                    decimal Quantity2 = it.GetValueForStock(Convert.ToInt32(Item_CB.SelectedValue), "Quantity", Convert.ToInt32(Location_CB.SelectedValue));
                    it.InsertItem(Convert.ToInt32(Item_CB.SelectedValue), Convert.ToInt32(Quantity2 - Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value.ToString())), Convert.ToInt32(Location_CB.SelectedValue));
                    dataGridView1.Rows.RemoveAt(Convert.ToInt16(dataGridView1.SelectedRows[0].Index));
                }
            }
        }

        private void Item_CB_TextChanged_1(object sender, EventArgs e)
        {
            Rate_tb.Text = it.GetRate(Item_CB.Text).ToString();
        }

        private void Location_CB_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
