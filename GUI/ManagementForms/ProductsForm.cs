using SupermarketSystem.BussinessLogicLayer.BLL;
using System;
using System.Windows.Forms;
using SupermarketSystem;

namespace SupermarketSystem.GUI.ManagementForms
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        ProductBLL bll = new ProductBLL();
        bool isAddMode = false;

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadData();
            SetState(false);
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bll.GetAll();
        }

        private void SetState(bool isEditing)
        {
            txtProductID.Enabled = isEditing && isAddMode;
            txtCategoryID.Enabled = isEditing;
            txtName.Enabled = isEditing;
            txtPrice.Enabled = isEditing;
            txtStock.Enabled = isEditing;
            txtStatus.Enabled = isEditing;

            btnSave.Enabled = isEditing;
            btnCancel.Enabled = isEditing;

            btnAdd.Enabled = !isEditing;
            btnEdit.Enabled = !isEditing;
            btnDelete.Enabled = !isEditing;
        }

        private void ClearInputs()
        {
            txtProductID.Clear();
            txtCategoryID.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtStatus.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dataGridView1.Rows[e.RowIndex];

                txtProductID.Text = row.Cells["ProductID"].Value?.ToString();
                txtCategoryID.Text = row.Cells["CategoryID"].Value?.ToString();
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtPrice.Text = row.Cells["Price"].Value?.ToString();
                txtStock.Text = row.Cells["Stock"].Value?.ToString();
                txtStatus.Text = row.Cells["Status"].Value?.ToString();

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddMode = true;
            SetState(true);
            ClearInputs();
            txtProductID.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductID.Text))
            {
                MessageBox.Show("Chọn sản phẩm cần sửa!");
                return;
            }

            isAddMode = false;
            SetState(true);
            txtProductID.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetState(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtProductID.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Chọn sản phẩm cần xóa!");
                return;
            }

            if (MessageBox.Show("Xóa sản phẩm?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string error = "";

                if (bll.Delete(id, ref error))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string error = "";

            try
            {
                var product = BuildProduct();

                bool success = isAddMode
                    ? bll.Add(product, ref error)
                    : bll.Update(product, ref error);

                if (success)
                {
                    MessageBox.Show("Lưu thành công!");
                    LoadData();
                    ClearInputs();
                    SetState(false);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Product BuildProduct()
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text))
                throw new Exception("Nhập thiếu dữ liệu!");

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
                throw new Exception("Price sai!");

            if (!int.TryParse(txtStock.Text, out int stock))
                throw new Exception("Stock sai!");

            if (!int.TryParse(txtStatus.Text, out int status))
                throw new Exception("Status phải là 0 hoặc 1!");

            return new Product
            {
                ProductID = txtProductID.Text.Trim(),
                CategoryID = txtCategoryID.Text.Trim(),
                Name = txtName.Text.Trim(),
                Price = price,
                Stock = stock,
                Status = status
            };
        }
    }
}