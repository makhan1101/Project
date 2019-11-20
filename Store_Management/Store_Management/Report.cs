using Microsoft.Reporting.WinForms;
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
    public partial class Report : Form
    {
        public Report(DataTable dt)
        {
            InitializeComponent();
            ReportDataSource rds = new ReportDataSource("DataSet1", dt); // ReportViewerDataSource : ReportViewer is to be bind to this DataSource
            reportViewer1.LocalReport.DataSources.Clear(); // Clear the Previous DataSource of ReportViewer
            reportViewer1.LocalReport.DataSources.Add(rds); //bind ReportViewer1 to the new datasource(Which you wish)
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.LocalReport.Refresh();
            
        }
        private void Report_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
