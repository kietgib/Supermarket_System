namespace SupermarketSystem
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Thongtindangnhap = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textboxUserName = new System.Windows.Forms.TextBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Thongtindangnhap
            // 
            this.Thongtindangnhap.AutoSize = true;
            this.Thongtindangnhap.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thongtindangnhap.ForeColor = System.Drawing.Color.Navy;
            this.Thongtindangnhap.Location = new System.Drawing.Point(187, 19);
            this.Thongtindangnhap.Name = "Thongtindangnhap";
            this.Thongtindangnhap.Size = new System.Drawing.Size(331, 37);
            this.Thongtindangnhap.TabIndex = 0;
            this.Thongtindangnhap.Text = "LOGIN INFORMATION";
            this.Thongtindangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(74, 118);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(107, 26);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(74, 179);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(104, 26);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // textboxUserName
            // 
            this.textboxUserName.Location = new System.Drawing.Point(219, 111);
            this.textboxUserName.Name = "textboxUserName";
            this.textboxUserName.Size = new System.Drawing.Size(421, 33);
            this.textboxUserName.TabIndex = 3;
            // 
            // textboxPassword
            // 
            this.textboxPassword.Location = new System.Drawing.Point(219, 172);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.Size = new System.Drawing.Size(421, 33);
            this.textboxPassword.TabIndex = 4;
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.Navy;
            this.buttonlogin.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonlogin.Location = new System.Drawing.Point(67, 235);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(573, 56);
            this.buttonlogin.TabIndex = 5;
            this.buttonlogin.Text = "Log In ";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonCancel.Location = new System.Drawing.Point(163, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(395, 35);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Exit";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.textboxUserName);
            this.panel1.Controls.Add(this.Thongtindangnhap);
            this.panel1.Controls.Add(this.buttonlogin);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.textboxPassword);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(45, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 374);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 8;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "LogInForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Thongtindangnhap;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textboxUserName;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

