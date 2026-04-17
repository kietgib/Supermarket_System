namespace SupermarketSystem.GUI.ManagementForms
{
    partial class CustomersForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();

            // ── dgvCustomers ──────────────────────────────────────────────
            this.dgvCustomers.AutoGenerateColumns = true;
            this.dgvCustomers.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 62;
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);

            // ── label1 (tiêu đề) ─────────────────────────────────────────
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cambria", 16F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMERS INFORMATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── label7 – CustomerID ──────────────────────────────────────
            this.label7.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "CustomerID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── label8 – Name ────────────────────────────────────────────
            this.label8.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── label9 – Phone ───────────────────────────────────────────
            this.label9.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "Phone";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── label10 – Address ────────────────────────────────────────
            this.label10.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 32);
            this.label10.TabIndex = 3;
            this.label10.Text = "Address";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── label2 – Status ──────────────────────────────────────────
            this.label2.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── txtCustomerID ────────────────────────────────────────────
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Location = new System.Drawing.Point(3, 3);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(500, 26);
            this.txtCustomerID.TabIndex = 0;

            // ── txtName ──────────────────────────────────────────────────
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(3, 41);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(500, 26);
            this.txtName.TabIndex = 1;

            // ── txtPhone ─────────────────────────────────────────────────
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(3, 79);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(500, 26);
            this.txtPhone.TabIndex = 2;

            // ── txtAddress ───────────────────────────────────────────────
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(3, 117);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(500, 26);
            this.txtAddress.TabIndex = 3;

            // ── txtStatus ────────────────────────────────────────────────
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Location = new System.Drawing.Point(3, 155);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(500, 26);
            this.txtStatus.TabIndex = 4;

            // ── btnAdd ───────────────────────────────────────────────────
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(10, 20);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 50);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // ── btnEdit ──────────────────────────────────────────────────
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(140, 20);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 50);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // ── btnCancel ────────────────────────────────────────────────
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(270, 20);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ── btnDelete ────────────────────────────────────────────────
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(400, 20);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // ── btnSave ──────────────────────────────────────────────────
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(530, 20);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // ── flowLayoutPanel1 (labels) ────────────────────────────────
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection =
                System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.TabIndex = 17;

            // ── flowLayoutPanel3 (textboxes) ─────────────────────────────
            this.flowLayoutPanel3.Controls.Add(this.txtCustomerID);
            this.flowLayoutPanel3.Controls.Add(this.txtName);
            this.flowLayoutPanel3.Controls.Add(this.txtPhone);
            this.flowLayoutPanel3.Controls.Add(this.txtAddress);
            this.flowLayoutPanel3.Controls.Add(this.txtStatus);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection =
                System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.TabIndex = 18;

            // ── flowLayoutPanel2 (buttons) ───────────────────────────────
            this.flowLayoutPanel2.Controls.Add(this.btnAdd);
            this.flowLayoutPanel2.Controls.Add(this.btnEdit);
            this.flowLayoutPanel2.Controls.Add(this.btnCancel);
            this.flowLayoutPanel2.Controls.Add(this.btnDelete);
            this.flowLayoutPanel2.Controls.Add(this.btnSave);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.TabIndex = 19;

            // ── tableLayoutPanel1 ────────────────────────────────────────
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(
                System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(
                System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(
                System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvCustomers, 0, 2);
            this.tableLayoutPanel1.SetColumnSpan(this.dgvCustomers, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.TabIndex = 24;

            // ── Form ─────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomersForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomersForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
        }

        // ── field declarations ───────────────────────────────────────────
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1, label7, label8, label9, label10, label2;
        private System.Windows.Forms.TextBox txtCustomerID, txtName, txtPhone, txtAddress, txtStatus;
        private System.Windows.Forms.Button btnAdd, btnEdit, btnCancel, btnDelete, btnSave;
    }
}