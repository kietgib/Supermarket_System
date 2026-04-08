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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDBDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.supermarketDBDataSet.Products);

        }
    }
}
