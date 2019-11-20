using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store_Management.BusinessLayer;

namespace Store_Management
{
    public partial class Stock : UserControl
    {
        Item i = new Item();
        private static Stock _Insatance;

        public static Stock Instance
        {
            get
            {
                if (_Insatance == null)
                {
                    _Insatance = new Stock();
                }
                return (_Insatance);
            }
        }
        private Stock()
        {
            InitializeComponent();
            initialize();
        }
        public void initialize()
        {
            //Before_dp.Enabled = false;
            //After_dp.Enabled = false;
            //AccountTitle_CB.Text = null;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoResizeColumns();
            view1();
            //dataGridView1.DataSource = acc.GetAllAccounts();
        }
        public void view1()
        {
            DataTable dt = new DataTable();
            dt = i.GetAllItem();

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
            }

        }
    }
}
