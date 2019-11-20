using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            ShowControl(DebitControl.Instance);
            ShowControl(CreditControl.Instance);
            ShowControl(JournalVoucherControl.Instance);
            ShowControl(SaleBillControl.Instance);
            ShowControl(PurchaseBill.Instance);
            ShowControl(Viewer.Instance);
            ShowControl(Items.Instance);
            ShowControl(Account.Instance);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ShowControl(DebitControl.Instance);
            DebitControl.Instance.initialize();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowControl(CreditControl.Instance);
            CreditControl.Instance.initialize();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowControl(JournalVoucherControl.Instance);
            JournalVoucherControl.Instance.initialize();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowControl(SaleBillControl.Instance);
            SaleBillControl.Instance.initialize();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowControl(PurchaseBill.Instance);
            PurchaseBill.Instance.initialize();
        }

        public void ShowControl(Control control)
        {
            if (!ControlPanel.Controls.Contains(control))
            {
                ControlPanel.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.BringToFront();
                control.Focus();
                control.Refresh();
                

            }
            else control.BringToFront();
        }

        private void Account_button_Click(object sender, EventArgs e)
        {
            ShowControl(Account.Instance);
            Account.Instance.initialize();
        }

        private void ControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowControl(Viewer.Instance);
            Viewer.Instance.initialize();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowControl(Stock.Instance);
            Stock.Instance.initialize();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowControl(Stock_Adjusment.Instance);
            Stock_Adjusment.Instance.initialize();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowControl(Items.Instance);
            Items.Instance.initialize();
        }
    }
}
