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
    public partial class Reports : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files (x86)\PRODUCTS INVENTORY AND RECORDS\Paint Products Database\Product Database.accdb");
        OleDbCommand cmd;
        
        public void loadRecordIN()
        {
            try
            {
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT ProductID, ProductName, Manufacturer, Type, Status, DateTaken, Stock, Amount, TotalPrice, Price, AddedBy FROM RecordIn";
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
        public void loadRecordOUT()
        {
            try
            {
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT ProductID, ProductName, Manufacturer, Type, Status, DateTaken, Stock, Amount, TotalPrice, Price, AddedBy FROM RecordOut";
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView2.DataSource = dt;
                }
            }
            finally
            {
                con.Close();
            }

        }
        public void loadRecordRETURN()
        {
            try
            {
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT ProductID, ProductName, Manufacturer, Type, Status, DateTaken, Stock, Amount, TotalPrice, Price, StoreName, AddedBy FROM RecordReturn";
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
        public void loadAlertQuantity()
        {
            try
            {
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT ProductID, ProductName, Manufacturer, Type, Stock ,Price, TotalPrice FROM Inventory WHERE AlertQuantity >= Stock";
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView4.DataSource = dt;
                }
            }
            finally
            {
                con.Close();
            }

        }
        public Reports()
        {
            InitializeComponent();
        }

        private void cbxInventorySearchSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxInventorySearchSelect.Text == "Manufacturer")
            {
                txtInventorySearchBoxManufacturer.Show();
                txtInventorySearchBoxProductName.Hide();
                txtInventorySearchBoxProductType.Hide();
                lbldateFrom.Hide();
                lbldateTo.Hide();
                dtpFrom.Hide();
                dtpTo.Hide();
                btnExecute.Hide();
            }
            else if (cbxInventorySearchSelect.Text == "Product ID")
            {
                txtInventorySearchBoxManufacturer.Hide();
                txtInventorySearchBoxProductName.Show();
                txtInventorySearchBoxProductType.Hide();
                lbldateFrom.Hide();
                lbldateTo.Hide();
                dtpFrom.Hide();
                dtpTo.Hide();
                btnExecute.Hide();
            }
            else if (cbxInventorySearchSelect.Text == "Product Type")
            {
                txtInventorySearchBoxManufacturer.Hide();
                txtInventorySearchBoxProductName.Hide();
                txtInventorySearchBoxProductType.Show();
                lbldateFrom.Hide();
                lbldateTo.Hide();
                dtpFrom.Hide();
                dtpTo.Hide();
                btnExecute.Hide();
            }
            else if (cbxInventorySearchSelect.Text == "Date")
            {
                txtInventorySearchBoxManufacturer.Hide();
                txtInventorySearchBoxProductName.Hide();
                txtInventorySearchBoxProductType.Hide();
                lbldateFrom.Show();
                lbldateTo.Show();
                dtpFrom.Show();
                dtpTo.Show();
                btnExecute.Show();
            }
        }

        private void txtInventorySearchBoxManufacturer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("Manufacturer like '%{0}%'", txtInventorySearchBoxManufacturer.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void txtInventorySearchBoxProductType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("Type like '%{0}%'", txtInventorySearchBoxProductType.Text.Trim().Replace("'", "''"));
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

        private void btnExecute_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dataGridView1.DataSource;

            bs.Filter = string.Format("DateTaken >= #{0:yyyy/MM/dd}# And DateTaken <= #{1:yyyy/MM/dd}#", dtpFrom.Value, dtpTo.Value);
            dataGridView1.DataSource = bs;
        }

        private void btnReportIN_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;

            btnToExcel1.Visible = true;
            btnToExcel2.Visible = false;
            btnToExcel3.Visible = false;
            btnToExcel4.Visible = false;
            loadRecordIN();
        }

        private void btnReportOut_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;

            btnToExcel1.Visible = false;
            btnToExcel2.Visible = true;
            btnToExcel3.Visible = false;
            btnToExcel4.Visible = false;
            loadRecordOUT();
        }

        private void btnReportReturn_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;

            btnToExcel1.Visible = false;
            btnToExcel2.Visible = false;
            btnToExcel3.Visible = true;
            btnToExcel4.Visible = false;
            loadRecordRETURN();
        }

        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
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
                        ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
            MessageBox.Show("Exported to Excel!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAlertQuantity_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;

            btnToExcel1.Visible = false;
            btnToExcel2.Visible = false;
            btnToExcel3.Visible = false;
            btnToExcel4.Visible = true;
            loadAlertQuantity();
        }

        private void btnStoreReport_Click(object sender, EventArgs e)
        {
            
        }

        private void btnToExcel2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();


            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2007)| *.xlsx | Excel Files (2010) | *.xlsx";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 15;

                for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
            MessageBox.Show("Exported to Excel!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnToExcel3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();


            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2007)| *.xlsx | Excel Files (2010) | *.xlsx";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 15;

                for (int i = 1; i < dataGridView3.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridView3.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView3.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridView3.Rows[i].Cells[j].Value;
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
            MessageBox.Show("Exported to Excel!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnToExcel4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();


            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2007)| *.xlsx | Excel Files (2010) | *.xlsx";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 15;

                for (int i = 1; i < dataGridView4.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridView4.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView4.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView4.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridView4.Rows[i].Cells[j].Value;
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
            MessageBox.Show("Exported to Excel!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
