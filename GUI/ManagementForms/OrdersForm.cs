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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDBDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.supermarketDBDataSet.Orders);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    textBox5.Text = row.Cells[0].Value?.ToString();
                    textBox6.Text = row.Cells[1].Value?.ToString();
                    textBox7.Text = row.Cells[2].Value?.ToString();
                    textBox8.Text = row.Cells[3].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nạp dữ liệu" + ex.Message);
                }
            }    
        }
    }
}
