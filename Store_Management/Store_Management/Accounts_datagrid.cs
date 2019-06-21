using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Management
{
    public partial class Accounts_datagrid : UserControl
    {
        private static Accounts_datagrid _Insatance;

        public static Accounts_datagrid Instance
        {
            get
            {
                if (_Insatance == null)
                {
                    _Insatance = new Accounts_datagrid();
                }
                return (_Insatance);
            }
        }
        private Accounts_datagrid()
        {
            InitializeComponent();
        }
        
        private void Change_button_Click(object sender, EventArgs e)
        {

        }
    }
}
