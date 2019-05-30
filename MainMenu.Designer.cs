namespace Paint_Products_Database
{
    partial class Form1
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
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRecordReturn = new System.Windows.Forms.Button();
            this.btnRecordOut = new System.Windows.Forms.Button();
            this.btnUserList = new System.Windows.Forms.Button();
            this.btnStoreList = new System.Windows.Forms.Button();
            this.btnManufacturerList = new System.Windows.Forms.Button();
            this.btnRecordIN = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.lblUsername);
            this.grpMenu.Controls.Add(this.btnLogOut);
            this.grpMenu.Controls.Add(this.btnReport);
            this.grpMenu.Controls.Add(this.btnRecordReturn);
            this.grpMenu.Controls.Add(this.btnRecordOut);
            this.grpMenu.Controls.Add(this.btnUserList);
            this.grpMenu.Controls.Add(this.btnStoreList);
            this.grpMenu.Controls.Add(this.btnManufacturerList);
            this.grpMenu.Controls.Add(this.btnRecordIN);
            this.grpMenu.Controls.Add(this.btnInventory);
            this.grpMenu.Location = new System.Drawing.Point(2, 0);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1336, 698);
            this.grpMenu.TabIndex = 0;
            this.grpMenu.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(1103, 634);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(217, 55);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(723, 320);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(277, 200);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "REPORTS";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnRecordReturn
            // 
            this.btnRecordReturn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordReturn.Location = new System.Drawing.Point(1043, 42);
            this.btnRecordReturn.Name = "btnRecordReturn";
            this.btnRecordReturn.Size = new System.Drawing.Size(277, 200);
            this.btnRecordReturn.TabIndex = 13;
            this.btnRecordReturn.Text = "RECORD RETURN";
            this.btnRecordReturn.UseVisualStyleBackColor = true;
            this.btnRecordReturn.Click += new System.EventHandler(this.btnRecordReturn_Click);
            // 
            // btnRecordOut
            // 
            this.btnRecordOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordOut.Location = new System.Drawing.Point(723, 42);
            this.btnRecordOut.Name = "btnRecordOut";
            this.btnRecordOut.Size = new System.Drawing.Size(277, 200);
            this.btnRecordOut.TabIndex = 12;
            this.btnRecordOut.Text = "RECORD OUT";
            this.btnRecordOut.UseVisualStyleBackColor = true;
            this.btnRecordOut.Click += new System.EventHandler(this.btnRecordOut_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserList.Location = new System.Drawing.Point(1043, 320);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(277, 200);
            this.btnUserList.TabIndex = 11;
            this.btnUserList.Text = "USER\'S LIST";
            this.btnUserList.UseVisualStyleBackColor = true;
            this.btnUserList.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnStoreList
            // 
            this.btnStoreList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreList.Location = new System.Drawing.Point(363, 320);
            this.btnStoreList.Name = "btnStoreList";
            this.btnStoreList.Size = new System.Drawing.Size(277, 200);
            this.btnStoreList.TabIndex = 10;
            this.btnStoreList.Text = "STORE LIST";
            this.btnStoreList.UseVisualStyleBackColor = true;
            this.btnStoreList.Click += new System.EventHandler(this.btnStoreList_Click);
            // 
            // btnManufacturerList
            // 
            this.btnManufacturerList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManufacturerList.Location = new System.Drawing.Point(42, 320);
            this.btnManufacturerList.Name = "btnManufacturerList";
            this.btnManufacturerList.Size = new System.Drawing.Size(277, 200);
            this.btnManufacturerList.TabIndex = 9;
            this.btnManufacturerList.Text = "MANUFACTURER LIST";
            this.btnManufacturerList.UseVisualStyleBackColor = true;
            this.btnManufacturerList.Click += new System.EventHandler(this.btnManufacturerList_Click);
            // 
            // btnRecordIN
            // 
            this.btnRecordIN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordIN.Location = new System.Drawing.Point(363, 42);
            this.btnRecordIN.Name = "btnRecordIN";
            this.btnRecordIN.Size = new System.Drawing.Size(277, 200);
            this.btnRecordIN.TabIndex = 6;
            this.btnRecordIN.Text = "RECORD IN";
            this.btnRecordIN.UseVisualStyleBackColor = true;
            this.btnRecordIN.Click += new System.EventHandler(this.btnRecords_Click_1);
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(42, 42);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(277, 200);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(10, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(51, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.grpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenu;
        public System.Windows.Forms.Button btnInventory;
        public System.Windows.Forms.Button btnRecordIN;
        public System.Windows.Forms.Button btnStoreList;
        public System.Windows.Forms.Button btnManufacturerList;
        public System.Windows.Forms.Button btnUserList;
        public System.Windows.Forms.Button btnRecordReturn;
        public System.Windows.Forms.Button btnRecordOut;
        public System.Windows.Forms.Button btnReport;
        public System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblUsername;
    }
}

