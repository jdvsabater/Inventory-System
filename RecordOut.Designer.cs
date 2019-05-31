namespace Paint_Products_Database
{
    partial class RecordOut
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.lblRecordNotice = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxManufacturer = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRecordSearchBoxProductType = new System.Windows.Forms.TextBox();
            this.txtRecordSearchBoxProductName = new System.Windows.Forms.TextBox();
            this.txtRecordSearchBoxManufacturer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRecordSearchSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtInventorySearchBoxProductType = new System.Windows.Forms.TextBox();
            this.txtInventorySearchBoxManufacturer = new System.Windows.Forms.TextBox();
            this.txtInventorySearchBoxProductName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxInventorySearchSelect = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpRecord = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.grpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.btnDeleteEntry);
            this.groupBox1.Controls.Add(this.lblRecordNotice);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnAddRecord);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Controls.Add(this.cbxManufacturer);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 252);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCT";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Manufacturer,
            this.Type,
            this.Status,
            this.Date,
            this.Stck,
            this.rAmount,
            this.TPrice,
            this.Prce});
            this.dataGridView2.Location = new System.Drawing.Point(-336, -16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1007, 206);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Stck
            // 
            this.Stck.HeaderText = "Stock";
            this.Stck.Name = "Stck";
            this.Stck.ReadOnly = true;
            // 
            // rAmount
            // 
            this.rAmount.HeaderText = "Amount";
            this.rAmount.Name = "rAmount";
            // 
            // TPrice
            // 
            this.TPrice.HeaderText = "Total Price";
            this.TPrice.Name = "TPrice";
            this.TPrice.ReadOnly = true;
            // 
            // Prce
            // 
            this.Prce.HeaderText = "Price";
            this.Prce.Name = "Prce";
            this.Prce.ReadOnly = true;
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Enabled = false;
            this.btnDeleteEntry.Location = new System.Drawing.Point(777, 153);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(236, 76);
            this.btnDeleteEntry.TabIndex = 32;
            this.btnDeleteEntry.Text = "DELETE ENTRY";
            this.btnDeleteEntry.UseVisualStyleBackColor = true;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // lblRecordNotice
            // 
            this.lblRecordNotice.AutoSize = true;
            this.lblRecordNotice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordNotice.Location = new System.Drawing.Point(1068, 35);
            this.lblRecordNotice.Name = "lblRecordNotice";
            this.lblRecordNotice.Size = new System.Drawing.Size(244, 17);
            this.lblRecordNotice.TabIndex = 31;
            this.lblRecordNotice.Text = "RECORD(s) IS NOT SUBMITTED!";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(615, 24);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(156, 29);
            this.txtStatus.TabIndex = 29;
            this.txtStatus.Text = "OUT";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(615, 202);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(156, 29);
            this.txtTotalAmount.TabIndex = 28;
            this.txtTotalAmount.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(1076, 66);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(236, 76);
            this.btnSubmit.TabIndex = 27;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(508, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 22);
            this.label13.TabIndex = 26;
            this.label13.Text = "PRICE:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 22);
            this.label12.TabIndex = 25;
            this.label12.Text = "PRODUCT ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(206, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(284, 29);
            this.txtID.TabIndex = 24;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(615, 155);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(156, 29);
            this.txtPrice.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(615, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 29);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(508, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 22);
            this.label11.TabIndex = 21;
            this.label11.Text = "DATE:";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(777, 48);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(236, 76);
            this.btnAddRecord.TabIndex = 20;
            this.btnAddRecord.Text = "ADD RECORD";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(615, 73);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(156, 29);
            this.txtAmount.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "AMOUNT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(508, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "STATUS:";
            // 
            // cbxType
            // 
            this.cbxType.Enabled = false;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "TINS",
            "GALS",
            "LITERS",
            "1/2 LITERS",
            "1/4 LITERS",
            "60ML",
            ""});
            this.cbxType.Location = new System.Drawing.Point(206, 119);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(284, 30);
            this.cbxType.TabIndex = 15;
            // 
            // cbxManufacturer
            // 
            this.cbxManufacturer.Enabled = false;
            this.cbxManufacturer.FormattingEnabled = true;
            this.cbxManufacturer.Items.AddRange(new object[] {
            "BOYSEN HOUSE PAINTS",
            "NATION HOUSE PAINTS",
            "DAVIES HOUSE PAINTS",
            "WELCOAT HOUSE PAINTS",
            "RAIN OR SHINE"});
            this.cbxManufacturer.Location = new System.Drawing.Point(206, 160);
            this.cbxManufacturer.Name = "cbxManufacturer";
            this.cbxManufacturer.Size = new System.Drawing.Size(284, 30);
            this.cbxManufacturer.TabIndex = 14;
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(206, 202);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(284, 29);
            this.txtStock.TabIndex = 13;
            this.txtStock.Text = "0";
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(206, 73);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(284, 29);
            this.txtProductName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "STOCK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "TYPE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "MANUFACTURER:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "PRODUCT NAME:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtRecordSearchBoxProductType);
            this.groupBox4.Controls.Add(this.txtRecordSearchBoxProductName);
            this.groupBox4.Controls.Add(this.txtRecordSearchBoxManufacturer);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cbxRecordSearchSelect);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.groupBox4.Location = new System.Drawing.Point(12, 504);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(301, 267);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RECORD SEARCH BOX";
            // 
            // txtRecordSearchBoxProductType
            // 
            this.txtRecordSearchBoxProductType.Location = new System.Drawing.Point(16, 154);
            this.txtRecordSearchBoxProductType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRecordSearchBoxProductType.Name = "txtRecordSearchBoxProductType";
            this.txtRecordSearchBoxProductType.Size = new System.Drawing.Size(244, 35);
            this.txtRecordSearchBoxProductType.TabIndex = 24;
            this.txtRecordSearchBoxProductType.TextChanged += new System.EventHandler(this.txtRecordSearchBoxProductType_TextChanged);
            // 
            // txtRecordSearchBoxProductName
            // 
            this.txtRecordSearchBoxProductName.Location = new System.Drawing.Point(16, 154);
            this.txtRecordSearchBoxProductName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRecordSearchBoxProductName.Name = "txtRecordSearchBoxProductName";
            this.txtRecordSearchBoxProductName.Size = new System.Drawing.Size(243, 35);
            this.txtRecordSearchBoxProductName.TabIndex = 23;
            this.txtRecordSearchBoxProductName.TextChanged += new System.EventHandler(this.txtRecordSearchBoxProductName_TextChanged);
            // 
            // txtRecordSearchBoxManufacturer
            // 
            this.txtRecordSearchBoxManufacturer.Location = new System.Drawing.Point(16, 154);
            this.txtRecordSearchBoxManufacturer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRecordSearchBoxManufacturer.Name = "txtRecordSearchBoxManufacturer";
            this.txtRecordSearchBoxManufacturer.Size = new System.Drawing.Size(243, 35);
            this.txtRecordSearchBoxManufacturer.TabIndex = 22;
            this.txtRecordSearchBoxManufacturer.TextChanged += new System.EventHandler(this.txtRecordSearchBoxManufacturer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search Name:";
            // 
            // cbxRecordSearchSelect
            // 
            this.cbxRecordSearchSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRecordSearchSelect.FormattingEnabled = true;
            this.cbxRecordSearchSelect.Items.AddRange(new object[] {
            "Manufacturer",
            "Product Type",
            "Product ID"});
            this.cbxRecordSearchSelect.Location = new System.Drawing.Point(15, 77);
            this.cbxRecordSearchSelect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbxRecordSearchSelect.Name = "cbxRecordSearchSelect";
            this.cbxRecordSearchSelect.Size = new System.Drawing.Size(246, 36);
            this.cbxRecordSearchSelect.TabIndex = 20;
            this.cbxRecordSearchSelect.SelectedIndexChanged += new System.EventHandler(this.cbxRecordSearchSelect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search Type:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtInventorySearchBoxProductType);
            this.groupBox3.Controls.Add(this.txtInventorySearchBoxManufacturer);
            this.groupBox3.Controls.Add(this.txtInventorySearchBoxProductName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbxInventorySearchSelect);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 190);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INVENTORY SEARCH BOX";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtInventorySearchBoxProductType
            // 
            this.txtInventorySearchBoxProductType.Location = new System.Drawing.Point(17, 143);
            this.txtInventorySearchBoxProductType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtInventorySearchBoxProductType.Name = "txtInventorySearchBoxProductType";
            this.txtInventorySearchBoxProductType.Size = new System.Drawing.Size(243, 35);
            this.txtInventorySearchBoxProductType.TabIndex = 24;
            this.txtInventorySearchBoxProductType.TextChanged += new System.EventHandler(this.txtInventorySearchBoxProductType_TextChanged);
            // 
            // txtInventorySearchBoxManufacturer
            // 
            this.txtInventorySearchBoxManufacturer.Location = new System.Drawing.Point(17, 143);
            this.txtInventorySearchBoxManufacturer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtInventorySearchBoxManufacturer.Name = "txtInventorySearchBoxManufacturer";
            this.txtInventorySearchBoxManufacturer.Size = new System.Drawing.Size(243, 35);
            this.txtInventorySearchBoxManufacturer.TabIndex = 23;
            this.txtInventorySearchBoxManufacturer.TextChanged += new System.EventHandler(this.txtInventorySearchBoxManufacturer_TextChanged);
            // 
            // txtInventorySearchBoxProductName
            // 
            this.txtInventorySearchBoxProductName.Location = new System.Drawing.Point(17, 143);
            this.txtInventorySearchBoxProductName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtInventorySearchBoxProductName.Name = "txtInventorySearchBoxProductName";
            this.txtInventorySearchBoxProductName.Size = new System.Drawing.Size(243, 35);
            this.txtInventorySearchBoxProductName.TabIndex = 22;
            this.txtInventorySearchBoxProductName.TextChanged += new System.EventHandler(this.txtInventorySearchBoxProductName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Search Name:";
            // 
            // cbxInventorySearchSelect
            // 
            this.cbxInventorySearchSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInventorySearchSelect.FormattingEnabled = true;
            this.cbxInventorySearchSelect.Items.AddRange(new object[] {
            "Manufacturer",
            "Product Type",
            "Product ID"});
            this.cbxInventorySearchSelect.Location = new System.Drawing.Point(16, 66);
            this.cbxInventorySearchSelect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbxInventorySearchSelect.Name = "cbxInventorySearchSelect";
            this.cbxInventorySearchSelect.Size = new System.Drawing.Size(246, 36);
            this.cbxInventorySearchSelect.TabIndex = 20;
            this.cbxInventorySearchSelect.SelectedIndexChanged += new System.EventHandler(this.cbxInventorySearchSelect_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Search Type:";
            // 
            // grpRecord
            // 
            this.grpRecord.Controls.Add(this.dataGridView3);
            this.grpRecord.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecord.Location = new System.Drawing.Point(319, 488);
            this.grpRecord.Name = "grpRecord";
            this.grpRecord.Size = new System.Drawing.Size(1019, 241);
            this.grpRecord.TabIndex = 27;
            this.grpRecord.TabStop = false;
            this.grpRecord.Text = "RECORD";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(16, 46);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(959, 150);
            this.dataGridView3.TabIndex = 14;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellClick);
            // 
            // grpInventory
            // 
            this.grpInventory.Controls.Add(this.dataGridView1);
            this.grpInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInventory.Location = new System.Drawing.Point(373, 12);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(1137, 190);
            this.grpInventory.TabIndex = 26;
            this.grpInventory.TabStop = false;
            this.grpInventory.Text = "INVENTORY";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(959, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // RecordOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpRecord);
            this.Controls.Add(this.grpInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RecordOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecordOut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecordOut_FormClosing);
            this.Load += new System.EventHandler(this.RecordOut_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.grpInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxManufacturer;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtRecordSearchBoxProductType;
        private System.Windows.Forms.TextBox txtRecordSearchBoxProductName;
        private System.Windows.Forms.TextBox txtRecordSearchBoxManufacturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxRecordSearchSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtInventorySearchBoxProductType;
        private System.Windows.Forms.TextBox txtInventorySearchBoxManufacturer;
        private System.Windows.Forms.TextBox txtInventorySearchBoxProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxInventorySearchSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpRecord;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stck;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prce;
        private System.Windows.Forms.Label lblRecordNotice;
        private System.Windows.Forms.Button btnDeleteEntry;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}