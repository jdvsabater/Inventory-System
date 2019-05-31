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
    public partial class BranchList : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files (x86)\PRODUCTS INVENTORY AND RECORDS\Paint Products Database\Product Database.accdb");
        OleDbCommand cmd;
        string fnction = "";
        public void BRefresh()
        {
            try
            {
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT TinNumber, BranchName, BranchOwner, Address, TelephoneNumber FROM Branch";
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
        public BranchList()
        {
            InitializeComponent();
            BRefresh();
        }

        private void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTinNumber.Text = dataGridView1.CurrentRow.Cells["TinNumber"].Value.ToString();
            txtBranchName.Text = dataGridView1.CurrentRow.Cells["BranchName"].Value.ToString();
            txtBranchOwner.Text = dataGridView1.CurrentRow.Cells["BranchOwner"].Value.ToString();
            rtbAddress.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells["TelephoneNumber"].Value.ToString();

            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
        }

        private void cbxSearchSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearchSelect.Text == "Tin Number")
            {
                txtSearchBoxTinNumber.Show();
                txtSearchBoxBranchName.Hide();
                txtSearchBoxBranchOwner.Hide();

                txtSearchBoxTinNumber.Text = " ";
                txtSearchBoxBranchName.Text = " "; 
                txtSearchBoxBranchOwner.Text = " "; 
            }
            else if (cbxSearchSelect.Text == "Branch Name")
            {
                txtSearchBoxTinNumber.Hide();
                txtSearchBoxBranchName.Show();
                txtSearchBoxBranchOwner.Hide();

                txtSearchBoxTinNumber.Text = " ";
                txtSearchBoxBranchName.Text = " ";
                txtSearchBoxBranchOwner.Text = " ";
            }
            else if (cbxSearchSelect.Text == "Branch Owner")
            {
                txtSearchBoxTinNumber.Hide();
                txtSearchBoxBranchName.Hide();
                txtSearchBoxBranchOwner.Show();

                txtSearchBoxTinNumber.Text = " ";
                txtSearchBoxBranchName.Text = " ";
                txtSearchBoxBranchOwner.Text = " ";
            }
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

        private void txtSearchBoxBranchName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("BranchName like '%{0}%'", txtSearchBoxBranchName.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void txtSearchBoxBranchOwner_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("BranchOwner like '%{0}%'", txtSearchBoxBranchOwner.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void BranchList_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTinNumber.Enabled = true;
            txtBranchName.Enabled = true;        
            txtBranchOwner.Enabled = true;
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
            lblNote.Text = "Note: You are about to Add a new Branch";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtTinNumber.Enabled = true;
            txtBranchName.Enabled = true;
            txtBranchOwner.Enabled = true;
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
            txtBranchOwner.Clear();
            txtBranchName.Clear();
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
                cmd = new OleDbCommand("DELETE FROM Branch WHERE TinNumber = '" + dataGridView1.SelectedCells[0].Value.ToString() + "'", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Branch Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                BRefresh();
                txtTinNumber.Clear();
                txtBranchOwner.Clear();
                txtBranchName.Clear();
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
            txtBranchName.Enabled = false;
            txtBranchOwner.Enabled = false;
            rtbAddress.Enabled = false;
            txtTel.Enabled = false;

            txtTinNumber.Clear();
            txtBranchName.Clear();
            txtBranchOwner.Clear();
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
                if ((txtTinNumber.Text == "") || (txtBranchName.Text == "") || (rtbAddress.Text == "") || (txtTel.Text == ""))
                {
                    MessageBox.Show("Fields must not be empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Open();

                    cmd = new OleDbCommand("INSERT into Branch(TinNumber, BranchName, BranchOwner, Address, TelephoneNumber) VALUES (@TinNumber, @BranchName, @BranchOwner, @Address, @TelephoneNumber)", con);

                    cmd.Parameters.AddWithValue("@TinNumber", txtTinNumber.Text);
                    cmd.Parameters.AddWithValue("@BranchName", txtBranchName.Text);
                    cmd.Parameters.AddWithValue("@BranchOwner", txtBranchOwner.Text);
                    cmd.Parameters.AddWithValue("@Address", rtbAddress.Text);
                    cmd.Parameters.AddWithValue("@TelephoneNumber", txtTel.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Branch Added", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BRefresh();

                }
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnSave.Enabled = false;
                dataGridView1.Enabled = true;
                btnCancel.Enabled = false;
                txtTinNumber.Clear();
                txtBranchName.Clear();
                txtBranchOwner.Clear();
                rtbAddress.Clear();
                txtTel.Clear();
                txtTinNumber.Enabled = false;
                txtBranchName.Enabled = false;
                txtBranchOwner.Enabled = false;
                rtbAddress.Enabled = false;
                txtTel.Enabled = false;
            }
            else if ((btnEdit.Enabled == false) && (fnction == "Edit"))
            {
                if ((txtTinNumber.Text == "") || (txtBranchName.Text == "") || (txtBranchOwner.Text == "") || (rtbAddress.Text == "") || (txtTel.Text == ""))
                {
                    MessageBox.Show("Fields must not be empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Open();

                    cmd = new OleDbCommand("UPDATE Branch SET BranchName=@BranchName, BranchOwner=@BranchOwner, Address=@Address, TelephoneNumber=@TelephoneNumber WHERE TinNumber=@TinNumber", con);
                    cmd.Parameters.AddWithValue("@BranchName", txtBranchName.Text);
                    cmd.Parameters.AddWithValue("@BranchOwner", txtBranchOwner.Text);
                    cmd.Parameters.AddWithValue("@Address", rtbAddress.Text);
                    cmd.Parameters.AddWithValue("@TelephoneNumber", txtTel.Text);
                    cmd.Parameters.AddWithValue("@TinNumber", txtTinNumber.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Branch Updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BRefresh();

                }
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnSave.Enabled = false;
                dataGridView1.Enabled = true;
                btnCancel.Enabled = false;
                txtTinNumber.Clear();
                txtBranchName.Clear();
                txtBranchOwner.Clear();
                rtbAddress.Clear();
                txtTel.Clear();
                txtTinNumber.Enabled = false;
                txtBranchName.Enabled = false;
                txtBranchOwner.Enabled = false;
                rtbAddress.Enabled = false;
                txtTel.Enabled = false;
            }

            RecordReturn rreturn = new RecordReturn();

            rreturn.Refresh();
            dataGridView1.Visible = true;
        }
        


    }
}
