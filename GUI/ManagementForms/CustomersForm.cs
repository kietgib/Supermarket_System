using SupermarketSystem.BussinessLogicLayer.BLL;
using System;
using System.Windows.Forms;
using SupermarketSystem;

namespace SupermarketSystem.GUI.ManagementForms
{
    public partial class CustomersForm : Form
    {
        private readonly CustomersBLL bll = new CustomersBLL();
        private bool isAddMode = false;

        public CustomersForm()
        {
            InitializeComponent();
        }

        // ================= LOAD FORM =================
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadData();
            SetState(false);
        }

        // ================= LOAD DATA =================
        private void LoadData()
        {
            dgvCustomers.DataSource = bll.GetAll();
        }

        // ================= STATE =================
        private void SetState(bool isEditing)
        {
            txtCustomerID.Enabled = isEditing && isAddMode;
            txtName.Enabled = isEditing;
            txtPhone.Enabled = isEditing;
            txtAddress.Enabled = isEditing;
            txtStatus.Enabled = isEditing;

            btnSave.Enabled = isEditing;
            btnCancel.Enabled = isEditing;

            btnAdd.Enabled = !isEditing;
            btnEdit.Enabled = !isEditing;
            btnDelete.Enabled = !isEditing;
        }

        // ================= CLEAR =================
        private void ClearInputs()
        {
            txtCustomerID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtStatus.Clear();
        }

        // ================= ADD =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddMode = true;
            ClearInputs();
            SetState(true);
            txtCustomerID.Focus();
        }

        // ================= EDIT =================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }

            isAddMode = false;
            SetState(true);
            txtCustomerID.Enabled = false; // ID không cho sửa
        }

        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtCustomerID.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }

            var dr = MessageBox.Show(
                "Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
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

        // ================= SAVE =================
        private void btnSave_Click(object sender, EventArgs e)
        {
            string error = "";

            // Validate and parse Status as integer
            int statusInt = 0;
            string statusText = txtStatus.Text.Trim();
            if (!int.TryParse(statusText, out statusInt))
            {
                MessageBox.Show("Trạng thái phải là số nguyên.");
                return;
            }

            var cus = new Customer
            {
                CustomerID = txtCustomerID.Text.Trim(),
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Status = statusInt
            };

            bool success = isAddMode
                ? bll.Add(cus, ref error)
                : bll.Update(cus, ref error);

            if (success)
            {
                MessageBox.Show("Lưu thành công!");
                LoadData();
                SetState(false);
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
            }
        }

        // ================= CANCEL =================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            isAddMode = false;
            SetState(false);
            ClearInputs();
        }

        // ================= GRID CLICK =================
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvCustomers.Rows[e.RowIndex];

                txtCustomerID.Text = row.Cells["CustomerID"].Value?.ToString() ?? "";
                txtName.Text = row.Cells["Name"].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
                txtStatus.Text = row.Cells["Status"].Value?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc dòng: " + ex.Message);
            }
        }
    }
}