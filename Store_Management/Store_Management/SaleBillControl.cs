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
    public partial class SaleBillControl : UserControl
    {
        private static SaleBillControl _Insatance;

        public static SaleBillControl Instance
        {
            get
            {
                if (_Insatance == null)
                {
                    _Insatance = new SaleBillControl();
                }
                return (_Insatance);
            }
        }

        private SaleBillControl()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
