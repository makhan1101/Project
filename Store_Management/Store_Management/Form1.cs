using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowControl(DebitControl.Instance);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowControl(CreditControl.Instance);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowControl(JournalVoucherControl.Instance);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowControl(SaleBillControl.Instance);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowControl(PurchaseBill.Instance);
        }

        public void ShowControl(Control control)
        {
            if (!ControlPanel.Controls.Contains(control))
            {
                ControlPanel.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.BringToFront();
                control.Focus();


            }
            else control.BringToFront();
        }

        private void Account_button_Click(object sender, EventArgs e)
        {
            ShowControl(Account.Instance);
        }
    }
}
