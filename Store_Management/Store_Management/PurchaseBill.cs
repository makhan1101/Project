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
    public partial class PurchaseBill : UserControl
    {
        private static PurchaseBill _Insatance;

        public static PurchaseBill Instance
        {
            get
            {
                if (_Insatance == null)
                {
                    _Insatance = new PurchaseBill();
                }
                return (_Insatance);
            }
        }

        private PurchaseBill()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
