namespace Paint_Products_Database
{
    partial class BranchList
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearchBoxBranchName = new System.Windows.Forms.TextBox();
            this.txtSearchBoxBranchOwner = new System.Windows.Forms.TextBox();
            this.txtSearchBoxTinNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxSearchSelect = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTinNumber = new System.Windows.Forms.TextBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.txtBranchOwner = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpAddBranch = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpAddBranch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearchBoxBranchName);
            this.groupBox3.Controls.Add(this.txtSearchBoxBranchOwner);
            this.groupBox3.Controls.Add(this.txtSearchBoxTinNumber);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbxSearchSelect);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.groupBox3.Location = new System.Drawing.Point(1061, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 284);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SEARCH BOX";
            // 
            // txtSearchBoxBranchName
            // 
            this.txtSearchBoxBranchName.Location = new System.Drawing.Point(16, 154);
            this.txtSearchBoxBranchName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSearchBoxBranchName.Name = "txtSearchBoxBranchName";
            this.txtSearchBoxBranchName.Size = new System.Drawing.Size(243, 35);
            this.txtSearchBoxBranchName.TabIndex = 24;
            this.txtSearchBoxBranchName.TextChanged += new System.EventHandler(this.txtSearchBoxBranchName_TextChanged);
            // 
            // txtSearchBoxBranchOwner
            // 
            this.txtSearchBoxBranchOwner.Location = new System.Drawing.Point(16, 154);
            this.txtSearchBoxBranchOwner.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSearchBoxBranchOwner.Name = "txtSearchBoxBranchOwner";
            this.txtSearchBoxBranchOwner.Size = new System.Drawing.Size(243, 35);
            this.txtSearchBoxBranchOwner.TabIndex = 23;
            this.txtSearchBoxBranchOwner.TextChanged += new System.EventHandler(this.txtSearchBoxBranchOwner_TextChanged);
            // 
            // txtSearchBoxTinNumber
            // 
            this.txtSearchBoxTinNumber.Location = new System.Drawing.Point(16, 154);
            this.txtSearchBoxTinNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSearchBoxTinNumber.Name = "txtSearchBoxTinNumber";
            this.txtSearchBoxTinNumber.Size = new System.Drawing.Size(243, 35);
            this.txtSearchBoxTinNumber.TabIndex = 22;
            this.txtSearchBoxTinNumber.TextChanged += new System.EventHandler(this.txtSearchBoxTinNumber_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Search Name:";
            // 
            // cbxSearchSelect
            // 
            this.cbxSearchSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchSelect.FormattingEnabled = true;
            this.cbxSearchSelect.Items.AddRange(new object[] {
            "Tin Number",
            "Branch Name",
            "Branch Owner"});
            this.cbxSearchSelect.Location = new System.Drawing.Point(15, 77);
            this.cbxSearchSelect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbxSearchSelect.Name = "cbxSearchSelect";
            this.cbxSearchSelect.Size = new System.Drawing.Size(244, 36);
            this.cbxSearchSelect.TabIndex = 20;
            this.cbxSearchSelect.SelectedIndexChanged += new System.EventHandler(this.cbxSearchSelect_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Search Type:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 445);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1296, 254);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIN NUMBER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "BRANCH NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "BRANCH OWNER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "ADDRESS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "CONTACT NUMBER:";
            // 
            // txtTinNumber
            // 
            this.txtTinNumber.Enabled = false;
            this.txtTinNumber.Location = new System.Drawing.Point(287, 32);
            this.txtTinNumber.MaxLength = 15;
            this.txtTinNumber.Name = "txtTinNumber";
            this.txtTinNumber.Size = new System.Drawing.Size(411, 39);
            this.txtTinNumber.TabIndex = 5;
            // 
            // txtBranchName
            // 
            this.txtBranchName.Enabled = false;
            this.txtBranchName.Location = new System.Drawing.Point(287, 80);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(411, 39);
            this.txtBranchName.TabIndex = 6;
            // 
            // txtBranchOwner
            // 
            this.txtBranchOwner.Enabled = false;
            this.txtBranchOwner.Location = new System.Drawing.Point(287, 127);
            this.txtBranchOwner.Name = "txtBranchOwner";
            this.txtBranchOwner.Size = new System.Drawing.Size(411, 39);
            this.txtBranchOwner.TabIndex = 7;
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(287, 285);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(411, 39);
            this.txtTel.TabIndex = 8;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Enabled = false;
            this.rtbAddress.Location = new System.Drawing.Point(287, 180);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(411, 96);
            this.rtbAddress.TabIndex = 9;
            this.rtbAddress.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(724, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 53);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(883, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 53);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(883, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 53);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(724, 95);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 53);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(883, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 53);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(721, 229);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(51, 17);
            this.lblNote.TabIndex = 25;
            this.lblNote.Text = "Note: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(724, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 53);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpAddBranch
            // 
            this.grpAddBranch.Controls.Add(this.btnCancel);
            this.grpAddBranch.Controls.Add(this.lblNote);
            this.grpAddBranch.Controls.Add(this.btnSave);
            this.grpAddBranch.Controls.Add(this.btnClear);
            this.grpAddBranch.Controls.Add(this.btnDelete);
            this.grpAddBranch.Controls.Add(this.btnEdit);
            this.grpAddBranch.Controls.Add(this.btnAdd);
            this.grpAddBranch.Controls.Add(this.rtbAddress);
            this.grpAddBranch.Controls.Add(this.txtTel);
            this.grpAddBranch.Controls.Add(this.txtBranchOwner);
            this.grpAddBranch.Controls.Add(this.txtBranchName);
            this.grpAddBranch.Controls.Add(this.txtTinNumber);
            this.grpAddBranch.Controls.Add(this.label5);
            this.grpAddBranch.Controls.Add(this.label4);
            this.grpAddBranch.Controls.Add(this.label3);
            this.grpAddBranch.Controls.Add(this.label2);
            this.grpAddBranch.Controls.Add(this.label1);
            this.grpAddBranch.Location = new System.Drawing.Point(6, 16);
            this.grpAddBranch.Name = "grpAddBranch";
            this.grpAddBranch.Size = new System.Drawing.Size(1044, 409);
            this.grpAddBranch.TabIndex = 13;
            this.grpAddBranch.TabStop = false;
            this.grpAddBranch.Text = "Branch Details";
            // 
            // BranchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpAddBranch);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "BranchList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branch List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BranchList_FormClosing);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpAddBranch.ResumeLayout(false);
            this.grpAddBranch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearchBoxBranchName;
        private System.Windows.Forms.TextBox txtSearchBoxBranchOwner;
        private System.Windows.Forms.TextBox txtSearchBoxTinNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxSearchSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTinNumber;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.TextBox txtBranchOwner;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpAddBranch;
    }
}