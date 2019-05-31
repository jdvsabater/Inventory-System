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
    public partial class ManufacturerDetails : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files (x86)\PRODUCTS INVENTORY AND RECORDS\Paint Products Database\Product Database.accdb");
        OleDbCommand cmd;
        string fnction = "";
        public void MRefresh()
        {
            try
            {
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT TinNumber, BusinessName, BusinessOwner, Address, TelephoneNumber FROM Manufacturer";
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
        public ManufacturerDetails()
        {
            
            InitializeComponent();
            MRefresh();
        }

        private void ManufacturerDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearchBoxTinNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("TinNumber like '%{0}%'", txtSearchBoxTinNumber.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void txtSearchBoxProductType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("BusinessOwner like '%{0}%'", txtSearchBusinessOwner.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void txtSearchBoxManufacturer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("BusinessName like '%{0}%'", txtSearchBoxManufacturer.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void cbxSearchSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearchSelect.Text == "Tin Number")
            {
                txtSearchBoxTinNumber.Show();
                txtSearchBoxManufacturer.Hide();
                txtSearchBusinessOwner.Hide();

                txtSearchBoxTinNumber.Text = "";
                txtSearchBoxManufacturer.Text = "";
                txtSearchBusinessOwner.Text = "";
            }
            else if (cbxSearchSelect.Text == "Business Name")
            {
                txtSearchBoxTinNumber.Hide();
                txtSearchBoxManufacturer.Show();
                txtSearchBusinessOwner.Hide();

                txtSearchBoxTinNumber.Text = "";
                txtSearchBoxManufacturer.Text = "";
                txtSearchBusinessOwner.Text = "";
            }
            else if (cbxSearchSelect.Text == "Business Owner")
            {
                txtSearchBoxTinNumber.Hide();
                txtSearchBoxManufacturer.Hide();
                txtSearchBusinessOwner.Show();

                txtSearchBoxTinNumber.Text = "";
                txtSearchBoxManufacturer.Text = "";
                txtSearchBusinessOwner.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new OleDbCommand("DELETE FROM Manufacturer WHERE TinNumber = '" + dataGridView1.SelectedCells[0].Value.ToString() + "'", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Business Deleted", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            MRefresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTinNumber.Text = dataGridView1.CurrentRow.Cells["TinNumber"].Value.ToString();
            txtBusinessName.Text = dataGridView1.CurrentRow.Cells["BusinessName"].Value.ToString();
            txtBusinessOwner.Text = dataGridView1.CurrentRow.Cells["BusinessOwner"].Value.ToString();
            rtbAddress.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells["TelephoneNumber"].Value.ToString();

            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
        }

        private void ManufacturerDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTinNumber.Enabled = true;
            txtBusinessName.Enabled = true;
            txtBusinessOwner.Enabled = true;
            rtbAddress.Enabled = true;
            txtTel.Enabled = true;


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

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            txtTinNumber.Enabled = true;
            txtBusinessName.Enabled = true;
            txtBusinessOwner.Enabled = true;
            rtbAddress.Enabled = true;
            txtTel.Enabled = true;

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTinNumber.Clear();
            txtBusinessName.Clear();
            txtBusinessOwner.Clear();
            rtbAddress.Clear();
            txtTel.Clear();
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete?", "Close Confirmation", MessageBoxButtons.YesNo/*Cancel*/, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dataGridView1.RowCount == 1)
                {
                    dataGridView1.Visible = false;
                }

                con.Open();
                cmd = new OleDbCommand("DELETE FROM Manufacturer WHERE TinNumber = '" + dataGridView1.SelectedCells[0].Value.ToString() + "'", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                MRefresh();
                txtTinNumber.Clear();
                txtBusinessName.Clear();
                txtBusinessOwner.Clear();
                rtbAddress.Clear();
                txtTel.Clear();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTinNumber.Enabled = false;
            txtBusinessName .Enabled = false;
            txtBusinessOwner.Enabled = false;
            rtbAddress.Enabled = false;
            txtTel.Enabled = false;

            txtTinNumber.Clear();
            txtBusinessName.Clear();
            txtBusinessOwner.Clear();
            rtbAddress.Clear();
            txtTel.Clear();


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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((btnAdd.Enabled == false) && (fnction == "Add"))
            {
                if ((txtTinNumber.Text == "") || (txtBusinessName.Text == "") || (rtbAddress.Text == "") || (txtTel.Text == ""))
                {
                    MessageBox.Show("Fields must not be empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Open();

                    cmd = new OleDbCommand("INSERT into Manufacturer(TinNumber, BusinessName, BusinessOwner, Address, TelephoneNumber) VALUES(@TinNumber, @BusinessName, @BusinessOwner, @Address, @TelephoneNumber)", con);

                    cmd.Parameters.AddWithValue("@TinNumber", txtTinNumber.Text);
                    cmd.Parameters.AddWithValue("@BusinessName", txtBusinessName.Text);
                    cmd.Parameters.AddWithValue("@BusinessOwner", txtBusinessOwner.Text);
                    cmd.Parameters.AddWithValue("@Address", rtbAddress.Text);
                    cmd.Parameters.AddWithValue("@TelephoneNumber", txtTel.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Business Added", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MRefresh();

                }
                dataGridView1.Visible = true;
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnSave.Enabled = false;
                dataGridView1.Enabled = true;
                btnCancel.Enabled = false;
                txtTinNumber.Clear();
                txtBusinessName.Clear();
                txtBusinessOwner.Clear();
                rtbAddress.Clear();
                txtTel.Clear();
                txtTinNumber.Enabled = false;
                txtBusinessName.Enabled = false;
                txtBusinessOwner.Enabled = false;
                rtbAddress.Enabled = false;
                txtTel.Enabled = false;
            }
            else if ((btnEdit.Enabled == false) && (fnction == "Edit"))
            {
                if ((txtTinNumber.Text == "") || (txtBusinessName.Text == "") || (txtBusinessOwner.Text == "") || (rtbAddress.Text == "") || (txtTel.Text == ""))
                {
                    MessageBox.Show("Fields must not be empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Open();

                    cmd = new OleDbCommand("UPDATE Manufacturer SET BusinessName=@BusinessName, BusinessOwner=@BusinessOwner, Address=@Address, TelephoneNumber=@TelephoneNumber WHERE TinNumber=@TinNumber", con);
                    cmd.Parameters.AddWithValue("@BusinessName", txtBusinessName.Text);
                    cmd.Parameters.AddWithValue("@BusinessOwner", txtBusinessOwner.Text);
                    cmd.Parameters.AddWithValue("@Address", rtbAddress.Text);
                    cmd.Parameters.AddWithValue("@TelephoneNumber", txtTel.Text);
                    cmd.Parameters.AddWithValue("@TinNumber", txtTinNumber.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("User Updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MRefresh();

                }
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnSave.Enabled = false;
                dataGridView1.Enabled = true;
                btnCancel.Enabled = false;
                txtTinNumber.Clear();
                txtBusinessName.Clear();
                txtBusinessOwner.Clear();
                rtbAddress.Clear();
                txtTel.Clear();
                txtTinNumber.Enabled = false;
                txtBusinessName.Enabled = false;
                txtBusinessOwner.Enabled = false;
                rtbAddress.Enabled = false;
                txtTel.Enabled = false;
            }
            dataGridView1.Visible = true;
        }
    }
}
