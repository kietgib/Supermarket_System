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
    public partial class OrderDetailsForm : Form
    {
        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDBDataSet.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.supermarketDBDataSet.OrderDetails);

        }
    }
}
