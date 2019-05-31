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
    class Variables
    {
        public static string username;
        public static string position;
    }
    public partial class LogInForm : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files (x86)\PRODUCTS INVENTORY AND RECORDS\Paint Products Database\Product Database.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        
        public LogInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usr = txtUserName.Text;
            string psw = txtPassword.Text;
            string type = string.Empty;
            con.Open();
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Users where UName='" + txtUserName.Text + "' AND PW='" + txtPassword.Text + "'";
            dr = cmd.ExecuteReader();
            Variables.username = txtUserName.Text;
            
            if (dr.Read())
            {
                type = dr["Type"].ToString();
                this.Hide();
                this.Parent = null;
                Variables.position = type;
                if (type == "Admin")
                {
                    Form1 menu = new Form1();
                    menu.Show();
                    
                    
                    
                }
                else
                {
                    Form1 menu = new Form1();
                    menu.Show();

                    menu.Size = new Size(1366, 350);
                    menu.btnLogOut.Location = new Point(1103, 260);
                    menu.btnUserList.Visible = false;
                    menu.btnManufacturerList.Visible = false;
                    menu.btnReport.Visible = false;
                    menu.btnStoreList.Visible = false;

                }
                
                

            }
            else
            {
                MessageBox.Show("Username or password is incorrect", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
