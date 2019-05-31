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

namespace Paint_Products_Database
{
    public partial class RecordIN : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files (x86)\PRODUCTS INVENTORY AND RECORDS\Paint Products Database\Product Database.accdb");
        OleDbCommand cmd;
        
        Inventory invent = new Inventory();
        int id;
        int stock;//
        double price;
        int amount;
        double totalprice;
        int originalStock;
        int stocksubmit;
        int tempamount;//
        int row;
        double tempprice;//
        string strQuery;
        int submmited = 0;


        public void refreshInventory()
        {
            try
            {
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT ProductID, Stock, Type, Manufacturer, ProductName, Price FROM Inventory";
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
        public void updateInventorymethod()
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Fields must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                amount = Convert.ToInt32(txtAmount.Text);
                int tempstock = Convert.ToInt32(txtStock.Text);
                price = double.Parse(txtPrice.Text);
                stock = Convert.ToInt32(txtStock.Text);

                stock = tempstock + amount;

                totalprice = stock * price;
                con.Open();

                cmd = new OleDbCommand("UPDATE Inventory SET Stock=@Stock, TotalPrice=@TotalPrice WHERE ProductID=@ProductID AND Type=@Type", con);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@TotalPrice", totalprice);
                cmd.Parameters.AddWithValue("@ProductID", txtID.Text);
                cmd.Parameters.AddWithValue("@Type", cbxType.Text);

                cmd.ExecuteNonQuery();

                con.Close();
                stocksubmit = stock;
                txtStock.Text = Convert.ToString(stock);
            }
        }

       

        public RecordIN()
        {
            InitializeComponent();          
            refreshInventory();
            refreshRecordsIn();
        }

        private void txtSearchBoxProductType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("Type like '%{0}%'", txtInventorySearchBoxProductType.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }
      
        private void txtSearchBoxManufacturer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("Manufacturer like '%{0}%'", txtInventorySearchBoxManufacturer.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void txtInventorySearchBoxProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("ProductID like '%{0}%'", txtInventorySearchBoxProductName.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void cbxInventorySearchSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxInventorySearchSelect.Text == "Manufacturer")
            {
                txtInventorySearchBoxManufacturer.Show();
                txtInventorySearchBoxProductName.Hide();
                txtInventorySearchBoxProductType.Hide();

                txtInventorySearchBoxManufacturer.Text = "";
                txtInventorySearchBoxProductName.Text = "";
                txtInventorySearchBoxProductType.Text = "";
            }
            else if (cbxInventorySearchSelect.Text == "Product ID")
            {
                txtInventorySearchBoxManufacturer.Hide();
                txtInventorySearchBoxProductName.Show();
                txtInventorySearchBoxProductType.Hide();

                txtInventorySearchBoxManufacturer.Text = "";
                txtInventorySearchBoxProductName.Text = "";
                txtInventorySearchBoxProductType.Text = "";
            }
            else if (cbxInventorySearchSelect.Text == "Product Type")
            {
                txtInventorySearchBoxManufacturer.Hide();
                txtInventorySearchBoxProductName.Hide();
                txtInventorySearchBoxProductType.Show();

                txtInventorySearchBoxManufacturer.Text = "";
                txtInventorySearchBoxProductName.Text = "";
                txtInventorySearchBoxProductType.Text = "";
            }
        }

