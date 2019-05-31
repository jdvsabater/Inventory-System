using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Products_Database
{
    public partial class Form1 : Form
    {
        Inventory invent = new Inventory();
        RecordIN rec = new RecordIN();
        ManufacturerDetails mdetails = new ManufacturerDetails();
        BranchList bList = new BranchList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            

        }

        private void btnManufacturerList_Click(object sender, EventArgs e)
        {
            ManufacturerDetails md = new ManufacturerDetails();
            md.Refresh();
            mdetails.Show();

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            invent.Show();
            invent.refreshInventory();
        }

        private void btnStoreList_Click(object sender, EventArgs e)
        {
            bList.Show();
        }

        private void btnRecords_Click_1(object sender, EventArgs e)
        {
            RecordIN rin = new RecordIN();
            rin.Refresh();


            rec.Show();
            rec.refreshInventory();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserList uList = new UserList();

            uList.Show();
        }

        private void btnRecordOut_Click(object sender, EventArgs e)
        {


            RecordOut rOut = new RecordOut();

            rOut.Refresh();

            rOut.Show();
        }

        private void btnRecordReturn_Click(object sender, EventArgs e)
        {
            RecordReturn rReturn = new RecordReturn();
            rReturn.Refresh();

            rReturn.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Reports rprts = new Reports();
            rprts.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForm lgform = new LogInForm();
            lgform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogInForm lgf = new LogInForm();
            string user = "Current User: " + Variables.username.ToString();
            string position = "Position: " + Variables.position.ToString();
            lblUsername.Text = user;
            label1.Text = position;
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
