using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Configuration;
using System.IO;
using System.Security.Cryptography;


namespace Paint_Products_Database
{
    public partial class Inventory : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files (x86)\PRODUCTS INVENTORY AND RECORDS\Paint Products Database\Product Database.accdb");
        OleDbCommand cmd;
        string fnction = "";
        
        double totalprice;
        public void refreshInventory()
        {
            try
            {
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT ProductID, ProductName, Manufacturer, Type, Stock ,Price, TotalPrice, AlertQuantity FROM Inventory";
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
            }
            finally
            {
                con.Close();
            }

        }
        
        public Inventory()
        {
            InitializeComponent();
            refreshInventory();
            refreshType();
            refreshManufacturer();
        }
        public void refreshType()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT Type FROM Type", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();

            dt.Rows.InsertAt(dr, 0);
            cbxType.DisplayMember = "Type";
            cbxType.ValueMember = "Type";
            cbxType.DataSource = dt;
            con.Close();
        }
        public void refreshManufacturer()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT BusinessName FROM Manufacturer", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();

            dt.Rows.InsertAt(dr, 0);
            cbxManufacturer.DisplayMember = "BusinessName";
            cbxManufacturer.ValueMember = "BusinessName";
            cbxManufacturer.DataSource = dt;
            con.Close();
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            refreshManufacturer();
            refreshType();
            refreshInventory();
        }

        private void cbxSearchSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearchSelect.Text == "Manufacturer")
            {
                txtSearchBoxManufacturer.Show();
                txtSearchBoxProductName.Hide();
                txtSearchBoxProductType.Hide();

                txtSearchBoxManufacturer.Text = "";
                txtSearchBoxProductName.Text = "";
                txtSearchBoxProductType.Text = "";

            }
            else if (cbxSearchSelect.Text == "Product ID")
            {
                txtSearchBoxManufacturer.Hide();
                txtSearchBoxProductName.Show();
                txtSearchBoxProductType.Hide();

                txtSearchBoxManufacturer.Text = "";
                txtSearchBoxProductName.Text = "";
                txtSearchBoxProductType.Text = "";
            }
            else if (cbxSearchSelect.Text == "Product Type")
            {
                txtSearchBoxManufacturer.Hide();
                txtSearchBoxProductName.Hide();
                txtSearchBoxProductType.Show();

                txtSearchBoxManufacturer.Text = "";
                txtSearchBoxProductName.Text = "";
                txtSearchBoxProductType.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            refreshType();
            refreshManufacturer();

            txtID.Enabled = true;
            txtProductName.Enabled = true;
            cbxManufacturer.Enabled = true;
            cbxType.Enabled = true;
            txtStock.Enabled = true;
            txtProductPrice.Enabled = true;
            txtAlertQuantity.Enabled = true;

            cbxManufacturer.Text = "";
            cbxType.Text = "";


            fnction = "Add";
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

            dataGridView1.Enabled = false;
            lblNote.Text = "Note: You are about to Add a new Product";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtProductName.Enabled = true;
            cbxManufacturer.Enabled = true;
            cbxType.Enabled = true;
            txtStock.Enabled = true;
            txtProductPrice.Enabled = true;
            txtAlertQuantity.Enabled = true;

            fnction = "Edit";
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

            dataGridView1.Enabled = false;
            lblNote.Text = "Note: You are about to Edit a new Product";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells["ProductID"].Value.ToString();
            txtProductName.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            cbxManufacturer.Text = dataGridView1.CurrentRow.Cells["Manufacturer"].Value.ToString();
            cbxType.Text = dataGridView1.CurrentRow.Cells["Type"].Value.ToString();
            txtProductPrice.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
            txtAlertQuantity.Text = dataGridView1.CurrentRow.Cells["AlertQuantity"].Value.ToString();

            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;

            if (txtStock.Text == "")
            {
                txtStock.Text = "0";
            }
            if (txtAlertQuantity.Text == "")
            {
                txtAlertQuantity.Text = "0";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you really want to delete?", "Close Confirmation", MessageBoxButtons.YesNo/*Cancel*/, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                cmd = new OleDbCommand("DELETE FROM Inventory WHERE ProductID = '" + dataGridView1.SelectedCells[0].Value.ToString() + "'", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                refreshInventory();
                txtID.Clear();
                txtProductName.Clear();
                txtStock.Clear();
                txtProductPrice.Clear();
                txtAlertQuantity.Clear();
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnClear.Enabled = false;

            }

            else
            {
                
            }
            

            
        }

        private void txtSearchBoxProductType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("Type like '%{0}%'", txtSearchBoxProductType.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void txtSearchBoxManufacturer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("Manufacturer like '%{0}%'", txtSearchBoxManufacturer.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void txtSearchBoxProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("ProductID like '%{0}%'", txtSearchBoxProductName.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            

        }

        private void btnAddType_Click(object sender, EventArgs e)
        { 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //con.Open();

            //OleDbCommand cmd = new OleDbCommand("UPDATE Inventory SET ProductName=@ProductName WHERE ProductID=@ProductID", con);
            //cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
            //cmd.Parameters.AddWithValue("@ProductID", txtID.Text);


            //cmd.ExecuteNonQuery();

            //MessageBox.Show("Product Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //con.Close();

            //refreshInventory();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnToExcel_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files (2010) | *.xlsx";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 15;
                
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
            MessageBox.Show("Exported to Excel!","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void manufacturerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManufacturerList mList = new ManufacturerList();

            mList.Show();
        }

        private void typeListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            txtID.Enabled = false;
            txtProductName.Enabled = false;
            cbxManufacturer.Enabled = false;
            cbxType.Enabled = false;
            txtStock.Enabled = false;
            txtProductPrice.Enabled = false;
            txtAlertQuantity.Enabled = false;

            txtID.Clear();
            txtProductName.Clear();
            txtStock.Clear();
            txtProductPrice.Clear();
            txtAlertQuantity.Clear();


            fnction = "";
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            dataGridView1.Enabled = true;
            lblNote.Text = "Note: ";

            TypeList tList = new TypeList();

            tList.Show();
        }

        private void Inventory_Enter(object sender, EventArgs e)
        {
            
        }

        private void Inventory_MouseClick(object sender, MouseEventArgs e)
        {
            refreshInventory();
            refreshManufacturer();
            refreshType();
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxSearchSelect_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void quantityAlertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuantityAlert qAlert = new QuantityAlert();

            qAlert.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtProductName.Clear();
            txtStock.Clear();
            txtProductPrice.Clear();
            txtAlertQuantity.Clear();
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((btnAdd.Enabled == false) && (fnction == "Add"))
            {
                if ((txtID.Text == "") && (txtProductName.Text == "") && (cbxManufacturer.Text == "") && (cbxType.Text == "") && (txtStock.Text == "") && (txtProductPrice.Text == "") && (txtTotalAmount.Text == "") && (txtAlertQuantity.Text == ""))
                {
                    MessageBox.Show("Fields must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {

                    double price = Convert.ToInt32(txtProductPrice.Text);
                    int stock = Convert.ToInt32(txtStock.Text);
                    totalprice = stock * price;
                    con.Open();

                    cmd = new OleDbCommand("INSERT INTO Inventory(ProductID, ProductName, Manufacturer, Type, Stock ,Price,TotalPrice, AlertQuantity) VALUES (@ProductID,@ProductName, @Manufacturer, @Type, @Stock,@Price,@TotalPrice, @AlertQuantity)", con);
                    cmd.Parameters.AddWithValue("@ProductID", txtID.Text);
                    cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@Manufacturer", cbxManufacturer.Text);
                    cmd.Parameters.AddWithValue("@Type", cbxType.Text);
                    cmd.Parameters.AddWithValue("@Stock", txtStock.Text);
                    cmd.Parameters.AddWithValue("@Price", txtProductPrice.Text);
                    cmd.Parameters.AddWithValue("@TotalPrice", totalprice);
                    cmd.Parameters.AddWithValue("@AlertQuantity", txtAlertQuantity.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();

                    refreshInventory();
                }
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnSave.Enabled = false;
                dataGridView1.Enabled = true;
                btnCancel.Enabled = false;
                txtID.Clear();
                txtProductName.Clear();
                txtStock.Clear();
                txtProductPrice.Clear();
                txtAlertQuantity.Clear();

            }
            else if ((btnEdit.Enabled == false) && (fnction == "Edit"))
            {
                if ((txtID.Text == "") && (txtProductName.Text == "") && (cbxManufacturer.Text == "") && (cbxType.Text == "") && (txtStock.Text == "") && (txtProductPrice.Text == "") && (txtTotalAmount.Text == "") && (txtAlertQuantity.Text == ""))
                {
                    MessageBox.Show("Fields must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int price = Convert.ToInt32(txtProductPrice.Text);
                    int stock = Convert.ToInt32(txtStock.Text);
                    totalprice = stock * price;
                    con.Open();

                    cmd = new OleDbCommand("UPDATE Inventory SET ProductName=@ProductName, Manufacturer=@Manufacturer, Type=@Type, Stock=@Stock, Price=@Price, TotalPrice=@TotalPrice, AlertQuantity=@AlertQuantity WHERE ProductID=@ProductID", con);
                    cmd.Parameters.AddWithValue("@Productname", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@Manufacturer", cbxManufacturer.Text);
                    cmd.Parameters.AddWithValue("@Type", cbxType.Text);
                    cmd.Parameters.AddWithValue("@Stock", txtStock.Text);
                    cmd.Parameters.AddWithValue("@Price", txtProductPrice.Text);
                    cmd.Parameters.AddWithValue("@TotalPrice", totalprice);
                    cmd.Parameters.AddWithValue("@AlertQuantity", txtAlertQuantity.Text);
                    cmd.Parameters.AddWithValue("@ProductID", txtID.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();

                    refreshInventory();
                }
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnSave.Enabled = false;
                dataGridView1.Enabled = true;
                btnCancel.Enabled = false;
                txtID.Clear();
                txtProductName.Clear();
                txtStock.Clear();
                txtProductPrice.Clear();
                txtAlertQuantity.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtProductName.Enabled = false;
            cbxManufacturer.Enabled = false;
            cbxType.Enabled = false;
            txtStock.Enabled = false;
            txtProductPrice.Enabled = false;
            txtAlertQuantity.Enabled = false;

            txtID.Clear();
            txtProductName.Clear();
            txtStock.Clear();
            txtProductPrice.Clear();
            txtAlertQuantity.Clear();
            

            fnction = "";
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            dataGridView1.Enabled = true;
            lblNote.Text = "Note: ";
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Inventory_MouseEnter(object sender, EventArgs e)
        {
           
        }
    }
}
