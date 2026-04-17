using SupermarketSystem.BussinessLogicLayer.BLL;
using SupermarketSystem;
using System;
using System.Windows.Forms;

namespace SupermarketSystem.GUI.ManagementForms
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        OrderBLL bll = new OrderBLL();

        // ================= LOAD =================
        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // ================= LOAD DATA =================
        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bll.GetAll();
        }

        // ================= CLICK GRID =================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    textBox5.Text = row.Cells["OrderID"].Value?.ToString();
                    textBox6.Text = row.Cells["CustomerID"].Value?.ToString();
                    textBox8.Text = Convert.ToDateTime(row.Cells["OrderDate"].Value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nạp dữ liệu: " + ex.Message);
                }
            }
        }
    }
}