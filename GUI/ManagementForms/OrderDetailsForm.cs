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

        OrderDetailsBLL bll = new OrderDetailsBLL();
        bool isAddMode = false; // Cờ kiểm tra đang Thêm hay Sửa
        private double TotalAmount;

        //hàm tắt/mở các Control để tránh người dùng bấm nhầm
        private void SetState(bool isEditing)
        {
            // Các textBox
            txtOrderDetailID.Enabled = isEditing && isAddMode; // Chỉ cho nhập ID khi Thêm mới
            txtOrderID.Enabled = isEditing;
            txtProductID.Enabled = isEditing;
            txtUnitprice.Enabled = isEditing;
            txtQuantity.Enabled = isEditing;
            txtTotalAmount.Enabled = isEditing;

            // Các nút bấm
            btnSave.Enabled = isEditing;
            btnCancel.Enabled = isEditing;

            btnAdd.Enabled = !isEditing;
            btnEdit.Enabled = !isEditing;
            btnDelete.Enabled = !isEditing;
        }

        // Hàm nạp dữ liệu lên GridView
        private void LoadData()
        {
            string error = "";
            // Vì BLL trả về DataSet nên ta lấy Table[0]
            dgvOrderDetails.DataSource = bll.GetAll().Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddMode = true;
            // Xóa trắng các TextBox để nhập dữ liệu mới
            txtOrderDetailID.Clear();
            txtOrderID.Clear();
            txtProductID.Clear();
            txtUnitprice.Clear();
            txtQuantity.Clear();
            txtTotalAmount.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderDetailID.Text))
            {
                MessageBox.Show("Vui lòng chọn một Order Detail để sửa.");
                return;
            }
            isAddMode = false; //đanh dấu đang ở chế độ sửa
            SetState(true); // Bật các TextBox lên để sửa
        }

        private void ClearInputs()
        {
            txtOrderDetailID.Clear();
            txtOrderID.Clear();
            txtProductID.Clear();
            txtUnitprice.Clear();
            txtQuantity.Clear();
            txtTotalAmount.Clear();

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetState(false); // Tắt các TextBox, bật lại các nút bấm
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtOrderDetailID.Text;
            if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng chọn một Order Detail để xóa.");
                    return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa Order Detail này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string error = "";
                if (bll.Delete(id, ref error))
                {
                    MessageBox.Show("Xóa Order Detail thành công!");
                    LoadData(); // Tải lại dữ liệu sau khi xóa
                }
                else
                {
                    MessageBox.Show("Xóa Order Detail thất bại! Lỗi: " + error);
                }
            }
        }

        private double GetTotalAmount()
        {
            return TotalAmount;
        }

        private void btnSave_Click(object sender, EventArgs e, double totalAmount)
        {
            string error = "";
            //1. Gom dữ liệu từ giao diện vào Entity
            var orderDetail = BuildOrderDetailFromInputs();
            bool success;
            if (isAddMode)
            {
                // Thêm mới
                success = bll.Add(orderDetail, ref error);
            }
            else
            {
                // Cập nhật
                success = bll.Update(orderDetail, ref error);
            }
            if (success)
            {
                MessageBox.Show(isAddMode ? "Thêm Order Detail thành công!" : "Cập nhật Order Detail thành công!");
                LoadData(); // Tải lại dữ liệu sau khi thêm/sửa
                ClearInputs(); // Xóa trắng các ô nhập sau khi lưu
                SetState(false); // Trở về trạng thái ban đầu
            }
            else
            {
                MessageBox.Show("Lưu Order Detail thất bại! Lỗi: " + error);
            }

        }

        private BussinessLogicLayer.Entities.OrderDetail BuildOrderDetailFromInputs()
        {
            return new BussinessLogicLayer.Entities.OrderDetail
            {
                OrderDetailID = txtOrderDetailID.Text,
                OrderID = txtOrderID.Text,
                ProductID = txtProductID.Text,
                UnitPrice = (double)(decimal.TryParse(txtUnitprice.Text, out decimal unitPrice) ? unitPrice : 0),
                Quantity = int.TryParse(txtQuantity.Text, out int quantity) ? quantity : 0,
                totalAmount = decimal.TryParse(txtTotalAmount.Text, out decimal totalAmount) ? totalAmount : 0
            };
        }

        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng không bấm vào header
            {
                try
                {
                    DataGridViewRow row = dgvOrderDetails.Rows[e.RowIndex];
                    txtOrderDetailID.Text = row.Cells["OrderDetailID"].Value.ToString();
                    txtOrderID.Text = row.Cells["OrderID"].Value.ToString();
                    txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                    txtUnitprice.Text = row.Cells["UnitPrice"].Value.ToString();
                    txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                    txtTotalAmount.Text = row.Cells["TotalAmount"].Value.ToString();

                    btnEdit.Enabled = true; // Cho phép sửa khi đã chọn một dòng
                    btnDelete.Enabled = true; // Cho phép xóa khi đã chọn một dòng
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn Order Detail: " + ex.Message);
                }

            }

        }
    }
}
