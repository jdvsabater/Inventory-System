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
                lblState.Text = "Search Manufacturer";
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
                lblState.Text = "Search Product ID";
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
                lblState.Text = "Search Product Type";
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
                lblState.Text = "Search Date";
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
            label10.Text = "REPORTS IN LOADED";

            grpSearchIn.Visible = true;
            grpSearchOut.Visible = false;
            grpSearchReturn.Visible = false;
            grpQuantityAlert.Visible = false;

            grpSearchIn.Location = new Point(21, 12);
            grpSearchOut.Location = new Point(21, 12);
            grpSearchReturn.Location = new Point(21, 12);
            grpQuantityAlert.Location = new Point(21, 12);

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
            label10.Text = "REPORTS OUT LOADED";

            grpSearchIn.Visible = false;
            grpSearchOut.Visible = true;
            grpSearchReturn.Visible = false;
            grpQuantityAlert.Visible = false;

            grpSearchIn.Location = new Point(21, 12);
            grpSearchOut.Location = new Point(21, 12);
            grpSearchReturn.Location = new Point(21, 12);
            grpQuantityAlert.Location = new Point(21, 12);

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
            label10.Text = "REPORTS RETURN LOADED";

            grpSearchIn.Visible = false;
            grpSearchOut.Visible = false;
            grpSearchReturn.Visible = true;
            grpQuantityAlert.Visible = false;

            grpSearchIn.Location = new Point(21, 12);
            grpSearchOut.Location = new Point(21, 12);
            grpSearchReturn.Location = new Point(21, 12);
            grpQuantityAlert.Location = new Point(21, 12);

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
            txtInventorySearchBoxManufacturer.Clear();
            txtInventorySearchBoxManufacturer2.Clear();
            txtInventorySearchBoxManufacturer3.Clear();
            txtInventorySearchBoxManufacturer4.Clear();

            txtInventorySearchBoxProductName.Clear();
            txtInventorySearchBoxProductName2.Clear();
            txtInventorySearchBoxProductName3.Clear();
            txtInventorySearchBoxProductName4.Clear();

            txtInventorySearchBoxProductType.Clear();
            txtInventorySearchBoxProductType2.Clear();
            txtInventorySearchBoxProductType3.Clear();
            txtInventorySearchBoxProductType4.Clear();

            txtInventorySearchBoxStoreName3.Clear();

            dtpFrom.Text = " ";
            dtpFrom2.Text = " ";
            dtpFrom3.Text = " ";

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
            label10.Text = "QUANTITY ALERT LOADED";

            grpSearchIn.Visible = false;
            grpSearchOut.Visible = false;
            grpSearchReturn.Visible = false;
            grpQuantityAlert.Visible = true;

            grpSearchIn.Location = new Point(21, 12);
            grpSearchOut.Location = new Point(21, 12);
            grpSearchReturn.Location = new Point(21, 12);
            grpQuantityAlert.Location = new Point(21, 12);

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
            txtInventorySearchBoxManufacturer.Clear();
            txtInventorySearchBoxManufacturer2.Clear();
            txtInventorySearchBoxManufacturer3.Clear();
            txtInventorySearchBoxManufacturer4.Clear();

            txtInventorySearchBoxProductName.Clear();
            txtInventorySearchBoxProductName2.Clear();
            txtInventorySearchBoxProductName3.Clear();
            txtInventorySearchBoxProductName4.Clear();

            txtInventorySearchBoxProductType.Clear();
            txtInventorySearchBoxProductType2.Clear();
            txtInventorySearchBoxProductType3.Clear();
            txtInventorySearchBoxProductType4.Clear();

            txtInventorySearchBoxStoreName3.Clear();

            dtpFrom.Text = " ";
            dtpFrom2.Text = " ";
            dtpFrom3.Text = " ";

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
            txtInventorySearchBoxManufacturer.Clear();
            txtInventorySearchBoxManufacturer2.Clear();
            txtInventorySearchBoxManufacturer3.Clear();
            txtInventorySearchBoxManufacturer4.Clear();

            txtInventorySearchBoxProductName.Clear();
            txtInventorySearchBoxProductName2.Clear();
            txtInventorySearchBoxProductName3.Clear();
            txtInventorySearchBoxProductName4.Clear();

            txtInventorySearchBoxProductType.Clear();
            txtInventorySearchBoxProductType2.Clear();
            txtInventorySearchBoxProductType3.Clear();
            txtInventorySearchBoxProductType4.Clear();

            txtInventorySearchBoxStoreName3.Clear();

            dtpFrom.Text = " ";
            dtpFrom2.Text = " ";
            dtpFrom3.Text = " ";

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
            txtInventorySearchBoxManufacturer.Clear();
            txtInventorySearchBoxManufacturer2.Clear();
            txtInventorySearchBoxManufacturer3.Clear();
            txtInventorySearchBoxManufacturer4.Clear();

            txtInventorySearchBoxProductName.Clear();
            txtInventorySearchBoxProductName2.Clear();
            txtInventorySearchBoxProductName3.Clear();
            txtInventorySearchBoxProductName4.Clear();

            txtInventorySearchBoxProductType.Clear();
            txtInventorySearchBoxProductType2.Clear();
            txtInventorySearchBoxProductType3.Clear();
            txtInventorySearchBoxProductType4.Clear();

            txtInventorySearchBoxStoreName3.Clear();

            dtpFrom.Text = " ";
            dtpFrom2.Text = " ";
            dtpFrom3.Text = " ";

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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnClearData_Click(object sender, EventArgs e)
        {

        }

        private void CbxInventorySearchSelect2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxInventorySearchSelect2.Text == "Manufacturer")
            {
                txtInventorySearchBoxManufacturer2.Show();
                txtInventorySearchBoxProductName2.Hide();
                txtInventorySearchBoxProductType2.Hide();
                lbldateFrom.Hide();
                lbldateTo.Hide();
                dtpFrom2.Hide();
                dtpTo2.Hide();
                btnExecute2.Hide();
                lblState2.Text = "Search Manufacturer";
            }
            else if (cbxInventorySearchSelect2.Text == "Product ID")
            {
                txtInventorySearchBoxManufacturer2.Hide();
                txtInventorySearchBoxProductName2.Show();
                txtInventorySearchBoxProductType2.Hide();
                lbldateFrom.Hide();
                lbldateTo.Hide();
                dtpFrom2.Hide();
                dtpTo2.Hide();
                btnExecute2.Hide();
                lblState2.Text = "Search Product ID";
            }
            else if (cbxInventorySearchSelect2.Text == "Product Type")
            {
                txtInventorySearchBoxManufacturer2.Hide();
                txtInventorySearchBoxProductName2.Hide();
                txtInventorySearchBoxProductType2.Show();
                lbldateFrom.Hide();
                lbldateTo.Hide();
                dtpFrom2.Hide();
                dtpTo2.Hide();
                btnExecute2.Hide();
                lblState2.Text = "Search Product Type";
            }
            else if (cbxInventorySearchSelect2.Text == "Date")
            {
                txtInventorySearchBoxManufacturer2.Hide();
                txtInventorySearchBoxProductName2.Hide();
                txtInventorySearchBoxProductType2.Hide();
                lbldateFrom.Show();
                lbldateTo.Show();
                dtpFrom2.Show();
                dtpTo2.Show();
                btnExecute2.Show();
                lblState2.Text = "Search Date";
            }
        }

        private void TxtInventorySearchBoxManufacturer2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView2.DataSource).DefaultView.RowFilter = string.Format("Manufacturer like '%{0}%'", txtInventorySearchBoxManufacturer2.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void TxtInventorySearchBoxProductType2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView2.DataSource).DefaultView.RowFilter = string.Format("Type like '%{0}%'", txtInventorySearchBoxProductType2.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void TxtInventorySearchBoxProductName2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView2.DataSource).DefaultView.RowFilter = string.Format("ProductID like '%{0}%'", txtInventorySearchBoxProductName2.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void BtnExecute2_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dataGridView2.DataSource;

            bs.Filter = string.Format("DateTaken >= #{0:yyyy/MM/dd}# And DateTaken <= #{1:yyyy/MM/dd}#", dtpFrom2.Value, dtpTo2.Value);
            dataGridView1.DataSource = bs;
        }

        private void CbxInventorySearchSelect3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxInventorySearchSelect3.Text == "Manufacturer")
            {
                txtInventorySearchBoxManufacturer3.Show();
                txtInventorySearchBoxProductName3.Hide();
                txtInventorySearchBoxProductType3.Hide();
                lbldateFrom.Hide();
                lbldateTo.Hide();
                dtpFrom3.Hide();
                dtpTo3.Hide();
                btnExecute3.Hide();
                lblState3.Text = "Search Manufacturer";
            }
            else if (cbxInventorySearchSelect3.Text == "Product ID")
            {
                txtInventorySearchBoxManufacturer3.Hide();
                txtInventorySearchBoxProductName3.Show();
                txtInventorySearchBoxProductType3.Hide();
                lbldateFrom.Hide();
                lbldateTo.Hide();
                dtpFrom3.Hide();
                dtpTo3.Hide();
                btnExecute3.Hide();
                lblState3.Text = "Search Product ID";
            }
            else if (cbxInventorySearchSelect3.Text == "Product Type")
            {
                txtInventorySearchBoxManufacturer3.Hide();
                txtInventorySearchBoxProductName3.Hide();
                txtInventorySearchBoxProductType3.Show();
                lbldateFrom.Hide();
                lbldateTo.Hide();
                dtpFrom3.Hide();
                dtpTo3.Hide();
                btnExecute3.Hide();
                lblState3.Text = "Search Product Type";
            }
            else if (cbxInventorySearchSelect3.Text == "Date")
            {
                txtInventorySearchBoxManufacturer3.Hide();
                txtInventorySearchBoxProductName3.Hide();
                txtInventorySearchBoxProductType3.Hide();
                lbldateFrom.Show();
                lbldateTo.Show();
                dtpFrom3.Show();
                dtpTo3.Show();
                btnExecute3.Show();
                lblState3.Text = "Search Date";
            }
            else if (cbxInventorySearchSelect3.Text == "Store Name")
            {
                txtInventorySearchBoxManufacturer3.Hide();
                txtInventorySearchBoxProductName3.Hide();
                txtInventorySearchBoxProductType3.Hide();
                txtInventorySearchBoxStoreName3.Show();
                lbldateFrom.Hide();
                lbldateTo.Hide();
                dtpFrom3.Hide();
                dtpTo3.Hide();
                btnExecute3.Hide();
                lblState3.Text = "Search Store Name";
            }

        }

        private void TxtInventorySearchBoxManufacturer3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView3.DataSource).DefaultView.RowFilter = string.Format("Manufacturer like '%{0}%'", txtInventorySearchBoxManufacturer3.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void TxtInventorySearchBoxProductType3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView3.DataSource).DefaultView.RowFilter = string.Format("Type like '%{0}%'", txtInventorySearchBoxProductType3.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void TxtInventorySearchBoxProductName3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView3.DataSource).DefaultView.RowFilter = string.Format("ProductID like '%{0}%'", txtInventorySearchBoxProductName3.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void BtnExecute3_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dataGridView3.DataSource;

            bs.Filter = string.Format("DateTaken >= #{0:yyyy/MM/dd}# And DateTaken <= #{1:yyyy/MM/dd}#", dtpFrom3.Value, dtpTo3.Value);
            dataGridView1.DataSource = bs;
        }

        private void CbxInventorySearchSelect4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxInventorySearchSelect4.Text == "Manufacturer")
            {
                txtInventorySearchBoxManufacturer4.Show();
                txtInventorySearchBoxProductName4.Hide();
                txtInventorySearchBoxProductType4.Hide();
                lbldateFrom.Hide();
                lbldateTo.Hide();
                dtpFrom4.Hide();
                dtpTo4.Hide();
                btnExecute4.Hide();
                lblState4.Text = "Search Manufacturer";
            }
            else if (cbxInventorySearchSelect4.Text == "Product ID")
            {
                txtInventorySearchBoxManufacturer4.Hide();
                txtInventorySearchBoxProductName4.Show();
                txtInventorySearchBoxProductType4.Hide();
                lbldateFrom.Hide();
                lbldateTo.Hide();
                dtpFrom4.Hide();
                dtpTo4.Hide();
                btnExecute4.Hide();
                lblState4.Text = "Search Product ID";
            }
            else if (cbxInventorySearchSelect4.Text == "Product Type")
            {
                txtInventorySearchBoxManufacturer4.Hide();
                txtInventorySearchBoxProductName4.Hide();
                txtInventorySearchBoxProductType4.Show();
                lbldateFrom.Hide();
                lbldateTo.Hide();
                dtpFrom4.Hide();
                dtpTo4.Hide();
                btnExecute4.Hide();
                lblState4.Text = "Search Product Type";
            }
            else if (cbxInventorySearchSelect4.Text == "Date")
            {
                txtInventorySearchBoxManufacturer4.Hide();
                txtInventorySearchBoxProductName4.Hide();
                txtInventorySearchBoxProductType4.Hide();
                lbldateFrom.Show();
                lbldateTo.Show();
                dtpFrom4.Show();
                dtpTo4.Show();
                btnExecute4.Show();
                lblState4.Text = "Search Date";
            }
        }

        private void TxtInventorySearchBoxManufacturer4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView4.DataSource).DefaultView.RowFilter = string.Format("Manufacturer like '%{0}%'", txtInventorySearchBoxManufacturer4.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void TxtInventorySearchBoxProductType4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView4.DataSource).DefaultView.RowFilter = string.Format("Type like '%{0}%'", txtInventorySearchBoxProductType4.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void TxtInventorySearchBoxProductName4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView4.DataSource).DefaultView.RowFilter = string.Format("ProductID like '%{0}%'", txtInventorySearchBoxProductName4.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void BtnExecute4_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dataGridView4.DataSource;

            bs.Filter = string.Format("DateTaken >= #{0:yyyy/MM/dd}# And DateTaken <= #{1:yyyy/MM/dd}#", dtpFrom4.Value, dtpTo4.Value);
            dataGridView1.DataSource = bs;
        }

        private void TxtInventorySearchBoxStoreName3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView3.DataSource).DefaultView.RowFilter = string.Format("StoreName like '%{0}%'", txtInventorySearchBoxStoreName3.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }
    }



}

   

