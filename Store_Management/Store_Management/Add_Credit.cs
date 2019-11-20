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
    public partial class Add_Credit : Form
    {
        Accounts acc = new Accounts();
        Journal journal = new Journal();
        public Add_Credit()
        {
            InitializeComponent();
            refreshdata1();
            refreshdata2();
            if (CreditControl.type == "Edit")
            {
                Description_richTextBox.Text = CreditControl.Description;
                if (CreditControl.VoucherIndex == 1)
                {
                    DRAccount_CB.Text = CreditControl.AccountTitle;
                    CRAccount_CB.Text = journal.GetValue(CreditControl.VoucherID, CreditControl.VoucherIndex + 1, "AccountTitle");
                    CR_textBox.Text = journal.GetValue(CreditControl.VoucherID, CreditControl.VoucherIndex + 1, "CR");
                    DR_textbox.Text = CreditControl.DR.ToString();

                }
                else if (CreditControl.VoucherIndex == 2)
                {
                    DRAccount_CB.Text = journal.GetValue(CreditControl.VoucherID, CreditControl.VoucherIndex - 1, "AccountTitle");
                    CRAccount_CB.Text = CreditControl.AccountTitle;
                    CR_textBox.Text = CreditControl.CR.ToString();
                    DR_textbox.Text = journal.GetValue(CreditControl.VoucherID, CreditControl.VoucherIndex - 1, "DR");
                }
            }
        }
        public void refreshdata1()
        {
            DataRow dr;
            DataTable dt = journal.fillcombo2();
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
            DataTable dt = journal.fillcombo1();
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
            else if ((balance2 - balance3) < 0)
            {
                MessageBox.Show("you cannot do this entry because your balance is low");
                return false;
            }
            else if (DR_textbox.Text != CR_textBox.Text)
            {
                MessageBox.Show("Please Enter same amount on both entries");
                return false;
            }
            return true;
        }
        private void Save_button_Click(object sender, EventArgs e)
        {

            //if (varify() == true)
            //{
            //    if (CreditControl.type == "Add")
            //    {
            //        int i = journal.InsertVoucher(dateTimePicker1.Text);
            //        journal.InsertJournal(i, 1, 3, DRAccount_CB.Text, Description_richTextBox.Text, Convert.ToDecimal(DR_textbox.Text)
            //            , 0, dateTimePicker1.Text);
            //        journal.InsertJournal(i, 2, 3, CRAccount_CB.Text, Description_richTextBox.Text, 0, Convert.ToDecimal(CR_textBox.Text)
            //            , dateTimePicker1.Text);
            //        decimal balance1 = journal.GetValue(CRAccount_CB.Text);
            //        decimal balance2 = journal.GetValue(DRAccount_CB.Text);
            //        decimal balance3 = Convert.ToDecimal(DR_textbox.Text);
            //        decimal balance4 = Convert.ToDecimal(CR_textBox.Text);
            //        acc.EditAccount(DRAccount_CB.Text, (balance2 + balance3).ToString());
            //        acc.EditAccount(CRAccount_CB.Text, (balance1 - balance4).ToString());
            //    }
            //    else
            //    {
            //        journal.EditJournal(CreditControl.VoucherID, 1, 3, DRAccount_CB.Text, Description_richTextBox.Text,
            //            Convert.ToDecimal(DR_textbox.Text), 0, dateTimePicker1.Text);
            //        journal.EditJournal(CreditControl.VoucherID, 2, 3, CRAccount_CB.Text, Description_richTextBox.Text, 0,
            //            Convert.ToDecimal(CR_textBox.Text), dateTimePicker1.Text);
            //        decimal balance1 = journal.GetValue(CRAccount_CB.Text);
            //        decimal balance2 = journal.GetValue(DRAccount_CB.Text);
            //        decimal balance3 = Convert.ToDecimal(DR_textbox.Text);
            //        decimal balance4 = Convert.ToDecimal(CR_textBox.Text);
            //        acc.EditAccount(DRAccount_CB.Text, (balance2 + balance3).ToString());
            //        acc.EditAccount(CRAccount_CB.Text, (balance1 - balance4).ToString());
            //    }
            //    this.Close();
            //}
        }

        private void Add_Credit_Load(object sender, EventArgs e)
        {

        }

        private void CR_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_button_Click_1(object sender, EventArgs e)
        {
            if (varify() == true)
            {
                if (CreditControl.type == "Add")
                {
                    int i = journal.InsertVoucher(dateTimePicker1.Text);
                    journal.InsertJournal(i, 1, 2, DRAccount_CB.Text, Description_richTextBox.Text, Convert.ToDecimal(DR_textbox.Text)
                        , 0, dateTimePicker1.Text);
                    journal.InsertJournal(i, 2, 2, CRAccount_CB.Text, Description_richTextBox.Text, 0, Convert.ToDecimal(CR_textBox.Text)
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
                    journal.EditJournal(CreditControl.VoucherID, 1, 2, DRAccount_CB.Text, Description_richTextBox.Text,
                        Convert.ToDecimal(DR_textbox.Text), 0, dateTimePicker1.Text);
                    journal.EditJournal(CreditControl.VoucherID, 2, 2, CRAccount_CB.Text, Description_richTextBox.Text, 0,
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
    }
}
