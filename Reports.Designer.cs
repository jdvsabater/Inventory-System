﻿namespace Paint_Products_Database
{
    partial class Reports
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lbldateTo = new System.Windows.Forms.Label();
            this.lbldateFrom = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.txtInventorySearchBoxProductType = new System.Windows.Forms.TextBox();
            this.txtInventorySearchBoxManufacturer = new System.Windows.Forms.TextBox();
            this.txtInventorySearchBoxProductName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxInventorySearchSelect = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReportIN = new System.Windows.Forms.Button();
            this.btnReportOut = new System.Windows.Forms.Button();
            this.btnReportReturn = new System.Windows.Forms.Button();
            this.btnToExcel1 = new System.Windows.Forms.Button();
            this.btnAlertQuantity = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btnToExcel2 = new System.Windows.Forms.Button();
            this.btnToExcel3 = new System.Windows.Forms.Button();
            this.btnToExcel4 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.btnClearData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1317, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExecute);
            this.groupBox3.Controls.Add(this.lbldateTo);
            this.groupBox3.Controls.Add(this.lbldateFrom);
            this.groupBox3.Controls.Add(this.dtpTo);
            this.groupBox3.Controls.Add(this.dtpFrom);
            this.groupBox3.Controls.Add(this.txtInventorySearchBoxProductType);
            this.groupBox3.Controls.Add(this.txtInventorySearchBoxManufacturer);
            this.groupBox3.Controls.Add(this.txtInventorySearchBoxProductName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbxInventorySearchSelect);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.groupBox3.Location = new System.Drawing.Point(21, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 270);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SEARCH BOX";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(99, 228);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(134, 36);
            this.btnExecute.TabIndex = 28;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Visible = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lbldateTo
            // 
            this.lbldateTo.AutoSize = true;
            this.lbldateTo.Location = new System.Drawing.Point(12, 192);
            this.lbldateTo.Name = "lbldateTo";
            this.lbldateTo.Size = new System.Drawing.Size(49, 28);
            this.lbldateTo.TabIndex = 27;
            this.lbldateTo.Text = "To:";
            this.lbldateTo.Visible = false;
            // 
            // lbldateFrom
            // 
            this.lbldateFrom.AutoSize = true;
            this.lbldateFrom.Location = new System.Drawing.Point(6, 151);
            this.lbldateFrom.Name = "lbldateFrom";
            this.lbldateFrom.Size = new System.Drawing.Size(80, 28);
            this.lbldateFrom.TabIndex = 26;
            this.lbldateFrom.Text = "From:";
            this.lbldateFrom.Visible = false;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(109, 187);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(243, 35);
            this.dtpTo.TabIndex = 25;
            this.dtpTo.Visible = false;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(109, 146);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(243, 35);
            this.dtpFrom.TabIndex = 17;
            this.dtpFrom.Visible = false;
            // 
            // txtInventorySearchBoxProductType
            // 
            this.txtInventorySearchBoxProductType.Location = new System.Drawing.Point(17, 143);
            this.txtInventorySearchBoxProductType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtInventorySearchBoxProductType.Name = "txtInventorySearchBoxProductType";
            this.txtInventorySearchBoxProductType.Size = new System.Drawing.Size(244, 35);
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
            "Product ID",
            "Date"});
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
            // btnReportIN
            // 
            this.btnReportIN.Location = new System.Drawing.Point(419, 32);
            this.btnReportIN.Name = "btnReportIN";
            this.btnReportIN.Size = new System.Drawing.Size(205, 101);
            this.btnReportIN.TabIndex = 14;
            this.btnReportIN.Text = "LOAD REPORT (IN)";
            this.btnReportIN.UseVisualStyleBackColor = true;
            this.btnReportIN.Click += new System.EventHandler(this.btnReportIN_Click);
            // 
            // btnReportOut
            // 
            this.btnReportOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportOut.Location = new System.Drawing.Point(419, 155);
            this.btnReportOut.Name = "btnReportOut";
            this.btnReportOut.Size = new System.Drawing.Size(205, 101);
            this.btnReportOut.TabIndex = 15;
            this.btnReportOut.Text = "LOAD REPORT (OUT)";
            this.btnReportOut.UseVisualStyleBackColor = true;
            this.btnReportOut.Click += new System.EventHandler(this.btnReportOut_Click);
            // 
            // btnReportReturn
            // 
            this.btnReportReturn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportReturn.Location = new System.Drawing.Point(721, 33);
            this.btnReportReturn.Name = "btnReportReturn";
            this.btnReportReturn.Size = new System.Drawing.Size(205, 101);
            this.btnReportReturn.TabIndex = 16;
            this.btnReportReturn.Text = "LOAD REPORT (RETURN)";
            this.btnReportReturn.UseVisualStyleBackColor = true;
            this.btnReportReturn.Click += new System.EventHandler(this.btnReportReturn_Click);
            // 
            // btnToExcel1
            // 
            this.btnToExcel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToExcel1.Location = new System.Drawing.Point(1148, 228);
            this.btnToExcel1.Name = "btnToExcel1";
            this.btnToExcel1.Size = new System.Drawing.Size(190, 48);
            this.btnToExcel1.TabIndex = 17;
            this.btnToExcel1.Text = "Save To Excel";
            this.btnToExcel1.UseVisualStyleBackColor = true;
            this.btnToExcel1.Visible = false;
            this.btnToExcel1.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // btnAlertQuantity
            // 
            this.btnAlertQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertQuantity.Location = new System.Drawing.Point(721, 155);
            this.btnAlertQuantity.Name = "btnAlertQuantity";
            this.btnAlertQuantity.Size = new System.Drawing.Size(205, 101);
            this.btnAlertQuantity.TabIndex = 18;
            this.btnAlertQuantity.Text = "LOAD QUANTITY ALERT";
            this.btnAlertQuantity.UseVisualStyleBackColor = true;
            this.btnAlertQuantity.Click += new System.EventHandler(this.btnAlertQuantity_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 288);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1317, 429);
            this.dataGridView2.TabIndex = 19;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(21, 288);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1317, 429);
            this.dataGridView3.TabIndex = 20;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(21, 288);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1317, 429);
            this.dataGridView4.TabIndex = 21;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView4_CellContentClick);
            // 
            // btnToExcel2
            // 
            this.btnToExcel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToExcel2.Location = new System.Drawing.Point(1148, 228);
            this.btnToExcel2.Name = "btnToExcel2";
            this.btnToExcel2.Size = new System.Drawing.Size(190, 48);
            this.btnToExcel2.TabIndex = 22;
            this.btnToExcel2.Text = "Save To Excel";
            this.btnToExcel2.UseVisualStyleBackColor = true;
            this.btnToExcel2.Visible = false;
            this.btnToExcel2.Click += new System.EventHandler(this.btnToExcel2_Click);
            // 
            // btnToExcel3
            // 
            this.btnToExcel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToExcel3.Location = new System.Drawing.Point(1148, 228);
            this.btnToExcel3.Name = "btnToExcel3";
            this.btnToExcel3.Size = new System.Drawing.Size(190, 48);
            this.btnToExcel3.TabIndex = 23;
            this.btnToExcel3.Text = "Save To Excel";
            this.btnToExcel3.UseVisualStyleBackColor = true;
            this.btnToExcel3.Visible = false;
            this.btnToExcel3.Click += new System.EventHandler(this.btnToExcel3_Click);
            // 
            // btnToExcel4
            // 
            this.btnToExcel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToExcel4.Location = new System.Drawing.Point(1148, 228);
            this.btnToExcel4.Name = "btnToExcel4";
            this.btnToExcel4.Size = new System.Drawing.Size(190, 48);
            this.btnToExcel4.TabIndex = 24;
            this.btnToExcel4.Text = "Save To Excel";
            this.btnToExcel4.UseVisualStyleBackColor = true;
            this.btnToExcel4.Visible = false;
            this.btnToExcel4.Click += new System.EventHandler(this.btnToExcel4_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(512, 199);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(574, 313);
            this.dataGridView5.TabIndex = 25;
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(952, 113);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(134, 36);
            this.btnClearData.TabIndex = 29;
            this.btnClearData.Text = "Execute";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.BtnClearData_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(974, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 39);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.btnToExcel4);
            this.Controls.Add(this.btnToExcel3);
            this.Controls.Add(this.btnToExcel2);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAlertQuantity);
            this.Controls.Add(this.btnToExcel1);
            this.Controls.Add(this.btnReportReturn);
            this.Controls.Add(this.btnReportOut);
            this.Controls.Add(this.btnReportIN);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reports_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtInventorySearchBoxProductType;
        private System.Windows.Forms.TextBox txtInventorySearchBoxManufacturer;
        private System.Windows.Forms.TextBox txtInventorySearchBoxProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxInventorySearchSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReportIN;
        private System.Windows.Forms.Button btnReportOut;
        private System.Windows.Forms.Button btnReportReturn;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lbldateTo;
        private System.Windows.Forms.Label lbldateFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnToExcel1;
        private System.Windows.Forms.Button btnAlertQuantity;
        private System.Windows.Forms.Button btnToExcel2;
        private System.Windows.Forms.Button btnToExcel3;
        private System.Windows.Forms.Button btnToExcel4;
        public System.Windows.Forms.DataGridView dataGridView4;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.TextBox textBox1;
    }
}