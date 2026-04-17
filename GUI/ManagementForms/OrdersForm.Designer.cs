namespace SupermarketSystem.GUI.ManagementForms
{
    partial class OrdersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();

            // ── dataGridView1 ─────────────────────────────────────────────
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // ── label1 (tiêu đề) ──────────────────────────────────────────
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
            this.label1.Text = "ORDERS INFORMATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── label7 – OrderID ──────────────────────────────────────────
            this.label7.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "OrderID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── label8 – CustomerID ───────────────────────────────────────
            this.label8.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "CustomerID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── label9 – Order Date ───────────────────────────────────────
            this.label9.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "Order Date";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── label10 – Status ──────────────────────────────────────────
            this.label10.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 32);
            this.label10.TabIndex = 3;
            this.label10.Text = "Status";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── textBox5 – OrderID ────────────────────────────────────────
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(3, 3);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(600, 26);
            this.textBox5.TabIndex = 4;

            // ── textBox6 – CustomerID ─────────────────────────────────────
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(3, 41);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(600, 26);
            this.textBox6.TabIndex = 5;

            // ── textBox7 – Order Date ─────────────────────────────────────
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(3, 79);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(600, 26);
            this.textBox7.TabIndex = 6;

            // ── textBox8 – Status ─────────────────────────────────────────
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(3, 117);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(600, 26);
            this.textBox8.TabIndex = 7;

            // ── button6 – ADD ─────────────────────────────────────────────
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Margin = new System.Windows.Forms.Padding(20, 50, 10, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 73);
            this.button6.TabIndex = 10;
            this.button6.Text = "ADD";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;

            // ── button7 – EDIT ────────────────────────────────────────────
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Margin = new System.Windows.Forms.Padding(20, 50, 10, 20);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 73);
            this.button7.TabIndex = 11;
            this.button7.Text = "EDIT";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;

            // ── button8 – CANCEL ──────────────────────────────────────────
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Margin = new System.Windows.Forms.Padding(20, 50, 10, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 73);
            this.button8.TabIndex = 13;
            this.button8.Text = "CANCEL";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;

            // ── button9 – DELETE ──────────────────────────────────────────
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Margin = new System.Windows.Forms.Padding(20, 50, 10, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 73);
            this.button9.TabIndex = 14;
            this.button9.Text = "DELETE";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;

            // ── button10 – SAVE ───────────────────────────────────────────
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Cambria", 10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Margin = new System.Windows.Forms.Padding(20, 50, 20, 50);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 73);
            this.button10.TabIndex = 12;
            this.button10.Text = "SAVE";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;

            // ── flowLayoutPanel1 (labels) ─────────────────────────────────
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection =
                System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.TabIndex = 17;

            // ── flowLayoutPanel3 (textboxes) ──────────────────────────────
            this.flowLayoutPanel3.Controls.Add(this.textBox5);
            this.flowLayoutPanel3.Controls.Add(this.textBox6);
            this.flowLayoutPanel3.Controls.Add(this.textBox7);
            this.flowLayoutPanel3.Controls.Add(this.textBox8);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection =
                System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.TabIndex = 18;

            // ── flowLayoutPanel2 (buttons) ────────────────────────────────
            this.flowLayoutPanel2.Controls.Add(this.button6);
            this.flowLayoutPanel2.Controls.Add(this.button7);
            this.flowLayoutPanel2.Controls.Add(this.button8);
            this.flowLayoutPanel2.Controls.Add(this.button9);
            this.flowLayoutPanel2.Controls.Add(this.button10);
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
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.TabIndex = 32;

            // ── Form ──────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2501, 1410);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
        }

        // ── field declarations ────────────────────────────────────────────
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1, label7, label8, label9, label10;
        private System.Windows.Forms.TextBox textBox5, textBox6, textBox7, textBox8;
        private System.Windows.Forms.Button button6, button7, button8, button9, button10;
    }
}