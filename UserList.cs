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
    public partial class UserList : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files (x86)\PRODUCTS INVENTORY AND RECORDS\Paint Products Database\Product Database.accdb");
        OleDbCommand cmd;
        string fnction = "";
        public void uRefresh()
        {
            try
            {
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT ID, UName, PW, Type, DateRegistered FROM Users";
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

        public UserList()
        {
            InitializeComponent();
            uRefresh();
        }

        private void UserList_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void UserList_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void txtSearchUsername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("Username like '%{0}%'", txtSearchUsername.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new OleDbCommand("DELETE FROM Inventory WHERE ID = '" + dataGridView1.SelectedCells[0].Value.ToString() + "'", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("User Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            uRefresh();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            txtRetypePassword.Enabled = true;
            cbxRole.Enabled = true;


            fnction = "Add";
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

            dataGridView1.Enabled = false;
            lblNote.Text = "Note: You are about to Add a new User";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            //txtRetypePassword.Enabled = true;
            cbxRole.Enabled = true;

            fnction = "Edit";
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

            dataGridView1.Enabled = false;
            lblNote.Text = "Note: You are about to Edit a new User";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtRetypePassword.Clear();
            
            
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
                con.Open();
                cmd = new OleDbCommand("DELETE FROM Users WHERE ID = '" + dataGridView1.SelectedCells[0].Value.ToString() + "'", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("User Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                uRefresh();
                txtUserName.Clear();
                txtPassword.Clear();
                txtRetypePassword.Clear();


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
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            txtRetypePassword.Enabled = false;
            cbxRole.Enabled = false;
            dateTimePicker1.Enabled = false;

            txtUserName.Clear();
            txtPassword.Clear();
            txtRetypePassword.Clear();
            


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

                if ((txtUserName.Text == "") && (txtPassword.Text == "") && (cbxRole.Text == "") && (dateTimePicker1.Text == ""))
                {
                    MessageBox.Show("Fields must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!(txtPassword.Text == txtRetypePassword.Text))
                {
                    MessageBox.Show("Password And Retype Password Must be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    con.Open();

                    cmd = new OleDbCommand("INSERT INTO Users(UName, PW, Type, DateRegistered) VALUES (@UName, @PW, @Type, @DateRegistered)", con);

                    cmd.Parameters.AddWithValue("@UName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@PW", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Type", cbxRole.Text);
                    cmd.Parameters.AddWithValue("@DateRegistered", dateTimePicker1.Text);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();

                    uRefresh();
                }
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnSave.Enabled = false;
                dataGridView1.Enabled = true;
                btnCancel.Enabled = false;
                txtUserName.Clear();
                txtPassword.Clear();
                txtRetypePassword.Clear();

                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                txtRetypePassword.Enabled = false;
                cbxRole.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
            else if ((btnEdit.Enabled == false) && (fnction == "Edit"))
            {
                if ((txtUserName.Text == "") && (txtPassword.Text == "") && (cbxRole.Text == ""))
                {
                    MessageBox.Show("Fields must not be empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Open();

                    cmd = new OleDbCommand("UPDATE Users SET UName=@UName, PW=@PW, Type=@Type WHERE ID=@ID", con);
                    cmd.Parameters.AddWithValue("@UName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@PW", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Type", cbxRole.Text);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Branch Updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    uRefresh();

                }

                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnSave.Enabled = false;
                dataGridView1.Enabled = true;
                btnCancel.Enabled = false;
                txtUserName.Clear();
                txtPassword.Clear();
                txtRetypePassword.Clear();

                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                txtRetypePassword.Enabled = false;
                cbxRole.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = dataGridView1.CurrentRow.Cells["UName"].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells["PW"].Value.ToString();
            cbxRole.Text = dataGridView1.CurrentRow.Cells["Type"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["DateRegistered"].Value.ToString();
            txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            

            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
        }
    }
}
