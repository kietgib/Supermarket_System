using Microsoft.Reporting.WinForms;
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
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            try
            {
                // Dùng OrderReportTableAdapter từ DataSet
                var ta = new SupermarketDBDataSetTableAdapters.OrderReportTableAdapter();
                var ds = new SupermarketDBDataSet();
                ta.Fill(ds.OrderReport);

                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "SupermarketSystem.GUI.ManagementForms.InvoiceReport.rdlc";

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DataSet1", ds.Tables["OrderReport"])
                );

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void InvoiceReportForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}