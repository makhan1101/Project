using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Store_Management.BusinessLayer;

namespace Store_Management
{
    public partial class Account : UserControl
    {
        Accounts acc = new BusinessLayer.Accounts();
        private static Account _Insatance;
        
        public static Account Instance
        {
            get
            {
                if (_Insatance == null)
                {
                    _Insatance = new Account();
                }
                return (_Insatance);
            }
        }
        private Account()
        {
            InitializeComponent();

            initialize();
        }

        public void initialize()
        {
            dataGridView1.DataSource = acc.GetAllAccounts();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            acc.InsertAccount(AccountTitle_TextBox.Text, Balance_TextBox.Text);

            initialize();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            acc.DeleteAccount(AccountTitle_TextBox.Text);

            initialize();
        }

    private void Update_button_Click(object sender, EventArgs e)
        {
            acc.EditAccount(AccountTitle_TextBox.Text, Balance_TextBox.Text);

            initialize();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
