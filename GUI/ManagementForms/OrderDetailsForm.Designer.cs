namespace SupermarketSystem.GUI.ManagementForms
{
    partial class OrderDetailsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.supermarketDBDataSet = new SupermarketSystem.SupermarketDBDataSet();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsTableAdapter = new SupermarketSystem.SupermarketDBDataSetTableAdapters.OrderDetailsTableAdapter();
            this.orderDetailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDetailIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(752, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1441, 652);
            this.dataGridView1.TabIndex = 31;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(363, 304);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 73);
            this.button5.TabIndex = 30;
            this.button5.Text = "DELETE";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(247, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 73);
            this.button4.TabIndex = 29;
            this.button4.Text = "CANCEL";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(592, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 73);
            this.button3.TabIndex = 28;
            this.button3.Text = "SAVE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 73);
            this.button2.TabIndex = 27;
            this.button2.Text = "EDIT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 73);
            this.button1.TabIndex = 26;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 235);
            this.panel1.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(536, 26);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(536, 26);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(536, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(536, 26);
            this.textBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "UnitPrice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "ProductID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "OrderID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "OrderDetailID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "ORDER DETAILS INFORMATION";
            // 
            // supermarketDBDataSet
            // 
            this.supermarketDBDataSet.DataSetName = "SupermarketDBDataSet";
            this.supermarketDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.supermarketDBDataSet;
            // 
            // orderDetailsTableAdapter
            // 
            this.orderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // orderDetailIDDataGridViewTextBoxColumn
            // 
            this.orderDetailIDDataGridViewTextBoxColumn.DataPropertyName = "OrderDetailID";
            this.orderDetailIDDataGridViewTextBoxColumn.HeaderText = "OrderDetailID";
            this.orderDetailIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderDetailIDDataGridViewTextBoxColumn.Name = "orderDetailIDDataGridViewTextBoxColumn";
            this.orderDetailIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(132, 153);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(536, 26);
            this.textBox5.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantity";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(132, 190);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(536, 26);
            this.textBox6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Amount";
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2502, 1425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Name = "OrderDetailsForm";
            this.Text = "OrderDetailsForm";
            this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private SupermarketDBDataSet supermarketDBDataSet;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private SupermarketDBDataSetTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
    }
}