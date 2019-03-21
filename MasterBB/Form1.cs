using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterBB
{
    public partial class Form1 : Form
    {

        private MasterDB masterDB;

        public Form1()
        {
            InitializeComponent();
            string connection = @"Server=HGDLMARTINEZHRI\SQLEXPRESS;Trusted_Connection=True;";
            masterDB = new MasterDB(connection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lstDBs.DataSource = masterDB.GetAllBD();
            //this.listBox1.DisplayMember = "name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string table = this.lstDBs.SelectedItem.ToString();
            this.lstTables.DataSource = masterDB.GetAllTables(table);
            this.lstViews.DataSource = masterDB.GetAllViews(table);
            this.lstSPs.DataSource = masterDB.GetAllSP(table);
        }
    }
}
