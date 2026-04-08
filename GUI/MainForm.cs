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
    public partial class MainForm : Form
    {
        public static bool bIsLoggedIn = false; //ghi nhận tình trạng đăng nhập 
        public MainForm()
        {
            InitializeComponent();
            //MenuThoat.Enabled = false; //vô hiệu hóa menu thoát khi chưa đăng nhập
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Full màn hình
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.BackgroundImage = Properties.Resources.BackgroundHome;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            // Stretch 
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.StartPosition = FormStartPosition.CenterParent; // thêm dòng này
            logInForm.ShowDialog(this); // truyền this

            if (bIsLoggedIn)
            {
                // MenuThoat.Enabled = true; //kích hoạt menu thoát khi đã đăng nhập
            }
        }

        private void main_load(object sender, EventArgs e)
        {
            // Full
        }

        private void exitAltXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
               {
                Application.Exit();
            }
        }


    }
}
    