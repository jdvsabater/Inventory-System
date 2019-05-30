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
    public partial class QuantityAlert : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files (x86)\PRODUCTS INVENTORY AND RECORDS\Paint Products Database\Product Database.accdb");
        OleDbCommand cmd;

        public void refreshInventory()
        {
            try
            {
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT ProductID , Type, Manufacturer, ProductName, Stock ,Price FROM Inventory WHERE Stock<=20";
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
        public QuantityAlert()
        {
            InitializeComponent();
            refreshInventory();
        }

        private void QuantityAlert_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
