using SupermarketSystem.BussinessLogicLayer.BLL;
using SupermarketSystem.BussinessLogicLayer.Entities;
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

        CustomersBLL bll = new CustomersBLL();
        bool isAddMode = false; // Cờ kiểm tra đang Thêm hay Sửa

        // Hàm tắt/mở các Control để tránh người dùng bấm nhầm
        private void SetState(bool isEditing)
        {
            // Các TextBox
            txtCustomerID.Enabled = isEditing && isAddMode; // Chỉ cho nhập ID khi Thêm mới
            txtName.Enabled = isEditing;
            txtPhone.Enabled = isEditing;
            txtAddress.Enabled = isEditing;

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
            dgvCustomers.DataSource = bll.GetAll().Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddMode = true;
            SetState(true); // Bật các TextBox lên

            // Xóa trắng dữ liệu cũ
            txtCustomerID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtCustomerID.Focus();
        }

        //bật chế độ sửa cho dòng đang chọn 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa từ bảng!");
                return;
            }

            isAddMode = false; // Đánh dấu là đang SỬA chứ không phải THÊM
            SetState(true);    // Mở khóa các TextBox (txtName, txtPhone...)

            // Khóa ô ID lại vì thường ID là khóa chính, không được sửa
            txtCustomerID.Enabled = false;
            txtName.Focus();
        }

        //quay lại trạng thái ban đầu, có thể gọi lại hàm LoadData() để reset dữ liệu
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetState(false);
            // Có thể gọi lại hàm đổ dữ liệu từ GridView lên TextBox để reset
        }


        private void ClearInputs()
        {
            txtCustomerID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }
        //xóa khách hàng đang chọn, cần xác nhận trước khi xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtCustomerID.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                string error = "";
                // Gọi hàm Delete từ BLL
                if (bll.Delete(id, ref error))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData(); // Nạp lại bảng
                    ClearInputs(); // Xóa trắng các ô nhập
                }
                else
                {
                    // Lỗi này thường do khóa ngoại (khách hàng đã có hóa đơn)
                    MessageBox.Show("Không thể xóa! Lỗi: " + error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string error = "";
            // 1. Gom dữ liệu từ giao diện vào Entity
            Customers cus = new Customers(
                txtCustomerID.Text,
                txtName.Text,
                txtPhone.Text,
                txtAddress.Text
            );

            // 2. Gọi BLL xử lý
            bool success = isAddMode ? bll.Add(cus, ref error) : bll.Update(cus, ref error);

            if (success)
            {
                MessageBox.Show("Lưu dữ liệu thành công!");
                SetState(false); // Khóa các ô nhập lại
                LoadData();      // Cập nhật lại bảng hiển thị
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào dòng hợp lệ
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                    // Cách 1: Dùng Index (Số thứ tự cột) - An toàn nhất
                    txtCustomerID.Text = row.Cells[0].Value?.ToString();
                    txtName.Text = row.Cells[1].Value?.ToString();
                    txtPhone.Text = row.Cells[2].Value?.ToString();
                    txtAddress.Text = row.Cells[3].Value?.ToString();

                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nạp dữ liệu: " + ex.Message);
                }
            }

        }
    }
}
