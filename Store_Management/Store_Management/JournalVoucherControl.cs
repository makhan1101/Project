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
    public partial class JournalVoucherControl : UserControl
    {
        private static JournalVoucherControl _Insatance;

        public static JournalVoucherControl Instance
        {
            get
            {
                if (_Insatance == null)
                {
                    _Insatance = new JournalVoucherControl();
                }
                return (_Insatance);
            }
        }

        private JournalVoucherControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
