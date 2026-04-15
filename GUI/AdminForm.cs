using SupermarketSystem.GUI;
using SupermarketSystem.GUI.ManagementForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Full màn hình
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            //lưu lại form đang mở 
            AddMenuEffect(Staff);
            AddMenuEffect(Customer);
            AddMenuEffect(Order);
            AddMenuEffect(Products);
            AddMenuEffect(OrderDetails);

            //kích thước panel trái
            panelMain.Dock = DockStyle.Left;
            panelMain.Width = 200;

            //kích thước panel phải
            panel1.Dock = DockStyle.Fill;
            
        }

        //tạo biến lưu chữ màu menu để có thể reset về mặc định khi đổi màu panel trái
        private Color menuTextColor = Color.Black;

        // MouseLeave, MouseEnter, Click cho menu item (Label) để tạo hiệu ứng khi hover và click
        private void panelMain_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl != null && lbl.BackColor != Color.LightBlue)
            {
                lbl.ForeColor = menuTextColor;
                lbl.Font = new Font(lbl.Font, FontStyle.Regular);
            }
        }
        private void panelMain_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl != null && lbl.BackColor != Color.LightBlue)
            {
                lbl.ForeColor = Color.Blue;
                lbl.Font = new Font(lbl.Font, FontStyle.Bold);
            }
        }
        private void panelMain_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl == null) return;

            ResetMenuUI();

            // highlight label được chọn
            lbl.BackColor = Color.LightBlue;
            lbl.ForeColor = Color.Blue;
            lbl.Font = new Font(lbl.Font, FontStyle.Bold);

            // load form tương ứng
            if (lbl == Staff)
                LoadForm(new StaffForm());
            else if (lbl == Customer)
                LoadForm(new CustomersForm());
            else if (lbl == Order)
                LoadForm(new OrdersForm());
            else if (lbl == Products)
                LoadForm(new ProductsForm());
            else if (lbl == OrderDetails)
                LoadForm(new OrderDetailsForm());
        }
        private void ResetMenuUI()
        {
            foreach (Control ctrl in panelMain.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = menuTextColor;
                    lbl.Font = new Font(lbl.Font, FontStyle.Regular);
                }
            }
        }
        private void AddMenuEffect(Label lbl)
        {
            lbl.MouseEnter += panelMain_MouseEnter;
            lbl.MouseLeave += panelMain_MouseLeave;
            lbl.Click += panelMain_Click;

            lbl.Cursor = Cursors.Hand;
        }


        // chỉnh màu panel trái
        private void leftPanelColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            // cho phép chọn màu custom
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;

            // mở bảng màu
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelMain.BackColor = colorDialog.Color;
            }
        }
        //chỉnh màu panel phải 
        private void rightPanelColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (currentForm != null)
                {
                    currentForm.BackColor = colorDialog.Color;
                }
            }
        }

        //hàm đổi màu chữ tất cả control con trong form hiện tại
        private void SetTextColor(Control parent, Color color)
        {
            parent.ForeColor = color;

            foreach (Control ctrl in parent.Controls)
            {
                SetTextColor(ctrl, color); // đệ quy xuống tất cả control con
            }
        }
        //gọi khi chọn màu
        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (currentForm != null)
                {
                    SetTextColor(currentForm, colorDialog.Color);
                }
            }
        }


        private void textColorInLeftPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            // cho phép chọn màu custom
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {

                // mở bảng màu
                menuTextColor = colorDialog.Color;
                foreach (Control ctrl in panelMain.Controls)
                {
                    if (ctrl is Label lbl)
                    {
                        lbl.ForeColor = menuTextColor;
                    }
                }
            }

        }
        //exit menu item


        private void OpenChildForm(Form childForm)
        {
            // Đóng form con cũ nếu đang mở trong panel
            foreach (Control c in panelMain.Controls)
                if (c is Form f) f.Close();

            panelMain.Controls.Clear();

            childForm.TopLevel = false;          // không hiện cửa sổ riêng
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;     // tự co giãn theo panel

            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.Show();
        }

        //tạo hàm nhúng form vào panelMain để hiển thị form con khi click vào menu item

        private Form currentForm;
        private void LoadForm(Form form)
        {
            panel1.Controls.Clear();

            currentForm = form; //lưu lại form hiện tại để có thể đóng khi mở form mới
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel1.Controls.Add(form);
            form.Show();
        }


        // ── Management Lists → Staff 

        private void Staff_Click(object sender, EventArgs e)
        {
            LoadForm(new StaffForm());
        }
        private void Customer_Click(object sender, EventArgs e)
        {
            LoadForm(new CustomersForm());
        }
        private void Order_Click(object sender, EventArgs e)
        {
            LoadForm(new OrdersForm());
        }
        private void Products_Click(object sender, EventArgs e)
        {
            LoadForm(new ProductsForm());
        }
        private void OrderDetails_Click(object sender, EventArgs e)
        {
            LoadForm(new OrderDetailsForm());
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
