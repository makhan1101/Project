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
    public partial class DebitControl : UserControl
    {
        private static DebitControl _Insatance;

        public static DebitControl Instance
        {
            get
            {
                if (_Insatance == null)
                {
                    _Insatance = new DebitControl();
                }
                return (_Insatance);
            }
        }

        private DebitControl()
        {
            InitializeComponent();
        }

        private void DebitControl_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {

        }

        private void Update_button_Click(object sender, EventArgs e)
        {

        }
    }
}
