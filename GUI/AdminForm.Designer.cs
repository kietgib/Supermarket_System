namespace SupermarketSystem
{
    partial class AdminForm
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
            this.menuStripSystemAdminForm = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSystemAdminForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripSystemAdminForm
            // 
            this.menuStripSystemAdminForm.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripSystemAdminForm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripSystemAdminForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.managementListsToolStripMenuItem});
            this.menuStripSystemAdminForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripSystemAdminForm.Name = "menuStripSystemAdminForm";
            this.menuStripSystemAdminForm.Size = new System.Drawing.Size(800, 33);
            this.menuStripSystemAdminForm.TabIndex = 1;
            this.menuStripSystemAdminForm.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.exitToolStripMenuItem.Text = "Exit                   Alt+F4";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // managementListsToolStripMenuItem
            // 
            this.managementListsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.customerToolStripMenuItem1,
            this.orderToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.orderDetailsToolStripMenuItem});
            this.managementListsToolStripMenuItem.Name = "managementListsToolStripMenuItem";
            this.managementListsToolStripMenuItem.Size = new System.Drawing.Size(172, 29);
            this.managementListsToolStripMenuItem.Text = "Management Lists";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click_1);
            // 
            // customerToolStripMenuItem1
            // 
            this.customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            this.customerToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.customerToolStripMenuItem1.Text = "Customer";
            this.customerToolStripMenuItem1.Click += new System.EventHandler(this.customerToolStripMenuItem1_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 33);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 417);
            this.panelMain.TabIndex = 2;
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.orderDetailsToolStripMenuItem.Text = "Order Details";
            this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStripSystemAdminForm);
            this.MainMenuStrip = this.menuStripSystemAdminForm;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStripSystemAdminForm.ResumeLayout(false);
            this.menuStripSystemAdminForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripSystemAdminForm;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
    }
}