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
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.orderDetailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermarketDBDataSet = new SupermarketSystem.SupermarketDBDataSet();
            this.orderDetailsTableAdapter = new SupermarketSystem.SupermarketDBDataSetTableAdapters.OrderDetailsTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtOrderDetailID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtUnitprice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtOrderIDSearch = new System.Windows.Forms.TextBox();
            this.txtOrderDetailIDSearch = new System.Windows.Forms.TextBox();
            this.txtProductIDSearch = new System.Windows.Forms.TextBox();
            this.txtUnitPriceSearch = new System.Windows.Forms.TextBox();
            this.txtQuantitySearch = new System.Windows.Forms.TextBox();
            this.txtTotalAmountSearch = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDBDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AutoGenerateColumns = false;
            this.dgvOrderDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDetailIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.Status});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvOrderDetails, 2);
            this.dgvOrderDetails.DataSource = this.orderDetailsBindingSource;
            this.dgvOrderDetails.Location = new System.Drawing.Point(10, 291);
            this.dgvOrderDetails.Margin = new System.Windows.Forms.Padding(10);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowHeadersWidth = 62;
            this.dgvOrderDetails.RowTemplate.Height = 28;
            this.dgvOrderDetails.Size = new System.Drawing.Size(989, 522);
            this.dgvOrderDetails.TabIndex = 31;
            this.dgvOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellClick);
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
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.supermarketDBDataSet;
            // 
            // supermarketDBDataSet
            // 
            this.supermarketDBDataSet.DataSetName = "SupermarketDBDataSet";
            this.supermarketDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsTableAdapter
            // 
            this.orderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.69646F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.29073F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.01281F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvOrderDetails, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1710, 844);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.txtOrderID);
            this.flowLayoutPanel3.Controls.Add(this.txtOrderDetailID);
            this.flowLayoutPanel3.Controls.Add(this.txtProductID);
            this.flowLayoutPanel3.Controls.Add(this.txtUnitprice);
            this.flowLayoutPanel3.Controls.Add(this.txtQuantity);
            this.flowLayoutPanel3.Controls.Add(this.txtTotalAmount);
            this.flowLayoutPanel3.Controls.Add(this.textBox1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(260, 72);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(756, 201);
            this.flowLayoutPanel3.TabIndex = 18;
            // 
            // txtOrderID
            // 
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderID.Location = new System.Drawing.Point(3, 2);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(534, 22);
            this.txtOrderID.TabIndex = 4;
            // 
            // txtOrderDetailID
            // 
            this.txtOrderDetailID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderDetailID.Location = new System.Drawing.Point(3, 28);
            this.txtOrderDetailID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderDetailID.Name = "txtOrderDetailID";
            this.txtOrderDetailID.Size = new System.Drawing.Size(534, 22);
            this.txtOrderDetailID.TabIndex = 5;
            // 
            // txtProductID
            // 
            this.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductID.Location = new System.Drawing.Point(3, 54);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(534, 22);
            this.txtProductID.TabIndex = 6;
            // 
            // txtUnitprice
            // 
            this.txtUnitprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitprice.Location = new System.Drawing.Point(3, 80);
            this.txtUnitprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitprice.Name = "txtUnitprice";
            this.txtUnitprice.Size = new System.Drawing.Size(534, 22);
            this.txtUnitprice.TabIndex = 7;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(3, 106);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(534, 22);
            this.txtQuantity.TabIndex = 8;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Location = new System.Drawing.Point(3, 132);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(534, 22);
            this.txtTotalAmount.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(3, 158);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(534, 22);
            this.textBox1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightPink;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 3);
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.label8.Size = new System.Drawing.Size(1710, 64);
            this.label8.TabIndex = 0;
            this.label8.Text = "ORDER DETAILS INFORMATION";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.label13);
            this.flowLayoutPanel1.Controls.Add(this.label14);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 72);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(233, 201);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 2);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Order ID";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "OrderDetail ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Product ID";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 86);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 24);
            this.label12.TabIndex = 3;
            this.label12.Text = "Unit Price";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 114);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 24);
            this.label13.TabIndex = 4;
            this.label13.Text = "Quantity";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 142);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 24);
            this.label14.TabIndex = 5;
            this.label14.Text = "Total Amount";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAdd);
            this.flowLayoutPanel2.Controls.Add(this.btnEdit);
            this.flowLayoutPanel2.Controls.Add(this.btnCancel);
            this.flowLayoutPanel2.Controls.Add(this.btnDelete);
            this.flowLayoutPanel2.Controls.Add(this.btnSave);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1028, 66);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(679, 213);
            this.flowLayoutPanel2.TabIndex = 17;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(27, 48);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(18, 40, 9, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 58);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(143, 48);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(18, 40, 9, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 58);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(259, 48);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(18, 40, 9, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 58);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(375, 48);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(18, 40, 9, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 58);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(491, 48);
            this.btnSave.Margin = new System.Windows.Forms.Padding(18, 40, 18, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 58);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AllowDrop = true;
            this.flowLayoutPanel4.Controls.Add(this.txtOrderIDSearch);
            this.flowLayoutPanel4.Controls.Add(this.txtOrderDetailIDSearch);
            this.flowLayoutPanel4.Controls.Add(this.txtProductIDSearch);
            this.flowLayoutPanel4.Controls.Add(this.txtUnitPriceSearch);
            this.flowLayoutPanel4.Controls.Add(this.txtQuantitySearch);
            this.flowLayoutPanel4.Controls.Add(this.txtTotalAmountSearch);
            this.flowLayoutPanel4.Controls.Add(this.btnReset);
            this.flowLayoutPanel4.Controls.Add(this.btnSearch);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(1035, 291);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(665, 386);
            this.flowLayoutPanel4.TabIndex = 32;
            this.flowLayoutPanel4.WrapContents = false;
            // 
            // txtOrderIDSearch
            // 
            this.txtOrderIDSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderIDSearch.Location = new System.Drawing.Point(3, 2);
            this.txtOrderIDSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderIDSearch.Name = "txtOrderIDSearch";
            this.txtOrderIDSearch.Size = new System.Drawing.Size(534, 22);
            this.txtOrderIDSearch.TabIndex = 31;
            // 
            // txtOrderDetailIDSearch
            // 
            this.txtOrderDetailIDSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderDetailIDSearch.Location = new System.Drawing.Point(3, 28);
            this.txtOrderDetailIDSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderDetailIDSearch.Name = "txtOrderDetailIDSearch";
            this.txtOrderDetailIDSearch.Size = new System.Drawing.Size(534, 22);
            this.txtOrderDetailIDSearch.TabIndex = 30;
            // 
            // txtProductIDSearch
            // 
            this.txtProductIDSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductIDSearch.Location = new System.Drawing.Point(3, 54);
            this.txtProductIDSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductIDSearch.Name = "txtProductIDSearch";
            this.txtProductIDSearch.Size = new System.Drawing.Size(534, 22);
            this.txtProductIDSearch.TabIndex = 25;
            // 
            // txtUnitPriceSearch
            // 
            this.txtUnitPriceSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitPriceSearch.Location = new System.Drawing.Point(3, 80);
            this.txtUnitPriceSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitPriceSearch.Name = "txtUnitPriceSearch";
            this.txtUnitPriceSearch.Size = new System.Drawing.Size(534, 22);
            this.txtUnitPriceSearch.TabIndex = 24;
            this.txtUnitPriceSearch.Text = "nhap <, >, <=, >= truoc so khi muon tim khoang";
            // 
            // txtQuantitySearch
            // 
            this.txtQuantitySearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantitySearch.Location = new System.Drawing.Point(3, 106);
            this.txtQuantitySearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantitySearch.Name = "txtQuantitySearch";
            this.txtQuantitySearch.Size = new System.Drawing.Size(534, 22);
            this.txtQuantitySearch.TabIndex = 26;
            this.txtQuantitySearch.Text = "nhap <, >, <=, >= truoc so khi muon tim khoang";
            // 
            // txtTotalAmountSearch
            // 
            this.txtTotalAmountSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmountSearch.Location = new System.Drawing.Point(3, 132);
            this.txtTotalAmountSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalAmountSearch.Name = "txtTotalAmountSearch";
            this.txtTotalAmountSearch.Size = new System.Drawing.Size(534, 22);
            this.txtTotalAmountSearch.TabIndex = 27;
            this.txtTotalAmountSearch.Text = "nhap <, >, <=, >= truoc so khi muon tim khoang";
            // 
            // btnReset
            // 
            this.btnReset.AllowDrop = true;
            this.btnReset.AutoSize = true;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(18, 196);
            this.btnReset.Margin = new System.Windows.Forms.Padding(18, 40, 9, 16);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 58);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(18, 277);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(18, 7, 9, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 58);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 844);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderDetailsForm";
            this.Text = "OrderDetailsForm";
            this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDBDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private SupermarketDBDataSet supermarketDBDataSet;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private SupermarketDBDataSetTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtOrderDetailID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtUnitprice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox txtOrderIDSearch;
        private System.Windows.Forms.TextBox txtOrderDetailIDSearch;
        private System.Windows.Forms.TextBox txtProductIDSearch;
        private System.Windows.Forms.TextBox txtUnitPriceSearch;
        private System.Windows.Forms.TextBox txtQuantitySearch;
        private System.Windows.Forms.TextBox txtTotalAmountSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
    }
}