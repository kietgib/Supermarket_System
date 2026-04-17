using SupermarketSystem.BussinessLogicLayer.BLL;
using System;
using System.Data;
using System.Windows.Forms;
using SupermarketSystem; // 👉 dùng Entity Framework (Employee)

namespace SupermarketSystem.GUI.ManagementForms
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        // 👉 BLL
        StaffBLL bll = new StaffBLL();

        bool isAddMode = false;

        private void StaffForm_Load(object sender, EventArgs e)
        {
            LoadData();
            SetState(false);
        }

        // ================= LOAD DATA =================
        private void LoadData()
        {
            dgvStaff.DataSource = bll.GetAll(); // ❌ KHÔNG dùng .Tables nữa
        }

        // ================= STATE =================
        private void SetState(bool isEditing)
        {
            txtEmployeeID.Enabled = isEditing && isAddMode;
            txtName.Enabled = isEditing;
            txtPhone.Enabled = isEditing;
            txtPosition.Enabled = isEditing;
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
            txtEmployeeID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtPosition.Clear();
            txtStatus.Clear();
        }

        // ================= GRID CLICK =================
        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvStaff.Rows[e.RowIndex];

                    txtEmployeeID.Text = row.Cells[0].Value?.ToString();
                    txtName.Text = row.Cells[1].Value?.ToString();
                    txtPhone.Text = row.Cells[2].Value?.ToString();
                    txtPosition.Text = row.Cells[3].Value?.ToString();
                    txtStatus.Text = row.Cells[4].Value?.ToString();

                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        // ================= ADD =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddMode = true;
            SetState(true);
            ClearInputs();
            txtEmployeeID.Focus();
        }

        // ================= EDIT =================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("Chọn nhân viên cần sửa!");
                return;
            }

            isAddMode = false;
            SetState(true);
            txtEmployeeID.Enabled = false;
        }

        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtEmployeeID.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Chọn nhân viên cần xóa!");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
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
            try
            {
                string error = "";

                // 👉 DÙNG EF ENTITY: Employee (KHÔNG phải Staff)
                Employee emp = new Employee()
                {
                    EmployeeID = txtEmployeeID.Text,
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Position = txtPosition.Text,
                    Status = txtStatus.Text == "1" ? 1 : 0
                };

                bool success = isAddMode
                    ? bll.Add(emp, ref error)
                    : bll.Update(emp, ref error);

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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập: " + ex.Message);
            }
        }

        // ================= CANCEL =================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetState(false);
        }
    }
}