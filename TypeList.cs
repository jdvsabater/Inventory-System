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
    public partial class TypeList : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files (x86)\PRODUCTS INVENTORY AND RECORDS\Paint Products Database\Product Database.accdb");
        OleDbCommand cmd;
        public TypeList()
        {
            InitializeComponent();
        }
        public void TRefresh()
        {
            try
            {
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT Type FROM Type";
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
        private void TypeList_Load(object sender, EventArgs e)
        {
            TRefresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTypeName.Text = dataGridView1.CurrentRow.Cells["Type"].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTypeName.Text == "")
            {
                MessageBox.Show("Field must not be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                con.Open();

                cmd = new OleDbCommand("INSERT into Type(Type) VALUES(@Type)", con);

                cmd.Parameters.AddWithValue("@Type", txtTypeName.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Type Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                TRefresh();
                Inventory inv = new Inventory();

                inv.Refresh();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtTypeName.Text == "")
            {
                MessageBox.Show("Field must not be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                con.Open();

                cmd = new OleDbCommand("DELETE FROM Type WHERE Type= '" + dataGridView1.SelectedCells[0].Value.ToString() + "'", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Manufacturer Removed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                TRefresh();

                Inventory inv = new Inventory();

                inv.Refresh();
            }
        }

        private void TypeList_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
