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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 5;
            progressBar1.Value = startpoint;
            if (progressBar1.Value == 100)
            { 
                progressBar1.Value = 0;
                timer1.Stop();
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
                main.FormClosed += (s, args) => this.Close();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}