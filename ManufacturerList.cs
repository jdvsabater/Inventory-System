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
    public partial class ManufacturerList : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files (x86)\PRODUCTS INVENTORY AND RECORDS\Paint Products Database\Product Database.accdb");
        OleDbCommand cmd;

        public ManufacturerList()
        {
            InitializeComponent();
        }
        public void MRefresh()
        {
            try
            {
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT Manufacturer FROM Manufacturer";
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
        private void ManufacturerList_Load(object sender, EventArgs e)
        {
            MRefresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManufacturerName.Text = dataGridView1.CurrentRow.Cells["Manufacturer"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtManufacturerName.Text == "")
            {
                MessageBox.Show("Field must not be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                con.Open();

                cmd = new OleDbCommand("INSERT into Manufacturer(Manufacturer) VALUES(@Manufacturer)",con);

                cmd.Parameters.AddWithValue("@Manufacturer",txtManufacturerName.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Manufacturer Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                MRefresh();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtManufacturerName.Text == "")
            {
                MessageBox.Show("Field must not be empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                con.Open();

                cmd = new OleDbCommand("UPDATE Manufacturer SET Manufacturer=@Manufacturer WHERE Manufacturer=@Manufacturer", con);

                cmd.Parameters.AddWithValue("@Manufacturer",txtManufacturerName.Text);
                //cmd.Parameters.AddWithValue("@ID", txtID.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Manufacturer Updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                MRefresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtManufacturerName.Text == "")
            {
                MessageBox.Show("Field must not be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                con.Open();

                cmd = new OleDbCommand("DELETE FROM Manufacturer WHERE Manufacturer= '" + dataGridView1.SelectedCells[0].Value.ToString() + "'", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Manufacturer Removed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                MRefresh();
            }
        }

        private void ManufacturerList_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
