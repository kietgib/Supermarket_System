using SupermarketSystem.BussinessLogicLayer.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketSystem.GUI.ManagementForms
{
    public partial class InvoiceReportForm : Form
    {
        public InvoiceReportForm()
        {
            InitializeComponent();
        }

        private void InvoiceReportForm_Load(object sender, EventArgs e)
        {
            OrderDetailsBLL bll = new OrderDetailsBLL();
            var ds = bll.GetAll();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource(
                    "DataSet1",
                    ds.Tables[0]
                )
            );

            reportViewer1.RefreshReport();
        }
    }
}
