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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.supermarketDBDataSet.Customers);

        }
    }
}
