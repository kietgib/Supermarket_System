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
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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

        // ── Management Lists → Staff 
        private void staffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new StaffForm());
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomersForm());
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrdersForm());
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductsForm());
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrderDetailsForm());
        }
    }
}
