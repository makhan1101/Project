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
    public partial class ADD_JOURNAL : Form
    {
        Accounts acc = new Accounts();
        Journal journal = new Journal();
        public ADD_JOURNAL()
        {
            InitializeComponent();
            refreshdata1();
            refreshdata2();
            if (JournalVoucherControl.type == "Edit")
            {
                Description_richTextBox.Text = JournalVoucherControl.Description;
                if(JournalVoucherControl.VoucherIndex==1)
                {
                    DRAccount_CB.Text = JournalVoucherControl.AccountTitle;
                    CRAccount_CB.Text = journal.GetValue(JournalVoucherControl.VoucherID,JournalVoucherControl.VoucherIndex+1,"AccountTitle");
                    CR_textBox.Text = journal.GetValue(JournalVoucherControl.VoucherID, JournalVoucherControl.VoucherIndex+1, "CR");
                    DR_textbox.Text = JournalVoucherControl.DR.ToString();

                }
                else if(JournalVoucherControl.VoucherIndex==2)
                {
                    DRAccount_CB.Text = journal.GetValue(JournalVoucherControl.VoucherID, JournalVoucherControl.VoucherIndex-1, "AccountTitle");
                    CRAccount_CB.Text = JournalVoucherControl.AccountTitle;
                    CR_textBox.Text = JournalVoucherControl.CR.ToString();
                    DR_textbox.Text = journal.GetValue(JournalVoucherControl.VoucherID, JournalVoucherControl.VoucherIndex-1, "DR");
                }
            }
        }
        public void refreshdata1()
        {
            DataRow dr;
            DataTable dt = journal.fillcombo();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select--" };
            dt.Rows.InsertAt(dr, 0);
            DRAccount_CB.ValueMember = "AccountID";
            DRAccount_CB.DisplayMember = "AccountTitle";
            DRAccount_CB.DataSource = dt;
        }
        public void refreshdata2()
        {
            DataRow dr;
            DataTable dt = journal.fillcombo();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select--" };
            dt.Rows.InsertAt(dr, 0);
            CRAccount_CB.ValueMember = "AccountID";
            CRAccount_CB.DisplayMember = "AccountTitle";
            CRAccount_CB.DataSource = dt;
        }
        public bool varify()
        {
            decimal balance2 = journal.GetValue(DRAccount_CB.Text);
            decimal balance3 = Convert.ToDecimal(CR_textBox.Text);
            if (string.IsNullOrEmpty(DRAccount_CB.Text))
            {
                MessageBox.Show("Enter AccountTitle");
                return false;
            }
            else if (string.IsNullOrEmpty(DR_textbox.Text))
            {
                MessageBox.Show("Enter dr");
                return false;
            }
            else if (string.IsNullOrEmpty(CR_textBox.Text))
            {
                MessageBox.Show("Enter cr");
                return false;
            }
            else if (string.IsNullOrEmpty(Description_richTextBox.Text))
            {
                MessageBox.Show("Enter Description");
                return false;
            }
            else if ((balance2-balance3)<0)
            {
                MessageBox.Show("you cannot do this entry because your balance is low");
                return false;
            }
            else if (DR_textbox.Text!=CR_textBox.Text)
            {
                MessageBox.Show("Please Enter same amount on both entries");
                return false;
            }
            return true;
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (varify() == true)
            {
                if (JournalVoucherControl.type == "Add")
                {
                    int i=journal.InsertVoucher(dateTimePicker1.Text);
                    journal.InsertJournal(i,1,3,DRAccount_CB.Text, Description_richTextBox.Text, Convert.ToDecimal(DR_textbox.Text)
                        ,0,dateTimePicker1.Text);
                    journal.InsertJournal(i,2,3,CRAccount_CB.Text, Description_richTextBox.Text,0,Convert.ToDecimal(CR_textBox.Text)
                        , dateTimePicker1.Text);
                    decimal balance1 = journal.GetValue(CRAccount_CB.Text);
                    decimal balance2 = journal.GetValue(DRAccount_CB.Text);
                    decimal balance3 = Convert.ToDecimal(DR_textbox.Text);
                    decimal balance4 = Convert.ToDecimal(CR_textBox.Text);
                    acc.EditAccount(DRAccount_CB.Text, (balance2 + balance3).ToString());
                    acc.EditAccount(CRAccount_CB.Text, (balance1 - balance4).ToString());
                }
                else
                {
                    journal.EditJournal(JournalVoucherControl.VoucherID, 1, 3, DRAccount_CB.Text, Description_richTextBox.Text, 
                        Convert.ToDecimal(DR_textbox.Text), 0, dateTimePicker1.Text);
                    journal.EditJournal(JournalVoucherControl.VoucherID, 2, 3, CRAccount_CB.Text, Description_richTextBox.Text,0,
                        Convert.ToDecimal(CR_textBox.Text), dateTimePicker1.Text);
                    decimal balance1 = journal.GetValue(CRAccount_CB.Text);
                    decimal balance2 = journal.GetValue(DRAccount_CB.Text);
                    decimal balance3 = Convert.ToDecimal(DR_textbox.Text);
                    decimal balance4 = Convert.ToDecimal(CR_textBox.Text);
                    acc.EditAccount(DRAccount_CB.Text, (balance2 + balance3).ToString());
                    acc.EditAccount(CRAccount_CB.Text, (balance1 - balance4).ToString());
                }
                this.Close();
            }
           
        }

        private void Description_richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CR_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DR_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Account_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void jornal_dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