        private void cbxRecordSearchSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRecordSearchSelect.Text == "Manufacturer")
            {
                txtRecordSearchBoxManufacturer.Show();
                txtRecordSearchBoxProductName.Hide();
                txtRecordSearchBoxProductType.Hide();

                txtRecordSearchBoxManufacturer.Text = "";
                txtRecordSearchBoxProductName.Text = "";
                txtRecordSearchBoxProductType.Text = "";
            }
            else if (cbxRecordSearchSelect.Text == "Product ID")
            {
                txtRecordSearchBoxManufacturer.Hide();
                txtRecordSearchBoxProductName.Show();
                txtRecordSearchBoxProductType.Hide();

                txtRecordSearchBoxManufacturer.Text = "";
                txtRecordSearchBoxProductName.Text = "";
                txtRecordSearchBoxProductType.Text = "";
            }
            else if (cbxRecordSearchSelect.Text == "Product Type")
            {
                txtRecordSearchBoxManufacturer.Hide();
                txtRecordSearchBoxProductName.Hide();
                txtRecordSearchBoxProductType.Show();

                txtRecordSearchBoxManufacturer.Text = "";
                txtRecordSearchBoxProductName.Text = "";
                txtRecordSearchBoxProductType.Text = "";
            }
        }

        private void txtRecordSearchBoxProductType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView3.DataSource).DefaultView.RowFilter = string.Format("Type like '%{0}%'", txtRecordSearchBoxProductType.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void txtRecordSearchBoxProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView3.DataSource).DefaultView.RowFilter = string.Format("ProductID like '%{0}%'", txtRecordSearchBoxProductName.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void txtRecordSearchBoxManufacturer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView3.DataSource).DefaultView.RowFilter = string.Format("Manufacturer like '%{0}%'", txtRecordSearchBoxManufacturer.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddRecord.Enabled = true;
            btnSubmit.Enabled = true;
            btnDeleteEntry.Enabled = false;
            txtID.Text = dataGridView1.CurrentRow.Cells["ProductID"].Value.ToString();
            txtProductName.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            cbxManufacturer.Text = dataGridView1.CurrentRow.Cells["Manufacturer"].Value.ToString();
            cbxType.Text = dataGridView1.CurrentRow.Cells["Type"].Value.ToString();
            txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            btnDeleteEntry.Enabled = false;
            if (txtStock.Text == "")
            {
                txtStock.Text = "0";
            }

        }
        public void refreshRecordsIn()
        {
            try
            {
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT ProductID, ProductName, Manufacturer, Type, Status, DateTaken, Stock, Amount, TotalPrice, Price FROM tempRecordIn";
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView3.DataSource = dt;
                }
            }
            finally
            {
                con.Close();
            }

        }

        public void tempRecordIn()
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Fields must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                amount = Convert.ToInt32(txtAmount.Text);
                int tempstock = Convert.ToInt32(txtStock.Text);
                price = Convert.ToDouble(txtPrice.Text);
                stock = Convert.ToInt32(txtStock.Text);

                stock = tempstock + amount;

                totalprice = stock * price;
                con.Open();
                //string[] row = { txtID.Text, txtProductName.Text, cbxManufacturer.Text, cbxType.Text, txtStatus.Text, dateTimePicker1.Text, stocksubmit.ToString(), txtAmount.Text, (((Convert.ToInt32(txtStock.Text)) * (Convert.ToDouble(txtPrice.Text)))).ToString(), txtPrice.Text };
                cmd = new OleDbCommand("INSERT INTO tempRecordIn(ProductID, ProductName, Manufacturer, Type, Status, DateTaken, Stock, Amount , TotalPrice, Price) VALUES (@ProductID, @ProductName, @Manufacturer, @Type, @Status, @DateTaken, @Stock, @Amount , @TotalPrice, @Price)", con);
                cmd.Parameters.AddWithValue("@ProductID", txtID.Text);
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                cmd.Parameters.AddWithValue("@Manufacturer", cbxManufacturer.Text);
                cmd.Parameters.AddWithValue("@Type", cbxType.Text);
                cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                cmd.Parameters.AddWithValue("@DateTaken", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Stock", txtStock.Text);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@TotalPrice", totalprice);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.ExecuteNonQuery();

                con.Close();
                stocksubmit = stock;
                txtStock.Text = Convert.ToString(stock);
                RecordIN rin = new RecordIN();
                rin.Refresh();
            }
        }
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                lblRecordNotice.Text = "RECORD(s) IS NOT SUBMITTED!";
                if ((txtProductName.Text == " ") && (cbxManufacturer.Text == " ") && (cbxType.Text == " ") && (txtStock.Text == "") && (txtStatus.Text == "") && (txtAmount.Text == ""))
                {
                    MessageBox.Show("Fields must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    updateInventorymethod();
                    if (txtAmount.Text == "")
                    {

                    }
                    else
                    {


                        tempRecordIn();
                        //string[] row = { txtID.Text, txtProductName.Text, cbxManufacturer.Text, cbxType.Text, txtStatus.Text, dateTimePicker1.Text, stocksubmit.ToString(), txtAmount.Text, (((Convert.ToInt32(txtStock.Text)) * (Convert.ToDouble(txtPrice.Text)))).ToString(), txtPrice.Text };

                        //dataGridView2.Rows.Add(row);

                        refreshInventory();
                        refreshRecordsIn();
                        btnSubmit.Enabled = true;
                    }
                }
                dataGridView3.Visible = true;

                txtID.Text = "";
                txtProductName.Text = "";
                cbxManufacturer.Text = "";
                cbxType.Text = "";
                txtStock.Text = "";
                txtAmount.Text = "";
                txtTotalAmount.Text = "";
                txtPrice.Text = "";
                submmited = 0;
                
            }
            catch
            {
            }
            
        }

        private void Records_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you done Recording?", "Close Confirmation", MessageBoxButtons.YesNo/*Cancel*/, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                if (submmited == 0)
                {
                    resetStocks();

                    con.Open();
                    string comand = "DELETE FROM TempRecordIn";
                    cmd = new OleDbCommand(comand, con);
                    cmd.ExecuteNonQuery();

                    con.Close();



                    dataGridView3.Visible = false;
                    RecordIN rin = new RecordIN();
                    rin.Refresh();

                    this.Hide();
                    this.Parent = null;
                    e.Cancel = true;
                }

                else if (submmited == 1)
                {
                   
                    dataGridView3.Visible = false;
                    RecordIN rin = new RecordIN();
                    rin.Refresh();

                    this.Hide();
                    this.Parent = null;
                    e.Cancel = true;
                }


            }

            else 
            {
                e.Cancel = true;
            }
        }

        private void Records_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        public void resetStocks()
        {
            con.Open();

            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {

                tempamount = Convert.ToInt32(dataGridView3.Rows[i].Cells["Amount"].Value.ToString());
                stock = Convert.ToInt32(dataGridView3.Rows[i].Cells["Stock"].Value.ToString());
                tempprice = Convert.ToDouble(dataGridView3.Rows[i].Cells["Price"].Value.ToString());


                txtID.Text = dataGridView3.Rows[i].Cells["ProductID"].Value.ToString();
                txtProductName.Text = dataGridView3.Rows[i].Cells["ProductName"].Value.ToString();
                cbxManufacturer.Text = dataGridView3.Rows[i].Cells["Manufacturer"].Value.ToString();
                cbxType.Text = dataGridView3.Rows[i].Cells["Type"].Value.ToString();
                txtStock.Text = dataGridView3.Rows[i].Cells["Stock"].Value.ToString();
                txtPrice.Text = dataGridView3.Rows[i].Cells["Price"].Value.ToString();

                stock = stock - tempamount;
                totalprice = stock * tempprice;

                cmd = new OleDbCommand("UPDATE Inventory SET Stock=@Stock, TotalPrice=@TotalPrice WHERE ProductID=@ProductID AND Type=@Type", con);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@TotalPrice", totalprice);
                cmd.Parameters.AddWithValue("@ProductID", txtID.Text);
                cmd.Parameters.AddWithValue("@Type", cbxType.Text);



                cmd.ExecuteNonQuery();
            }


            con.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtRecordSearchBoxProductType.Clear();
            txtRecordSearchBoxManufacturer.Clear();
            txtRecordSearchBoxProductName.Clear();
            
            if (dataGridView3.Rows.Count == 0)
            {
                MessageBox.Show("Record Table is Empty!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to submit the records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    con.Open();
                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    {
                        txtID.Text = dataGridView3.Rows[i].Cells["ProductID"].Value.ToString();
                        txtProductName.Text = dataGridView3.Rows[i].Cells["ProductName"].Value.ToString();
                        cbxManufacturer.Text = dataGridView3.Rows[i].Cells["Manufacturer"].Value.ToString();
                        cbxType.Text = dataGridView3.Rows[i].Cells["Type"].Value.ToString();
                        txtStatus.Text = dataGridView3.Rows[i].Cells["Status"].Value.ToString();
                        dateTimePicker1.Text = dataGridView3.Rows[i].Cells["DateTaken"].Value.ToString();
                        txtStock.Text = dataGridView3.Rows[i].Cells["Stock"].Value.ToString();
                        txtAmount.Text = dataGridView3.Rows[i].Cells["Amount"].Value.ToString();
                        txtTotalAmount.Text = dataGridView3.Rows[i].Cells["TotalPrice"].Value.ToString();
                        txtPrice.Text = dataGridView3.Rows[i].Cells["Price"].Value.ToString();



                        cmd = new OleDbCommand("INSERT INTO RecordIn(ProductID, ProductName, Manufacturer, Type, Status, DateTaken, Stock, Amount, TotalPrice, Price, AddedBy) VALUES (@ProductID, @ProductName, @Manufacturer, @Type, @Status, @DateTaken, @Stock, @Amount, @TotalPrice, @Price, @AddedBy)", con);

                        cmd.Parameters.AddWithValue("@ProductID", txtID.Text);
                        cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@Manufacturer", cbxManufacturer.Text);
                        cmd.Parameters.AddWithValue("@Type", cbxType.Text);
                        cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                        cmd.Parameters.AddWithValue("@DateTaken", dateTimePicker1.Text);
                        cmd.Parameters.AddWithValue("@Stock", txtStock.Text);
                        cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                        cmd.Parameters.AddWithValue("@TotalPrice", txtTotalAmount.Text);
                        cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                        cmd.Parameters.AddWithValue("@AddedBy", Variables.username.ToString());



                        cmd.ExecuteNonQuery();
                    }



                    con.Close();
                    
                    con.Open();
                    string comand = "DELETE FROM TempRecordIn";
                    cmd = new OleDbCommand(comand, con);
                    cmd.ExecuteNonQuery();                
                      
                    con.Close();

                    
                    


                    MessageBox.Show("Record Success!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dataGridView2.Rows.Clear();
                    //dataGridView2.Refresh();
                    btnSubmit.Enabled = false;
                    lblRecordNotice.Text = "RECORD(s) IS SUBMITTED!";

                    submmited = 1;
                    dataGridView3.Visible = false;
                }

                else
                {
                    
                }


                
            }
            txtID.Text = "";
            txtProductName.Text = "";
            cbxManufacturer.Text = "";
            cbxType.Text = "";
            txtStock.Text = "";
            txtAmount.Text = "";
            txtTotalAmount.Text = "";
            txtPrice.Text = "";
            txtAmount.Text = " ";
            RecordIN rin = new RecordIN();
            rin.Refresh();
            Reports rpts = new Reports();
            rpts.Refresh();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnDeleteEntry.Enabled = true;
            btnAddRecord.Enabled = false;
            btnSubmit.Enabled = false;

            tempamount = Convert.ToInt32(dataGridView2.CurrentRow.Cells["rAmount"].Value.ToString());
            stock = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Stck"].Value.ToString());
            tempprice = Convert.ToDouble(dataGridView2.CurrentRow.Cells["Prce"].Value.ToString());


            txtID.Text = dataGridView2.CurrentRow.Cells["ProductID"].Value.ToString();
            txtProductName.Text = dataGridView2.CurrentRow.Cells["ProductName"].Value.ToString();
            cbxManufacturer.Text = dataGridView2.CurrentRow.Cells["Manufacturer"].Value.ToString();
            cbxType.Text = dataGridView2.CurrentRow.Cells["Type"].Value.ToString();
            txtStock.Text = dataGridView2.CurrentRow.Cells["Stck"].Value.ToString();
            txtPrice.Text = dataGridView2.CurrentRow.Cells["Prce"].Value.ToString();

            row = dataGridView1.CurrentCell.RowIndex;
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            txtRecordSearchBoxManufacturer.Clear();
            txtRecordSearchBoxProductName.Clear();
            txtRecordSearchBoxProductType.Clear();

            DialogResult result = MessageBox.Show("Do you really want to delete?", "Close Confirmation", MessageBoxButtons.YesNo/*Cancel*/, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dataGridView3.RowCount == 1)
                {
                    dataGridView3.Visible = false;
                }
                con.Open();
                cmd = new OleDbCommand("DELETE FROM tempRecordIn WHERE ProductID =@ProductID AND Type=@Type", con);
                cmd.Parameters.AddWithValue("@ProductID", txtID.Text);
                cmd.Parameters.AddWithValue("@Type", cbxType.Text);



                cmd.ExecuteNonQuery();
                con.Close();
                stock = stock - tempamount;
                totalprice = stock * tempprice;
                con.Open();

                cmd = new OleDbCommand("UPDATE Inventory SET Stock=@Stock, TotalPrice=@TotalPrice WHERE ProductID=@ProductID AND Type=@Type", con);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@TotalPrice", totalprice);
                cmd.Parameters.AddWithValue("@ProductID", txtID.Text);
                cmd.Parameters.AddWithValue("@Type", cbxType.Text);

                cmd.ExecuteNonQuery();

                con.Close();
                txtStock.Text = Convert.ToString(stock);
                refreshRecordsIn();
                refreshInventory();

                MessageBox.Show("Entry Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dataGridView3.Rows.Count == 0)
                {
                    btnSubmit.Enabled = false;
                    
                }
                btnDeleteEntry.Enabled = false;
                btnAddRecord.Enabled = true;
                btnSubmit.Enabled = true;

            }
        }

        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteEntry.Enabled = true;
            btnAddRecord.Enabled = false;
            btnSubmit.Enabled = false;

            tempamount = Convert.ToInt32(dataGridView3.CurrentRow.Cells["Amount"].Value.ToString());
            stock = Convert.ToInt32(dataGridView3.CurrentRow.Cells["Stock"].Value.ToString());
            tempprice = Convert.ToDouble(dataGridView3.CurrentRow.Cells["Price"].Value.ToString());


            txtID.Text = dataGridView3.CurrentRow.Cells["ProductID"].Value.ToString();
            txtProductName.Text = dataGridView3.CurrentRow.Cells["ProductName"].Value.ToString();
            cbxManufacturer.Text = dataGridView3.CurrentRow.Cells["Manufacturer"].Value.ToString();
            cbxType.Text = dataGridView3.CurrentRow.Cells["Type"].Value.ToString();
            txtStock.Text = dataGridView3.CurrentRow.Cells["Stock"].Value.ToString();
            txtPrice.Text = dataGridView3.CurrentRow.Cells["Price"].Value.ToString();

            row = dataGridView1.CurrentCell.RowIndex;
        }
    }
}
