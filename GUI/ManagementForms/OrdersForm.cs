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
using SupermarketSystem.BussinessLogicLayer.Entities;

namespace SupermarketSystem.GUI.ManagementForms
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        OrderBLL bll = new OrderBLL();

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDBDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.supermarketDBDataSet.Orders);

        }

        private void LoadData()
        {
            string error = "";
            // Vì BLL trả về DataSet nên ta lấy Table[0]
            dataGridView1.DataSource = bll.GetAll().Tables[0];
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string orderID = txtOrderIDSearch.Text.Trim();
            string customerID = txtCustomerIDSearch.Text.Trim();
            string orderDate = txtOrderDateSearch.Text.Trim();

            try
            {
                dataGridView1.DataSource = bll.OrderSearch(orderID, customerID, orderDate).Tables[0];
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm! Vui lòng kiểm tra lại các điều kiện tìm kiếm.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOrderIDSearch.Clear();
            txtCustomerIDSearch.Clear();
            txtOrderDateSearch.Clear();
            txtOrderIDSearch.Focus(); // Đặt con trỏ vào ô ID sau khi reset

            LoadData(); // Tải lại dữ liệu để reset GridView
        }
    }
}
