namespace SupermarketSystem.GUI.ManagementForms
{
    partial class InvoiceReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.supermarketDBDataSet = new SupermarketSystem.SupermarketDBDataSet();
            this.orderReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderReportTableAdapter = new SupermarketSystem.SupermarketDBDataSetTableAdapters.OrderReportTableAdapter();
            this.tableAdapterManager = new SupermarketSystem.SupermarketDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SupermarketSystem.GUI.ManagementForms.InvoiceReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1037, 460);
            this.reportViewer1.TabIndex = 0;
            // 
            // supermarketDBDataSet
            // 
            this.supermarketDBDataSet.DataSetName = "SupermarketDBDataSet";
            this.supermarketDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderReportBindingSource
            // 
            this.orderReportBindingSource.DataMember = "OrderReport";
            this.orderReportBindingSource.DataSource = this.supermarketDBDataSet;
            // 
            // orderReportTableAdapter
            // 
            this.orderReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SupermarketSystem.SupermarketDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // InvoiceReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 460);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InvoiceReportForm";
            this.Text = "))";
            this.Load += new System.EventHandler(this.InvoiceReportForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InvoiceReportForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SupermarketDBDataSet supermarketDBDataSet;
        private System.Windows.Forms.BindingSource orderReportBindingSource;
        private SupermarketDBDataSetTableAdapters.OrderReportTableAdapter orderReportTableAdapter;
        private SupermarketDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}