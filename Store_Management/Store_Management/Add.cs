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
    public partial class Add : Form
    {
        Accounts acc;
        Journal journal = new Journal();
        public Add()
        {
            InitializeComponent();
            acc = new Accounts();
            refreshdata();
            if (Account.type=="Edit")
            {
                AccountTitle_TextBox.Text = Account.AccountTitle;
                Balance_TextBox.Text = Account.Balance;
                HeadAccount_CB.Text = Account.HeadAccount;
            }
        }
        public void refreshdata()
        {
            DataRow dr1;
            DataRow dr2;
            DataTable dt = journal.fillcombo();
            dr1 = dt.NewRow();
            dr2 = dt.NewRow();
            dr2.ItemArray = new object[] { 1, "None" };
            dr1.ItemArray = new object[] { 0, "--Select--" };
            dt.Rows.InsertAt(dr2, 1);
            dt.Rows.InsertAt(dr1, 0);
            HeadAccount_CB.ValueMember = "AccountID";
            
            HeadAccount_CB.DisplayMember = "AccountTitle";
            HeadAccount_CB.DataSource = dt;

        }
        private void Add_Load(object sender, EventArgs e)
        {
           
        }
        
        public bool varify()
        {
            if (string.IsNullOrEmpty(AccountTitle_TextBox.Text))
            {
                MessageBox.Show("Enter AccountTitle");
                return false;
            }
            else if(string.IsNullOrEmpty(Balance_TextBox.Text))
            {
                MessageBox.Show("Enter Balance");
                return false;
            }
            return true;
        }
      
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (varify()==true)
            {
                if (Account.type=="Add")
                {
                    acc.InsertAccount(AccountTitle_TextBox.Text, Balance_TextBox.Text,HeadAccount_CB.Text);
                }
                else
                {
                    acc.EditAccount(AccountTitle_TextBox.Text, Balance_TextBox.Text,Account.AccountID, HeadAccount_CB.Text);
                }
            this.Close();
            }

        }
    }
}
