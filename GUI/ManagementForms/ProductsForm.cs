using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using SupermarketSystem.BussinessLogicLayer.BLL;
using SupermarketSystem.BussinessLogicLayer.Entities;

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

        ProductBLL bll = new ProductBLL();
        bool isAddMode = false; 

        //hàm tắt mở control

        private void SetState(bool isEditing)
        {
            txtCategoryID.Enabled = isEditing && isAddMode; //chỉ cho nhập ID khi thêm mới 
            txtName.Enabled = isEditing;
            txtPrice.Enabled = isEditing;
            txtProductID.Enabled = isEditing;
            txtStatus.Enabled = isEditing;
            txtStock.Enabled = isEditing;

            //Các nút bấm 
            btnSave.Enabled = isEditing;
            btnCancel.Enabled = isEditing;

            btnAdd.Enabled = !isEditing;
            btnEdit.Enabled = !isEditing;
            btnDelete.Enabled = !isEditing;
        }

        //hàm nạp dữ liệu lên gridview
        private void LoadData()
        {
            string error = "";
            // Vì BLL trả về DataSet nên ta lấy Table[0]
            dataGridView1.DataSource = bll.GetAll().Tables[0];
        }

        //hàm clear input
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
            // Kiểm tra nếu click vào dòng hợp lệ
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Cách 1: Dùng Index (Số thứ tự cột) - An toàn nhất
                    txtProductID.Text = row.Cells[0].Value?.ToString();
                    txtCategoryID.Text = row.Cells[1].Value?.ToString();
                    txtName.Text = row.Cells[2].Value?.ToString();
                    txtPrice.Text = row.Cells[3].Value?.ToString();
                    txtStock.Text = row.Cells[4].Value?.ToString();
                    txtStatus.Text = row.Cells[5].Value?.ToString();

                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nạp dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddMode = true;
            SetState(true); // Bật các TextBox lên để nhập dữ liệu mới  
            ClearInputs(); // Xóa trắng các TextBox để nhập dữ liệu mới

            txtProductID.Focus(); // Đặt con trỏ vào TextBox đầu tiên để nhập
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductID.Text))
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.");
                return;
            }
            isAddMode = false; // Chuyển sang chế độ Sửa
            SetState(true); // Bật các TextBox lên để chỉnh sửa dữ liệu

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetState(false); // Tắt các TextBox, bật lại các nút bấm
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string productId = txtProductID.Text;
            if (string.IsNullOrEmpty(productId))
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
                return;
            }
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Xóa",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                string errror = "";
                if (bll.Delete(productId, ref errror))
                {
                    MessageBox.Show("Xóa sản phẩm thành công.");
                    LoadData(); // Tải lại dữ liệu sau khi xóa
                    ClearInputs(); // Xóa trắng các TextBox sau khi xóa
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại. Lỗi: " + errror);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string error = "";
            Product product = new Product
            {
                ProductID = txtProductID.Text,
                CategoryID = txtCategoryID.Text,
                Name = txtName.Text,
                Price = txtPrice.Text,
                Stock = txtStock.Text,
                Status = txtStatus.Text
            };

            //gọi BLL để xử lí 
            bool success = isAddMode ? bll.Add(product, ref error) : bll.Update(product, ref error);

            if (success)
            {
                MessageBox.Show(isAddMode ? "Thêm sản phẩm thành công." : "Cập nhật sản phẩm thành công.");
                LoadData(); // Tải lại dữ liệu sau khi thêm/sửa
                ClearInputs(); // Xóa trắng các TextBox sau khi lưu
                SetState(false); // Tắt các TextBox, bật lại các nút bấm
            }
            else
            {
                MessageBox.Show( "Lỗi: " + error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string categoryID = txtCategoryIDSearch.Text.Trim();
            string name = txtNameSearch.Text.Trim();
            string price = txtPriceSearch.Text.Trim();
            string stock = txtStockSearch.Text.Trim();
            string productID = txtProductIDSearch.Text.Trim();

            try
            {
                dataGridView1.DataSource = bll.ProductsSearch(categoryID, productID, name, price, stock ).Tables[0];
            }
            catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCategoryID.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtProductID.Clear();
            txtStatus.Clear();
            txtStock.Clear();

            LoadData();
        }
    }
}
