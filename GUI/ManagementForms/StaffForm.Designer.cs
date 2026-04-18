namespace SupermarketSystem.GUI.ManagementForms
{
    partial class StaffForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();

            // ── label6 (tiêu đề) ──────────────────────────────────────────
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightPink;
            this.tableLayoutPanel1.SetColumnSpan(this.label6, 3);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Cambria", 16F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "STAFF INFORMATION";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── label7 – EmployeeID ───────────────────────────────────────
            this.label7.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "EmployeeID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── label8 – Name ─────────────────────────────────────────────
            this.label8.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── label9 – Phone ────────────────────────────────────────────
            this.label9.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "Phone";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── label10 – Position ────────────────────────────────────────
            this.label10.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 30);
            this.label10.TabIndex = 3;
            this.label10.Text = "Position";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── label1 – Status ───────────────────────────────────────────
            this.label1.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── txtEmployeeID ─────────────────────────────────────────────
            this.txtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeID.Location = new System.Drawing.Point(3, 3);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(600, 26);
            this.txtEmployeeID.TabIndex = 4;

            // ── txtName ───────────────────────────────────────────────────
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(3, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(600, 26);
            this.txtName.TabIndex = 5;

            // ── txtPhone ──────────────────────────────────────────────────
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(3, 67);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(600, 26);
            this.txtPhone.TabIndex = 6;

            // ── txtPosition ───────────────────────────────────────────────
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosition.Location = new System.Drawing.Point(3, 99);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(600, 26);
            this.txtPosition.TabIndex = 7;

            // ── txtStatus ─────────────────────────────────────────────────
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Location = new System.Drawing.Point(3, 131);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(600, 26);
            this.txtStatus.TabIndex = 8;

            // ── dgvStaff ──────────────────────────────────────────────────
            this.dgvStaff.AutoGenerateColumns = true;
            this.dgvStaff.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(10);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 62;
            this.dgvStaff.RowTemplate.Height = 28;
            this.dgvStaff.TabIndex = 7;
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick_1);

            // ── btnAdd ────────────────────────────────────────────────────
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(30, 60);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(20, 50, 10, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 73);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);

            // ── btnEdit ───────────────────────────────────────────────────
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(160, 60);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(20, 50, 10, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 73);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);

            // ── btnCancel ─────────────────────────────────────────────────
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(290, 60);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(20, 50, 10, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 73);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);

            // ── btnDelete ─────────────────────────────────────────────────
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(420, 60);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(20, 50, 10, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 73);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);

            // ── btnSave ───────────────────────────────────────────────────
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(550, 60);
            this.btnSave.Margin = new System.Windows.Forms.Padding(20, 50, 20, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 73);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);

            // ── flowLayoutPanel1 (labels) ─────────────────────────────────
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection =
                System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.TabIndex = 17;

            // ── flowLayoutPanel3 (textboxes) ──────────────────────────────
            this.flowLayoutPanel3.Controls.Add(this.txtEmployeeID);
            this.flowLayoutPanel3.Controls.Add(this.txtName);
            this.flowLayoutPanel3.Controls.Add(this.txtPhone);
            this.flowLayoutPanel3.Controls.Add(this.txtPosition);
            this.flowLayoutPanel3.Controls.Add(this.txtStatus);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection =
                System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.TabIndex = 18;

            // ── flowLayoutPanel2 (buttons) ────────────────────────────────
            this.flowLayoutPanel2.Controls.Add(this.btnAdd);
            this.flowLayoutPanel2.Controls.Add(this.btnEdit);
            this.flowLayoutPanel2.Controls.Add(this.btnCancel);
            this.flowLayoutPanel2.Controls.Add(this.btnDelete);
            this.flowLayoutPanel2.Controls.Add(this.btnSave);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.TabIndex = 17;
            this.flowLayoutPanel2.WrapContents = false;

            // ── tableLayoutPanel1 ─────────────────────────────────────────
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent, 14.69175F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent, 45.27622F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(
                System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(
                System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(
                System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvStaff, 0, 2);
            this.tableLayoutPanel1.SetColumnSpan(this.dgvStaff, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.TabIndex = 17;

            // ── Form ──────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2457, 1358);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
        }

        // ── field declarations ────────────────────────────────────────────
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label6, label7, label8, label9, label10, label1;
        private System.Windows.Forms.TextBox txtEmployeeID, txtName, txtPhone, txtPosition, txtStatus;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnAdd, btnEdit, btnCancel, btnDelete, btnSave;
    }
}