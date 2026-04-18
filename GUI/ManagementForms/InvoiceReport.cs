using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace SupermarketSystem.GUI.ManagementForms
{
    public partial class InvoiceReport : Form
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }

        private void InvoiceReport_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                // Dùng TableAdapter từ DataSet
                SupermarketDBDataSetTableAdapters.OrderReportTableAdapter ta
                    = new SupermarketDBDataSetTableAdapters.OrderReportTableAdapter();

                SupermarketDBDataSet ds = new SupermarketDBDataSet();
                ta.Fill(ds.OrderReport);

                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "SupermarketSystem.GUI.ManagementForms.Report1.rdlc";

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DataSet1", ds.Tables["OrderReport"]));

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}