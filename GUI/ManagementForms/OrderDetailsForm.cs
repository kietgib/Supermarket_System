using SupermarketSystem.BussinessLogicLayer.BLL;
using System;
using System.Linq;
using System.Windows.Forms;
using SupermarketSystem;

namespace SupermarketSystem.GUI.ManagementForms
{
    public partial class OrderDetailsForm : Form
    {
        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        OrderDetailsBLL bll = new OrderDetailsBLL();
        bool isAddMode = false;

        // ================= LOAD =================
        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            LoadData();
            SetState(false);
        }

        // ================= LOAD DATA =================
        private void LoadData()
        {
            dgvOrderDetails.DataSource = null;
            dgvOrderDetails.DataSource = bll.GetAll();
        }

        // ================= STATE =================
        private void SetState(bool isEditing)
        {
            txtOrderDetailID.Enabled = isEditing && isAddMode;
            txtOrderID.Enabled = isEditing;
            txtProductID.Enabled = isEditing;
            txtUnitprice.Enabled = isEditing;
            txtQuantity.Enabled = isEditing;
            txtTotalAmount.Enabled = false; // luôn disable vì tự tính

            btnSave.Enabled = isEditing;
            btnCancel.Enabled = isEditing;

            btnAdd.Enabled = !isEditing;
            btnEdit.Enabled = !isEditing;
            btnDelete.Enabled = !isEditing;
        }

        // ================= CLEAR =================
        private void ClearInputs()
        {
            txtOrderDetailID.Clear();
            txtOrderID.Clear();
            txtProductID.Clear();
            txtUnitprice.Clear();
            txtQuantity.Clear();
            txtTotalAmount.Clear();
        }

        // ================= ADD =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddMode = true;
            SetState(true);
            ClearInputs();
            txtOrderDetailID.Focus();
        }

        // ================= EDIT =================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderDetailID.Text))
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }

            isAddMode = false;
            SetState(true);
            txtOrderDetailID.Enabled = false;
        }

        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtOrderDetailID.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            if (MessageBox.Show("Xóa dòng này?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
        // ================= SAVE =================
        private void btnSave_Click(object sender, EventArgs e)
        {
            string error = "";

            try
            {
                var od = BuildOrderDetail();

                bool success = isAddMode
                    ? bll.Add(od, ref error)
                    : bll.Update(od, ref error);

                if (success)
                {
                    MessageBox.Show("Lưu thành công!");
                    LoadData();
                    ClearInputs();
                    SetState(false);      // ← đúng thứ tự: clear xong mới set state
                    isAddMode = false;    // ← reset flag
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

        // ================= BUILD ENTITY =================
        private OrderDetail BuildOrderDetail()
        {
            if (string.IsNullOrWhiteSpace(txtOrderDetailID.Text) ||
                string.IsNullOrWhiteSpace(txtOrderID.Text) ||
                string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                throw new Exception("Nhập thiếu dữ liệu!");
            }

            if (!decimal.TryParse(txtUnitprice.Text, out decimal unitPrice))
                throw new Exception("UnitPrice sai!");

            if (!int.TryParse(txtQuantity.Text, out int quantity))
                throw new Exception("Quantity sai!");

            decimal total = unitPrice * quantity;

            txtTotalAmount.Text = total.ToString();

            return new OrderDetail
            {
                OrderDetailID = txtOrderDetailID.Text.Trim(),
                OrderID = txtOrderID.Text.Trim(),
                ProductID = txtProductID.Text.Trim(),
                UnitPrice = unitPrice,
                Quantity = quantity,
                TotalAmount = total
            };
        }

        // ================= GRID CLICK =================
        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvOrderDetails.Rows[e.RowIndex];

            txtOrderDetailID.Text = row.Cells["OrderDetailID"].Value?.ToString();
            txtOrderID.Text = row.Cells["OrderID"].Value?.ToString();
            txtProductID.Text = row.Cells["ProductID"].Value?.ToString();
            txtUnitprice.Text = row.Cells["UnitPrice"].Value?.ToString();
            txtQuantity.Text = row.Cells["Quantity"].Value?.ToString();
            txtTotalAmount.Text = row.Cells["TotalAmount"].Value?.ToString();

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        // ================= CANCEL =================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Restore non-editing state and clear inputs when Cancel is clicked.
            ClearInputs();
            SetState(false);
        }
    }
}