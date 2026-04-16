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

namespace SupermarketSystem.GUI.ManagementForms
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.supermarketDBDataSet.Employees);
            // TODO: This line of code loads data into the 'supermarketDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.supermarketDBDataSet.Customers);

        }

        StaffBLL bll = new StaffBLL();
        bool isAddMode = false; // Cờ kiểm tra đang Thêm hay Sửa

        //hàm tắt/mở các Control để tránh người dùng bấm nhầm
        private void SetState(bool isEditing)
        {
            // Các textBox
            txtEmployeeID.Enabled = isEditing && isAddMode; // Chỉ cho nhập ID khi Thêm mới
            txtName.Enabled = isEditing;
            txtPhone.Enabled = isEditing;
            txtPosition.Enabled = isEditing;

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
            dgvStaff.DataSource = bll.GetAll().Tables[0];
        }

        private void ClearInputs()
        {
            txtEmployeeID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtPosition.Clear();

        }

        private void dgvStaff_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào dòng hợp lệ
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvStaff.Rows[e.RowIndex];

                    // Cách 1: Dùng Index (Số thứ tự cột) - An toàn nhất
                    txtEmployeeID.Text = row.Cells[0].Value?.ToString();
                    txtName.Text = row.Cells[1].Value?.ToString();
                    txtPhone.Text = row.Cells[2].Value?.ToString();
                    txtPosition.Text = row.Cells[3].Value?.ToString();

                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nạp dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            isAddMode = true;
            SetState(true); // Bật các TextBox lên để nhập dữ liệu mới  

            // Xóa trắng các TextBox để nhập dữ liệu mới
            txtEmployeeID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtPosition.Clear();
            // Khóa ô ID lại vì thường ID là khóa chính, không được sửa
            txtEmployeeID.Focus();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("Vui lòng chọn một Staff để sửa.");
                return;
            }
            isAddMode = false; //đanh dấu đang ở chế độ sửa
            SetState(true); // Bật các TextBox lên để sửa
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            SetState(false); // Tắt các TextBox, bật lại các nút bấm
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string id = txtEmployeeID.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng chọn một Staff để xóa.");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa Staff này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string error = "";
                if (bll.Delete(id, ref error))
                {
                    MessageBox.Show("Xóa Staff thành công!");
                    LoadData(); // Tải lại dữ liệu sau khi xóa
                }
                else
                {
                    MessageBox.Show("Xóa Staff thất bại! Lỗi: " + error);
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string error = "";
            // 1. Gom dữ liệu từ giao diện vào Entity
            Staff cus = new Staff(
                txtEmployeeID.Text,
                txtName.Text,
                txtPhone.Text,
                txtPosition.Text
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
    }
}
