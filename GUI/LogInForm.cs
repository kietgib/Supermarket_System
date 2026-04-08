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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (textboxUserName.Text.Trim().Equals("admin") &&
                textboxPassword.Text.Trim() == "123")
            {
                MainForm.bIsLoggedIn = true; //đăng nhập thành công

                AdminForm admin = new AdminForm();
                this.Hide();
                admin.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult traloi; 
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Close();
            }    
        }
    }
}
