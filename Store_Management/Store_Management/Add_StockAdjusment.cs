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
    public partial class Add_StockAdjusment : Form
    {
        
        Item item = new Item();
        public Add_StockAdjusment()
        {
            InitializeComponent();
            Type_CB.SelectedIndex = 0;
            Type2_CB.SelectedIndex = 0;
            refreshdata1();
            refreshdata2();
            refreshdata3();
            refreshdata4();
            Item2_CB.Enabled = false;
            Location2_CB.Enabled = false;
            Type2_CB.Enabled = false;
            Quantity2_tb.Enabled = false;
            if (Stock_Adjusment.type=="Edit")
            {
                Add_c.Enabled = false;
                dateTimePicker1.Text = Stock_Adjusment.Date;
                Type_CB.Text = Stock_Adjusment.Type;
                Location_CB.Text = Stock_Adjusment.Loc;
                Quantity_tb.Text = Stock_Adjusment.Quantity.ToString();
                Item_CB.Text = Stock_Adjusment.Item;
            }
        }
        
        public void refreshdata1()
        {
            DataRow dr;
            DataTable dt = item.fillcombo1();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "All" };
            dt.Rows.InsertAt(dr, 0);
            Item_CB.ValueMember = "ItemID";
            Item_CB.DisplayMember = "Item";
            Item_CB.DataSource = dt;
        }
        public void refreshdata3()
        {
            if (!Item2_CB.Items.Contains("--Select--"))
            {
                Item2_CB.Items.Add("--Select--");
            }
            Item2_CB.SelectedIndex = 0;
            if (Location != null)
            {
                DataTable dt = item.fillcombo1();
                foreach (DataRow ddr in dt.Rows)
                {
                    if (!Item2_CB.Items.Contains(ddr["Item"].ToString()))
                    {
                        Item2_CB.Items.Add(ddr["Item"].ToString());
                    }
                }
            }
        }
        public void refreshdata4()
        {
            if (!Location2_CB.Items.Contains("--Select--"))
            {
                Location2_CB.Items.Add("--Select--");
            }
            Location2_CB.SelectedIndex = 0;
            DataTable dt2 = item.fillcombo();
            foreach (DataRow ddr in dt2.Rows)
            {
                if (!Location2_CB.Items.Contains(ddr["Location"].ToString()))
                {
                    Location2_CB.Items.Add(ddr["Location"].ToString());
                }
            }
        }
        public void refreshdata2()
        {
            DataRow dr;
            DataTable dt =item.fillcombo();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "All" };
            dt.Rows.InsertAt(dr, 0);
            Location_CB.ValueMember = "LocationID";
            Location_CB.DisplayMember = "Location";
            Location_CB.DataSource = dt;
        }
        //public bool varify()
        //{
        //    //decimal balance2 = journal.GetValue(DRAccount_CB.Text);
        //    //decimal balance3 = Convert.ToDecimal(CR_textBox.Text);
        //    //if (string.IsNullOrEmpty(DRAccount_CB.Text))
        //    //{
        //    //    MessageBox.Show("Enter AccountTitle");
        //    //    return false;
        //    //}
        //    //else if (string.IsNullOrEmpty(DR_textbox.Text))
        //    //{
        //    //    MessageBox.Show("Enter dr");
        //    //    return false;
        //    //}
        //    //else if (string.IsNullOrEmpty(CR_textBox.Text))
        //    //{
        //    //    MessageBox.Show("Enter cr");
        //    //    return false;
        //    //}
        //    //else if (string.IsNullOrEmpty(Description_richTextBox.Text))
        //    //{
        //    //    MessageBox.Show("Enter Description");
        //    //    return false;
        //    //}
        //    //else if ((balance2 - balance3) < 0)
        //    //{
        //    //    MessageBox.Show("you cannot do this entry because your balance is low");
        //    //    return false;
        //    //}
        //    //else if (DR_textbox.Text != CR_textBox.Text)
        //    //{
        //    //    MessageBox.Show("Please Enter same amount on both entries");
        //    //    return false;
        //    //}
        //    //return true;
        //}

        private void Save_button_Click(object sender, EventArgs e)
        {
            //if (varify() == true)
            {
                if (Stock_Adjusment.type == "Add")
                {
                    decimal Quantity1 = item.GetValueForAdjustment(Type_CB.Text,"Factor");
                    decimal Quantity2 = item.GetValueForStock(Convert.ToInt32(Item_CB.SelectedValue), "Quantity", Convert.ToInt32(Location_CB.SelectedValue));
                    decimal total =Convert.ToDecimal (Quantity1 * Convert.ToInt32(Quantity_tb.Text));
                    item.InsertItem(Convert.ToInt32(Item_CB.SelectedValue),Convert.ToInt32(total+Quantity2), Convert.ToInt32(Location_CB.SelectedValue));
                    item.InsertItem(dateTimePicker1.Text,Item_CB.Text,Location_CB.Text,Type_CB.Text,Convert.ToInt16(Quantity_tb.Text));
                    if(Add_c.Checked==true)
                    {
                        item.InsertItem(dateTimePicker1.Text, Item2_CB.Text, Location2_CB.Text, Type2_CB.Text, Convert.ToInt16(Quantity2_tb.Text));
                    }
                    //journal.InsertJournal(i, 2, 3, CRAccount_CB.Text, Description_richTextBox.Text, 0, Convert.ToDecimal(CR_textBox.Text)
                    //    , dateTimePicker1.Text);
                    //decimal balance1 = journal.GetValue(CRAccount_CB.Text);
                    //decimal balance2 = journal.GetValue(DRAccount_CB.Text);
                    //decimal balance3 = Convert.ToDecimal(DR_textbox.Text);
                    //decimal balance4 = Convert.ToDecimal(CR_textBox.Text);
                    //acc.EditAccount(DRAccount_CB.Text, (balance2 + balance3).ToString());
                    //acc.EditAccount(CRAccount_CB.Text, (balance1 - balance4).ToString());
                }
                else
                {
                    item.EditItem(Stock_Adjusment.ID,dateTimePicker1.Text, Item_CB.Text, Location_CB.Text, Type_CB.Text, Convert.ToInt16(Quantity_tb.Text));
                    //Add_c.Visible = false;
                    //journal.EditJournal(JournalVoucherControl.VoucherID, 1, 3, DRAccount_CB.Text, Description_richTextBox.Text,
                    //    Convert.ToDecimal(DR_textbox.Text), 0, dateTimePicker1.Text);
                    //journal.EditJournal(JournalVoucherControl.VoucherID, 2, 3, CRAccount_CB.Text, Description_richTextBox.Text, 0,
                    //    Convert.ToDecimal(CR_textBox.Text), dateTimePicker1.Text);
                    //decimal balance1 = journal.GetValue(CRAccount_CB.Text);
                    //decimal balance2 = journal.GetValue(DRAccount_CB.Text);
                    //decimal balance3 = Convert.ToDecimal(DR_textbox.Text);
                    //decimal balance4 = Convert.ToDecimal(CR_textBox.Text);
                    //acc.EditAccount(DRAccount_CB.Text, (balance2 + balance3).ToString());
                    //acc.EditAccount(CRAccount_CB.Text, (balance1 - balance4).ToString());
                }
                this.Close();
            }
        }

        private void Add_CheckedChanged(object sender, EventArgs e)
        {
            //if (Add_c.Checked == true)
            //{
            //    Item_CB.Enabled = true;
            //    Location_CB.Enabled = true;
            //    Type_CB.Enabled = true;
            //    Quantity_tb.Enabled = true;
            //}
            //else
            //{
            //    Item_CB.Enabled =     false;
            //    Location_CB.Enabled = false;
            //    Type_CB.Enabled =     false;
            //    Quantity_tb.Enabled = false;
            //}
        }

        private void Add_c_CheckedChanged(object sender, EventArgs e)
        {

            if (Add_c.Checked == true)
            {
                Item2_CB.Enabled = true;
                Location2_CB.Enabled = true;
                Type2_CB.Enabled = true;
                Quantity2_tb.Enabled = true;
                refreshdata3();
                refreshdata4();
            }
            else
            {
                Item2_CB.Enabled = false;
                Location2_CB.Enabled = false;
                Type2_CB.Enabled = false;
                Quantity2_tb.Enabled = false;
            }
        }

        private void Location_CB_TextChanged(object sender, EventArgs e)
        {
            //refreshdata1(Location_CB.Text);
        }

        private void Location2_CB_TextChanged(object sender, EventArgs e)
        {
            //refreshdata3(Location2_CB.Text);
        }

        private void Type_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
